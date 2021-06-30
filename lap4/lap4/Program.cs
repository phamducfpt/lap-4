using System;

namespace lap4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Duc", "0973559222", "duc@gmail.com");
            Console.WriteLine(person.ToString());
        }
    }
}