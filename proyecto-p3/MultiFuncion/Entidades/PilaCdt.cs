using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PilaCdt
    {
        public int numeroCdt {get; set;}
        public int numIdentificacion { get; set;}
        public string mesApertura {get; set;}
        public string nombre { get; set;}
        public string direccion { get; set;}
        public int estrato { get; set;}
        public string categoria { get; set;}
        public int tiempoCdt { get; set;}
        public double valorCdt { get; set;}
        public double totalPagar { get; set;}
        public DateTime fechaDePago { get; set;}

        public PilaCdt()
        {
        }

        public PilaCdt(int numeroCdt, int numIdentificacion, string mesApertura, string nombre, string direccion, int estrato, string categoria, int tiempoCdt, double valorCdt, double totalPagar, DateTime fechaDePago)
        {
            this.numeroCdt = numeroCdt;
            this.numIdentificacion = numIdentificacion;
            this.mesApertura = mesApertura;
            this.nombre = nombre;
            this.direccion = direccion;
            this.estrato = estrato;
            this.categoria = categoria;
            this.tiempoCdt = tiempoCdt;
            this.valorCdt = valorCdt;
            this.totalPagar = totalPagar;
            this.fechaDePago = fechaDePago;
        }
    }
}
