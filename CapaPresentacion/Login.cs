using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            
            //Boton del login cancelar al tocarlo debe cerrar el formulario
            this.Close();

        }

        private void btingrear_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();
            //Busca que coincida lo ingresa en documento y clave para encontrar uno similar
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text).FirstOrDefault();
            
            if (ousuario != null)
            {
                //Boton ingresar
                Inicio form = new Inicio();//Inicio es el nombre del form, que es una nueva instancia

                form.Show();//Que se muestre el form.
                this.Hide();//Que se oculte el form actual que es el de login
                form.FormClosing += frm_cerrar;//Al cerrar el form incio se vuelva a abrir el de login
            }
            else
            {
                MessageBox.Show("No se encontro el usuario","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        private void frm_cerrar(object sender, FormClosingEventArgs e)
        {
            //Para limpiar los campos documento y contraseña
            txtdocumento.Text = "";
            txtclave.Text = "";
            //Para que al cerrar el form de incio vuelva a aparecer el de login
            this.Show();
        }
    }
}
