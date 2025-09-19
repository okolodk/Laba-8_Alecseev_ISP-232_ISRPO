using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba_8_Alecseev_ISP_232_ISRPO.Models;

namespace Laba_8_Alecseev_ISP_232_ISRPO.Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Users me = new Users("grisha", "grisha.zhivot@bk.ru", true);
            me.PrintInfo();
        }
    }
}
