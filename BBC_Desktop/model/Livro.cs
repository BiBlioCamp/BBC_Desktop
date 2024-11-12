using BBC_Desktop.connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBC_Desktop.model
{
    internal class Livro
    {
        public Livro() { }

        public MySqlDataReader consultarTodosLivros()
        {
            MySqlDataReader consulta = null;
            try
            {
                Conexao.con.Open();
                MySqlCommand consultar = new MySqlCommand("select * from BBC_Book", Conexao.con);
                consulta = consultar.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return consulta;
        }
    }
}
