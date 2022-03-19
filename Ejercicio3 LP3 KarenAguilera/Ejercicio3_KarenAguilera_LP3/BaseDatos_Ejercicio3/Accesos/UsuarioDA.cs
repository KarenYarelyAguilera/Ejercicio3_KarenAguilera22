using BaseDatos_Ejercicio3.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos_Ejercicio3.Accesos
{
    public class UsuarioDA
    {
        readonly string cadena = "Server= localhost; Port=3306; Database= Programacion; Uid=root; Pwd=12345678";
        MySqlConnection conn;
        MySqlCommand cmd;


        public Usuario Login(string NombreUsuario, string contraseña)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM usuario WHERE NombreUsuario= @NombreUsuario AND contraseña = @contraseña;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.NombreUsuario= reader[0].ToString();
                    user.contraseña = reader[1].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                

            }
            return user;
        }
        public DataTable ListarUsuarios()
        {
            DataTable ListaUsuariosDT=new DataTable();
            try
            {
                string sql = "SELECT * FROM usuario;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                ListaUsuariosDT.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return ListaUsuariosDT;
        }

        public bool AñadirUsuario(Usuario usuario)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO usuario VALUES (@NombreUsuario, @contraseña);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@contraseña", usuario.contraseña);
          

                cmd.ExecuteNonQuery();
                inserto = true;

                conn.Close();
            }
            catch (Exception)
            {
            }
            return inserto;
        }

        public bool ModificarUsuario(Usuario usuario)
        {
            bool modifico = false;
            try
            {
                string sql = "UPDATE usuario SET NombreUsuario = @NombreUsuario, contraseña = @contraseña, WHERE NombreUsuario = @NombreUsuario;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@contraseña", usuario.contraseña);
               

                cmd.ExecuteNonQuery();
                modifico = true;
                conn.Close();
            }
            catch (Exception)
            {
            }
            return modifico;
        }
        public bool EliminarUsuario(string NombreUsuario)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM usuario WHERE NombreUsuario = @NombreUsuario;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);

                cmd.ExecuteNonQuery();
                elimino = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return elimino;
        }





    }




}

    
