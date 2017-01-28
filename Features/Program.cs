using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            //Litteral binaries
            int[] numbers = { 1, 2, 0b100, 0b10_000, 123_456 };

            //Tuples
            var r = Calculate(numbers);
            WriteLine($"Somme : {r.sum} & Count : {r.count}");

            //Deconstruction
            Person person = new Person();
            WriteLine(person);
            var deconstructed = person;
            WriteLine($"First Name : {deconstructed.FirstName} & Last Name : {deconstructed.LastName}");

            //out variables
            if (int.TryParse("1", out int i))
            {
                i++;
                WriteLine($"out variable result : {i}");
            }

            //Pattern matching (is / switch)
            PatternMatching("Hello");
            PatternMatching(120);
            PatternMatching(80);
            PatternMatching(20);
            PatternMatching(1);
            PatternMatching(true);

            //Throw expr
            try
            {
                int y = 1;
                int x = y == 2 ? 1 : throw new Exception();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                //throw;
            }
        }

        //Function returning Tuple
        static (int sum, int count) Calculate(int[] values)
        {
            //Tuple variable (we can give names to Tuple elements)
            var r = (s: 0, c: 0);

            foreach (var v in values)
            {
                DoWork(v);
            }

            //Local function
            void DoWork(int n)
            {
                r.s += n;
                r.c++;
            }

            return r;
        }

        static void PatternMatching(object obj)
        {
            switch (obj)
            {
                //case object x:
                //Console.WriteLine("Type objet");
                //break;
                case string s:
                    WriteLine("String type");
                    break;
                case int i when (i > 100):
                    WriteLine("int greater than 100");
                    break;
                case int i when (i > 50):
                    WriteLine("int between 50 and 100");
                    break;
                case 1: //Constant pattern
                    WriteLine("equal to 1");
                    break;
                case int i:
                    WriteLine("int type");
                    break;
                default:
                    WriteLine("Unknown type");
                    break;
            }
        }
    }
}
