using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ListaEstudiante
    {
        public string tipoIdentificacion { get; set; }
        public int identificacion { set; get; }
        public string nombre { set; get; }
        public int edad { set; get; }
        public int estrato { set; get; }
        public DateTime fechaRegistro { set; get; }
        public string voto { set; get; }

        public ListaEstudiante()
        {
        }

        public ListaEstudiante(string tipoIdentificacion, int identificacion, string nombre, int edad, int estrato, DateTime fechaRegistro, string voto)
        {
            this.tipoIdentificacion = tipoIdentificacion;
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.edad = edad;
            this.estrato = estrato;
            this.fechaRegistro = fechaRegistro;
            this.voto = voto;
        }
    }
}
