using System;
namespace Homework{

    public class Eagle : animals
    {
        public Eagle(string name, int age) : base(name, age)
        {
        }

        public override  void  movement()// Kartal uçtuğu için hareket şeklini override yaparak değiştiriyoruz.
        {
            Console.WriteLine("Uçar");
        }
    }


}