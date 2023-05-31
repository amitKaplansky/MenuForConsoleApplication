using System;

namespace Ex04.Menues.Interfaces
{
    public class MainMenu : MenuItem
    {
        //private List<MenuItem> m_MenuChain;

        public MainMenu(List<MenuItem> i_NextMenus, string i_Text,IInSelected i_InSelected):
            base(i_NextMenus, i_Text,i_InSelected)
        {
            m_ExitPoint = "Exit";
        }

        public void Show()
        {
            bool continueRun = true;
            while (continueRun)
            {
                InSelected();
            }
        }
    }
}