using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17022019
{
    abstract class Human
    {
        public abstract string Name { get; set; }
        private int age;

        public int AgeGet
        {
            get
            {
                return this.age;
            }
            
        }

        public Human(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"The Name is: {Name}, age is: {age}";
        }
    }
}
