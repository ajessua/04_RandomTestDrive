using System;

namespace RandomTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random free range of integers
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine(randomInt);


            //Random values 0-9
            int zeroToNine = random.Next(10);
            Console.WriteLine(zeroToNine);


            //Random values 1-7
            int dieRoll = random.Next(1, 7);
            Console.WriteLine(dieRoll);


            //random double
            double randomDouble = random.NextDouble();
            Console.WriteLine(randomDouble * 100);


            //random double cast to float as well as decimal
            Console.WriteLine((float)randomDouble * 100f);
            Console.WriteLine((decimal)randomDouble * 100m);


            //random integer converted to boolean response
            int zeroOrOne = random.Next(2);
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(coinFlip);



        }
    }
}
