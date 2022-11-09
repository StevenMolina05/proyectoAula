using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_GUI
{
    public partial class FromEntrada : Form
    {
        public FromEntrada()
        {
            InitializeComponent();
        }

       private void button1_Click(object sender, EventArgs e)
        {
            if (textContraseña.Text.Equals("123"))
            {
                MessageBox.Show("Bienvenido");
                AbrirFormulario<FromPrincipal>();
                textContraseña.Clear();

           }
           else
           {
                
               MessageBox.Show("Contraseña Incorrecta!");
               textContraseña.Clear();
           }
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelPrincipal.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                   //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(formulario);
                panelPrincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
    }
}
