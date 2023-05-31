using Ex04.Menues.Interfaces;
using Ex04.Menues.Test;

namespace Ex04.Menus.Test
{
    public class Menus
    {

        public void RunMenus()
        {
            MainMenu inerfaceMenu = createInterfaceMenu();
            inerfaceMenu.Show();
        }

        private MainMenu createInterfaceMenu()
        {
            List<MenuItem> firstMenu = new List<MenuItem>();
            List<MenuItem> subMenu1 = new List<MenuItem>();
            List<MenuItem> subMenu2 = new List<MenuItem>();

            MenuItem dateAndTime;
            MenuItem versionAndSpace;
            MenuItem showDateOption = new MenuItem(null, "show date", new ShowDate());
            MenuItem showTimeOption = new MenuItem(null, "show time", new ShowTime());
            MenuItem showVersion = new MenuItem(null, "show version", new ShowVersion());
            MenuItem countSpaces = new MenuItem(null, "show version", new CountSpaces());


            subMenu1.Add(showTimeOption);
            subMenu1.Add(showDateOption);
            subMenu2.Add(showVersion);
            subMenu2.Add(countSpaces);

            dateAndTime = new MenuItem(subMenu1, "Show Date/Time" , null);
            versionAndSpace = new MenuItem(subMenu2, "Version and Spaces", null);
            
            firstMenu.Add(dateAndTime);
            firstMenu.Add(versionAndSpace);
            MainMenu mainMenu = new MainMenu(firstMenu, "Show Date/Time", null);


            return mainMenu;
        }
    }
}