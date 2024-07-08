

namespace lesson9
{
    public class  Polymorphism
    {
        //  this is method trying to print out the drawing
       public virtual void Draw()
        {
            System.Console.WriteLine("Drawing");
        } 


        public class Circle : Polymorphism
        {
            public override void Draw()
            {
                System.Console.WriteLine("Drawing Circle");
            }
        }

        public class Rectangle : Polymorphism
        {
            public override void Draw()
            {
                System.Console.WriteLine("Drawing Rectangle");
            }
        }
    }
}