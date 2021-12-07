using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIClassLibrary
{
    public class Patient : Person
    {
        public string Status { get; set; }
        public List<Prescription> Prescriptions { get; set; }
    }
}
