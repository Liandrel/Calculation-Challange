namespace CalculationLibrary
{
    public interface ITemperatureListModel
    {
        double? avgTemp { get; }
        double? maxTemp { get; }
        double? minTemp { get; }

        void Insert(string entry);
        void Insert(TemperatureModel entry);
    }
}