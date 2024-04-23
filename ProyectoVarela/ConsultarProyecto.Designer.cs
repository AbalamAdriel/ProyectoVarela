namespace ProyectoVarela
{
    partial class ConsultarProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProyecto));
            this.dataGridViewMateriales = new System.Windows.Forms.DataGridView();
            this.txtBuscarProyecto = new System.Windows.Forms.Button();
            this.txtId_Proyecto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHerramientas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistrarProyecto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMateriales
            // 
            this.dataGridViewMateriales.AllowUserToAddRows = false;
            this.dataGridViewMateriales.AllowUserToDeleteRows = false;
            this.dataGridViewMateriales.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridViewMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateriales.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridViewMateriales.Location = new System.Drawing.Point(33, 154);
            this.dataGridViewMateriales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMateriales.Name = "dataGridViewMateriales";
            this.dataGridViewMateriales.ReadOnly = true;
            this.dataGridViewMateriales.RowHeadersWidth = 51;
            this.dataGridViewMateriales.RowTemplate.Height = 24;
            this.dataGridViewMateriales.Size = new System.Drawing.Size(1000, 185);
            this.dataGridViewMateriales.TabIndex = 0;
            this.dataGridViewMateriales.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMateriales_CellFormatting);
            this.dataGridViewMateriales.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewMateriales_RowPrePaint);
            this.dataGridViewMateriales.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewMateriales_RowsAdded);
            // 
            // txtBuscarProyecto
            // 
            this.txtBuscarProyecto.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtBuscarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtBuscarProyecto.Location = new System.Drawing.Point(267, 54);
            this.txtBuscarProyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarProyecto.Name = "txtBuscarProyecto";
            this.txtBuscarProyecto.Size = new System.Drawing.Size(80, 37);
            this.txtBuscarProyecto.TabIndex = 1;
            this.txtBuscarProyecto.Text = "Buscar";
            this.txtBuscarProyecto.UseVisualStyleBackColor = false;
            this.txtBuscarProyecto.Click += new System.EventHandler(this.txtBuscarProyecto_Click);
            // 
            // txtId_Proyecto
            // 
            this.txtId_Proyecto.BackColor = System.Drawing.Color.LightGreen;
            this.txtId_Proyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId_Proyecto.Location = new System.Drawing.Point(67, 62);
            this.txtId_Proyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId_Proyecto.Name = "txtId_Proyecto";
            this.txtId_Proyecto.Size = new System.Drawing.Size(183, 22);
            this.txtId_Proyecto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(67, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID_PROYECTO";
            // 
            // dataGridViewHerramientas
            // 
            this.dataGridViewHerramientas.AllowUserToAddRows = false;
            this.dataGridViewHerramientas.AllowUserToDeleteRows = false;
            this.dataGridViewHerramientas.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridViewHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHerramientas.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridViewHerramientas.Location = new System.Drawing.Point(33, 369);
            this.dataGridViewHerramientas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHerramientas.Name = "dataGridViewHerramientas";
            this.dataGridViewHerramientas.ReadOnly = true;
            this.dataGridViewHerramientas.RowHeadersWidth = 51;
            this.dataGridViewHerramientas.RowTemplate.Height = 24;
            this.dataGridViewHerramientas.Size = new System.Drawing.Size(1000, 185);
            this.dataGridViewHerramientas.TabIndex = 4;
            this.dataGridViewHerramientas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewHerramientas_RowsAdded);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(33, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "MATERIALES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Location = new System.Drawing.Point(33, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "HERRAMIENTAS";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(867, 43);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 62);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Location = new System.Drawing.Point(37, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 118);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(696, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrarProyecto
            // 
            this.btnRegistrarProyecto.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegistrarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarProyecto.Location = new System.Drawing.Point(520, 41);
            this.btnRegistrarProyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarProyecto.Name = "btnRegistrarProyecto";
            this.btnRegistrarProyecto.Size = new System.Drawing.Size(133, 62);
            this.btnRegistrarProyecto.TabIndex = 11;
            this.btnRegistrarProyecto.Text = "Registrar";
            this.btnRegistrarProyecto.UseVisualStyleBackColor = false;
            this.btnRegistrarProyecto.Click += new System.EventHandler(this.btnRegistrarProyecto_Click);
            // 
            // ConsultarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.btnRegistrarProyecto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewHerramientas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId_Proyecto);
            this.Controls.Add(this.txtBuscarProyecto);
            this.Controls.Add(this.dataGridViewMateriales);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultarProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Proyecto | VARELA";
            this.Load += new System.EventHandler(this.ConsultarProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMateriales;
        private System.Windows.Forms.Button txtBuscarProyecto;
        private System.Windows.Forms.TextBox txtId_Proyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHerramientas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegistrarProyecto;
    }
}