using System;
using System.Collections.Generic;
// using Chicken;

namespace Chicken
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word, and we shall tell you if its palindromes");
            string stringOne, rev;
            stringOne = Console.ReadLine();
            char[] chars = stringOne.ToCharArray();
            Array.Reverse(chars);
            rev = new string(chars);
            Console.WriteLine(chars);
            bool palin = stringOne.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if(palin == true)
            {
                 Console.WriteLine("" + stringOne + " is a Palindrome!");
            } else 
            {
                 Console.WriteLine("" + stringOne + " is not a palindrome");
            }
        }
    }
}


            //  char[] inputArray;
            //  _inputWord = Console.ReadLine();
            //  inputArray.Add(_inputWord);

            //  Array.Reverse(inputArray);

            //  Console.WriteLine(inputArray);

            // List<string> Words = new List<string>() { };

            
            // foreach(Word palindrome in Words)
            // {
            //     Words.Add(palindrome.inputWord);
            //     newWord = Array.Reverse(palindrome.Word);
            //     Console.WriteLine(palindrome.newWord);
            // 

            // Console.WriteLine(_inputWord);

            
            //    string _inputWord = Console.ReadLine();
            // _inputWord.Split(' ');

               // Words.ToCharArray(_inputWord);

                // string[] asStringArray = Array.ConvertAll(chars, char.ToString);
            // Console.WriteLine(asStringArray);
            // Console.WriteLine(chars);