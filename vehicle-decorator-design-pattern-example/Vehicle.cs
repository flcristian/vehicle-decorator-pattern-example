using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_decorator_design_pattern_example
{
    public abstract class Vehicle
    {
        private String _make;
        private String _model;
        private int _leasableCount;

        public String Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public String Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int LeasableCount
        {
            get { return _leasableCount; }
            set { _leasableCount = value; }
        }

        public abstract void Display();
    }
}
