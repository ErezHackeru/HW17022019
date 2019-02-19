using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17022019
{
    class SpiderMan : Human, IClimb
    {
        public int Speed { get; private set; }

        public SpiderMan(int speed, string name, int age) : base(name, age)
        {
            Speed = speed;
        }

        public override string Name { get; set; }

        public void Climb()
        {
            Console.WriteLine("SpiderMan can Climb high !");
        }
        public void ActivateSuperPowers()
        {
            Console.WriteLine("SpiderMan has great superPowers");
        }

        public override string ToString()
        {
            return $"Speed is: {Speed} " + base.ToString();
        }
    }
}
