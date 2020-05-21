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
        public Order(List<Portion> portions, Client client)
        {
            Portions = portions;
            Client = client;
            DateTime = DateTime.Now;
        }

        public List<Portion> Portions { private set; get; }
        public Client Client { private set; get; }
        public DateTime DateTime { private set; get; }
    }
}
