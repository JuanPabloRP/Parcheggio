using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio
{
    public class Cliente
    {

        public static List<Cliente> clientes = new List<Cliente>();

        public int id { get; set; }
        public string tipo { get; set; }
        public string puesto { get; set; }
        public string placa { get; set; }
        public string color { get; set; }
        public double valorAPagar { get; set; }

        public DateTime fechaEntrada { get; set; }
        public DateTime fechaSalida { get; set; }
        

        public Cliente(int _id, string _tipo, string _puesto,string _placa, string _color, DateTime _fechaEntrada)
        {
            id = _id;
            tipo = _tipo;
            puesto = _puesto;
            placa = _placa;
            color = _color;
            fechaEntrada = _fechaEntrada;
        }

        public Cliente()
        {
            
        }

        public double CalcularTotalAPagar(DateTime fechaSalida)
        {
            
            this.fechaSalida = fechaSalida;

            var horas = (this.fechaSalida - this.fechaEntrada).TotalHours;

            this.valorAPagar = horas * 2000;

            return Math.Truncate(this.valorAPagar * 10)/10;
        }
     
    }
}
