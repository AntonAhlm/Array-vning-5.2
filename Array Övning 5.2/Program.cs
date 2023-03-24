using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många sporter har du testat? : ");
            int AntalSporter=Convert.ToInt32(Console.ReadLine());

            string[] Sport = new string[AntalSporter];

            for(int i=0;i<AntalSporter;i++)
            {
                Console.Write("Sport " + (i + 1) + ": ");
                Sport[i] = Console.ReadLine();

            }

            Console.WriteLine("Sporterna du har testat:");

            for(int i=0;i<AntalSporter;i++)
            {
                Console.WriteLine(Sport[i]);
            }
        }
    }
}
