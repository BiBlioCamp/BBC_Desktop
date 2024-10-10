namespace BBC_Desktop.view
{
    partial class frmConsultarAttLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarAttLivro));
            this.gpbAtualizar = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.dgwLivros = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbAtualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbAtualizar
            // 
            this.gpbAtualizar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gpbAtualizar.Controls.Add(this.txtClasse);
            this.gpbAtualizar.Controls.Add(this.textBox1);
            this.gpbAtualizar.Controls.Add(this.btnAtualizar);
            this.gpbAtualizar.Controls.Add(this.btnLimpar);
            this.gpbAtualizar.Controls.Add(this.label4);
            this.gpbAtualizar.Controls.Add(this.label5);
            this.gpbAtualizar.Controls.Add(this.label6);
            this.gpbAtualizar.Controls.Add(this.label7);
            this.gpbAtualizar.Controls.Add(this.label8);
            this.gpbAtualizar.Controls.Add(this.txtEditora);
            this.gpbAtualizar.Controls.Add(this.txtAutor);
            this.gpbAtualizar.Controls.Add(this.txtTitulo);
            this.gpbAtualizar.ForeColor = System.Drawing.Color.White;
            this.gpbAtualizar.Location = new System.Drawing.Point(55, 263);
            this.gpbAtualizar.Name = "gpbAtualizar";
            this.gpbAtualizar.Size = new System.Drawing.Size(544, 213);
            this.gpbAtualizar.TabIndex = 4;
            this.gpbAtualizar.TabStop = false;
            this.gpbAtualizar.Text = "Atualizar";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.Location = new System.Drawing.Point(85, 172);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(361, 20);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(309, 145);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(137, 20);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Classificação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Editora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Autor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Titulo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Estoque";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(132, 146);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(160, 20);
            this.txtEditora.TabIndex = 14;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(124, 73);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(322, 20);
            this.txtAutor.TabIndex = 13;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(124, 35);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(322, 20);
            this.txtTitulo.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 24;
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(305, 109);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(141, 20);
            this.txtClasse.TabIndex = 25;
            // 
            // dgwLivros
            // 
            this.dgwLivros.AllowUserToAddRows = false;
            this.dgwLivros.BackgroundColor = System.Drawing.Color.White;
            this.dgwLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            this.dgwLivros.GridColor = System.Drawing.Color.White;
            this.dgwLivros.Location = new System.Drawing.Point(12, 12);
            this.dgwLivros.MultiSelect = false;
            this.dgwLivros.Name = "dgwLivros";
            this.dgwLivros.ReadOnly = true;
            this.dgwLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwLivros.Size = new System.Drawing.Size(644, 245);
            this.dgwLivros.TabIndex = 5;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Autor";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Editora";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Classificação";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Estoque Atual";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estoque Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmConsultarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(669, 488);
            this.Controls.Add(this.dgwLivros);
            this.Controls.Add(this.gpbAtualizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarLivro";
            this.Text = "Consultar Livros";
            this.gpbAtualizar.ResumeLayout(false);
            this.gpbAtualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAtualizar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgwLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}