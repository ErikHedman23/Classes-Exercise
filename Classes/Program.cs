using System.ComponentModel;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Year = 2001;
            car.Make = "Jeep";
            car.Model = "Wrangler";
            car.Description();
        }
    }
}
