Console.WriteLine("How many chocolate eggs where gathers?");
string textChoco = Console.ReadLine();

int numChoco = Convert.ToInt32(textChoco); // converts the input into a number not a string

int sistersEggs; // the int variable must be declared first
sistersEggs = numChoco / 4; // takes the input number and divides it by the 4 sisters
Console.WriteLine($"Each sister gets {sistersEggs} chocolate eggs");

int duckBearShare; // the int variable must be declared before assinging a value
duckBearShare = numChoco  % 4; // takes the input number and finds the remainder.
Console.WriteLine($"Duckbear gets {duckBearShare}");

/* The 3 total egg counts where Duckbear gets more chocolate eggs are 6, 7, and 11. */