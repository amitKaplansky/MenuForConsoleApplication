using Interfaces = Ex04.Menues.Interfaces;
using Ex04.Menues.Test;
using Delegates = Ex04.Menues.Delegates;

namespace Ex04.Menus.Test
{
    public class Menus
    {

        public void RunMenus()
        {
            Interfaces.MainMenu inerfaceMenu = createInterfaceMenu();
            inerfaceMenu.Show();

            Delegates.MainMenu delegatesMenu = createDelegatesMenu();
            delegatesMenu.Show();
        }

        private Interfaces.MainMenu createInterfaceMenu()
        {
            List<Interfaces.MenuItem> firstMenu = new List<Interfaces.MenuItem>();
            List<Interfaces.MenuItem> subMenu1 = new List<Interfaces.MenuItem>();
            List<Interfaces.MenuItem> subMenu2 = new List<Interfaces.MenuItem>();

            Interfaces.MenuItem dateAndTime;
            Interfaces.MenuItem versionAndSpace;
            Interfaces.MenuItem showDateOption = new Interfaces.MenuItem(null, "show date", new ShowDate());
            Interfaces.MenuItem showTimeOption = new Interfaces.MenuItem(null, "show time", new ShowTime());
            Interfaces.MenuItem showVersion = new Interfaces.MenuItem(null, "show version", new ShowVersion());
            Interfaces.MenuItem countSpaces = new Interfaces.MenuItem(null, "show version", new CountSpaces());


            subMenu1.Add(showTimeOption);
            subMenu1.Add(showDateOption);
            subMenu2.Add(showVersion);
            subMenu2.Add(countSpaces);

            dateAndTime = new Interfaces.MenuItem(subMenu1, "Show Date/Time" , null);
            versionAndSpace = new Interfaces.MenuItem(subMenu2, "Version and Spaces", null);
            
            firstMenu.Add(dateAndTime);
            firstMenu.Add(versionAndSpace);
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu(firstMenu, "Show Date/Time", null);


            return mainMenu;
        }

        private Delegates.MainMenu createDelegatesMenu()
        {
            ShowDate showDate = new ShowDate();
            ShowTime showTime = new ShowTime();
            ShowVersion showVersion = new ShowVersion();
            CountSpaces countSpaces = new CountSpaces();

            List<Delegates.MenuItem> firstMenu = new List<Delegates.MenuItem>();
            List<Delegates.MenuItem> subMenu1 = new List<Delegates.MenuItem>();
            List<Delegates.MenuItem> subMenu2 = new List<Delegates.MenuItem>();

            Delegates.MenuItem dateAndTime;
            Delegates.MenuItem versionAndSpace;
            Delegates.MenuItem showDateOption = new Delegates.MenuItem(null, "show date");
            showDateOption.AttachObserver(showDate.ReportItemWasSelected);
            Delegates.MenuItem showTimeOption = new Delegates.MenuItem(null, "show time");
            showTimeOption.AttachObserver(showTime.ReportItemWasSelected);
            Delegates.MenuItem showVersionOption = new Delegates.MenuItem(null, "show version");
            showVersionOption.AttachObserver(showVersion.ReportItemWasSelected);
            Delegates.MenuItem countSpacesOption = new Delegates.MenuItem(null, "show version");
            countSpacesOption.AttachObserver(countSpaces.ReportItemWasSelected);


            subMenu1.Add(showTimeOption);
            subMenu1.Add(showDateOption);
            subMenu2.Add(showVersionOption);
            subMenu2.Add(countSpacesOption);

            dateAndTime = new Delegates.MenuItem(subMenu1, "Show Date/Time");
            versionAndSpace = new Delegates.MenuItem(subMenu2, "Version and Spaces");

            firstMenu.Add(dateAndTime);
            firstMenu.Add(versionAndSpace);
            Delegates.MainMenu mainMenu = new Delegates.MainMenu(firstMenu, "Show Date/Time");


            return mainMenu;
        }
    }
}