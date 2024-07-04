
namespace lesson7
{  
    // car class
        public class Car
    {
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        // method 

        public void Drive()
        {
            Console.WriteLine("Car is moving");
        }

        // method to print car model 

        public void PrintModel()
        {
            Console.WriteLine(Model);
        }


        // method to print car make

        public void PrintMake()
        {
            Console.WriteLine(Make);
        }


        // method to print car year

        public void PrintYear()
        {
            Console.WriteLine(Year);
        }
        
    }
}