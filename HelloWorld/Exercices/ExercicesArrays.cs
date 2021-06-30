using System;
using System.Collections.Generic;

namespace CSharpFundamentals.Exercices
{
    class ExercicesArrays
    {
        /*When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

        If no one likes your post, it doesn't display anything.
        If only one person likes your post, it displays: [Friend's Name] likes your post.
        If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

        Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
        Depending on the number of names provided, display a message based on the above pattern.*/
        public static void Exercice1()
        {
            var names = new List<string>();
            string result;
            int countNames;

            while (true)
            {
                string name;
                Console.Write("Put differents names (or put nothing to skip): ");
                name = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(name))
                {
                    names.Add(name);
                }
                else
                {
                    break;
                }
            }


            countNames = names.Count;
            if (countNames > 2)
            {
                result = String.Format("{0}, {1} and {2} others like your post", names[0], names[1], countNames);
            }
            else if (countNames == 2)
            {
                result = String.Format("{0}, {1} like your post", names[0], names[1]);
            }
            else if (countNames == 1)
            {
                result = String.Format("{0} likes your post", names[0]);
            }
            else
            {
                result = String.Format("No ones like your post");
            }

            Console.WriteLine(result);
        }

        /*Write a program and ask the user to enter their name. 
        Use an array to reverse the name and then store the result in a new string. 
        Display the reversed name on the console.*/
        public static void Exercice2()
        {
            string name;

            Console.Write("Put your name: ");
            name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }

        /*Write a program and ask the user to enter 5 numbers. 
        If a number has been previously entered, display an error message and ask the user to re-try. 
        Once the user successfully enters 5 unique numbers, sort them and display the result on the console.*/
        public static void Exercice3()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);

        }

        /*Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
        The list of numbers may include duplicates. Display the unique numbers that the user has entered.*/
        public static void Exercice4()
        {
            string input;
            int number;
            var numbers = new List<int>();

            while(true)
            {
                Console.Write("Put a number (or QUIT to exit):  ");
                input = Console.ReadLine();

                if (input == "QUIT" || input == "quit" || String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    number = Convert.ToInt32(input);
                    numbers.Add(number);
                }
            }

            var uniques = new List<int>();
            foreach (var n in numbers)
            {
                if (!uniques.Contains(n))
                {
                    uniques.Add(n);
                }
            }

            Console.WriteLine("Unique numbers: ");
            foreach (var u in uniques)
                Console.Write(u + " ");
        }

        /*Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
        If the list is empty or includes less than 5 numbers, display "Invalid List" 
        and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.*/
        public static void Exercice5()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }
}
