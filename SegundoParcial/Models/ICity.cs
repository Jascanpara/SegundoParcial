using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Models
{
    public interface ICity
    {
        string Ciudad { get; set; }
        string Temperatura { get; set; }
        string Max { get; set; }
        string Min { get; set; }
    }
}
