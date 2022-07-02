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
    public partial class formCambioContrasena : Form
    {
        public formCambioContrasena()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtContrasenaActual.Text.Equals(frmInicioSesion.contrasena))
            {
                if (txtNuevaContrasena.Text.Equals(txtConfirmacionContrasena.Text))
                {
                    if (txtNuevaContrasena.Text.Equals(frmInicioSesion.contrasena))
                    {
                        MessageBox.Show("La Nueva Contraseña no puede ser igual a la Contraseña Actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                    else
                    {
                        frmInicioSesion.contrasena = txtNuevaContrasena.Text;
                        MessageBox.Show("Contraseña Cambiada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Las Nuevas Contraseña no Coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La Contraseña Actual no Coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
