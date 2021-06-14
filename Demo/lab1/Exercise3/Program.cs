using System;

namespace Exercise3
{
    class Program
    {
        public static string ReverseString(string userInput)
        {
            char[] userInputArray = userInput.ToCharArray();
            int length = userInputArray.Length;
            int left = 0, right = length - 1;
            while (left < right)
            {
                char temp = userInputArray[left];
                userInputArray[left++] = userInputArray[right];
                userInputArray[right--] = temp;
            }
            return new string(userInputArray);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.Write("Enter the string to reverse: ");
            string userInput = Console.ReadLine();
            string res = ReverseString(userInput);
            Console.WriteLine($"The reversed string: {res}");
        }
    }
}
