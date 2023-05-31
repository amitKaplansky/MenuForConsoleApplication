using Ex04.Menues.Interfaces;

namespace Ex04.Menues.Test
{
    public class ShowVersion : IInSelected
    {
        public void ReportItemWasSelected()
        {
            Console.WriteLine("Version:23.2.4.9805");
        }
    }
}