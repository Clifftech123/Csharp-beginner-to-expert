

namespace lesson7
{
    public class Shape
    {
        
        // Properties

        public int Width { get; set; }
        public int Height { get; set; }

        // constructor

        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }


        // method to calculate the area of a shape

        public void Area()
        {
            Console.WriteLine(Width * Height);
        }



        // method to calculate the perimeter of a shape

        public void Perimeter()
        {
            Console.WriteLine(2 * (Width + Height));
        }



        
    }
}