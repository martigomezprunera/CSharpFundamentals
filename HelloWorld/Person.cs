using System;

namespace CSharpFundamentals
{
    partial class Program
    {
        /*------------------------ CLASS  -----------------------*/
        public class Person
        {
            public string FirstName;
            public string LastName;

            public void Introduce()
            {
                Console.WriteLine("My name is " + FirstName + " " + LastName);
            }
        }



    }
}
