using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ColaJuventud
    {
        public int identificacion { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public int comuna { get; set; }
        public string genero { get; set; }
        public DateTime fechaActualizacion { get; set; }
        public double auxilio { get; set; }

        public ColaJuventud()
        {
        }

        public ColaJuventud(int identificacion, string nombre, string direccion, string ciudad, int comuna, string genero, DateTime fechaActualizacion, double auxilio)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.comuna = comuna;
            this.genero = genero;
            this.fechaActualizacion = fechaActualizacion;
            this.auxilio = auxilio;
        }
    }
}
