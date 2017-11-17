using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }

        public Menu()
        {
            MenuItems = new List<MenuItem>();
        }

        public DateTime LastUpdated()
        {
            return MenuItems.OrderByDescending(MenuItems => MenuItems.DateAdded).FirstOrDefault().DateAdded;
        }
    }
}
