using CSharpFundamentals.Math;
using CSharpFundamentals.Exercices;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CSharpFundamentals
{

    partial class Program
    {
        /*------------------------ Methods Human -----------------------*/
        /*public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Human human)
        {
            human.Age += 10;
        }*/

        /*------------------------ Enum -----------------------*/
        /*public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }*/

        static void Main(string[] args)
        {
            /*------------------------ Variables -----------------------*/
            /*byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = true;*/

            /*------------------------ Mostrar por pantalla las variables declaradas -----------------------*/
            /*Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);*/

            /*------------------------ Mostrar por pantalla con argumentos -----------------------*/
            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //{0} primer argumento, que va junto (en este caso) con byte.MinValue
            //{1} segundo argumento, que va junto (en este caso) con byte.MaxValue

            /*------------------------ Constantes -----------------------*/
            //const float Pi = 3.14f;

            /*------------------------ Implicit type conversion -----------------------*/
            /*byte b1 = 1;
            int i = b1;
            Console.WriteLine(i);*/

            /*------------------------ Explicit type conversion -----------------------*/
            /*int j = 1000;
            byte b2 = (byte)j;
            Console.WriteLine(b2);*/

            /*------------------------ Non-compatible types -----------------------*/
            /*string number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);*/

            /*------------------------ Operators -----------------------*/
            /*var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine((float)a / (float)b); //Division
            Console.WriteLine((a + b) * c); //Prioridad paréntesis.
            Console.WriteLine(a > b); //Devuelve true o false según lo especificado.
            Console.WriteLine(c > b && c > a);  //Logical operators (Devuelve true)
            Console.WriteLine(c > b && c == a);  //Logical operators (Devuelve false)
            Console.WriteLine(c > b || c == a);  //Logical operators (Devuelve true)*/

            /*------------------------ Object -----------------------*/
            /*Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();*/

            /*------------------------ Método público -----------------------*/
            /*Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);*/

            /*------------------------ Método estático -----------------------*/
            /*var result = Calculator.Add(1, 2);
            Console.WriteLine(result);*/

            /*------------------------ Arrays -----------------------*/
            /*var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new strings[3] {"Jack", "John", "Mary" };*/

            /*------------------------ Strings -----------------------*/
            /*var firstName = "Mosh";
            var lastName = "Hamedani";

            var fullname = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);

            var text = @"Hi John
                Look into the following paths
                c:\folder
                c:\folder3\folder4";

            Console.WriteLine(myFullName);
            Console.WriteLine(formattedNames);
            Console.WriteLine(text);*/

            /*------------------------ Enum -----------------------*/
            /*var method = ShippingMethod.Express;
            Console.WriteLine((int)method); //Casteamos a un numero entero

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); //Casteamos a la enumeración establecida

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); //hacemos un CAST al pricipio ya que el método PARSE devuelve un objeto 
            Console.WriteLine(shippingMethod);*/

            /*------------------------ Value types -----------------------*/
            /*var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b:{1}", a, b));*/

            /*------------------------ Reference types -----------------------*/
            /*var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));*/

            /*------------------------ Methods Human -----------------------*/
            /*------------------------ Value type -----------------------*/
            /*var number = 1;
            Increment(number);
            Console.WriteLine(number);*/

            /*------------------------ Reference type -----------------------*/
            /*var human = new Human() { Age = 20 };
            MakeOld(human);
            Console.WriteLine(human.Age);*/

            /*------------------------ Conditionals -----------------------*/
            /*int hour = 10;

            if(hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's agternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }*/

            /*------------------------ Abbreviation of else and if -----------------------*/
            /*bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }

            float price = (isGoldCustomer) ? 19.95f : 29.95f; //Esto es lo mismo que el bloque de condicionales de arriba
            Console.WriteLine(price);*/

            /*------------------------ Switch case -----------------------*/
            /*var season = Season.Autumn;

            switch(season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion");
                    break;
                case default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }*/ //Si estan los dos juntos se refiere a un OR (case Season.Autumn or case Season.Summer)

            /*------------------------ CONDITIONAL EXERCICES -----------------------*/
            /*------------------------ EXERCICE 1 -----------------------*/
            //ExercicesConditionals.Exercice1();
            /*------------------------ EXERCICE 2 -----------------------*/
            //ExercicesConditionals.Exercice2();
            /*------------------------ EXERCICE 3 -----------------------*/
            //ExercicesConditionals.Exercice3();
            /*------------------------ EXERCICE 4 -----------------------*/
            //ExercicesConditionals.Exercice4();

            /*------------------------ For loop -----------------------*/
            /*for(var i = 1; i <= 10; i++)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i);
            }

            for(var i = 10; i >= 10; i--)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i);
            }*/

            /*------------------------ For each loop -----------------------*/
            /*var name = "John Smith";
            for(var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            foreach(var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 1, 2, 3, 4};
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }*/
            //Los dos bloques son lo mismo, queda más limpio el segundo.

            /*------------------------ While loop -----------------------*/
            /*int i = 0;
            while(i <= 10)
            {
                if(i % 2 ==0)
                    Console.WriteLine(i);

                i++
            }*/

            /*while(true) //Se ejecuta todo el tiempo
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;   //Vuelve al principio del loop sin pasar por el break
                }
                break;
            }*/

            /*------------------------ Random (random String)-----------------------*/
            /*var random = new Random();
            const int passwordLength = 10;

            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);*/

            /*------------------------ LOOP EXERCICES -----------------------*/
            /*------------------------ EXERCICE 1 -----------------------*/
            //ExercicesLoop.Exercice1();
            /*------------------------ EXERCICE 2 -----------------------*/
            //ExercicesLoop.Exercice2();
            /*------------------------ EXERCICE 3 -----------------------*/
            //ExercicesLoop.Exercice3();
            /*------------------------ EXERCICE 4 -----------------------*/
            //ExercicesLoop.Exercice4();
            /*------------------------ EXERCICE 5 -----------------------*/
            //ExercicesLoop.Exercice5();

            /*------------------------ Arrays -----------------------*/
            /*var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Lenght : " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //Clear
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach(var n in numbers)
                Console.WriteLine(n);

            //Copy()
            Console.WriteLine("Effect of Copy()");
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach(var n in another)
                Console.WriteLine(n);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach(var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);*/

            /*------------------------ Lists -----------------------*/
            /*var numbers = new List<int>() { 1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach(var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);

            for(var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var number in numbers)
                Console.WriteLine(number);

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);*/

            /*------------------------ ARRAY/LIST EXERCICES -----------------------*/
            /*------------------------ EXERCICE 1 -----------------------*/
            //ExercicesArrays.Exercice1();
            /*------------------------ EXERCICE 2 -----------------------*/
            //ExercicesArrays.Exercice2();
            /*------------------------ EXERCICE 3 -----------------------*/
            //ExercicesArrays.Exercice3();
            /*------------------------ EXERCICE 4 -----------------------*/
            //ExercicesArrays.Exercice4();
            /*------------------------ EXERCICE 5  -----------------------*/
            //ExercicesArrays.Exercice5();

            /*------------------------ Datetime -----------------------*/
            /*var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));*/

            /*------------------------ TimeSpan -----------------------*/
            //Creating
            /*var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes) ;
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes) ;

            //Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));

            //Substract
            Console.WriteLine("Substract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString" + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));*/

            /*------------------------ String Methods -----------------------*/
            /*var fullName = "Martí Gómez ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());  //Borra los últimos espacios
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Martí", "Martolomeu"));

            if(String.IsNullOrEmpty(" ".Trim()))    //NO es invalida ya que si hay algo en la cadena, si añadimos TRIM si es inválida
                Console.WriteLine("Invalid");

            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));*/

            /*------------------------ Debugging Texts -----------------------*/
            /*var sentence = "This is going to be a really really really really really long text.";
            var summary  = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);*/

            /*------------------------ String Builder -----------------------*/
            //String builder no tiene métotos de búsqueda
            /*var builder = new StringBuilder("Hello World");

            builder                         //No hace falta repetir builder delante de todos los métodos si van seguidos
                    .Append('-', 10)
                    .AppendLine()
                    .Append("Header")
                    .AppendLine()
                    .Append('-', 10)
                    .Replace('-', '+')
                    .Remove(0, 10)
                    .Insert(0, new string('-', 10));
            
            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);*/

            /*------------------------ WORKING WITH TEXT -----------------------*/
            /*------------------------ EXERCICE 1 -----------------------*/
            //ExercicesWorkingWithText.Exercice1();

            /*------------------------ File and FileInfo -----------------------*/
            //El arroba se utiliza para no poner el doble contrabarra
            /*var path = @"c:\somefile";
            File.Copy(@"c:\temp\myfile.jpg", @"c:\temp\myfile.jpg", true);
            File.Delete(path);
            if(File.Exists(path))
            {
                //Do Something
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if(fileInfo.Exists)
            {
                //Do Something
            }*/

            /*------------------------ Directory and DirectoryInfo -----------------------*/
            /*Directory.CreateDirectory("@c:\temp\folder1");

            //Busca todos los archivos (3 variable de la función) con el patron especificado (2 variable de la función)
            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentasl", "*.sln*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            //Busca todos los directorios (3 variable de la función) con el patron especificado (2 variable de la función)
            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentasl", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();*/

            /*------------------------ Path -----------------------*/
            /*var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));*/

            /*------------------------ WORKING WITH FILES -----------------------*/
            /*------------------------ EXERCICE 1 -----------------------*/
            /*ExercicesFiles.Exercice1();
            ExercicesFiles.Exercice2();*/
        }
    }
}
