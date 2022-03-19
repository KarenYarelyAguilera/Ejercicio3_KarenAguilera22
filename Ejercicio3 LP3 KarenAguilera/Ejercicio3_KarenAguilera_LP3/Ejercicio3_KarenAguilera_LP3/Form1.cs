using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDatos_Ejercicio3;
using BaseDatos_Ejercicio3.Accesos;
using BaseDatos_Ejercicio3.Entidades;


namespace Ejercicio3_KarenAguilera_LP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Aceptar_Btn_Click(object sender, EventArgs e)
        {
            UsuarioDA UsuarioDA=new UsuarioDA();
            Usuario Usuario=new Usuario();
            Usuario= UsuarioDA.Login(NombreUsuario_txt.Text, Contraseña_txt.Text);

            if (Usuario == null)
            {
                MessageBox.Show("Datos erroneos");

            }
            else 
            {
                MessageBox.Show("Usuario Inactivo");
                return;

                ListaUsuarios listaUsuarios = new ListaUsuarios();
                listaUsuarios.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
