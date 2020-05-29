using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
    //Клас поставка - це колекція порцій + дата
{
    [Serializable]
    public class Supply
    {
        public Supply(List<Portion> portion)
        {
            portions = portion;
            datetime = DateTime.Now;
        }

        public List<Portion> portions { private get; set; }
        public DateTime datetime { private get; set; }
    }
}
