using Ex04.Menues.Delegates;
using System;

namespace Ex04.Menues.Delegates
{
    public class MainMenu : MenuItem
    {
        public MainMenu(List<MenuItem> i_NextMenus, string i_Text) :
            base(i_NextMenus, i_Text)
        {
            m_ExitPoint = "Exit";
        }

        public void Show()
        {

            nextOption();

        }
    }
}