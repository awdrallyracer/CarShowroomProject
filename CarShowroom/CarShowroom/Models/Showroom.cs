using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarShowroom.Models
//Клас автосалон - це колекція: клієнтів + автомобілів + поставок
{
    [Serializable]
    public class Showroom
    {
        public List<Client> Clients { private set; get; }
        public List<Car> Cars { private set; get; }
        public List<Order> Orders { private set; get; }

        public Showroom()
        {
            Clients = new List<Client>();
            Cars = new List<Car>();
            Orders = new List<Order>();
        }

        public void Save()
        {
            new DAO(this).Save();
        }

        public void Load()
        {
            new DAO(this).Load();
        }
    }
}
