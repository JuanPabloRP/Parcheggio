using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio.clases
{
    public class Lugar
    {
        public int id { get; set; }
        public string puesto { get; set; }
        public bool disponible { get; set; }


        public Lugar(int _id)
        {
            id = _id;
            puesto = null;
            disponible = true;
        }

    }
}
