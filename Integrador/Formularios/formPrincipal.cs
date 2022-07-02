using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador.Formularios
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formCambioContrasena fcc = new formCambioContrasena();
            fcc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmInicioSesion fcc = new frmInicioSesion();
            fcc.Show();
            this.Hide();

        }
    }
}
