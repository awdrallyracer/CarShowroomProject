using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
    //Клас адміністратор - це логін + пароль
{
    [Serializable]
    class Admin : User
    {
        public override string login { get; set; } = "admin";
        public override string password { get; set; } = "admin";
    }
}
