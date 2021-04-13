// using System;

// namespace Genes
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

using System;

namespace Genes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person<Food> person = new Person<Food>();
            // Console.WriteLine("test");
            Food[] foods = populateFood(10);
            Console.WriteLine("working");
            Console.WriteLine(foods[0].Energy);
            
        }
        public static Food[] populateFood(int amt){
        	Food[] foods = new Food[amt];
        	foods[0] = new Food(3);
        	return foods;
        }
    }
	
}

public class Person<T> where T:Food
{
	public Person() {
		Consumed = 0;
	}
	
	public int Consumed {get; set;}
	
	public void Eat(T food){
		Consumed += food.Energy;
	}
}
public class Food
{
	public Food(){
		Energy = 0;
	}
	public Food(int energy){
		Energy = energy;
	}
	
	public int Energy { get; }
}
