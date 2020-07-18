using System;
using System.Reflection;
using Newtonsoft.Json;

namespace BikeBuilderConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IBikeBuilder builder = new BikeBuilder();
            IBikeBuildDirector director = new BikeBuildDirector(builder);

            //build an R1
            Bike r1 = director.MakeR1();
            Describe(r1);

            //build an Avenger
            Bike avenger = director.MakeAvenger();
            Describe(avenger);

            //build a chetak
            Bike chetak = director.MakeChetak();
            Describe(chetak);
        }

        static void Describe(Bike b)
        {
            foreach (PropertyInfo p in b.GetType().GetProperties())
            {
                Console.WriteLine(p.Name + ":" + p.GetValue(b, null));
            }
            Console.WriteLine("\n");
        }
    }
}
