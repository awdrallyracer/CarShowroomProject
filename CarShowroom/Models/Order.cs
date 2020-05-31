using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    [Serializable]
    public class Order
    {
       //Колекція придбаних авто
        public List<Car> Cars { private set; get; }
        //Колекція покупців
        public Client Client { private set; get; }
        //Дані
        public string ClientName { get => Client.login; }

    }
}
