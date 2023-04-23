using System;
using System.Drawing;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            HuMan Rustam = new HuMan(50);
            var Ivan = new HuMan("Ivan", 10, 130, 40);
            HuMan Max = new HuMan("Max", 30, 180, 80,Color.Blue);
            HuMan German = new HuMan("German", 25, 190, 70,Color.Blue,new Car(Color.Black, 2020, 45000, 12));
            HuMan Kirill = new HuMan();
            
            
        }
    }
}