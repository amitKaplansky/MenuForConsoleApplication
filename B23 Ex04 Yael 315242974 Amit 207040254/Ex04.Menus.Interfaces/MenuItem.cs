using System;

namespace Ex04.Menues.Interfaces
{
    public class MenuItem
    {
        protected List<MenuItem> m_NextMenus;
        private readonly string r_Text;
        protected string m_ExitPoint = "Back";
        private IInSelected inSelected;
        public MenuItem (List<MenuItem> i_NextMenus, string i_Text,IInSelected i_InSelected)
        {
            this.m_NextMenus = i_NextMenus;
            this.r_Text = i_Text;
            this.inSelected = i_InSelected; 
        }

        public override string ToString()
        {
            return r_Text;
        }

        public bool InSelected()
        {
            bool validInput = false;
            int itemNumber; 
            while (!validInput)
            {
                Console.Clear();
                if (m_NextMenus != null)
                {

                    //print next menu
                    PrinxNextMenu();

                    //Ask from the user to select item
                    validInput = getUserInput(out itemNumber);

                    if (validInput)
                    {
                        if (itemNumber != 0)
                        {
                            m_NextMenus[itemNumber - 1].InSelected();
                        }
                        else
                        {
                            validInput =  false;
                            break;
                        }
                    }


                    else
                    {
                        Console.WriteLine("incorrect input");
                    }

                }

                else
                {
                    inSelected.ReportItemWasSelected();
                    validInput = false;
                    break;
                }

                
            }
            return validInput;

        }

        private void PrinxNextMenu()
        {
            int i = 0;

            Console.WriteLine($"**{r_Text}**");
            Console.WriteLine("--------------------------");

            foreach (MenuItem menuItem in m_NextMenus)
            {
                ++i;
                Console.WriteLine($"{i} -> {menuItem.ToString()}");
            }
            Console.WriteLine($"0 -> {m_ExitPoint}");

        }

        private bool getUserInput(out int i_itemNumber)
        {
            bool validInput = false;

            Console.WriteLine("--------------------------");
            Console.WriteLine($"Enter your request: (1 to {m_NextMenus.Count} or press '0' to {m_ExitPoint})");
         
            String item = Console.ReadLine();

            validInput =  int.TryParse(item, out i_itemNumber);

            return validInput && isValidInput(i_itemNumber);
        }

        //todo think about more cheks..
        private bool isValidInput(int i_Input){
            return i_Input >= 0 && i_Input <= m_NextMenus.Count;
        }


    }
}

