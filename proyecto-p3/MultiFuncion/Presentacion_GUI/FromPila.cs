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
    public partial class FromPila : Form
    {
        Stack<PilaCdt> pilaBanco = new Stack<PilaCdt>();
        double totalPagar = 0;
        public FromPila()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (textNcdt.Text.Equals("") || textIdentificacion.Text.Equals("") || listaMapertura.SelectedItem == null || textNombre.Text.Equals("") || textDireccion.Text.Equals("") || listaEstrato.SelectedItem == null || listaCategoria.SelectedItem == null || textMestar.Text.Equals("") || textValor.Text.Equals(""))
            {
                MessageBox.Show("Complete todos los datos!!");
            }else if (verificarCDT(int.Parse(textNcdt.Text)))
            {
                MessageBox.Show("El numero de CDT ya esta registrado, ingrese otro!");
            }
            else if (verificarIdentificacion(int.Parse(textIdentificacion.Text)))
            {
                MessageBox.Show("La identificacion ya esta registrada, ingrese otra!");
            }
            else
            {

                PilaCdt pila = new PilaCdt();
                double interes = 0;
                pila.numeroCdt = int.Parse(this.textNcdt.Text);
                pila.numIdentificacion = int.Parse(textIdentificacion.Text);
                pila.mesApertura = listaMapertura.SelectedItem.ToString();
                pila.nombre = textNombre.Text;
                pila.direccion = textDireccion.Text;
                pila.estrato = int.Parse(listaEstrato.SelectedItem.ToString());
                pila.categoria = listaCategoria.SelectedItem.ToString();
                pila.tiempoCdt = int.Parse(textMestar.Text);
                pila.valorCdt = double.Parse(textValor.Text);
                if (pila.tiempoCdt >= 1 && pila.tiempoCdt <= 12)
                {
                    interes = 0.02;
                }
                else if (pila.tiempoCdt >= 13 && pila.tiempoCdt <= 24)
                {
                    interes = 0.03;
                }
                else if (pila.tiempoCdt >= 25)
                {
                    interes = 0.05;
                }
                pila.totalPagar = pila.valorCdt + (((pila.valorCdt * interes) * pila.tiempoCdt));
                textTPagar.Text = pila.totalPagar.ToString();
                pila.fechaDePago = DateTime.Parse(fechaPago.Text);
                totalPagar += pila.totalPagar;
                pilaBanco.Push(pila);
                data.DataSource = null;
                data.DataSource = pilaBanco.ToArray();
                
                MessageBox.Show("Datos agregados a la pila!");
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (pilaBanco.Count != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el dato de la pila?","ATENCION",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    pilaBanco.Pop();
                    data.DataSource = null;
                    data.DataSource = pilaBanco.ToArray();
                    MessageBox.Show("Datos eliminado!");
                }
            }
            else
            {
                MessageBox.Show("No hay datos en la pila");
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            textTotal.Text = totalPagar.ToString();
        }

        public void limpiar()
        {
            textNcdt.Clear();
            textIdentificacion.Clear();
            listaCategoria.SelectedItem = null;
            textNombre.Clear();
            textDireccion.Clear();
            listaEstrato.SelectedItem = null;
            listaMapertura.SelectedItem = null;
            textMestar.Clear();
            textValor.Clear();
            textTPagar.Clear();
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

        private void textNcdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void textIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void textDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textMestar_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void textValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        public bool verificarIdentificacion(int cc)
        {
            bool encontro = false;
            foreach (PilaCdt l in pilaBanco)
            {
                if (l.numIdentificacion == cc)
                {
                    encontro = true;

                }
            }
            return encontro;
        }

        public bool verificarCDT(int cd)
        {
            bool encontro = false;
            foreach (PilaCdt l in pilaBanco)
            {
                if (l.numeroCdt == cd)
                {
                    encontro = true;

                }
            }
            return encontro;
        }
    }


}
