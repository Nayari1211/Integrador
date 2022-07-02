using Integrador.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class frmInicioSesion : Form
    {
        // Variables de entrada
       
       public static String usuario = "Integrador", contrasena = "123";

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {


        }

        public void limpiarText ()
        {
            textUsuario.Clear();
            textContrasena.Clear();
            textUsuario.Focus();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            
           
            if (textUsuario.Text == "")  
            {
                MessageBox.Show("Por favor Ingrese Usuario Correcto", "Aviso de Inicio Sesión",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (textContrasena.Text == "")
                {
                    MessageBox.Show("Por favor Ingrese Contraseña Correcto", "Aviso de Inicio Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((textUsuario.Text == usuario) && (textContrasena.Text== contrasena))
                    {
                    MessageBox.Show("Sesión Iniciada","Bienvenidos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    limpiarText();
                        formPrincipal fm = new formPrincipal();
                        this.Hide();
                        fm.Show();
                    }
                    else
                    {
                    MessageBox.Show("Credenciales Incorrectas", "Aviso de Inicio Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiarText();
                    }    
                   
                }
            }

            
           

        }
    }
}
