using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program2.starPyramid();
            Console.WriteLine(Program2.getName("Vu Minh Minh Hieu"));
            Class1.testStar();
            Console.ReadLine();

        }
    }

    internal class Program2
    {
        public static string gettext()
        {
            return "Hello Anh EMMMMMMM!!!!!!!!!";
        }

        public static void starPyramid()
        {
            int i, j, k;

            for (i = 0; i < 10; i++)
            {
                for (k = 0; k < 10 - i; k++)
                {
                    Console.Write(" ");
                }

                for (j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine(gettext());
        }

        public static string getName(string fullName)
        {
            Console.Write("What is your name ? ");
            //string fullName = Convert.ToString(Console.ReadLine());
            string[] splittedName = fullName.Split(' ');

            int index = 0;
            foreach (var item in splittedName)
            {
                Console.WriteLine($"{index} : {item} ");
                index++;
            }
            Console.Write("\n");
            if (splittedName.Length > 2)
            {
                string[] middleName = new string[splittedName.Length - 2];
                Array.Copy(splittedName, 1, middleName, 0, splittedName.Length - 2);
                string onlyMiddle = String.Join(" ", middleName);
                Console.WriteLine(gettext());
                return $"Your middle name is {onlyMiddle}";
            }
            else
            {
                return "Cannot extract your middle name hello";
            }

        }
    }
}

//                 _           ___     ___ _ _          _                      
//                | |         / __)   / __|_) |        | |                     
//  ____ ____   _ | |    ___ | |__   | |__ _| | ____   | | _   ____  ____ ____ 
// / _  )  _ \ / || |   / _ \|  __)  |  __) | |/ _  )  | || \ / _  )/ ___) _  )
//( (/ /| | | ( (_| |  | |_| | |     | |  | | ( (/ /   | | | ( (/ /| |  ( (/ / 
// \____)_| |_|\____|   \___/|_|     |_|  |_|_|\____)  |_| |_|\____)_|   \____)
