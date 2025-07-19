namespace DotNetAITutor
{
    public class CodingExercise01
    {
        //simple C# method that takes a list of integers and returns only the even numbers from that list.
        public static List<int> EvenNumbers(List<int> numbers)
        {
            return numbers.Where(num => num % 2 == 0).ToList();
        }
    }
}
