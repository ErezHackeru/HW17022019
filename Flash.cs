using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17022019
{
    class Flash : Human, IFlash
    {
        public int Voltage { get; private set; }

        public Flash(int voltage, string name, int age) : base(name, age)
        {
            Voltage = voltage;
        }
        public override string Name { get; set; }

        public void FireLightning()
        {
            Console.WriteLine("Flash ismaking great fireworks");
        }
        public void ActivateSuperPowers()
        {
            Console.WriteLine("Flash is coming soon ! careful from his Powers.");
        }

        public override string ToString()
        {
            return $"volage is: {Voltage} " + base.ToString();
        }
    }
}
