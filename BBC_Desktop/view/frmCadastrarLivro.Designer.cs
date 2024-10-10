namespace BBC_Desktop.view
{
    partial class frmCadastrarLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarLivro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEstoque);
            this.groupBox1.Controls.Add(this.txtClasse);
            this.groupBox1.Controls.Add(this.btnFoto);
            this.groupBox1.Controls.Add(this.ptbFoto);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEditora);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estoque";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(69, 133);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(191, 20);
            this.txtEstoque.TabIndex = 15;
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(69, 107);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(191, 20);
            this.txtClasse.TabIndex = 14;
            // 
            // btnFoto
            // 
            this.btnFoto.ForeColor = System.Drawing.Color.Black;
            this.btnFoto.Location = new System.Drawing.Point(266, 231);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(114, 20);
            this.btnFoto.TabIndex = 12;
            this.btnFoto.Text = "Escolher capa";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // ptbFoto
            // 
            this.ptbFoto.Image = ((System.Drawing.Image)(resources.GetObject("ptbFoto.Image")));
            this.ptbFoto.Location = new System.Drawing.Point(266, 84);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(114, 141);
            this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoto.TabIndex = 13;
            this.ptbFoto.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(20, 205);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(137, 20);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Classe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Editora";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(20, 231);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(240, 20);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titulo";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(69, 81);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(191, 20);
            this.txtEditora.TabIndex = 2;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(69, 55);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(311, 20);
            this.txtAutor.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(69, 29);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(311, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // frmCadastrarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(418, 285);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastrarLivro";
            this.Text = "Cadastrar Livro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtClasse;
    }
}