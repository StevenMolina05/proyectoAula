using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion_GUI
{
    public partial class FromCola : Form
    {
        Queue<ColaJuventud> colaSecretaria = new Queue<ColaJuventud>();
        public FromCola()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (textIdentificacion.Text.Equals("") || textNombre.Text.Equals("") || textDireccion.Text.Equals("") 
                || textCiudad.Text.Equals("") || listaComuna.SelectedItem == null || listaGenero.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los datos!");
            }
            else if (verificarIdentificacion(int.Parse(textIdentificacion.Text)))
            {
                MessageBox.Show("La identificacion ya esta registrada, ingrese otra!");
            }
            else
            {
                ColaJuventud cola = new ColaJuventud();
                cola.identificacion = int.Parse(textIdentificacion.Text);
                cola.nombre = textNombre.Text;
                cola.direccion = textDireccion.Text;
                cola.ciudad = textCiudad.Text;
                cola.comuna = int.Parse(listaComuna.SelectedItem.ToString());
                cola.genero = listaGenero.SelectedItem.ToString();
                cola.fechaActualizacion = DateTime.Parse(fechaActualizacion.Text);
                if (cola.comuna == 1 || cola.comuna == 8 || cola.comuna == 10)
                {
                    cola.auxilio = 100000;
                }
                else
                {
                    cola.auxilio = 50000;
                }
                textAuxilio.Text = cola.auxilio.ToString();
                colaSecretaria.Enqueue(cola);
                tabla.DataSource = null;
                tabla.DataSource = colaSecretaria.ToList();
                MessageBox.Show("Datos agregados a la cola");
                limpiar();
            }
            

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            textReporte.Text = colaSecretaria.Count.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (colaSecretaria.Count != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el dato de la cola?", "ATENCION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    colaSecretaria.Dequeue();
                    tabla.DataSource = null;
                    tabla.DataSource = colaSecretaria.ToList();
                    MessageBox.Show("Datos eliminado!");
                }
            }
            else
            {
                MessageBox.Show("No hay datos en la cola");
            }
        }

        public void limpiar()
        {
            textIdentificacion.Clear();
            textNombre.Clear();
            textDireccion.Clear();
            textCiudad.Clear();
            textAuxilio.Clear();
            listaComuna.SelectedItem = null;
            listaGenero.SelectedItem = null;
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void soloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void textIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void textCiudad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void FromCola_Load(object sender, EventArgs e)
        {

        }

        public bool verificarIdentificacion(int cc)
        {
            bool encontro = false;
            foreach (ColaJuventud l in colaSecretaria)
            {
                if (l.identificacion == cc)
                {
                    encontro = true;

                }
            }
            return encontro;
        }
    }
}
