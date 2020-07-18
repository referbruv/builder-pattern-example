namespace BikeBuilderConsoleApp
{
    public interface IBikeBuildDirector
    {
        Bike MakeAvenger();
        Bike MakeChetak();
        Bike MakeR1();
    }

    public class BikeBuildDirector : IBikeBuildDirector
    {
        private readonly IBikeBuilder _builder;

        public BikeBuildDirector(IBikeBuilder builder)
        {
            _builder = builder;
        }

        public Bike MakeR1()
        {
            _builder.SetBikeCategory(BikeTypes.Sports);
            _builder.SetEngineCapacity(1000);
            _builder.SetFuelCapacity(20);
            _builder.SetModelName("Yamaha R1");
            _builder.SetSeats(1);
            _builder.SetSeriesName("R Series");

            return _builder.Make();
        }

        public Bike MakeChetak()
        {
            _builder.SetBikeCategory(BikeTypes.Regular);
            _builder.SetEngineCapacity(80);
            _builder.SetFuelCapacity(15);
            _builder.SetModelName("Chetak");
            _builder.SetSeriesName("Chetak");
            _builder.SetSeats(2);

            return _builder.Make();
        }

        public Bike MakeAvenger()
        {
            _builder.SetBikeCategory(BikeTypes.Cruiser);
            _builder.SetEngineCapacity(220);
            _builder.SetFuelCapacity(15);
            _builder.SetModelName("Avenger 220");
            _builder.SetSeriesName("Avenger");
            _builder.SetSeats(2);

            return _builder.Make();
        }
    }
}