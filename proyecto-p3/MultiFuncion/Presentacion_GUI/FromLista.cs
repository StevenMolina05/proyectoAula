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
    public partial class FromLista : Form
    {
        List<ListaEstudiante> listaUNAD = new List<ListaEstudiante> ();
        public FromLista()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (textIdentificacion.Text.Equals("") || listaTIdentificacion.SelectedItem == null || textNombre.Text.Equals("") || textDireccion.Text.Equals("") || listaEstratos.SelectedItem == null || textEdad.Text.Equals("") || radioSi.Checked==false && radioNo.Checked==false)
            {
                MessageBox.Show("Complete todos los datos!!");
            }
            else if (verificarIdentificacion(int.Parse(textIdentificacion.Text)))
            {
                MessageBox.Show("La identificacion ya esta registrada, ingrese otra!");
            }
            else
            {

                ListaEstudiante lista = new ListaEstudiante();

                lista.tipoIdentificacion = listaTIdentificacion.SelectedItem.ToString();
                lista.identificacion = int.Parse(textIdentificacion.Text);
                lista.nombre = textNombre.Text;
                lista.edad = int.Parse(textEdad.Text);
                lista.estrato = int.Parse(listaEstratos.SelectedItem.ToString());
                lista.fechaRegistro = DateTime.Parse(fechaRegistro.Text);
                if (radioSi.Checked)
                {
                    lista.voto = "SI";
                }
                else
                {
                    lista.voto = "NO";
                }

                listaUNAD.Add(lista);
                tabla.DataSource = null;
                tabla.DataSource = listaUNAD;

                MessageBox.Show("Datos agregados a la lista!");
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool encontro = false;
            if (listaUNAD.Count == 0)
            {
                MessageBox.Show("No hay datos en la lista");

            }
            else if (textConsultar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una identificacion!");
            }
            else
            {

                foreach (ListaEstudiante l in listaUNAD)
                {
                    if (l.identificacion == int.Parse(textConsultar.Text))
                    {
                        if (MessageBox.Show("¿Desea eliminar el dato de la lista?", "ATENCION",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            listaUNAD.Remove(l);
                            encontro = true;
                            MessageBox.Show("Datos eliminado!");
                            break;
                        }
                    }
                }
                if (encontro == false)
                {
                    MessageBox.Show("La identificacion no esta registrada!");
                }
                tabla.DataSource = null;
                tabla.DataSource = listaUNAD;
                
            
        }
        }

        public void limpiar()
        {
            listaTIdentificacion.SelectedItem = null;
            textIdentificacion.Clear();
            textNombre.Clear();
            textEdad.Clear();
            textDireccion.Clear();
            listaEstratos.SelectedItem = null;
        }

        public bool verificarIdentificacion(int cc)
        {
            bool encontro = false;
            foreach (ListaEstudiante l in listaUNAD)
            {
                if (l.identificacion == cc)
                {
                     encontro = true;
                    
                }
            }
            return encontro;
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

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void textIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void textEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void textConsultar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
    }
}
