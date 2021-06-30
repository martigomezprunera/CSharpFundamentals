using System;

namespace CSharpFundamentals.Exercices
{
    public class ExercicesConditionals
    {
        /*Write a program and ask the user to enter a number. 
           The number should be between 1 to 10. If the user enters a valid number,
           display "Valid" on the console. Otherwise, display "Invalid". 
           (This logic is used a lot in applications where values entered into input boxes need to be validated.)*/
        public static void Exercice1()
        {
            int number;

            Console.WriteLine("Hello, put a number between 1 and 10: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
        
        /*Write a program which takes two numbers from the console and displays the maximum of the two.*/
        public static void Exercice2()
        {
            int number1;
            int number2;
            string result;

            Console.Write("Number1: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number2: ");
            number2 = Convert.ToInt32(Console.ReadLine());


            if (number1 > number2)
                result = string.Format("Number1: {0} is bigger than Number2: {1}", number1, number2);
            else
                result = string.Format("Number1: {0} is smaller than Number2: {1}", number1, number2);

            Console.WriteLine(result);
        }

        /*Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.*/
        public static void Exercice3()
        {
            int height;
            int widht;

            Console.WriteLine("Put the width of your image: ");
            widht = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Put the height of your image: ");
            height = Convert.ToInt32(Console.ReadLine());

            if(height > widht)
                Console.WriteLine("Portrait");
            else
                Console.WriteLine("LandScape");
        }

        /*Your job is to write a program for a speed camera. 
        For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
        Write a program that asks the user to enter the speed limit. 
        Once set, the program asks for the speed of a car. 
        If the user enters a value less than the speed limit, program should display Ok on the console. 
        If the value is above the speed limit, the program should calculate the number of demerit points. 
        For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
        If the number of demerit points is above 12, the program should display License Suspended.*/
        public static void Exercice4()
        {
            int speedCamera;
            int speedCar;
            string result;

            Console.Write("Put the speed of the camera: ");
            speedCamera = Convert.ToInt32(Console.ReadLine());

            Console.Write("Put the speed of the car: ");
            speedCar = Convert.ToInt32(Console.ReadLine());

            if(speedCar <= speedCamera)
                Console.WriteLine("OK");
            else
            {
                const int superPass = 5;
                int demerit = (speedCar - speedCamera) / superPass;

                if (demerit < 12)
                {
                    result = string.Format("You lose: {0} points", demerit);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("License Suspended");
                }
            }


        }
    }
}
