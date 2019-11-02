using System;
using System.Collections.Generic;

namespace SegundoParcial.Models
{
    public class Citi : ICity
    {
        public string Ciudad { get; set; }
        public string Temperatura { get; set; }
        public string Max { get; set; }
        public string Min { get; set; }

        public Citi()
        {

        }

        public Citi( string ciudad, string temp, string max, string min)
        //: this() //contructor manda a llamar al contructor base
        {
            Ciudad = ciudad;
            Temperatura = temp;
            Max = max;
            Min = min;
        }
    }
}
