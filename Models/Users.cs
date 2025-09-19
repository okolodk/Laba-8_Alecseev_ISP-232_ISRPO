using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_8_Alecseev_ISP_232_ISRPO.Models
{
    internal class Users
    {
        public string name { get; set; }
        public string email { get; set; }
        public bool isActive { get; set; }

        public Users(string name, string email, bool isActive)
        {
            this.name = name;
            this.email = email;
            this.isActive = isActive;
        }


        public void PrintInfo ()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Почта: {email}");
            Console.WriteLine($"Актив: {isActive}");
        }
    }
}
