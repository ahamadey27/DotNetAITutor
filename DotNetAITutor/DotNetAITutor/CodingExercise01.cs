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
    }
}
