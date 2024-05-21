namespace ProyectoVarela
{
    partial class FRMUsuarios
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
            this.btn_NuevoUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_EliminarUsuario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_NuevoUsuario
            // 
            this.btn_NuevoUsuario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_NuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_NuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoUsuario.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoUsuario.Location = new System.Drawing.Point(57, 56);
            this.btn_NuevoUsuario.Name = "btn_NuevoUsuario";
            this.btn_NuevoUsuario.Size = new System.Drawing.Size(194, 61);
            this.btn_NuevoUsuario.TabIndex = 6;
            this.btn_NuevoUsuario.Text = "Nuevo Usuario";
            this.btn_NuevoUsuario.UseVisualStyleBackColor = false;
            this.btn_NuevoUsuario.Click += new System.EventHandler(this.btn_NuevoUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.btn_EliminarUsuario);
            this.panel1.Controls.Add(this.btn_NuevoUsuario);
            this.panel1.Location = new System.Drawing.Point(61, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 280);
            this.panel1.TabIndex = 7;
            // 
            // btn_EliminarUsuario
            // 
            this.btn_EliminarUsuario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_EliminarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_EliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarUsuario.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarUsuario.Location = new System.Drawing.Point(57, 175);
            this.btn_EliminarUsuario.Name = "btn_EliminarUsuario";
            this.btn_EliminarUsuario.Size = new System.Drawing.Size(194, 61);
            this.btn_EliminarUsuario.TabIndex = 8;
            this.btn_EliminarUsuario.Text = "Eliminar Usuario";
            this.btn_EliminarUsuario.UseVisualStyleBackColor = false;
            this.btn_EliminarUsuario.Click += new System.EventHandler(this.btn_EliminarUsuario_Click);
            // 
            // FRMUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVarela.Properties.Resources.background_sec;
            this.ClientSize = new System.Drawing.Size(428, 329);
            this.Controls.Add(this.panel1);
            this.Name = "FRMUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMUsuarios";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NuevoUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_EliminarUsuario;
    }
}