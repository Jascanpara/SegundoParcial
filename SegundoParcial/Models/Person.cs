using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Models
{
    public class Person
    {
        public string Name;
        public PassInfo passInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.passInfo = new PassInfo(passInfo.Pass);
            clone.Name = string.Copy(Name);
            return clone;
        }

        public Person Clone()
        {
            return new Person { Name = Name, passInfo = new PassInfo(passInfo.Pass) };
        }
    }
}
