using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternApp.Model
{
    internal class IndianMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("1.Sadhya\n2.Chappathi\n" +
                "3.Biriyani\n4.Payasam\n5.Dosa\n" +
                "6.Idli\n7.Porotta\n8.Nadan Chicken Curry\n" +
                "9.Fish Masala");
        }
    }
}
