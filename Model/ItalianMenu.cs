using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternApp.Model
{
    internal class ItalianMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("1.Lasagne alla Bolognese\n2.Fettuccine al Pomodoro" +
                "\n3.Gnocchi di Patate\n4.Melanzane alla Parmigiana\n" +
                "5.Pollo alla Cacciatora\n6.Pizza Margherita\n" +
                "7.Costoletta alla Milanese\n8.Vitello Tonnato.");
        }
    }
}
