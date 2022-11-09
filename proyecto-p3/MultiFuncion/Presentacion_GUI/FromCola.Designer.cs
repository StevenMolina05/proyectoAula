namespace Presentacion_GUI
{
    partial class FromCola
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
            this.label11 = new System.Windows.Forms.Label();
            this.textReporte = new System.Windows.Forms.TextBox();
            this.grupoFormulario = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fechaActualizacion = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textAuxilio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listaComuna = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.grupoMenu = new System.Windows.Forms.GroupBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listaGenero = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textCiudad = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.grupoFormulario.SuspendLayout();
            this.grupoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textReporte);
            this.panel1.Controls.Add(this.grupoFormulario);
            this.panel1.Controls.Add(this.grupoMenu);
            this.panel1.Controls.Add(this.tabla);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 597);
            this.panel1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(499, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Reporte Registrados";
            // 
            // textReporte
            // 
            this.textReporte.Location = new System.Drawing.Point(502, 268);
            this.textReporte.Name = "textReporte";
            this.textReporte.Size = new System.Drawing.Size(100, 20);
            this.textReporte.TabIndex = 4;
            // 
            // grupoFormulario
            // 
            this.grupoFormulario.Controls.Add(this.label7);
            this.grupoFormulario.Controls.Add(this.textCiudad);
            this.grupoFormulario.Controls.Add(this.label4);
            this.grupoFormulario.Controls.Add(this.listaGenero);
            this.grupoFormulario.Controls.Add(this.label10);
            this.grupoFormulario.Controls.Add(this.fechaActualizacion);
            this.grupoFormulario.Controls.Add(this.label9);
            this.grupoFormulario.Controls.Add(this.textAuxilio);
            this.grupoFormulario.Controls.Add(this.label6);
            this.grupoFormulario.Controls.Add(this.listaComuna);
            this.grupoFormulario.Controls.Add(this.label5);
            this.grupoFormulario.Controls.Add(this.textDireccion);
            this.grupoFormulario.Controls.Add(this.label3);
            this.grupoFormulario.Controls.Add(this.textNombre);
            this.grupoFormulario.Controls.Add(this.label2);
            this.grupoFormulario.Controls.Add(this.textIdentificacion);
            this.grupoFormulario.Location = new System.Drawing.Point(19, 71);
            this.grupoFormulario.Name = "grupoFormulario";
            this.grupoFormulario.Size = new System.Drawing.Size(415, 217);
            this.grupoFormulario.TabIndex = 3;
            this.grupoFormulario.TabStop = false;
            this.grupoFormulario.Text = "FORMULARIO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha de Actualizacion";
            // 
            // fechaActualizacion
            // 
            this.fechaActualizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaActualizacion.Location = new System.Drawing.Point(17, 165);
            this.fechaActualizacion.Name = "fechaActualizacion";
            this.fechaActualizacion.Size = new System.Drawing.Size(121, 20);
            this.fechaActualizacion.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Auxilio";
            // 
            // textAuxilio
            // 
            this.textAuxilio.Enabled = false;
            this.textAuxilio.Location = new System.Drawing.Point(147, 165);
            this.textAuxilio.Name = "textAuxilio";
            this.textAuxilio.ReadOnly = true;
            this.textAuxilio.Size = new System.Drawing.Size(100, 20);
            this.textAuxilio.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Comuna";
            // 
            // listaComuna
            // 
            this.listaComuna.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.listaComuna.FormattingEnabled = true;
            this.listaComuna.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listaComuna.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.listaComuna.Location = new System.Drawing.Point(138, 100);
            this.listaComuna.Name = "listaComuna";
            this.listaComuna.Size = new System.Drawing.Size(101, 21);
            this.listaComuna.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Direccion";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(261, 42);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(100, 20);
            this.textDireccion.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(140, 43);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 2;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion";
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(18, 43);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textIdentificacion.TabIndex = 0;
            this.textIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdentificacion_KeyPress);
            // 
            // grupoMenu
            // 
            this.grupoMenu.Controls.Add(this.btnReportes);
            this.grupoMenu.Controls.Add(this.btnEliminar);
            this.grupoMenu.Controls.Add(this.btnRegistrar);
            this.grupoMenu.Location = new System.Drawing.Point(449, 71);
            this.grupoMenu.Name = "grupoMenu";
            this.grupoMenu.Size = new System.Drawing.Size(230, 174);
            this.grupoMenu.TabIndex = 2;
            this.grupoMenu.TabStop = false;
            this.grupoMenu.Text = "MENU";
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(30, 118);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(174, 44);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(28, 68);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(174, 44);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(30, 19);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(174, 43);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(36, 320);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(617, 222);
            this.tabla.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SECRETARIA DE LA JUVENTUD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Genero";
            // 
            // listaGenero
            // 
            this.listaGenero.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.listaGenero.FormattingEnabled = true;
            this.listaGenero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listaGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "No Binario"});
            this.listaGenero.Location = new System.Drawing.Point(261, 100);
            this.listaGenero.Name = "listaGenero";
            this.listaGenero.Size = new System.Drawing.Size(101, 21);
            this.listaGenero.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ciudad";
            // 
            // textCiudad
            // 
            this.textCiudad.Location = new System.Drawing.Point(18, 100);
            this.textCiudad.Name = "textCiudad";
            this.textCiudad.Size = new System.Drawing.Size(100, 20);
            this.textCiudad.TabIndex = 22;
            this.textCiudad.TextChanged += new System.EventHandler(this.textCiudad_TextChanged);
            this.textCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCiudad_KeyPress);
            // 
            // FromCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 579);
            this.Controls.Add(this.panel1);
            this.Name = "FromCola";
            this.Text = "FrameRegistrar";
            this.Load += new System.EventHandler(this.FromCola_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupoFormulario.ResumeLayout(false);
            this.grupoFormulario.PerformLayout();
            this.grupoMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textReporte;
        private System.Windows.Forms.GroupBox grupoFormulario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fechaActualizacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textAuxilio;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox listaComuna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.GroupBox grupoMenu;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox listaGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCiudad;
    }
}