using System;

namespace Ex04.Menues.Interfaces
{
    public class MenuItem
    {
        protected List<MenuItem> m_NextMenus;
        private readonly string r_Text;
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

        public void InSelected()
        {
            if (m_NextMenus != null)
            {
                //print next menu
                PrinxNextMenu();
            }

            else
            {
                inSelected.ReportItemWasSelected();
            }

        }

        protected void PrinxNextMenu()
        {
            int i = 0;
          //need to think how to add back or exit button
            foreach (MenuItem menuItem in m_NextMenus)
            {
                ++i;
                Console.WriteLine($"{i}.{menuItem.ToString()}");
            }
        }

    }
}

