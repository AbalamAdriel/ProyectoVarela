namespace ProyectoVarela
{
    partial class RegistrarUsuario
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtbox_usuario = new System.Windows.Forms.TextBox();
            this.txtbox_contrasenia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(150, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox_usuario
            // 
            this.txtbox_usuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtbox_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_usuario.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_usuario.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtbox_usuario.Location = new System.Drawing.Point(23, 43);
            this.txtbox_usuario.MaxLength = 30;
            this.txtbox_usuario.Multiline = true;
            this.txtbox_usuario.Name = "txtbox_usuario";
            this.txtbox_usuario.Size = new System.Drawing.Size(270, 32);
            this.txtbox_usuario.TabIndex = 0;
            this.txtbox_usuario.Text = "Nombre de usuario...";
            this.txtbox_usuario.Click += new System.EventHandler(this.textBox1_Click);
            this.txtbox_usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtbox_usuario.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtbox_usuario.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtbox_contrasenia
            // 
            this.txtbox_contrasenia.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtbox_contrasenia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_contrasenia.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_contrasenia.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtbox_contrasenia.Location = new System.Drawing.Point(23, 100);
            this.txtbox_contrasenia.MaxLength = 50;
            this.txtbox_contrasenia.Multiline = true;
            this.txtbox_contrasenia.Name = "txtbox_contrasenia";
            this.txtbox_contrasenia.PasswordChar = '*';
            this.txtbox_contrasenia.Size = new System.Drawing.Size(270, 30);
            this.txtbox_contrasenia.TabIndex = 1;
            this.txtbox_contrasenia.Text = "Contraseña...";
            this.txtbox_contrasenia.Click += new System.EventHandler(this.textBox2_Click);
            this.txtbox_contrasenia.Enter += new System.EventHandler(this.textBox2_Enter);
            this.txtbox_contrasenia.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.txtbox_contrasenia);
            this.panel1.Controls.Add(this.txtbox_usuario);
            this.panel1.Location = new System.Drawing.Point(71, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 178);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVarela.Properties.Resources.background_sec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Usuarios";
            this.Load += new System.EventHandler(this.RegistrarUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbox_usuario;
        private System.Windows.Forms.TextBox txtbox_contrasenia;
        private System.Windows.Forms.Panel panel1;
    }
}