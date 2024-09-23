Console.Title = "The Defence of Consolas";

Console.Write("Target row? ");
string textRow = Console.ReadLine();
Console.Write("Target column? ");
string textColumn = Console.ReadLine();

int Row = Convert.ToInt32(textRow);
int Column = Convert.ToInt32(textColumn);

int upRow = Row + 1;
int leftColumn = Column - 1;
int downRow = Row - 1;
int rightColumn = Column + 1;

Console.WriteLine($"Deploy to: ");
Console.WriteLine($"({Row}, {leftColumn})");
Console.WriteLine($"({downRow}, {Column})");
Console.WriteLine($"({Row}, {rightColumn})");
Console.WriteLine($"({upRow}, {Column})");

Console.Beep(440, 1000);