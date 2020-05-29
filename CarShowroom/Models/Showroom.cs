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
        private static Showroom showroom;

        // If any data changed.
        public bool IsDirty;
       static public Showroom GetShowroom()
        {
            if(showroom == null)
            {
                showroom = new Showroom();
            }
            return showroom;
        }
        protected Showroom()
        {
            Clients = new List<Client>();
            Cars = new List<Car>();
            Orders = new List<Order>();
        }
        public List<Car> Priority(Client cl)
        {
            List<Car> res = Cars.Where(o => o.Brand == cl.Brand && o.Price <= cl.Budget
                                       && o.Specs == cl.Specs && o.Status == cl.Status).ToList();
            return res;
        }
        public void AddCar(Car car)
        {
            
            Cars.Add(car);
        }

        public void AddClient(Client client)
        {
            Clients.Add(client);
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
