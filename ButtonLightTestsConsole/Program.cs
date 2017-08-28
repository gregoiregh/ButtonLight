using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PackageButton;
using PackageLight;

namespace Testeur
{
    class Testeur
    {
        public static void Main(string[] args)
        {
            Light light1 = new Light();
            Console.WriteLine("Light1 " + light1);
            Button button1 = new Button(light1);
            button1.Press();
            Console.WriteLine("Light1 " + light1);
            button1.Press();
            Console.WriteLine("Light1 " + light1);
            Console.ReadKey();
        }
    }
}
