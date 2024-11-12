using BBC_Desktop.connection;
using BBC_Desktop.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBC_Desktop.view
{
    public partial class frmConsultarUsuarios : Form
    {
        public frmConsultarUsuarios()
        {
            InitializeComponent();
            atualizaDataGridView();
        }

        public void atualizaDataGridView()
        {
            User user = new User();
            try
            {
                MySqlDataReader rUser = user.consultaTodosUsuarios();

                dgwUsuario.Rows.Clear();
                while (rUser.Read())
                {
                    if (rUser["type"].ToString() == "0")
                        dgwUsuario.Rows.Add(rUser["id"].ToString(), rUser["name"].ToString(), rUser["email"].ToString(), rUser["username"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conexao.con.Close();
            }
        }

        private void dgwCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
