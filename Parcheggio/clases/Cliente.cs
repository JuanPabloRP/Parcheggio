using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio.clases
{
    public class Cliente
    {

        public static List<Cliente> cliente = new List<Cliente>();

        public int id { get; set; }
        public string tipo { get; set; }
        public string placa { get; set; }
        public string color { get; set; }

        public Cliente(int _id, string _tipo, string _placa, string _color)
        {
            id = _id;
            tipo = _tipo;
            placa = _placa;
            color = _color;
        }
    }
}
