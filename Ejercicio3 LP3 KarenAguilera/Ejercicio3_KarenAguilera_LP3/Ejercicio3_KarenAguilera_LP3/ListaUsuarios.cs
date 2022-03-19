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
    public partial class ListaUsuarios : Form
    {
        public ListaUsuarios()
        {
            InitializeComponent();
        }

        UsuarioDA usuarioDA = new UsuarioDA();
        string operacion = string.Empty;
        Usuario user = new Usuario();

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
            
        }

        private void ListarUsuarios()
        {
            ListaUsuarios_dgv.DataSource = usuarioDA.ListarUsuarios();
        }

        private void Nuevo_btn_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void HabilitarControles()
        {
            Usuario_txt.Enabled = true;
            ContraseñaNuevo_Txt.Enabled = true;
            

            Nuevo_btn.Enabled = false;
            Añadir_btn.Enabled = true;
            Cancelar_btn.Enabled = true;


        }

        private void DesabilitarControles()
        {
            Usuario_txt.Enabled = false;
            ContraseñaNuevo_Txt.Enabled = false;
            

            Nuevo_btn.Enabled = true;
            Añadir_btn.Enabled = false;
            Cancelar_btn.Enabled = false;


        }
        private void LimpiarControles()
        {
            Usuario_txt.Clear();
            ContraseñaNuevo_Txt.Text = string.Empty;
            
        }

        private void Añadir_btn_Click(object sender, EventArgs e)
        {
            user.NombreUsuario = Usuario_txt.Text;
            user.contraseña = ContraseñaNuevo_Txt.Text;
            
            if (operacion == "Nuevo")
            {
                bool inserto = usuarioDA.AñadirUsuario(user);

                if (inserto)
                {
                    MessageBox.Show("Usuario Creado");
                    ListarUsuarios();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo Crear");
                }
            }
            else if (operacion == "Modificar")
            {
                bool modifico = usuarioDA.ModificarUsuario(user);
                if (modifico)
                {
                    MessageBox.Show("Usuario Modificado");
                    ListarUsuarios();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo Modificar");
                }
            }




        }

        private void Modificar_btn_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (ListaUsuarios_dgv.SelectedRows.Count > 0)
            {
                Usuario_txt.Text = ListaUsuarios_dgv.CurrentRow.Cells["NombreUsuario"].Value.ToString();
                ContraseñaNuevo_Txt.Text = ListaUsuarios_dgv.CurrentRow.Cells["contraseña"].Value.ToString();
                
                HabilitarControles();
            }

        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
        {
            if (ListaUsuarios_dgv.SelectedRows.Count > 0)
            {
                bool elimino = usuarioDA.EliminarUsuario(ListaUsuarios_dgv.CurrentRow.Cells["NombreUsuario"].Value.ToString());
                if (elimino)
                {
                    MessageBox.Show("Usuario Eliminado");
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo Eliminar");
                }

            }
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }
    }
    }
