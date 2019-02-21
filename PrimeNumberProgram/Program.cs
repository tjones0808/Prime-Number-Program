using System;
using System.Collections.Generic;
using System.IO;

namespace PrimeNumberProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, Please enter the path to your file containing ints.");
            var path = Console.ReadLine();

            string line = "";
            string output = "";

            if (System.IO.File.Exists(path) == true)
            {
                StreamReader reader;
                reader = new StreamReader(path);
                do
                {
                    line = reader.ReadLine();

                    int x;
                    if (int.TryParse(line, out x))
                    {
                        // find the prime factors
                        var primes = GetPrimeFactors(x);
                        var newLine = "";
                        // create comma list of factors and append to output with newline
                        for(int i = 0; i < primes.Count; i++)
                        {
                            if (i == primes.Count - 1)
                            {
                                newLine += (primes[i].ToString() + Environment.NewLine);
                            }
                            else
                            {
                                newLine += (primes[i].ToString() + ", ");
                            }
                            
                        }

                        output += newLine;

                    }

                } while (reader.Peek() != -1);

                reader.Close();

                Console.Write(output);
            }
            else
            {
                Console.WriteLine("You entered and invalid path.");
            }

            Console.ReadKey(true);

        }

        public static List<int> GetPrimeFactors(int num)
        {
            var primes = new List<int>();

            for (int div = 2; div <= num; div++)
                while (num % div == 0)
                {
                    primes.Add(div);
                    num = num / div;
                }

            return primes;
        }
    }
}
