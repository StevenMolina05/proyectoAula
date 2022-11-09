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
    public partial class FromPrincipal : Form
    {
        public FromPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            btnPila.BackColor = Color.White;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            btnPila.BackColor = Color.DeepSkyBlue;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            btnPila.BackColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            btnPila.BackColor = Color.DeepSkyBlue;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.DeepSkyBlue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.DeepSkyBlue;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            btnLista.BackColor = Color.White;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            btnLista.BackColor = Color.DeepSkyBlue;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.DeepSkyBlue;
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelCambiante.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelCambiante.Controls.Add(formulario);
                PanelCambiante.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario<FromCola>();
        }

        private void btnLista_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario<FromLista>();
        }

        private void btnPila_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario<FromPila>();
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
