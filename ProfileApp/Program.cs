using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileApp
{
    class Program
    {

        static int VCount(string sentence)
        {
            int count = 0;

            // Vowels list
            var vowels = new List<char>
                { 'a', 'e', 'i', 'o', 'u', 'y' };

            //index counter for sentence length
            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    count++;
                }
            }

            //get number of characters
            return count;
        }

        //prompt for sentence and reads
        static string ReadSentence()
        {
            Console.WriteLine("Type a sentence:");
            return Console.ReadLine().ToLower();
        }
        
        //writes message and gives vowel count
        static void Write(int count)
        {
            Console.WriteLine("The vowel count of your sentence is: {0}", count);
            Console.WriteLine();
        }

        //display sentence, checks for "exit" ; if exit display quit message
        static void Main(string[] args)
        {
            string sentence;

            while ((sentence = ReadSentence()) != "exit")
            {
                int count = VCount(sentence);

                Write(count);
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to quit");
            Console.ReadLine();
        }
    }
}
