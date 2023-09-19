using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_decorator_design_pattern_example
{
    public class Car : Vehicle
    {
        private int _topSpeed;

        public Car(String make, String model, int leasableCount, int topSpeed)
        {
            Make = make;
            Model = model;
            LeasableCount = leasableCount;
            _topSpeed = topSpeed;
        }

        public int TopSpeed 
        {
            get { return _topSpeed; }
            set { _topSpeed = value; }
        }

        public override String ToString()
        {
            String desc = "";
            desc += $"Make : {Make}\n";
            desc += $"Model : {Model}\n";
            desc += $"Leasable Count : {LeasableCount}\n";
            desc += $"Top Speed : {_topSpeed}\n";
            return desc;
        }

        public override void Display()
        {
            Console.WriteLine(this);
        }
    }
}
