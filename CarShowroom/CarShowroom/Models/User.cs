using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    [Serializable]
    public abstract class User
    {
        public abstract string login { set; get; }
        public abstract string password { set; get; }
    }
}
