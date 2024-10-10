namespace BBC_Desktop.view
{
    partial class frmConsultarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarUsuarios));
            this.dgwCliente = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCliente
            // 
            this.dgwCliente.AllowUserToAddRows = false;
            this.dgwCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgwCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Email,
            this.Column2});
            this.dgwCliente.Location = new System.Drawing.Point(12, 12);
            this.dgwCliente.MultiSelect = false;
            this.dgwCliente.Name = "dgwCliente";
            this.dgwCliente.ReadOnly = true;
            this.dgwCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCliente.Size = new System.Drawing.Size(442, 426);
            this.dgwCliente.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RA";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmConsultarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.dgwCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarUsuarios";
            this.Text = "Consultar Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}