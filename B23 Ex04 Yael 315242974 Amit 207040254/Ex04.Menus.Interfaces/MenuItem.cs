using System;

namespace Ex04.Menues.Interfaces
{
    public class MenuItem
    {
        protected List<MenuItem> m_NextMenus;
        private readonly string r_Text;
        protected string m_ExitPoint = "Back";
        private IOnSelect m_OnSelect;

        public MenuItem (List<MenuItem> i_NextMenus, string i_Text,IOnSelect i_InSelected)
        {
            this.m_NextMenus = i_NextMenus;
            this.r_Text = i_Text;
            this.m_OnSelect = i_InSelected; 
        }

        public override string ToString()
        {
            return r_Text;
        }

        public void NextOption()
        {
            bool validInput = false, keepRunning = true;
            int itemNumber; 
           
            while (keepRunning)
            {
                Console.Clear();
                if (m_NextMenus != null)
                {
                    printNextMenu();
                    validInput = getUserInput(out itemNumber);

                    if (validInput)
                    {
                        if (itemNumber != 0)
                        {
                            m_NextMenus[itemNumber - 1].NextOption();
                        }
                        else
                        {
                            keepRunning = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input, try again");
                        Thread.Sleep(2000);
                    }
                }
                else
                {
                    m_OnSelect.ReportItemWasSelected();
                    Thread.Sleep(3000);
                    keepRunning = false;
                }
            }
        }

        private void printNextMenu()
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
            Console.WriteLine($"Enter your request: (1 to {m_NextMenus.Count} or press '0' to {m_ExitPoint}).");
         
            String item = Console.ReadLine();

            validInput =  int.TryParse(item, out i_itemNumber);

            return validInput && isValidInput(i_itemNumber);
        }

        private bool isValidInput(int i_Input){
            return i_Input >= 0 && i_Input <= m_NextMenus.Count;
        }
    }
}

