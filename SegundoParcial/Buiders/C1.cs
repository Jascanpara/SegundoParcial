using System;
using System.Collections.Generic;
using SegundoParcial.Models;

namespace SegundoParcial.Buiders
{
    public class C1 : CBuilder
    {
        public C1()
        {
            _Ciudad = new Citi
            {
                Ciudad = "Rome",
                Temperatura = "17",
                Max = "23",
                Min="15",
            };
        }
        public override void PasoNombre()
        {
            _Ciudad.Ciudad = "Rome";
        }

        public override void PasoTemperatura()
        {
            _Ciudad.Temperatura = "17";
        }

        public override void PasoMax()
        {
            _Ciudad.Max = "23";
        }
        public override void PasoMin()
        {
            _Ciudad.Min = "15";
        }
    }
}
