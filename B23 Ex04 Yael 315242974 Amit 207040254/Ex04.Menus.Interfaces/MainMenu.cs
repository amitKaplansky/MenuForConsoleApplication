using System;

namespace Ex04.Menues.Interfaces
{
    public class MainMenu : MenuItem
    {
        //private List<MenuItem> m_MenuChain;

        public MainMenu(List<MenuItem> i_NextMenus, string i_Text,IInSelected i_InSelected):
            base(i_NextMenus, i_Text,i_InSelected)
        {   
            //m_MenuChain = i_FirstMenue;
        }

        public void Show()
        {
            //Present the main menue --> The first menu the app want to show
            PrinxNextMenu();

            //Ask from the user to select item
            Console.WriteLine("Please Enter your choice: ");
            String item = Console.ReadLine();
            int itemNumber;
            int.TryParse(item, out itemNumber);
            //alid input --> todo improve -->TODO add a loop 
            if (itemNumber != 0 && itemNumber >=1 && itemNumber <= m_NextMenus.Count) {
                Console.WriteLine("Succsed to get Your input");//todo think on the message
                m_NextMenus[itemNumber - 1].InSelected();
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
        }
    }
}