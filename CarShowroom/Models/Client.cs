using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
//Клас клієнт - це вимоги: до марки + до тех. характеристик + до тех стану + фінансові можливості
{
    [Serializable]
    public class Client : User
    {
        //Вимоги до марки
        public string Brand { set; get; }
        //Вимоги до тех. характеристик
        public string Specs { set; get; }
        //Вимоги до тех. стану
        public string Status { set; get; }
        //Вимоги до запитуваної ціни
        public int Budget { set; get; }
        public override string login { get; set; }
        public override string password { get; set; }
        public string email { set; get; }

        //Колекція запитуваних авто
        public List<Car> Cars { private set; get; } = new List<Car>();
    }
}
