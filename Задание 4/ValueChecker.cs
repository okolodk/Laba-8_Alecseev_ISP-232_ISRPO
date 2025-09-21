using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_8_Alecseev_ISP_232_ISRPO.Задание_4
{
    internal class ValueChecker
    {
        public void CheckType(object input)
        {
            string type = input.GetType().Name;
            string c = "";
            if (input is ValueType) { c = "Значимый";}
            else {c = "Ссылочный";}

            Console.WriteLine($"{c} тип ({type})");
        }
    }
}
