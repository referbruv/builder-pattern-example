namespace BikeBuilderConsoleApp
{
    public interface IBikeBuilder
    {
        void SetEngineCapacity(int capacity);
        void SetSeats(int seats);
        void SetFuelCapacity(int fuelCapacity);
        void SetModelName(string modelName);
        void SetSeriesName(string seriesName);
        void SetBikeCategory(string bikeCapacity);
        Bike Make();
    }
}