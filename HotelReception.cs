using FacadePatternApp.Model;

namespace FacadePatternApp
{
    public class HotelReception
    {
        public static void GetIndianMenu()
        {
            IHotel indHotel = new IndianHotel();
            IMenu menu = indHotel.GetMenu();
            menu.DisplayMenu();
        }
        public static void GetItalianMenu()
        {
            IHotel italianHotel = new ItalianHotel();
            IMenu menu = italianHotel.GetMenu();
            menu.DisplayMenu();
        }
        public static void GetChineseMenu()
        {
            IHotel chineseHotel = new ChineseHotel();
            IMenu menu = chineseHotel.GetMenu();
            menu.DisplayMenu();
        }
    }
}