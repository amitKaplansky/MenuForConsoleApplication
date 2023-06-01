using Ex04.Menues.Interfaces;

namespace Ex04.Menues.Test
{
    public class ShowTime : IOnSelect
    {
        public void ReportItemWasSelected()
        {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss");
            Console.WriteLine($"The Hour is: {formattedTime}");
        }
    }
}