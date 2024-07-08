


//  4 pilar object oriented programming
// 1. Inheritance
// 2. Polymorphism
// 3. Abstraction
// 4. Encapsulation


// ======= Inheritance ======= 


using lesson9;

public static  class Program
    {
          public class Animal
    {

        // this is properties
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
    

     // this is method
        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }


// this is a dog class which is inherited from Animal class
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking");
        }
    }


// this is a cat class which is inherited from Animal class
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meowing");
        }
    }

    //  another animal 

    public class Lion : Animal {
        public void Roar() {
            Console.WriteLine("Roaring");
        }
    }



    // =======  Polymorphism =========  
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "Dog";
            dog.Color = "Black";
            dog.Age = 5;

            dog.Eat();
            dog.Sleep();
            dog.Bark();

            Cat cat = new Cat();
            cat.Name = "Cat";
            cat.Color = "White";
            cat.Age = 3;

            cat.Eat();
            cat.Sleep();
            cat.Meow();

            Lion lion = new Lion();

            lion.Name = "Lion";
            lion.Color = "Yellow";
            lion.Age = 10;

            lion.Eat();
            lion.Sleep();
            lion.Roar();


            //  using the polymorphism here 

            Console.WriteLine("Polymorphism");

             Polymorphism polymorphism = new Polymorphism();
            polymorphism.Draw();
            polymorphism = new Polymorphism.Circle();
            polymorphism.Draw();

            // Encapsulation
            Console.WriteLine("Encapsulation");
            Encapsulation encapsulation = new Encapsulation();
            encapsulation.Deposit(100);
            encapsulation.Withdraw(50);


            // Abstraction

            Console.WriteLine("Abstraction");

            Device device = new Smartphone();
            device.TurnOn();
            device.TurnOff();
            

        }
    }