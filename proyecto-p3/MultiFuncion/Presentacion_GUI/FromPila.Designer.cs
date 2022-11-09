namespace Presentacion_GUI
{
    partial class FromPila
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
            this.textTotal = new System.Windows.Forms.TextBox();
            this.grupoFormulario = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textTPagar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fechaPago = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textMestar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listaCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listaEstrato = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listaMapertura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNcdt = new System.Windows.Forms.TextBox();
            this.grupoMenu = new System.Windows.Forms.GroupBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grupoFormulario.SuspendLayout();
            this.grupoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textTotal);
            this.panel1.Controls.Add(this.grupoFormulario);
            this.panel1.Controls.Add(this.grupoMenu);
            this.panel1.Controls.Add(this.data);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 590);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(499, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Total Pagos CDT";
            // 
            // textTotal
            // 
            this.textTotal.Enabled = false;
            this.textTotal.Location = new System.Drawing.Point(502, 268);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 20);
            this.textTotal.TabIndex = 4;
            // 
            // grupoFormulario
            // 
            this.grupoFormulario.Controls.Add(this.label12);
            this.grupoFormulario.Controls.Add(this.textTPagar);
            this.grupoFormulario.Controls.Add(this.label10);
            this.grupoFormulario.Controls.Add(this.fechaPago);
            this.grupoFormulario.Controls.Add(this.label9);
            this.grupoFormulario.Controls.Add(this.textValor);
            this.grupoFormulario.Controls.Add(this.label8);
            this.grupoFormulario.Controls.Add(this.textMestar);
            this.grupoFormulario.Controls.Add(this.label7);
            this.grupoFormulario.Controls.Add(this.listaCategoria);
            this.grupoFormulario.Controls.Add(this.label6);
            this.grupoFormulario.Controls.Add(this.listaEstrato);
            this.grupoFormulario.Controls.Add(this.label5);
            this.grupoFormulario.Controls.Add(this.textDireccion);
            this.grupoFormulario.Controls.Add(this.txtNombre);
            this.grupoFormulario.Controls.Add(this.textNombre);
            this.grupoFormulario.Controls.Add(this.label4);
            this.grupoFormulario.Controls.Add(this.listaMapertura);
            this.grupoFormulario.Controls.Add(this.label3);
            this.grupoFormulario.Controls.Add(this.textIdentificacion);
            this.grupoFormulario.Controls.Add(this.label2);
            this.grupoFormulario.Controls.Add(this.textNcdt);
            this.grupoFormulario.Location = new System.Drawing.Point(19, 71);
            this.grupoFormulario.Name = "grupoFormulario";
            this.grupoFormulario.Size = new System.Drawing.Size(415, 217);
            this.grupoFormulario.TabIndex = 3;
            this.grupoFormulario.TabStop = false;
            this.grupoFormulario.Text = "FORMULARIO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(155, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Total a Pagar CDT";
            // 
            // textTPagar
            // 
            this.textTPagar.Enabled = false;
            this.textTPagar.Location = new System.Drawing.Point(158, 185);
            this.textTPagar.Name = "textTPagar";
            this.textTPagar.Size = new System.Drawing.Size(100, 20);
            this.textTPagar.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha de Pago";
            // 
            // fechaPago
            // 
            this.fechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPago.Location = new System.Drawing.Point(18, 185);
            this.fechaPago.Name = "fechaPago";
            this.fechaPago.Size = new System.Drawing.Size(121, 20);
            this.fechaPago.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "valor CDT";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(281, 134);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(100, 20);
            this.textValor.TabIndex = 16;
            this.textValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textValor_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Meses de estar CDT";
            // 
            // textMestar
            // 
            this.textMestar.Location = new System.Drawing.Point(158, 134);
            this.textMestar.Name = "textMestar";
            this.textMestar.Size = new System.Drawing.Size(100, 20);
            this.textMestar.TabIndex = 14;
            this.textMestar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMestar_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Categoria";
            // 
            // listaCategoria
            // 
            this.listaCategoria.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.listaCategoria.FormattingEnabled = true;
            this.listaCategoria.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Urbano"});
            this.listaCategoria.Location = new System.Drawing.Point(18, 134);
            this.listaCategoria.Name = "listaCategoria";
            this.listaCategoria.Size = new System.Drawing.Size(121, 21);
            this.listaCategoria.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estrato";
            // 
            // listaEstrato
            // 
            this.listaEstrato.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.listaEstrato.FormattingEnabled = true;
            this.listaEstrato.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listaEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.listaEstrato.Location = new System.Drawing.Point(261, 84);
            this.listaEstrato.Name = "listaEstrato";
            this.listaEstrato.Size = new System.Drawing.Size(121, 21);
            this.listaEstrato.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Direccion";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(140, 84);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(100, 20);
            this.textDireccion.TabIndex = 8;
            this.textDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDireccion_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(15, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(44, 13);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(18, 84);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 6;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mes de Apertura";
            // 
            // listaMapertura
            // 
            this.listaMapertura.FormattingEnabled = true;
            this.listaMapertura.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.listaMapertura.Location = new System.Drawing.Point(261, 43);
            this.listaMapertura.Name = "listaMapertura";
            this.listaMapertura.Size = new System.Drawing.Size(121, 21);
            this.listaMapertura.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Identificacion";
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(140, 43);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textIdentificacion.TabIndex = 2;
            this.textIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdentificacion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero CDT";
            // 
            // textNcdt
            // 
            this.textNcdt.Location = new System.Drawing.Point(18, 43);
            this.textNcdt.Name = "textNcdt";
            this.textNcdt.Size = new System.Drawing.Size(100, 20);
            this.textNcdt.TabIndex = 0;
            this.textNcdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNcdt_KeyPress);
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
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(36, 320);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(617, 222);
            this.data.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANCO";
            // 
            // FromPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 578);
            this.Controls.Add(this.panel1);
            this.Name = "FromPila";
            this.Text = "FrameInicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupoFormulario.ResumeLayout(false);
            this.grupoFormulario.PerformLayout();
            this.grupoMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grupoFormulario;
        private System.Windows.Forms.GroupBox grupoMenu;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNcdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIdentificacion;
        public System.Windows.Forms.ComboBox listaMapertura;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textMestar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox listaCategoria;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox listaEstrato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fechaPago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textTPagar;
    }
}