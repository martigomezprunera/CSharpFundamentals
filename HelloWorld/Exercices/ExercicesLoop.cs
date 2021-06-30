using System;

namespace CSharpFundamentals.Exercices
{
    class ExercicesLoop
    {
        /*Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        Display the count on the console.*/
        public static void Exercice1()
        {
            int count = 0;
            string result;
            for(var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            result = string.Format("There is {0} that are divisible by 3 between 1 and 100", count);
            Console.WriteLine(result);
        }

        /*Write a program and continuously ask the user to enter a number or "ok" to exit. 
        Calculate the sum of all the previously entered numbers and display it on the console.*/
        public static void Exercice2()
        {
            int number;
            int numberResult = 0;
            string result;

            while(true)
            {
                Console.Write("Put a number or OK to exit: ");
                var input = Console.ReadLine();

                if(input == "OK" || input == "ok")
                {
                    break;
                }
                else
                {
                    number = Convert.ToInt32(input);
                    numberResult += number;
                }
            }

            result = string.Format("The result is: {0}", numberResult);
            Console.WriteLine(result);
        }

        /*Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
        For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.*/
        public static void Exercice3()
        {
            int number;
            int numberResult;
            string result;

            Console.Write("Put a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            numberResult = 1;

            for(var i = 1; i <= number; i++)
            {
                numberResult *= i;
            }

            result = string.Format("!{0} = {1}", number, numberResult);
            Console.WriteLine(result);
        }

        /* Write a program that picks a random number between 1 and 10. 
        Give the user 4 chances to guess the number. 
        If the user guesses the number, display “You won"; otherwise, display “You lost". 
        (To make sure the program is behaving correctly, you can display the secret number on the console first.)*/
        public static void Exercice4()
        {
            var rand = new Random();
            int randNumber = rand.Next(1, 10);
            string randomNumberChecked;
            int i = 0;
            int userNumber;

            randomNumberChecked = string.Format("The random number is: {0}", randNumber);
            Console.WriteLine(randomNumberChecked);

            while(i<4)
            {
                Console.Write("Guess a number: ");
                userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == randNumber)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else
                {
                    i++;
                }
            }

            if(i == 4)
            {
                Console.WriteLine("You lost");
            }
        }

        /*Write a program and ask the user to enter a series of numbers separated by comma. 
        Find the maximum of the numbers and display it on the console. 
        For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.*/
        public static void Exercice5()
        {
            Console.Write("Put numbers separated by commas: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Asumimos el primer numero como máximo
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);
        }

    }
}
