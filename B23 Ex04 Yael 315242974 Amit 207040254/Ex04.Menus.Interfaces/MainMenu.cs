using System;

namespace Ex04.Menues.Interfaces
{
    public class MainMenu : MenuItem
    {
        public MainMenu(List<MenuItem> i_NextMenus, string i_Text,IOnSelect i_InSelected):
            base(i_NextMenus, i_Text,i_InSelected)
        {
            m_ExitPoint = "Exit";
        }

        public void Show()
        {
           nextOption();
        }
    }
}