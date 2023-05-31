using Ex04.Menues.Interfaces;

namespace Ex04.Menues.Test
{
    public class CountSpaces : IInSelected
    {
        public void ReportItemWasSelected()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            int spaceCount = countSpaces(sentence);
            Console.WriteLine("Number of spaces in the sentence: " + spaceCount);
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