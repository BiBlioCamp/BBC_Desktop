namespace BBC_Desktop.view
{
    partial class frmConsultarAdmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarAdmins));
            this.dgwUsuario = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUsuario
            // 
            this.dgwUsuario.AllowUserToAddRows = false;
            this.dgwUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgwUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.email});
            this.dgwUsuario.Location = new System.Drawing.Point(12, 12);
            this.dgwUsuario.MultiSelect = false;
            this.dgwUsuario.Name = "dgwUsuario";
            this.dgwUsuario.ReadOnly = true;
            this.dgwUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUsuario.Size = new System.Drawing.Size(347, 292);
            this.dgwUsuario.TabIndex = 4;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Username";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // email
            // 
            this.email.FillWeight = 1000F;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // frmConsultarAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(373, 318);
            this.Controls.Add(this.dgwUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarAdmins";
            this.Text = "Consultar Admins";
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}