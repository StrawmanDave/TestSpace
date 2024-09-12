Console.WriteLine("What kind of thing are we talking about?");

// Stores what kind of thing you are talking about.
string a = Console.ReadLine();


Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

/* Stores the description of the thing */
string b = Console.ReadLine();

// Stores of Doom in a variable
string c = "of Doom"; 

// Stores 3000 as a string literal
string d = "3000";

Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
/* you do not need the " of " it just says of twice you could just combine variables c and d
as one variable. */