using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
    //Клас порція - це автомобіль + його кількість
{
    [Serializable]
    public class Portion
    {
        public Car car { set; get; }
        public int amount { set; get; }
    }
}
