using Ex04.Menues.Interfaces;

namespace Ex04.Menues.Test
{
    public class ShowDate : IInSelected
    {
        public void ReportItemWasSelected()
        {
            DateTime todayDate = DateTime.Now;
            Console.WriteLine(todayDate);
        }
    }
}