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
    public partial class frmConsultarAttLivro : Form
    {
        public frmConsultarAttLivro()
        {
            InitializeComponent();
            atualizaDataGridView();
        }

        public void atualizaDataGridView()
        {
            Livro livro = new Livro();
            try
            {
                MySqlDataReader rLivro = livro.consultarTodosLivros();

                dgwLivros.Rows.Clear();
                while (rLivro.Read())
                {
                    dgwLivros.Rows.Add(rLivro["title"].ToString(), rLivro["author"].ToString(), rLivro["editor"].ToString(),
                        rLivro["category"].ToString(), rLivro["actualStock"].ToString(), rLivro["fullStock"].ToString());
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
