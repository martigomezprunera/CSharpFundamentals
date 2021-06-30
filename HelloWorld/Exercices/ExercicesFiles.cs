using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpFundamentals.Exercices
{
    class ExercicesFiles
    {
        public static void Exercice1()
        {
            var path = @"G:\exercice1.txt";

            if(File.Exists(path))
            {
                var content = File.ReadAllText(path);
                var separatedText = content.Split(' ');
                Console.WriteLine(separatedText.Length);
            }
        }

        public static void Exercice2()
        {
            var path = @"G:\exercice1.txt";

            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                var separatedText = content.Split(' ');
                var counter = 0;
                var word = " ";

                foreach(var separated in separatedText)
                {
                    if (separated.Length > counter)
                    {
                        word = separated;
                        counter = separated.Length;
                    }
                }

                Console.WriteLine(word);
            }
        }
    }
}
