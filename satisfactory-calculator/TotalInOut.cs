using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator
{
    class TotalInOut
    {
        public Material Material;
        public double Output;
        public double Input;
        public TotalInOut(Material material, double output=0, double input=0)
        {
            Material = material;
            Output = output;
            Input = input;
        }
    }
}
