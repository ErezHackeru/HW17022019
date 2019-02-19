using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17022019
{
    class SuperMan : Human , IFly
    {
        public int WebLeft { get; private set; }

        public SuperMan(int webLeft, string name, int age) : base(name, age)
        {
            WebLeft = webLeft;
        }
        public override string Name { get; set; }

        public void Fly()
        {
            Console.WriteLine("I can Fly !");
        }
        public void ActivateSuperPowers()
        {
            Console.WriteLine("Superman is coming !");
        }

        public override string ToString()
        {
            return $"WebLeft is: {WebLeft} " + base.ToString();
        }
    }
}
