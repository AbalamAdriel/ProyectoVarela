namespace ProyectoVarela
{
    partial class FRMEliminarUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbox_usuario = new System.Windows.Forms.TextBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.txtbox_usuario);
            this.panel1.Location = new System.Drawing.Point(77, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 109);
            this.panel1.TabIndex = 7;
            // 
            // txtbox_usuario
            // 
            this.txtbox_usuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtbox_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_usuario.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_usuario.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtbox_usuario.Location = new System.Drawing.Point(23, 39);
            this.txtbox_usuario.MaxLength = 30;
            this.txtbox_usuario.Multiline = true;
            this.txtbox_usuario.Name = "txtbox_usuario";
            this.txtbox_usuario.Size = new System.Drawing.Size(270, 32);
            this.txtbox_usuario.TabIndex = 0;
            this.txtbox_usuario.Text = "Nombre de usuario...";
            this.txtbox_usuario.Click += new System.EventHandler(this.txtbox_usuario_Click);
            this.txtbox_usuario.Enter += new System.EventHandler(this.txtbox_usuario_Enter);
            this.txtbox_usuario.Leave += new System.EventHandler(this.txtbox_usuario_Leave);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(158, 241);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(159, 39);
            this.btnEliminarUsuario.TabIndex = 6;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // FRMEliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVarela.Properties.Resources.background_sec;
            this.ClientSize = new System.Drawing.Size(461, 335);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Name = "FRMEliminarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMEliminarUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbox_usuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
    }
}