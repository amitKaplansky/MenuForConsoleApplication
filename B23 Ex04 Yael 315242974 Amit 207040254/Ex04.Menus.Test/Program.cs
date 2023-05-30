using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menues.Interfaces;
using Ex04.Menues.Test;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {

            List<MenuItem> firstMenu = new List<MenuItem>();
            List<MenuItem> subMenu = new List<MenuItem>();
            MenuItem showDateOption = new MenuItem(null, "show date", new ShowDate());
            MenuItem stam1 = new MenuItem(null, "stam1", new ShowDate());
            MenuItem stam2 = new MenuItem(null, "stam2", new ShowDate());
            subMenu.Add(stam1 );    
            subMenu.Add(stam2);
            MenuItem showTimeOption = new MenuItem(subMenu,"show time",new ShowTime());
            firstMenu.Add(showTimeOption);
            firstMenu.Add(showDateOption);


            MainMenu mainMenu = new MainMenu(firstMenu, "Show Date/Time",null);

            Menus.RunMenus(mainMenu);
        }

    }
}

