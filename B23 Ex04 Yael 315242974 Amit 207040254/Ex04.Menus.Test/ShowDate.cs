using Ex04.Menues.Interfaces;

namespace Ex04.Menues.Test
{
    public class ShowDate : IOnSelect
    {
        public void ReportItemWasSelected()
        {
            DateTime todayDate = DateTime.Now;
            string formattedDate = todayDate.ToString("dd-MM-yyyy");
            Console.WriteLine($"The Date is: {formattedDate}");
        }
    }
}