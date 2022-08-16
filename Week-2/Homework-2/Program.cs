using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
             Dolphin dolphin = new Dolphin("Sugar", 5);
             Console.WriteLine("{0} is a dolphin and it is {1} years old.", dolphin.Name, dolphin.Age);
             dolphin.nutrition();
             dolphin.respiratory();
             dolphin.movement();
             Console.WriteLine("*_*_*_*_*_*_*_*_*_*");
             Elephant elephant = new Elephant("Big Boy",12);
             Console.WriteLine("{0} is a elephant and it is {1} years old.", elephant.Name, elephant.Age);
             elephant.nutrition();
             elephant.respiratory();
             elephant.movement();
             Console.WriteLine("*_*_*_*_*_*_*_*_*_*");
             Eagle eagle = new Eagle("Senator Joy", 5);
             Console.WriteLine("{0} is a eagle and it is {1} years old.", eagle.Name, eagle.Age);
             eagle.nutrition();
             eagle.respiratory();
             eagle.movement();





 
             
             
        }
    }
}
