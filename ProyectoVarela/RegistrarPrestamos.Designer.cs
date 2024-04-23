using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoVarela
{
    partial class RegistrarPrestamos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPrestamos));
            this.aceptar_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cantidad_UpDown = new System.Windows.Forms.NumericUpDown();
            this.regresar_Btn = new System.Windows.Forms.Button();
            this.registrar_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPrestamos = new System.Windows.Forms.DataGridView();
            this.nombreHerramientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboHerramientas = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.fechadevolucion_Datepicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaprestamo_Datepicker = new System.Windows.Forms.DateTimePicker();
            this.fechaPublicacion_Lbl = new System.Windows.Forms.Label();
            this.cod_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad_UpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aceptar_Btn
            // 
            this.aceptar_Btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.aceptar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptar_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.aceptar_Btn.Location = new System.Drawing.Point(435, 35);
            this.aceptar_Btn.Name = "aceptar_Btn";
            this.aceptar_Btn.Size = new System.Drawing.Size(119, 65);
            this.aceptar_Btn.TabIndex = 112;
            this.aceptar_Btn.Text = "Aceptar";
            this.aceptar_Btn.UseVisualStyleBackColor = false;
            this.aceptar_Btn.Click += new System.EventHandler(this.aceptar_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 111;
            this.label3.Text = "Cantidad:";
            // 
            // cantidad_UpDown
            // 
            this.cantidad_UpDown.BackColor = System.Drawing.Color.LightGreen;
            this.cantidad_UpDown.Location = new System.Drawing.Point(134, 78);
            this.cantidad_UpDown.Margin = new System.Windows.Forms.Padding(4);
            this.cantidad_UpDown.Name = "cantidad_UpDown";
            this.cantidad_UpDown.Size = new System.Drawing.Size(88, 22);
            this.cantidad_UpDown.TabIndex = 110;
            // 
            // regresar_Btn
            // 
            this.regresar_Btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.regresar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresar_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.regresar_Btn.Location = new System.Drawing.Point(26, 589);
            this.regresar_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.regresar_Btn.Name = "regresar_Btn";
            this.regresar_Btn.Size = new System.Drawing.Size(177, 35);
            this.regresar_Btn.TabIndex = 104;
            this.regresar_Btn.Text = "Cerrar";
            this.regresar_Btn.UseVisualStyleBackColor = false;
            this.regresar_Btn.Click += new System.EventHandler(this.regresar_Btn_Click);
            // 
            // registrar_Btn
            // 
            this.registrar_Btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.registrar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrar_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.registrar_Btn.Location = new System.Drawing.Point(422, 589);
            this.registrar_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.registrar_Btn.Name = "registrar_Btn";
            this.registrar_Btn.Size = new System.Drawing.Size(177, 35);
            this.registrar_Btn.TabIndex = 102;
            this.registrar_Btn.Text = "Registrar";
            this.registrar_Btn.UseVisualStyleBackColor = false;
            this.registrar_Btn.Click += new System.EventHandler(this.registrar_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.label4.Location = new System.Drawing.Point(20, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 114;
            this.label4.Text = "Herramienta";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.dataGridViewPrestamos);
            this.groupBox1.Controls.Add(this.cboHerramientas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.aceptar_Btn);
            this.groupBox1.Controls.Add(this.cantidad_UpDown);
            this.groupBox1.Location = new System.Drawing.Point(26, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 322);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Captura de Herramientas";
            // 
            // dataGridViewPrestamos
            // 
            this.dataGridViewPrestamos.AllowUserToAddRows = false;
            this.dataGridViewPrestamos.AutoGenerateColumns = false;
            this.dataGridViewPrestamos.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridViewPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreHerramientaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dataGridViewPrestamos.DataSource = this.prestamoBindingSource;
            this.dataGridViewPrestamos.Location = new System.Drawing.Point(23, 133);
            this.dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            this.dataGridViewPrestamos.ReadOnly = true;
            this.dataGridViewPrestamos.RowHeadersWidth = 51;
            this.dataGridViewPrestamos.RowTemplate.Height = 24;
            this.dataGridViewPrestamos.Size = new System.Drawing.Size(361, 168);
            this.dataGridViewPrestamos.TabIndex = 116;
            // 
            // nombreHerramientaDataGridViewTextBoxColumn
            // 
            this.nombreHerramientaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreHerramientaDataGridViewTextBoxColumn.DataPropertyName = "NombreHerramienta";
            this.nombreHerramientaDataGridViewTextBoxColumn.HeaderText = "Herramienta";
            this.nombreHerramientaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreHerramientaDataGridViewTextBoxColumn.Name = "nombreHerramientaDataGridViewTextBoxColumn";
            this.nombreHerramientaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 90;
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataSource = typeof(ProyectoVarela.Entidades.Prestamo);
            // 
            // cboHerramientas
            // 
            this.cboHerramientas.BackColor = System.Drawing.Color.LightGreen;
            this.cboHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHerramientas.FormattingEnabled = true;
            this.cboHerramientas.Location = new System.Drawing.Point(134, 35);
            this.cboHerramientas.Name = "cboHerramientas";
            this.cboHerramientas.Size = new System.Drawing.Size(250, 24);
            this.cboHerramientas.TabIndex = 115;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.cboEmpleados);
            this.panel1.Controls.Add(this.fechadevolucion_Datepicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fechaprestamo_Datepicker);
            this.panel1.Controls.Add(this.fechaPublicacion_Lbl);
            this.panel1.Controls.Add(this.cod_Lbl);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 229);
            this.panel1.TabIndex = 117;
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.BackColor = System.Drawing.Color.LightGreen;
            this.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(190, 173);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(259, 24);
            this.cboEmpleados.TabIndex = 123;
            // 
            // fechadevolucion_Datepicker
            // 
            this.fechadevolucion_Datepicker.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechadevolucion_Datepicker.Location = new System.Drawing.Point(190, 121);
            this.fechadevolucion_Datepicker.Margin = new System.Windows.Forms.Padding(4);
            this.fechadevolucion_Datepicker.Name = "fechadevolucion_Datepicker";
            this.fechadevolucion_Datepicker.Size = new System.Drawing.Size(259, 25);
            this.fechadevolucion_Datepicker.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.label1.Location = new System.Drawing.Point(19, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 121;
            this.label1.Text = "Fecha de devolución:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(201, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 21);
            this.label2.TabIndex = 120;
            this.label2.Text = "Registrar Prestamo";
            // 
            // fechaprestamo_Datepicker
            // 
            this.fechaprestamo_Datepicker.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaprestamo_Datepicker.Location = new System.Drawing.Point(190, 62);
            this.fechaprestamo_Datepicker.Margin = new System.Windows.Forms.Padding(4);
            this.fechaprestamo_Datepicker.Name = "fechaprestamo_Datepicker";
            this.fechaprestamo_Datepicker.Size = new System.Drawing.Size(259, 25);
            this.fechaprestamo_Datepicker.TabIndex = 119;
            this.fechaprestamo_Datepicker.ValueChanged += new System.EventHandler(this.fechaprestamo_Datepicker_ValueChanged);
            // 
            // fechaPublicacion_Lbl
            // 
            this.fechaPublicacion_Lbl.AutoSize = true;
            this.fechaPublicacion_Lbl.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.fechaPublicacion_Lbl.Location = new System.Drawing.Point(20, 67);
            this.fechaPublicacion_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaPublicacion_Lbl.Name = "fechaPublicacion_Lbl";
            this.fechaPublicacion_Lbl.Size = new System.Drawing.Size(150, 18);
            this.fechaPublicacion_Lbl.TabIndex = 118;
            this.fechaPublicacion_Lbl.Text = "Fecha del prestamo:";
            // 
            // cod_Lbl
            // 
            this.cod_Lbl.AutoSize = true;
            this.cod_Lbl.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.cod_Lbl.Location = new System.Drawing.Point(20, 175);
            this.cod_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cod_Lbl.Name = "cod_Lbl";
            this.cod_Lbl.Size = new System.Drawing.Size(166, 18);
            this.cod_Lbl.TabIndex = 117;
            this.cod_Lbl.Text = "Código del Empleado:";
            // 
            // RegistrarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVarela.Properties.Resources.background_sec;
            this.ClientSize = new System.Drawing.Size(642, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.regresar_Btn);
            this.Controls.Add(this.registrar_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(660, 578);
            this.Name = "RegistrarPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Prestamos";
            this.Load += new System.EventHandler(this.RegistrarPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidad_UpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button aceptar_Btn;
        private Label label3;
        private NumericUpDown cantidad_UpDown;
        private Button regresar_Btn;
        private Button registrar_Btn;
        private Label label4;
        private GroupBox groupBox1;
        private ComboBox cboHerramientas;
        private DataGridView dataGridViewPrestamos;
        private BindingSource prestamoBindingSource;
        private DataGridViewTextBoxColumn nombreHerramientaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private Panel panel1;
        private ComboBox cboEmpleados;
        private DateTimePicker fechadevolucion_Datepicker;
        private Label label1;
        private Label label2;
        private DateTimePicker fechaprestamo_Datepicker;
        private Label fechaPublicacion_Lbl;
        private Label cod_Lbl;
    }
}