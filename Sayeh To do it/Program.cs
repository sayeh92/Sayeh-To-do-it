using Sayeh_To_do_it.Models;

namespace Sayeh_To_do_it
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Below are the detals of person:");

            Person person1 = new Person(1, "Sayeh", "Ghaderi");


            Console.WriteLine(person1.Id + " " + person1.FirstName + " " + person1.LastName);
        }
    }
}