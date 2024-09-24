Console.Write("What is the number?");
string textNumber = Console.ReadLine();

int number = Convert.ToInt32(textNumber);

if (number % 2 == 0)
    Console.WriteLine("Tick");
else 
Console.WriteLine("Tock");