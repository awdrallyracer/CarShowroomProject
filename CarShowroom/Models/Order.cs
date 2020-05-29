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
        public Order(List<Car> car, Client client)
        {
            Cars = car;
            Client = client;
            DateTime = DateTime.Now;
        }
        public Order()
        {
            Cars = new List<Car>();
        }
        public List<Car> Cars { private set; get; }
        public Client Client { private set; get; }
        public string ClientName { get => Client.login; }
        public DateTime DateTime { private set; get; }
    }
}
