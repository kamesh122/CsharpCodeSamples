using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeChallenges.Samples
{
   public class NewChaleenges
    {
        public static void CorrectSentense()
        {
            string sentence = "tac rac doog";

            // Array of valid words
            string[] validWords = { "Cat", "Car", "Dog", "Good" };

            string[] words = sentence.Split(' ');

            string[] correct = new string[words.Length];

            for (int i = 0; i <= words.Length - 1; i++)
            {
                var str = new string( words[i].ToLower().OrderBy(c => c).ToArray());

                foreach (var word in validWords)
                {
                    var validword = new string( word.ToLower().OrderBy(c => c).ToArray());
                    if (str == validword)
                    {
                        correct[i] = word;
                    }
                }
            }

            Console.WriteLine(string.Join(' ', correct));
        }

      public  static string[] SortDaysByCorrectOrder()
        {
            // Array with jumbled day names
            string[] daysArray = { "Tuesday", "Monday", "Sunday", "Friday", "Thursday", "Wednesday", "Saturday" };

            // Correct order of days
            string[] correctOrder = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            // Sort the given daysArray based on the correct order
            
            // Create a new array to store sorted days
            string[] sortedArray = new string[daysArray.Length];

            // Iterate through the daysArray and place each day in its correct position
            for (int i = 0; i < correctOrder.Length; i++)
            {
                foreach (var day in daysArray)
                {
                    if (day == correctOrder[i])
                    {
                        sortedArray[i] = day;
                        break;
                    }
                }
            }

            return sortedArray;
        }
    }
}
