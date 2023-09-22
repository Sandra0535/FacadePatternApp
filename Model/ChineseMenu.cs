using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternApp.Model
{
    internal class ChineseMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("1.Kung Pao Chicken\n2.Sweet and Sour Pork\n" +
                "3.Peking Roast Duck\n4.Mapo Tofu\n5.Chow Mein\n" +
                "6.Chinese Hot Pot\n7.Spring Rolls\n8.Wonton Soup");
        }
    }
}
