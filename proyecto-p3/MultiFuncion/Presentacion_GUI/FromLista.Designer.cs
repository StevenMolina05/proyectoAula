namespace Presentacion_GUI
{
    partial class FromLista
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
            this.textConsultar = new System.Windows.Forms.TextBox();
            this.grupoFormulario = new System.Windows.Forms.GroupBox();
            this.fechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.listaTIdentificacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.grupoMenu = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listaEstratos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSi = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.grupoFormulario.SuspendLayout();
            this.grupoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.grupoFormulario);
            this.panel1.Controls.Add(this.grupoMenu);
            this.panel1.Controls.Add(this.tabla);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 598);
            this.panel1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Identificacion";
            // 
            // textConsultar
            // 
            this.textConsultar.Location = new System.Drawing.Point(30, 41);
            this.textConsultar.Name = "textConsultar";
            this.textConsultar.Size = new System.Drawing.Size(164, 20);
            this.textConsultar.TabIndex = 4;
            this.textConsultar.TextChanged += new System.EventHandler(this.textConsultar_TextChanged);
            this.textConsultar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textConsultar_KeyPress);
            // 
            // grupoFormulario
            // 
            this.grupoFormulario.Controls.Add(this.groupBox1);
            this.grupoFormulario.Controls.Add(this.label7);
            this.grupoFormulario.Controls.Add(this.label4);
            this.grupoFormulario.Controls.Add(this.listaEstratos);
            this.grupoFormulario.Controls.Add(this.fechaRegistro);
            this.grupoFormulario.Controls.Add(this.label6);
            this.grupoFormulario.Controls.Add(this.listaTIdentificacion);
            this.grupoFormulario.Controls.Add(this.label5);
            this.grupoFormulario.Controls.Add(this.textNombre);
            this.grupoFormulario.Controls.Add(this.txtNombre);
            this.grupoFormulario.Controls.Add(this.textEdad);
            this.grupoFormulario.Controls.Add(this.label3);
            this.grupoFormulario.Controls.Add(this.textIdentificacion);
            this.grupoFormulario.Controls.Add(this.label2);
            this.grupoFormulario.Controls.Add(this.textDireccion);
            this.grupoFormulario.Location = new System.Drawing.Point(19, 71);
            this.grupoFormulario.Name = "grupoFormulario";
            this.grupoFormulario.Size = new System.Drawing.Size(415, 217);
            this.grupoFormulario.TabIndex = 3;
            this.grupoFormulario.TabStop = false;
            this.grupoFormulario.Text = "FORMULARIO";
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaRegistro.Location = new System.Drawing.Point(16, 165);
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.Size = new System.Drawing.Size(101, 20);
            this.fechaRegistro.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo Identificacion";
            // 
            // listaTIdentificacion
            // 
            this.listaTIdentificacion.AutoCompleteCustomSource.AddRange(new string[] {
            "CC",
            "TI",
            "CE",
            "NIP",
            "NIT"});
            this.listaTIdentificacion.FormattingEnabled = true;
            this.listaTIdentificacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listaTIdentificacion.Items.AddRange(new object[] {
            "CC",
            "TI",
            "CE",
            "NIP",
            "NIT"});
            this.listaTIdentificacion.Location = new System.Drawing.Point(18, 43);
            this.listaTIdentificacion.Name = "listaTIdentificacion";
            this.listaTIdentificacion.Size = new System.Drawing.Size(100, 21);
            this.listaTIdentificacion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Direccion";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(261, 43);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 8;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(15, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(32, 13);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.Text = "Edad";
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(18, 100);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(100, 20);
            this.textEdad.TabIndex = 6;
            this.textEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
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
            this.label2.Location = new System.Drawing.Point(137, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(140, 101);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(100, 20);
            this.textDireccion.TabIndex = 0;
            // 
            // grupoMenu
            // 
            this.grupoMenu.Controls.Add(this.btnRegistrar);
            this.grupoMenu.Location = new System.Drawing.Point(449, 71);
            this.grupoMenu.Name = "grupoMenu";
            this.grupoMenu.Size = new System.Drawing.Size(230, 83);
            this.grupoMenu.TabIndex = 2;
            this.grupoMenu.TabStop = false;
            this.grupoMenu.Text = "MENU";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(28, 70);
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
            this.label1.Location = new System.Drawing.Point(295, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Estrato";
            // 
            // listaEstratos
            // 
            this.listaEstratos.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.listaEstratos.FormattingEnabled = true;
            this.listaEstratos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listaEstratos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.listaEstratos.Location = new System.Drawing.Point(261, 100);
            this.listaEstratos.Name = "listaEstratos";
            this.listaEstratos.Size = new System.Drawing.Size(100, 21);
            this.listaEstratos.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fecha de Registro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.radioNo);
            this.groupBox1.Controls.Add(this.radioSi);
            this.groupBox1.Location = new System.Drawing.Point(139, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 76);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elecciones";
            // 
            // radioSi
            // 
            this.radioSi.AutoSize = true;
            this.radioSi.Location = new System.Drawing.Point(66, 47);
            this.radioSi.Name = "radioSi";
            this.radioSi.Size = new System.Drawing.Size(35, 17);
            this.radioSi.TabIndex = 0;
            this.radioSi.TabStop = true;
            this.radioSi.Text = "SI";
            this.radioSi.UseVisualStyleBackColor = true;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(122, 47);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(41, 17);
            this.radioNo.TabIndex = 1;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "NO";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "¿Voto en las elecciones presidenciales?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textConsultar);
            this.groupBox2.Location = new System.Drawing.Point(449, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 124);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SUBMENU";
            // 
            // FromLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 585);
            this.Controls.Add(this.panel1);
            this.Name = "FromLista";
            this.Text = "FromConsultar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupoFormulario.ResumeLayout(false);
            this.grupoFormulario.PerformLayout();
            this.grupoMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textConsultar;
        private System.Windows.Forms.GroupBox grupoFormulario;
        private System.Windows.Forms.DateTimePicker fechaRegistro;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox listaTIdentificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.GroupBox grupoMenu;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox listaEstratos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.RadioButton radioSi;
    }
}