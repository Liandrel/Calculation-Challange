using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLibrary
{
    public class TemperatureModel : IComparable
    {
        public double Value { get; set; }

        public int CompareTo(object? obj)
        {
            TemperatureModel? nextTemp = obj as TemperatureModel;

            return this.Value.CompareTo(nextTemp?.Value);
        }
    }
}
