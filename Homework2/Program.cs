using System;
namespace Homework2
{
    public class Program
    {
        static void Main()
        {

            

            Bmw bmw = new Bmw( "M5" , 360 , 150000 , "darkgreen") ;
            Mercedes mercedes = new Mercedes("c6.3", 320, 18000, "darkblack");

            

            Console.WriteLine($"{bmw.model} {bmw.speed} {bmw.price} {bmw.color}");
            Console.WriteLine($"{mercedes.model} {mercedes.speed} {mercedes.price} {mercedes.color}");

        }
    }
}
