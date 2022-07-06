using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Car
    {
        public Car()
        {

        }

        public string model;
        public int speed;
        public int price;
        public string color;


        public Car(string model, int speed, int price, string color):this()

        {
            this.model = model;
            this.speed = speed; 
            this.price = price;
            this.color = color;
        }




    }
}
