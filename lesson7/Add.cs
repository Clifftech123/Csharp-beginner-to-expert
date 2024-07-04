


namespace lesson7
{
    public class Add
    {
        public int number1 { get; set; }
         public int number2 { get; set; } 


         // constructor
        public Add(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }



        // method to add two numbers

        public void AddNumbers()
        {
            Console.WriteLine(number1 + number2);
        }


        // method to subtract two numbers


        public void SubtractNumbers()
        {
            Console.WriteLine(number1 - number2);
        }
       

 
    }
}