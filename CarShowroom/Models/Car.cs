using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
    //Клас автомобіль - це коллекція характеристик + опис особливойстей виконання + тех. стан + марка + рік випуску
{
    [Serializable]
    public class Car
    {
        public string Description { set; get; }
        public string Status { set; get; }
        public string Brand { set; get; }
        public string Year { set; get; }
        public string Specs { get; set; }
        public decimal Price { get; set; }
        public Image Image { get; set; }
    }
}
