namespace BikeBuilderConsoleApp
{
    public class BikeBuilder : IBikeBuilder
    {
        private string _bikeCategory;
        private int _engineCapacity;
        private int _fuelCapacity;
        private string _modelName;
        private int _seats;
        private string _seriesName;

        public Bike Make()
        {
            return new Bike(_modelName, _seriesName, _bikeCategory, _fuelCapacity, _engineCapacity, _seats);
        }

        public void SetBikeCategory(string bikeCapacity)
        {
            _bikeCategory = bikeCapacity;
        }

        public void SetEngineCapacity(int capacity)
        {
            _engineCapacity = capacity;
        }

        public void SetFuelCapacity(int fuelCapacity)
        {
            _fuelCapacity = fuelCapacity;
        }

        public void SetModelName(string modelName)
        {
            _modelName = modelName;
        }

        public void SetSeats(int seats)
        {
            _seats = seats;
        }

        public void SetSeriesName(string seriesName)
        {
            _seriesName = seriesName;
        }
    }
}