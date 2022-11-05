using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio.clases
{
    public class Cliente
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public string placa { get; set; }
        public string color { get; set; }
        public double totalAPagar { get; set; }

        public Cliente(int _id)
        {
            id = _id;
            tipo = null;
            placa = null;
            color = null;
            totalAPagar = 0;
        }



    }
}
