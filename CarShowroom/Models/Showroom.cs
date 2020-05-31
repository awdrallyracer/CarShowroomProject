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
    public class Showroom : Car
    {
        public List<Client> Clients { private set; get; }
        public List<Car> Cars { private set; get; }
        public List<Order> Orders { private set; get; }
        private static Showroom showroom;

        // Перевірка зміни даних.
        public bool IsDirty;
        static public Showroom GetShowroom()
        {
            if (showroom == null)
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
        //Вибір приорітету (автопідбору)
        public List<Car> Priority(Client cl)
        {
            List<Car> res = new List<Car>();
            if (string.IsNullOrWhiteSpace(cl.Specs))
            {
                res = Cars.Where(o => o.Brand == cl.Brand && o.Price <= cl.Budget
                                     && o.Status == cl.Status).ToList();
            }
            else
            {
                res = Cars.Where(o => o.Brand == cl.Brand && o.Price <= cl.Budget
                                      && o.Specs == cl.Specs && o.Status == cl.Status).ToList();
            }
            return res;
        }

        //Додавання нового авто
        public void AddCar(Car car)
        {

            Cars.Add(car);
        }

        //Реєстрація нового клієнта
        public void AddClient(Client client)
        {
            Clients.Add(client);
        }
        //Збереження даних
        public void Save()
        {
            new DAO(this).Save();
        }
        //Завантаження данних з файлу
        public void Load()
        {
            new DAO(this).Load();
        }
    }
}
