string name;
Console.Write("What is your name?");
name = Console.ReadLine();

Console.Write("What is your age?");
string ageText = Console.ReadLine();
int age = Convert.ToByte(ageText);
Console.WriteLine($"You are {name} and {age} years old");