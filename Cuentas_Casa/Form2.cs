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
    public partial class Form2 : Form
    {
        List<Medio_de_pago> listarNegMDP;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MedioDePagoNegocio negocioMDP = new MedioDePagoNegocio();
            listarNegMDP = negocioMDP.listar();
            dgvMdP.DataSource = listarNegMDP;
        }
    }
}
