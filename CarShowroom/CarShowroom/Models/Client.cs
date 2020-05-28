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
        public string Brand { set; get; }
        public string Specs { set; get; }
        public string Status { set; get; }
        public int Budget { set; get; }
        public override string login { get; set; }
        public override string password { get; set; }
        public string email { set; get; }

        public List<Car> Cars { private set; get; } = new List<Car>();
    }
}
