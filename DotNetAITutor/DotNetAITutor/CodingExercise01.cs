﻿using System.Collections;

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

        //Reverse a string
        public static void ReverseString(string input)
        {
            string newString = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                newString += input[i];
            }

            Console.WriteLine(newString);
        }

        //Max number in an array
        public static void MaxNumber(int[] numArray)
        {
            int largest = numArray[0];
            for (int index = 0; index < numArray.Length; index++)
            {
                if (numArray[index] > largest)
                {
                    largest = numArray[index];
                }
            }

            Console.WriteLine(largest);
        }


        //Sum of even numbers in an array
        public static int SumOfEvenNumbers(int[] numArray)
        {
            int sum = 0;
            foreach (int num in numArray)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }


        //Count number of words in a sentence 
        public static int CountWords(string sentence)
        {
            //Checks for null, empty or whitespace-only string
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return 0;
            }

            //Slits sentence into words, using spaces and separators 
            //RemoveEmptyEntires ensures we ignore multiple spaces
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }

            return true;

        }

        public static decimal AverageOfArray(int[] numArray)
        {
            decimal arraySum = 0;

            foreach (var item in numArray)
            {
                arraySum += item;
            }

            decimal arrayAverage = (decimal)arraySum / numArray.Length;
            return arrayAverage;
        }


    }


}
