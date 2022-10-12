using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLibrary
{
    public class TemperatureListModel : ITemperatureListModel
    {
        private List<TemperatureModel> TemperatureList { get; set; } = new();
        private Dictionary<string, int> wordInt = new();
        public double? minTemp
        {
            get
            {
                return TemperatureList.Min(x => x.Value);
            }
        }
        public double? maxTemp
        {
            get
            {
                return TemperatureList.Max(x => x.Value);
            }
        }
        public double? avgTemp
        {
            get
            {
                return Math.Round(TemperatureList.Average(x => x.Value), 2);
            }
        }
        public TemperatureListModel()
        {
            wordInt.Add("one", 1);
            wordInt.Add("two", 2);
            wordInt.Add("three", 3);
            wordInt.Add("four", 4);
            wordInt.Add("five", 5);
            wordInt.Add("six", 6);
            wordInt.Add("seven", 7);
            wordInt.Add("eight", 8);
            wordInt.Add("nine", 9);
            wordInt.Add("ten", 10);
        }
        public void Insert(TemperatureModel entry)
        {
            TemperatureList.Add(entry);
        }
        public void Insert(string entry)
        {
            entry = entry.ToLower();
            Insert(new TemperatureModel { Value = wordInt[entry] });
        }



    }
}
