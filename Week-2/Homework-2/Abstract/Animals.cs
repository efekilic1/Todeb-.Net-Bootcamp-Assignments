using System;

namespace Homework
{
    public abstract class animals{

        private string name; //field
        //dışarıdan erişime kapatarak korumak istediğim için değişkenlerimizi private olarak oluşturuyoruz.
        private int age; //field

        protected animals(string name, int age) // Constructor Method 
        {
            Age = age;
            Name = name;

        }

        public string Name { get=>name; set=>name=value; } // property
        public int Age { get=>age; set=>age=value; } // property




        public void respiratory(){
            Console.WriteLine("Solunum yapar.");
        } 





        public void nutrition(){
            Console.WriteLine("Beslenir.");
        } 


        public virtual void movement() 
        // override yapacağımız için virtual olarak kullanıyoruz.
        // elimizdeki hayvanların çoğunluğunun hareket şekli koşu olduğu için default olarak koşmayı kullanıyoruz.
        {
            Console.WriteLine("Koşar.");

            

        }




    }

}