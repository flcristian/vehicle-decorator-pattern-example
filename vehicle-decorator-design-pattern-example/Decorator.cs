using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_decorator_design_pattern_example
{
    public class Decorator : Vehicle
    {
        protected Vehicle _vehicle;

        public Decorator(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public override void Display()
        {
            _vehicle.Display();
        }
    }
}
