namespace BikeBuilderConsoleApp
{
    public class Bike
    {
        public int EngineCapacity { get; }
        public int Seats { get; }
        public int FuelCapacity { get; }
        public string ModelName { get; }
        public string SeriesName { get; }
        public string BikeCategory { get; }

        public Bike(
            string modelName,
            string seriesName,
            string category,
            int fuelCapacity,
            int engineCapacity,
            int seats)
        {
            this.ModelName = modelName;
            this.SeriesName = seriesName;
            this.Seats = seats;
            this.BikeCategory = category;
            this.EngineCapacity = engineCapacity;
            this.FuelCapacity = fuelCapacity;
        }
    }

    public class BikeTypes
    {
        public const string Sports = "SPORTS";
        public const string Cruiser = "CRUISER";
        public const string Classic = "CLASSIC";
        public const string Regular = "REGULAR";
    }
}