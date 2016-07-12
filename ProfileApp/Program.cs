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

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    count++;
                }
            }
            
            return count;            

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Type a word:");
            string sentence = Console.ReadLine().ToLower();

            int count = VCount(sentence);

            Console.WriteLine("The vowel count of your sentence is: {0}", count);
            Console.ReadLine();
        }
    }
}
