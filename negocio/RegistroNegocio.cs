using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class RegistroNegocio
    {
        public List<Registro> ListarRegistro()
        {

            List<Registro> lista = new List<Registro>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CUENTAS_CASA; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT  R.RegistroID as REGISTROID, R.Descripcion AS DESCRIPCION, PRECIO, PAGADO, IMAGEN, M.DESCRIPCION AS FORMADEPAGO FROM REGISTRO R, MEDIO_DE_PAGO M WHERE R.Forma_de_Pago = M.ID";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader(); // da como resultado un sqldatareader

                //debo transformar la tabla en objetos que almaceno en lector
                while (lector.Read())//esto va a hacer dos cosas, si hay un registro devuelve true y posiciona un puntero en la próxima selección, es decir si hay una lectura devuelve true y posiciona el puntero en la primera fila (entonces ingresa al while con el lector apuntando a la primera fila)
                {
                    Registro aux = new Registro();
                    aux.RegistroId = (int)lector["REGISTROID"];
                    aux.Descripcion = (string)lector["DESCRIPCION"];
                    aux.Precio = (int)lector["PRECIO"];
                    aux.Pagado = (bool)lector["PAGADO"];
                    aux.Imagen = (string)lector["IMAGEN"];
                    aux.FormaDePago = new Medio_de_pago(); // ESTO PORQUE AL CREAR EL ATRIBUTO FORMADEPAGO EN REGISTRO ESTE SE CREA SIN INSTANCIA POR LO QUE LO DEBO INSTANCIAR PRIMERO ACÀ (SINO TAMBIÉN DESDE LA CLASE COMO UN CONSRTUCTOR Y CUANDO CREO AL REGISTRO LE INFORMO POR PARAMETRO LA FORMADEPAGO)
                    aux.FormaDePago.Descripcion = (string)lector["FORMADEPAGO"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }


        public void agregar(Registro nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO REGISTRO (Descripcion,Precio,Pagado,Imagen,Forma_de_Pago) VALUES ('" + nuevo.Descripcion + "', " +nuevo.Precio + ", 0,'', " + nuevo.FormaDePago.Id+ ")");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        
    }
}
