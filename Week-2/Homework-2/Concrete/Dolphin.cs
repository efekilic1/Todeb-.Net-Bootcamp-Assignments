using System;
namespace Homework{

    public class Dolphin : animals
    {
        public Dolphin(string name, int age) : base(name, age)
        {

        }

        public  override void movement() //Yunus koşmadığı yüzdüğü için override yapıyoruz ve hareket şeklini değiştiriyoruz.
        {
           Console.WriteLine("Yüzer.");
        }
    }


}