using System;


namespace Genes
{
    class Program
    {
        static void Main(string[] args)
        {
            Environment environment = new Environment();
			environment.populateFoods(10, 2);
			environment.populatePeople(20);
			Console.WriteLine(environment.Foods[2].Energy);
        }
    }
}