using Classes.Models;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Model = "Ford Focus";
            car.Year = 2013;

            Console.WriteLine(car.Model);
            Console.WriteLine(car.Year);
        }
    }
}
