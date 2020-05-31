using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
    //Клас автомобіль - це опис особливойстей виконання + тех. стан + марка + рік випуску
{
    [Serializable]
    public class Car
    {
        //Опис особливостей виконання
        public string Description { set; get; }
        //Технічний стан авто
        public string Status { set; get; }
        //Марка авто
        public string Brand { set; get; }
        //Рік випуску авто
        public string Year { set; get; }
        //Технічні характеристики авто
        public string Specs { get; set; }
        //Запитувана ціна авто
        public decimal Price { get; set; }
        //Зображення авто
        public Image Image { get; set; }
    }
}
