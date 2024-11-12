namespace BBC_Desktop
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.mspBiBliocamp = new System.Windows.Forms.MenuStrip();
            this.livroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAdminsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.mspBiBliocamp.SuspendLayout();
            this.gpbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspBiBliocamp
            // 
            this.mspBiBliocamp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mspBiBliocamp.Enabled = false;
            this.mspBiBliocamp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livroToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.mspBiBliocamp.Location = new System.Drawing.Point(0, 0);
            this.mspBiBliocamp.Name = "mspBiBliocamp";
            this.mspBiBliocamp.Size = new System.Drawing.Size(1010, 24);
            this.mspBiBliocamp.TabIndex = 1;
            this.mspBiBliocamp.Text = "menuStrip1";
            // 
            // livroToolStripMenuItem
            // 
            this.livroToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.livroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLivroToolStripMenuItem,
            this.consultarLivrosToolStripMenuItem,
            this.atualizarLivroToolStripMenuItem});
            this.livroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            this.livroToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.livroToolStripMenuItem.Text = "Livro";
            // 
            // cadastrarLivroToolStripMenuItem
            // 
            this.cadastrarLivroToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cadastrarLivroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrarLivroToolStripMenuItem.Name = "cadastrarLivroToolStripMenuItem";
            this.cadastrarLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarLivroToolStripMenuItem.Text = "Cadastrar Livro";
            this.cadastrarLivroToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLivroToolStripMenuItem_Click);
            // 
            // consultarLivrosToolStripMenuItem
            // 
            this.consultarLivrosToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.consultarLivrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultarLivrosToolStripMenuItem.Name = "consultarLivrosToolStripMenuItem";
            this.consultarLivrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarLivrosToolStripMenuItem.Text = "Consultar Livros";
            this.consultarLivrosToolStripMenuItem.Click += new System.EventHandler(this.consultarLivrosToolStripMenuItem_Click);
            // 
            // atualizarLivroToolStripMenuItem
            // 
            this.atualizarLivroToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.atualizarLivroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.atualizarLivroToolStripMenuItem.Name = "atualizarLivroToolStripMenuItem";
            this.atualizarLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atualizarLivroToolStripMenuItem.Text = "Atualizar Livro";
            this.atualizarLivroToolStripMenuItem.Click += new System.EventHandler(this.atualizarLivroToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarUsuariosToolStripMenuItem,
            this.consultarAdminsToolStripMenuItem});
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // consultarUsuariosToolStripMenuItem
            // 
            this.consultarUsuariosToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.consultarUsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultarUsuariosToolStripMenuItem.Name = "consultarUsuariosToolStripMenuItem";
            this.consultarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarUsuariosToolStripMenuItem.Text = "Consultar Usuarios";
            this.consultarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.consultarUsuariosToolStripMenuItem_Click);
            // 
            // consultarAdminsToolStripMenuItem
            // 
            this.consultarAdminsToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.consultarAdminsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultarAdminsToolStripMenuItem.Name = "consultarAdminsToolStripMenuItem";
            this.consultarAdminsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarAdminsToolStripMenuItem.Text = "Consultar Admins";
            this.consultarAdminsToolStripMenuItem.Click += new System.EventHandler(this.consultarAdminsToolStripMenuItem_Click);
            // 
            // gpbLogin
            // 
            this.gpbLogin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gpbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbLogin.Controls.Add(this.btnEntrar);
            this.gpbLogin.Controls.Add(this.label1);
            this.gpbLogin.Controls.Add(this.txtSenha);
            this.gpbLogin.Controls.Add(this.txtUsername);
            this.gpbLogin.Controls.Add(this.lblAdmin);
            this.gpbLogin.ForeColor = System.Drawing.Color.White;
            this.gpbLogin.Location = new System.Drawing.Point(293, 156);
            this.gpbLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbLogin.Size = new System.Drawing.Size(418, 257);
            this.gpbLogin.TabIndex = 6;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "Login";
            // 
            // btnEntrar
            // 
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(82, 168);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(262, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 3;
            this.label1.Tag = "";
            this.label1.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(124, 117);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(220, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "steve";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(124, 65);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Steve";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(63, 65);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(57, 16);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Usuário:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1010, 576);
            this.Controls.Add(this.gpbLogin);
            this.Controls.Add(this.mspBiBliocamp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmLogin";
            this.Text = "BiBlioCamp";
            this.mspBiBliocamp.ResumeLayout(false);
            this.mspBiBliocamp.PerformLayout();
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspBiBliocamp;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAdminsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblAdmin;
    }
}

