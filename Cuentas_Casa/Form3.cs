using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Cuentas_Casa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Registro nuevoRegistro = new Registro();
            RegistroNegocio nuevoRegNegocio = new RegistroNegocio();

            try
            {
                nuevoRegistro.Descripcion = (string)txtDescr.Text;
                nuevoRegistro.Precio = int.Parse(txtPrecio.Text);
                nuevoRegistro.FormaDePago = new Medio_de_pago();
                //nuevoRegistro.FormaDePago.Id = 1;
                if (cbFDP.Text == "Efectivo")
                    nuevoRegistro.FormaDePago.Id = 1;
                else if ((string)cbFDP.SelectedItem == "Mercado Pago")
                    nuevoRegistro.FormaDePago.Id = 2;
                else if (cbFDP.Text == "Tarjeta de Débito")
                    nuevoRegistro.FormaDePago.Id = 3;
                else if (cbFDP.Text == "Tarjeta de Crédito")
                    nuevoRegistro.FormaDePago.Id = 4;
                else if (cbFDP.Text == "Cuenta DNI")
                    nuevoRegistro.FormaDePago.Id = 5;
                else
                    nuevoRegistro.FormaDePago.Id = 1;
                nuevoRegNegocio.agregar(nuevoRegistro);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MedioDePagoNegocio negocioMDP = new MedioDePagoNegocio();
            try
            {
                cbFDP.DataSource = negocioMDP.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void cbFDP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
