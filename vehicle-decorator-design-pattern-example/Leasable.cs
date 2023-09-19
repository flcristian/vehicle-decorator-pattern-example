using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_decorator_design_pattern_example
{
    public class Leasable : Decorator
    {
        protected List<String> _customers;

        public Leasable(Vehicle vehicle) : base(vehicle) { _customers = new List<String>(); }

        public void LeaseVehicle(String customer)
        {
            if(_vehicle.LeasableCount > 0)
            {
                _customers.Add(customer);
                _vehicle.LeasableCount--;
            }
            else
            {
                Console.WriteLine("No more cars available.");
            }
        }

        public void ReturnVehicle(String name)
        {
            _customers.Remove(name);
            _vehicle.LeasableCount++;
        }

        public override void Display()
        {
            base.Display();
            foreach(String customer in _customers)
            {
                Console.WriteLine($"Customer : {customer}");
            }
        }
    }
}
