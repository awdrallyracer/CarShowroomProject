using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
    //Клас автомобіль - це коллекція характеристик + опис особливойстей виконання + тех. стан + марка + рік випуску
{
    [Serializable]
    public class Car
    {
        public int Id { set; get; }
        public string Description { set; get; }
        public string Status { set; get; }
        public string Brand { set; get; }
        public int Year { set; get; }
        public Specs Specs { get; set; }
    }
}
