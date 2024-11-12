using System;
using BBC_Desktop.model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBC_Desktop.connection;
using BBC_Desktop.view;

namespace BBC_Desktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            if (Conexao.getConexao("143.106.241.3", "cl202235", "cl202235", "cl*17062007"))
                Console.WriteLine("Conectado!");
            else
                Console.WriteLine("Erro de conexão!");
            mspBiBliocamp.Enabled = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                User usuario = new User(txtUsername.Text, txtSenha.Text);
                if (usuario.consultarUsuario())
                {
                    gpbLogin.Visible = false;
                    mspBiBliocamp.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Senha ou usuário incorreto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void cadastrarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarLivro frm = new frmCadastrarLivro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultarLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarAttLivro frm = new frmConsultarAttLivro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void atualizarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarAttLivro frm = new frmConsultarAttLivro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarUsuarios frm = new frmConsultarUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultarAdminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarAdmins frm = new frmConsultarAdmins();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
