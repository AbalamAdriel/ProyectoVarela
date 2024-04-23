namespace ProyectoVarela
{
    partial class ModificarProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProyecto));
            this.listViewHerramientas = new System.Windows.Forms.ListView();
            this.IdHerramienta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomHerramienta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantHerramienta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnadirMateriales = new System.Windows.Forms.Button();
            this.txtCantidadM = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cbMateriales = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewMateriales = new System.Windows.Forms.ListView();
            this.Id_Material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreMaterial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantidadM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbHerramientas = new System.Windows.Forms.ComboBox();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.btnAnadirHerramienta = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnEliminarH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId_Proyecto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewHerramientas
            // 
            this.listViewHerramientas.BackColor = System.Drawing.Color.LightGreen;
            this.listViewHerramientas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHerramienta,
            this.NomHerramienta,
            this.CantHerramienta});
            this.listViewHerramientas.HideSelection = false;
            this.listViewHerramientas.Location = new System.Drawing.Point(347, 275);
            this.listViewHerramientas.Name = "listViewHerramientas";
            this.listViewHerramientas.Size = new System.Drawing.Size(319, 204);
            this.listViewHerramientas.TabIndex = 63;
            this.listViewHerramientas.UseCompatibleStateImageBehavior = false;
            this.listViewHerramientas.View = System.Windows.Forms.View.Details;
            // 
            // IdHerramienta
            // 
            this.IdHerramienta.Text = "Id_Herramienta";
            this.IdHerramienta.Width = 91;
            // 
            // NomHerramienta
            // 
            this.NomHerramienta.Text = "Nombre Herramienta";
            // 
            // CantHerramienta
            // 
            this.CantHerramienta.Text = "Cantidad Herramienta";
            this.CantHerramienta.Width = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Location = new System.Drawing.Point(109, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "MATERIALES:";
            // 
            // btnAnadirMateriales
            // 
            this.btnAnadirMateriales.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAnadirMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirMateriales.Location = new System.Drawing.Point(240, 234);
            this.btnAnadirMateriales.Name = "btnAnadirMateriales";
            this.btnAnadirMateriales.Size = new System.Drawing.Size(80, 32);
            this.btnAnadirMateriales.TabIndex = 61;
            this.btnAnadirMateriales.Text = "Añadir";
            this.btnAnadirMateriales.UseVisualStyleBackColor = false;
            this.btnAnadirMateriales.Click += new System.EventHandler(this.btnAnadirMateriales_Click);
            // 
            // txtCantidadM
            // 
            this.txtCantidadM.BackColor = System.Drawing.Color.LightGreen;
            this.txtCantidadM.Location = new System.Drawing.Point(133, 206);
            this.txtCantidadM.Name = "txtCantidadM";
            this.txtCantidadM.Size = new System.Drawing.Size(187, 22);
            this.txtCantidadM.TabIndex = 60;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblCantidad.Location = new System.Drawing.Point(30, 213);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 16);
            this.lblCantidad.TabIndex = 59;
            this.lblCantidad.Text = "CANTIDAD:";
            // 
            // cbMateriales
            // 
            this.cbMateriales.BackColor = System.Drawing.Color.LightGreen;
            this.cbMateriales.FormattingEnabled = true;
            this.cbMateriales.Location = new System.Drawing.Point(133, 168);
            this.cbMateriales.Name = "cbMateriales";
            this.cbMateriales.Size = new System.Drawing.Size(187, 24);
            this.cbMateriales.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Location = new System.Drawing.Point(30, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "NOMBRE";
            // 
            // txtCantidadH
            // 
            this.txtCantidadH.BackColor = System.Drawing.Color.LightGreen;
            this.txtCantidadH.Location = new System.Drawing.Point(483, 207);
            this.txtCantidadH.Name = "txtCantidadH";
            this.txtCantidadH.Size = new System.Drawing.Size(183, 22);
            this.txtCantidadH.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Location = new System.Drawing.Point(344, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "CANTIDAD:";
            // 
            // listViewMateriales
            // 
            this.listViewMateriales.BackColor = System.Drawing.Color.LightGreen;
            this.listViewMateriales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_Material,
            this.NombreMaterial,
            this.CantidadM});
            this.listViewMateriales.HideSelection = false;
            this.listViewMateriales.Location = new System.Drawing.Point(33, 275);
            this.listViewMateriales.Name = "listViewMateriales";
            this.listViewMateriales.Size = new System.Drawing.Size(287, 204);
            this.listViewMateriales.TabIndex = 54;
            this.listViewMateriales.UseCompatibleStateImageBehavior = false;
            this.listViewMateriales.View = System.Windows.Forms.View.Details;
            // 
            // Id_Material
            // 
            this.Id_Material.Text = "Id_Material";
            this.Id_Material.Width = 91;
            // 
            // NombreMaterial
            // 
            this.NombreMaterial.Text = "Nombre Material";
            // 
            // CantidadM
            // 
            this.CantidadM.Text = "Cantidad Material";
            this.CantidadM.Width = 102;
            // 
            // cbHerramientas
            // 
            this.cbHerramientas.BackColor = System.Drawing.Color.LightGreen;
            this.cbHerramientas.FormattingEnabled = true;
            this.cbHerramientas.Location = new System.Drawing.Point(481, 171);
            this.cbHerramientas.Name = "cbHerramientas";
            this.cbHerramientas.Size = new System.Drawing.Size(185, 24);
            this.cbHerramientas.TabIndex = 53;
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblNombreProyecto.Location = new System.Drawing.Point(35, 94);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(151, 16);
            this.lblNombreProyecto.TabIndex = 52;
            this.lblNombreProyecto.Text = "NOMBRE_PROYECTO:";
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.BackColor = System.Drawing.Color.LightGreen;
            this.txtNombreProyecto.Location = new System.Drawing.Point(208, 91);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(218, 22);
            this.txtNombreProyecto.TabIndex = 51;
            // 
            // btnAnadirHerramienta
            // 
            this.btnAnadirHerramienta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAnadirHerramienta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirHerramienta.Location = new System.Drawing.Point(586, 233);
            this.btnAnadirHerramienta.Name = "btnAnadirHerramienta";
            this.btnAnadirHerramienta.Size = new System.Drawing.Size(80, 32);
            this.btnAnadirHerramienta.TabIndex = 50;
            this.btnAnadirHerramienta.Text = "Añadir";
            this.btnAnadirHerramienta.UseVisualStyleBackColor = false;
            this.btnAnadirHerramienta.Click += new System.EventHandler(this.btnAnadirHerramienta_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(575, 486);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 31);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(464, 486);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 31);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Location = new System.Drawing.Point(344, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Location = new System.Drawing.Point(458, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "HERRAMIENTAS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "NOMBRE_CLIENTE:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.LightGreen;
            this.txtNombreCliente.Location = new System.Drawing.Point(208, 63);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(218, 22);
            this.txtNombreCliente.TabIndex = 44;
            // 
            // btnEliminarH
            // 
            this.btnEliminarH.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminarH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarH.Location = new System.Drawing.Point(483, 235);
            this.btnEliminarH.Name = "btnEliminarH";
            this.btnEliminarH.Size = new System.Drawing.Size(80, 31);
            this.btnEliminarH.TabIndex = 65;
            this.btnEliminarH.Text = "Eliminar";
            this.btnEliminarH.UseVisualStyleBackColor = false;
            this.btnEliminarH.Click += new System.EventHandler(this.btnEliminarH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "ID_PROYECTO:";
            // 
            // txtId_Proyecto
            // 
            this.txtId_Proyecto.BackColor = System.Drawing.Color.LightGreen;
            this.txtId_Proyecto.Location = new System.Drawing.Point(208, 18);
            this.txtId_Proyecto.Name = "txtId_Proyecto";
            this.txtId_Proyecto.Size = new System.Drawing.Size(218, 22);
            this.txtId_Proyecto.TabIndex = 66;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(442, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 28);
            this.btnBuscar.TabIndex = 68;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarM.Location = new System.Drawing.Point(133, 234);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(80, 31);
            this.btnEliminarM.TabIndex = 70;
            this.btnEliminarM.Text = "Eliminar";
            this.btnEliminarM.UseVisualStyleBackColor = false;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // ModificarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(696, 531);
            this.Controls.Add(this.btnEliminarM);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId_Proyecto);
            this.Controls.Add(this.btnEliminarH);
            this.Controls.Add(this.listViewHerramientas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnadirMateriales);
            this.Controls.Add(this.txtCantidadM);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cbMateriales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidadH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listViewMateriales);
            this.Controls.Add(this.cbHerramientas);
            this.Controls.Add(this.lblNombreProyecto);
            this.Controls.Add(this.txtNombreProyecto);
            this.Controls.Add(this.btnAnadirHerramienta);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarProyecto";
            this.Text = "ModificarProyecto | VARELA";
            this.Load += new System.EventHandler(this.ModificarProyecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewHerramientas;
        private System.Windows.Forms.ColumnHeader IdHerramienta;
        private System.Windows.Forms.ColumnHeader CantHerramienta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnadirMateriales;
        private System.Windows.Forms.TextBox txtCantidadM;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cbMateriales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewMateriales;
        private System.Windows.Forms.ColumnHeader Id_Material;
        private System.Windows.Forms.ColumnHeader CantidadM;
        private System.Windows.Forms.ComboBox cbHerramientas;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.Button btnAnadirHerramienta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnEliminarH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId_Proyecto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminarM;
        private System.Windows.Forms.ColumnHeader NomHerramienta;
        private System.Windows.Forms.ColumnHeader NombreMaterial;
    }
}