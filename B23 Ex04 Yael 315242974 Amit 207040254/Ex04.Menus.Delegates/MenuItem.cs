using System;

namespace Ex04.Menues.Delegates
{
    public delegate void ReportItemWasSelected();

    public class MenuItem
    {
        protected List<MenuItem> m_NextMenus;
        private readonly string r_Text;
        protected string m_ExitPoint = "Back";
        public event ReportItemWasSelected Selected;

        public MenuItem(List<MenuItem> i_NextMenus, string i_Text)
        {
            this.m_NextMenus = i_NextMenus;
            this.r_Text = i_Text;
        }
        public void AttachObserver(ReportItemWasSelected i_ObserverDelegate)
        {
            Selected += i_ObserverDelegate;
        }

        public void DetachObserver(ReportItemWasSelected i_ObserverDelegate)
        {
            Selected -= i_ObserverDelegate;
        }

        public override string ToString()
        {
            return r_Text;
        }

        protected virtual void OnSelect()
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
                            m_NextMenus[itemNumber - 1].OnSelect();
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
                    if (Selected != null)
                    {
                        Selected.Invoke();
                        Thread.Sleep(4000);
                        keepRunning = false;
                    }
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

            validInput = int.TryParse(item, out i_itemNumber);

            return validInput && isValidInput(i_itemNumber);
        }

        private bool isValidInput(int i_Input)
        {
            return i_Input >= 0 && i_Input <= m_NextMenus.Count;
        }


    }
}

