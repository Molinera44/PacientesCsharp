using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacientesCesharp.bbdd
{
    internal class conexion
    {
        
        private static readonly string url = "Data Source=JPexamen.db";

        public static bool Acceder(string user, string pass)
        {
            string consulta = "SELECT * FROM Usuarios WHERE usuario = @user AND pass = @pass";
            SqliteConnection conn = new SqliteConnection(url);

            conn.Open();

            SqliteCommand command = new SqliteCommand(consulta, conn);

            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);

            SqliteDataReader resultados = command.ExecuteReader();
            try
            {
                return resultados.Read();
            }
            catch (SqliteException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                resultados.Close();
                conn.Close();
            }
        }

        public static void CargarComboCiudades(System.Windows.Forms.ComboBox cb)
        {
            string consulta = "SELECT ciudad FROM ciudades";
            SqliteConnection conn = new SqliteConnection(url);
            conn.Open();

            //DataTable dt = new DataTable();

            SqliteCommand command = new SqliteCommand(consulta, conn);
            SqliteDataReader resultados = command.ExecuteReader();

            while (resultados.Read())
            {
                cb.Items.Add(resultados.GetString(0));
            }

            resultados.Close();
            conn.Close();
        }

        public static bool RegistrarPaciente(Paciente p)
        {
            string consulta = "INSERT INTO Pacientes (nombre, apellidos, direccion, ciudad) VALUES (@nom, @ape, @dir, @ciu)";
            SqliteConnection conn = new SqliteConnection(url);
            conn.Open();
            try
            {

                SqliteCommand comando = new SqliteCommand(consulta, conn);

                comando.Parameters.AddWithValue("@nom", p.Nombre);
                comando.Parameters.AddWithValue("@ape", p.Apellidos);
                comando.Parameters.AddWithValue("@dir", p.Direccion);
                comando.Parameters.AddWithValue("@ciu", p.Ciudad);

                comando.ExecuteNonQuery();
                return true;

            }
            catch (SqliteException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool RegistrarUsuario(Usuario u)
        {
            string consulta = "INSERT INTO Usuarios (nombre, usuario, pass) VALUES (@nom, @usu, @pass)";
            SqliteConnection conn = new SqliteConnection(url);
            conn.Open();
            try
            {

                SqliteCommand comando = new SqliteCommand(consulta, conn);

                comando.Parameters.AddWithValue("@nom", u.Nombre);
                comando.Parameters.AddWithValue("@usu", u.Usuarios);
                comando.Parameters.AddWithValue("@pass", u.Pass);

                comando.ExecuteNonQuery();
                return true;

            }
            catch (SqliteException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool CompruebaUsuario(string usuario)
        {
            string consultausuario = "SELECT usuario FROM usuarios WHERE usuario=@usu";
            SqliteConnection conn = new SqliteConnection(url);
            conn.Open();

            using (SqliteCommand command = new SqliteCommand(consultausuario, conn))
            {
                command.Parameters.AddWithValue("@usu", usuario);
                SqliteDataReader resultados = command.ExecuteReader();
                if (resultados.HasRows)
                {
                    conn.Close();
                    resultados.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    resultados.Close();
                    return false;

                }
            }
        }
    }
}
}
