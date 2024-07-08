

namespace lesson9
{
    public class Encapsulation
    {
        private double balance; // encapsulated field


        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {balance}");
        }   

        public void Withdraw(double amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {balance}");
        }
    }


   
    
}