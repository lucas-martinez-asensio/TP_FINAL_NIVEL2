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
    public partial class Form1 : Form
    {
        private List<Registro> listaRegistro;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistroNegocio negocio = new RegistroNegocio();
            listaRegistro = negocio.ListarRegistro();
            dgvRegistro.DataSource = listaRegistro;
            dgvRegistro.Columns["Imagen"].Visible = false;
            pbxRegistro.Load(listaRegistro[0].Imagen);

        }

        private void dgvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            Registro seleccionado = (Registro)dgvRegistro.CurrentRow.DataBoundItem;
            imageLoad(seleccionado.Imagen);
        }

        private void imageLoad(string image)
        {
            try
            {
                pbxRegistro.Load(image);
            }
            catch
            {
                pbxRegistro.Load("https://www.cignasalud.es/sites/default/files/styles/full_width/public/2023-08/imagen-por-defecto-1280x640.jpg?itok=RqBP1Jum");
            }

        }

        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 alta = new Form3();
            alta.ShowDialog();
        }
    }
}
