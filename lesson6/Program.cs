// If-else statement
int age = 18;
if (age >= 18)
{
    Console.WriteLine("You are an adult");
}
else
{
    Console.WriteLine("You are a minor");
}


// Loops
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("The value of i is " + i);
}

// While loop

int number = 1;
while (number <= 10)
{
    Console.WriteLine("The value of number is " + number);
    number++;
}


// Do-while loop

int count = 10;
do
{
    Console.WriteLine("The value of count is " + count);
    count++;
} while (count <= 11);



// Nested loops


for (int row = 0; row <= 5; row++)
{
    for (int col = 1; col <= 5; col++)
    {
       Console.Write($"{row * col}\t"); 
    }
    Console.WriteLine();
}


//Break and Continue

int count  = 0 ;
while (count <= 10)
{
    if (count == 4)
    {
        count++;
        continue;
    }
    Console.WriteLine("The value of count is break " + $"{count}");
    count++;
}


// break statement

count  = 0 ;
while (count <= 10)
{
    if (count == 2)
    {
        break;
    }
    Console.WriteLine("The value of count is " + $"{count}");
    count++;
}


// check if a number is even or odd

int num = 11;

if (num % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}


// check if a number prime number


int number =20;
bool isPrime = true;


for (int i = 2; i < number; i++)
{
    if (number % i == 0)
    {
        isPrime = false;
        break;
    }
    else{
        for (int j = 2; j < number; j++)
        {
            if (number % j == 0)
            {
                isPrime = false;
                break;
            }
        }
    }
}

Console.WriteLine(isPrime ? "The number is prime" : "The number is not prime");