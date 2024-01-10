using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MedioDePagoNegocio
    {
        public List<Medio_de_pago> listar()
        {
            List<Medio_de_pago> lista = new List<Medio_de_pago>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM MEDIO_DE_PAGO");
                datos.ejecturarLectura();

                while (datos.Lector.Read())
                {
                    Medio_de_pago aux = new Medio_de_pago();
                    aux.Id = Convert.ToInt64(datos.Lector["ID"]);
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);

                }

                return lista;
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
