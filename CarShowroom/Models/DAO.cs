using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    [Serializable]
    public class DAO
    {
        Showroom showroom;
        const string filePath = "showroom.bin";

        public DAO(Showroom showroom)
        {
            this.showroom = showroom;
        }

        public Showroom Showroom
        {
            get => default;
            set
            {
            }
        }

        //Збереження даних
        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, showroom);
            }
        }

        //Завантаження даних
        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                    var serializer = new BinaryFormatter();
                    Showroom st = (Showroom)serializer.Deserialize(stream);
                    Copy(st.Clients, showroom.Clients);
                    Copy(st.Cars, showroom.Cars);
                    Copy(st.Orders, showroom.Orders);
            }
            
            //Перенесення списку
            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}
