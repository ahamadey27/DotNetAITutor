using System.Collections;

namespace DotNetAITutor
{
    public class CodingExercise01
    {
        //simple C# method that takes a list of integers and returns only the even numbers from that list.
        public static List<int> EvenNumbers(List<int> numbers)
        {
            return numbers.Where(num => num % 2 == 0).ToList();
        }

        public static void FizzBuzz(int calcAmount)
        {
            bool fizz = false;
            bool buzz = false;

            for (int i = 1; i <= calcAmount; i++)
            {
                fizz = i % 3 == 0;
                buzz = i % 5 == 0;

                Console.WriteLine((fizz && buzz) ? "FizzBuzz" : fizz ? "Fizz" : buzz ? "Buzz" : i.ToString());
            }
        }

        public static char FirstNonRepeatingChar(string input)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            //first pass. count each char
            foreach (char c in input)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts[c] = 1;
                }
            }

            foreach (char c in input)
            {
                if (counts[c] == 1)
                {
                    return c;
                }
            }

            return '\0';
        }

        public static int CountVowel(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int count = 0;
            string vowel = "aeiou";

            foreach (char c in input)
            {
                if (vowel.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }

        //Remove duplicates from an array
        public static void RemoveDuplicates(int[] sArray)
        {
            var sList = new ArrayList();
            for (int i = 0; i < sArray.Length; i++)
            {
                if (sList.Contains(sArray[i]) == false)
                {
                    sList.Add(sArray[i]);
                }
            }

            var sNew = sList.ToArray();

            for (int i = 0; i < sNew.Length; i++)
            {
                Console.WriteLine(sNew[i]);
            }
        }

        //Removes duplicates in an array using hashset (unordered collection of unique elements)

        public static string[] RemoveDupsHashset(string[] s)
        {
            return new HashSet<string>(s).ToArray();
        }

    }


}
