namespace ProyectoVarela
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_registro = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_prestamo = new System.Windows.Forms.Button();
            this.btn_proyecto = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Proveedores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consulta
            // 
            this.btn_consulta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta.Location = new System.Drawing.Point(367, 37);
            this.btn_consulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(107, 37);
            this.btn_consulta.TabIndex = 0;
            this.btn_consulta.Text = "Material";
            this.btn_consulta.UseVisualStyleBackColor = false;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_registro
            // 
            this.btn_registro.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registro.Location = new System.Drawing.Point(367, 98);
            this.btn_registro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(107, 37);
            this.btn_registro.TabIndex = 1;
            this.btn_registro.Text = "Herramienta";
            this.btn_registro.UseVisualStyleBackColor = false;
            this.btn_registro.Click += new System.EventHandler(this.btn_registro_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Location = new System.Drawing.Point(367, 160);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(107, 37);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Empleado";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_prestamo
            // 
            this.btn_prestamo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_prestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prestamo.Location = new System.Drawing.Point(367, 345);
            this.btn_prestamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prestamo.Name = "btn_prestamo";
            this.btn_prestamo.Size = new System.Drawing.Size(107, 37);
            this.btn_prestamo.TabIndex = 4;
            this.btn_prestamo.Text = "Prestamo";
            this.btn_prestamo.UseVisualStyleBackColor = false;
            this.btn_prestamo.Click += new System.EventHandler(this.btn_prestamo_Click);
            // 
            // btn_proyecto
            // 
            this.btn_proyecto.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_proyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proyecto.Location = new System.Drawing.Point(367, 283);
            this.btn_proyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_proyecto.Name = "btn_proyecto";
            this.btn_proyecto.Size = new System.Drawing.Size(107, 37);
            this.btn_proyecto.TabIndex = 5;
            this.btn_proyecto.Text = "Proyecto";
            this.btn_proyecto.UseVisualStyleBackColor = false;
            this.btn_proyecto.Click += new System.EventHandler(this.btn_proyecto_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(27, 357);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(67, 49);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Proveedores.Location = new System.Drawing.Point(367, 222);
            this.btn_Proveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Size = new System.Drawing.Size(107, 37);
            this.btn_Proveedores.TabIndex = 7;
            this.btn_Proveedores.Text = "Proveedor";
            this.btn_Proveedores.UseVisualStyleBackColor = false;
            this.btn_Proveedores.Click += new System.EventHandler(this.btn_Proveedores_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Location = new System.Drawing.Point(353, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 431);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProyectoVarela.Properties.Resources.LAMINADO_INDUSTRIAL_VARELA__;
            this.pictureBox1.Location = new System.Drawing.Point(27, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Proveedores);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_proyecto);
            this.Controls.Add(this.btn_prestamo);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_registro);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAMINADO INDUSTRIAL | VARELA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_prestamo;
        private System.Windows.Forms.Button btn_proyecto;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_Proveedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

