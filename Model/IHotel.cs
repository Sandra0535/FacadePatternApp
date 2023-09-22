using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternApp.Model
{
    public interface IHotel
    {
        IMenu GetMenu();
    }
}
