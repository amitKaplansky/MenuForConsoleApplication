using Ex04.Menues.Interfaces;

namespace Ex04.Menues.Test
{
    public class CountSpaces : IOnSelect
    {
        public void ReportItemWasSelected()
        {
            Console.WriteLine("Please enter your sentence");
            string sentence = Console.ReadLine();

            int spaceCount = countSpaces(sentence);
            Console.WriteLine($"There are {spaceCount} spaces in your sentence.");
        }

        static int countSpaces(string sentence)
        {
            int count = 0;

            foreach (char c in sentence)
            {
                if (c == ' ')
                    count++;
            }

            return count;
        }
    }
}