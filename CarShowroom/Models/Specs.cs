using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    [Serializable]
    public class Specs
    {
        public string Engine { get; set; }
        public string Color { get; set; }
        public string Gearbox { get; set; }
        public string Wheels { get; set; }

    }
}
