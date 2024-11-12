using BBC_Desktop.connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BBC_Desktop.model
{
    internal class User
    {
        private String username, senha;

        public string Username { get => username; set => username = value; }
        public string Senha { get => senha; set => senha = value; }

        public User() { }

        public User(String username, String senha) {
            Username = username;
            Senha = senha;
        }

        public bool consultarUsuario()
        {
            bool consulta = false;
            try
            {
                Conexao.con.Open();
                MySqlCommand consultar = new MySqlCommand("select * from BBC_Account where username = '" + username + "' and password = '" +
                    senha + "'", Conexao.con);
                MySqlDataReader resultado = consultar.ExecuteReader();
                if (resultado.Read())
                {
                    consulta = true;
                }
            }
            finally
            {
                Conexao.con.Close();
            }
            return consulta;
        }

        public MySqlDataReader consultaTodosUsuarios()
        {
            MySqlDataReader resultado = null;
            try
            {
                Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from BBC_Account", Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }
    }
}
