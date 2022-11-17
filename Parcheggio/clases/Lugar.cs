﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio
{
    public class Lugar
    {
        public static List<Lugar> lugares = new List<Lugar>();
        public int id { get; set; }
        public string puesto { get; set; }
        public bool disponible { get; set; }


        public Lugar(int _id, string _puesto, bool _disponible)
        {
            id = _id;
            puesto = _puesto;
            disponible = _disponible;
        }
        
    }
}
