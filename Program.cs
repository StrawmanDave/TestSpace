/* Loops there is while loops do loops and for loops*/
// Console.Clear();
// for(int i = 1; i <= 12; i ++){
// 
//     for (int j = 1; j <= 12; j ++){
//         Console.WriteLine($" {i} x {j} = {i * j}");
//     }
// }
// Console.Write("\n");

// string phrase = "The quick brown fox jumps over the lazy dog";
// string[] words = phrase.Split('o', 'a', 'e','i', 'u');
// 
// for (int i = 0; i<words.Length; i++)
//     Console.Write(words[i]);
// 
// Console.WriteLine();

// string phrase = "Hello, World!";
// string substring1 = phrase.Substring(2,7).ToUpper();
// string substring2 = phrase.Substring(6).ToLower();
// Console.WriteLine(substring1 + substring2);


/*
// The Replicator of D'To
int[] fiveNum = new int[5]{0,1,2,3,4};
int inSideNum;
Console.WriteLine("This is the first list of numbers");
for (int f=0; f<fiveNum.Length; f++) // writes out the first list of numbers
{
    Console.Write($"{fiveNum[f]} ");
};


Console.WriteLine("Please give me 5 numbers");
for (int i=0; i<fiveNum.Length; i++)
{
    
    inSideNum = Convert.ToInt32(Console.ReadLine());
    fiveNum[i] = inSideNum;
    
};

Console.WriteLine("The new list of numbers is");
for (int j=0; j<fiveNum.Length; j++)
{
    Console.Write($"{fiveNum[j]} ");
};
*/

// int[] array = new int[] { 4, 51, -7, 14, -99, 15, -8, 45, 90 };
// int currentSmallest = int.MaxValue; // Starts higher than anything in the array.
// foreach(int hold in array)
// {
//     if (hold < currentSmallest)
//     {
//         currentSmallest = hold;
//     }
// };
// Console.WriteLine(currentSmallest);
// 
// 
// int[] ave = new int[] { 4, 51, -7, 14, -99, 15, -8, 45, 90 };
// 
// int total = 0;
// foreach(int avehold in ave)
// {
//     total += avehold;
// }
// float average =(float)total / ave.Length;
// Console.WriteLine(average);

/*
int[] numbers = new int[10]{0,1,2,3,4,5,6,7,8,9};
foreach (int number in numbers)
    Console.WriteLine(number);

*/
// string phrase = "The quick brown fox jumps over the lazy dog";
// string[] words = phrase.Split (' ');
// string[] space = new string [1] {" "};
// int x = 0;
// int y = 0;
// 
// Console.WriteLine();
// 
// for(int i=0; i<words.Length; i++)
// {
//     if(i != words.Length - 1){
//         words[i] = words[i] + " ";
//     }
// 
//     for(int j=0; j<words[i].Length; j++)
//     {   
//         Console.Write($"X value:{x} Y Value:{y} ");
//         Console.WriteLine($"{words[i][j]}");
//         y++;
//         
//     }
//     x++;
// }
// 
// Console.WriteLine();

// The Defense of Consolas Better and improved

// Console.Write($"Target Row? ");
// int Row =Convert.ToInt32(Console.ReadLine());
// Console.Write($"Target Row? ");
// int Column =Convert.ToInt32(Console.ReadLine());
// 
// int left = Column - 1;
// int up = Row + 1;
// int right = Column + 1;
// int down = Row - 1;
// 
// Console.WriteLine($"Deploy to: ({Row}, {left})");
// Console.WriteLine($"Deploy to: ({down}, {Column})");
// Console.WriteLine($"Deploy to: ({Row}, {right})");
// Console.WriteLine($"Deploy to: ({up}, {Column})");
// 
// const int GRIDSIZE = 8;
// string[,] grid = new string [GRIDSIZE, GRIDSIZE];
// 
// string[,] filler = new string[1,1] {{"-"}};
// string[,] target = new string[1,1] {{"*"}};
// 
// string[,] deploy = new string[1,1] {{"^"}};
// 
// 
// /* for the number that row  is called then the x value for should be changed
// for the number that the column is called the y value should be changed
// */
// 
// for (int i = 0; i <GRIDSIZE; i++)
// {
//     
//     for (int j=0; j<GRIDSIZE; j++)
//     {   
//         grid[i,j] = filler[0,0];     
//         
// 
//         if(grid[i,j] == grid[Row,Column]) // if the target row is equal to the spot in grid[i,j] then do stuff
//         {
//             grid[Row,Column] = target[0,0];
//         }
// 
//         if(grid[i,j] == grid[Row,left])
//         {
//             grid[Row,left] = deploy[0,0];
//         }
//         if(grid[i,j] == grid[down,Column])
//         {
//             grid[down,Column] = deploy[0,0];
//         }
// 
//         if(grid[i,j] == grid[Row,right])
//         {
//             grid[Row,right] = deploy[0,0];
//         }
// 
//         if(grid[i,j] == grid[up,Column])
//         {
//             grid[up,Column] = deploy[0,0];
//         }
// 
//         Console.Write(grid[i,j]);
//     }
//     Console.WriteLine();
// };
// 
// Console.WriteLine();

// string[] phrase = new string [] {"--------","--------","--------","--------","--------","--------","--------","--------"};
// int x = -1;
// int y = -1;
// const int spot = 8;
// 
// Console.WriteLine();
// 
// for(int i=0; i<phrase.Length; i++)
// {
//     
//     for(int j=0; j<phrase.Length; j++)
//     {
//         spot--;
//         Console.Write($"{phrase[spot]}");
//         
//     }
//     Console.Write(phrase[spot]);
//     Console.WriteLine();
// 
// }
// Console.WriteLine();

// double x = 4.0;
// double y = 3.4;
// 
// (double x, double y) coordinates = (y,x);
// Console.Write($"{coordinates.x},{coordinates.y}");

/* Objectives 
Define enumerations for the three variations on food: type(soup,stew,gumbo), main ingredient 
(mushrooms, chicken, carrots, potatoes), and seasoning(spicy, salty, sweet).
Make a tuple variable to represent a soup composed of the three above enumeration types.
Let the user pick a type, main ingredient, and seasoning from the allowed choices and fill the tuple with the results.
Hint you could give the user a menu to pick from or simply compare the users text input against specific strings to determine
wich enumeration value represents their choice.
When done, display the contents of the soup tuple varialbe in a format like "Sweet Chicken Gumbo".
Hint: you don't need to convert the enumeration vlaue bakc to a string. Simply display an enumeration value with Write or 
WriteLine will display the name of the enumeration value.
*/

// // Simula's Soup
// Console.Clear();
// string order = "";
// 
// // second objective complete
// (Type typeOfFood, mainIngredient ingredient, Seasoning seasoning) Food = (Type.soup, mainIngredient.mushrooms, Seasoning.spicy);
// 
// string menu = @" Simula's Menu
// Types of food: soup, stew, gumbo
// Main ingredients: mushrooms, chicken, carrots, potatoes
// Seasoings: spicy, salty, sweet
// ";
// Console.Write(menu);
// 
// //ask for what type of food is in simplest way I know
// Console.WriteLine($"What type of food would you like?");
// order = Console.ReadLine();
// 
// // depending on the user input it changes the seasoning the defualt is left to soup
// if(order == "gumbo")
// {
//     Food.typeOfFood = (Type.gumbo);
// }else if(order == "stew")
// {
//     Food.typeOfFood = Type.stew;
// }else  //could make this into an if else statement then have the defualt loop back and say that is not on the menu
// {
//     Food.typeOfFood = Type.soup;
// };
// 
// //ask for what Main ingredient in simplest way I know
// Console.WriteLine($"What type of Main ingredient would you like?");
// order = Console.ReadLine();
// 
// // depending on the user input it changes the seasoning the defualt is left to mushrooms
// if(order == "potatoes")
// {
//     Food.ingredient = mainIngredient.potatoes;
// }else if(order == "carrots")
// {
//     Food.ingredient = mainIngredient.carrots;
// }else if(order == "chicken")
// {
//     Food.ingredient = mainIngredient.chicken;
// }else // could make this into an if else statement then have the defualt loop back and say that is not on the menu
// {
//     Food.ingredient = mainIngredient.mushrooms;
// };
// 
// //ask for what seasoning in simplest way I know
// Console.WriteLine($"What type of seasoning would you like?");
// order = Console.ReadLine();
// 
// // depending on the user input it changes the seasoning the defualt is left to spicy
// if (order == "sweet")
// {
//     Food.seasoning = Seasoning.sweet;
// }else if (order == "salty")
// {
//     Food.seasoning = Seasoning.salty;
// }else //could make this into an else if statement then have the defualt loop back and say that is not on the menu
// {
//     Food.seasoning = Seasoning.spicy;
// };
// 
// // third objective complete
// Console.WriteLine($"Here is your order {Food.seasoning} {Food.ingredient} {Food.typeOfFood}");
// 
// // first objective done
// enum Type {soup, stew, gumbo} //type food with the choices soup, stew, gumbo
// enum mainIngredient {mushrooms, chicken, carrots, potatoes} //type with the choices mushroom, chicken, carrots, potatoes
// enum Seasoning {spicy, salty, sweet} // type with the choices spice, salty, sweet
// Console.Clear();
// int[] numbers = new int[20]{20,19,18,17,16,15,14,13,12,11,10,9,8,7,6,5,4,3,2,1};
// // test one will be how many times the bubble sort runs
// int test1 = 0;
// // test two will be how many times the insert sort runs 
// int test2 = 0;

// Bubble sort
// bool itemMoved = false;
//  do
//  {
//     itemMoved = false;
//     for (int i = 0; i < numbers.Count() - 1; i++)
//     {
//         
//         if (numbers[i] > numbers[i + 1])
//         {
//             int lowerValue = numbers[i + 1];
//             numbers[i + 1] = numbers[i];
//             numbers[i] = lowerValue;
//             itemMoved = true;
//         }
//         test1 ++;
//     }
//      
// } while(itemMoved);
// 
// foreach (int n in numbers)
// {
//     Console.Write($"{n} ");    
// }
// Console.WriteLine($"number of times Bubble sort ran {test1}");
// Console.WriteLine("\n");

// variables for any sort
// int[] someNumbers = new int[10]{1,4,9,16,25,36,49,64,81,100};
// int runAmount = 0;
// Console.Write("What number are you looking for? ");
// int searchNum = Convert.ToInt32(Console.ReadLine());

// // insert sort
//     for (int i = 0; i < numbers.Count(); i++)
//     {
//         var item = numbers[i];
//         var currentIndex = i;
// 
//         while (currentIndex > 0 && numbers[currentIndex - 1] > item)
//         {
//             numbers[currentIndex] = numbers[currentIndex - 1];
//             currentIndex--;
//         }
// 
//         numbers[currentIndex] = item;
//         Console.Write($"{numbers[i]} ");
//         test2 ++;
//     }
//     Console.WriteLine($"number of times insert sort ran {test2}");
//     Console.WriteLine();

// // Linear search
// for( int i=0; i<someNumbers.Length; i++)
// {
//     runAmount ++;
//     if(someNumbers[i] == searchNum)
//     {
//         Console.WriteLine($"{someNumbers[i]} found at spot {runAmount}");
//     }
// }
// Console.WriteLine();


// 
// //Binary Search
// int minArray = 0;
// int maxArray = someNumbers.Count() -1;
// int mid;
// int position = -1;
// 
// while(minArray <= maxArray)
// {
//     mid = (minArray + maxArray) /2;
//     Console.WriteLine(minArray);
//     Console.WriteLine(mid);
//     Console.WriteLine(maxArray);
//     if(searchNum == someNumbers[mid])
//     {
//         position = mid;
//         maxArray = -1; // we found it so the loop stops
//     }
//     else if(searchNum < someNumbers[mid])
//     {
//         maxArray = mid  -1;
//     }
//     else
//     {
//         minArray = mid +1;
//     }
//     runAmount ++;
// };
// 
// if (position == -1)
// {
//     Console.WriteLine($"We did not find the number {searchNum}."); 
// }else 
// {
//     Console.WriteLine($"We found {searchNum} in position {position}.");
// }
// Console.WriteLine($"The search ran {runAmount} times.");

// int countdown = 10;
// do {
// countdown --;
// Console.Write($"{countdown} ");
// } while (countdown > 0);
// Console.WriteLine("Blastoff!");



// string[] employRase = File.ReadAllLines("employeeDataBase-1.txt");
// int i = 0;
// string salaryRaise = "";
// 
// for(i = 1; i<employRase.Length; i++)
// {
// string[] newRase = employRase[i].Split(",");
// //gives the person the raise
// double raise =Convert.ToDouble(newRase[2]);
// raise *= 1.05;
// newRase[2] =Convert.ToString(raise);
// 
// employRase[i] = newRase[0] + "," + newRase[1] + "," + newRase[2] + "\n";
// salaryRaise = salaryRaise + employRase[i];
// 
// Console.Write(employRase[i]);
// 
// File.WriteAllText("salaryRaise.txt", salaryRaise);
// }


// int count = 1000;
// CountToTen();
// void CountToTen()
// {
//     Console.WriteLine(count);      
//      for(int count = 1; count<=10; count++)
//     Console.Write($"{count} ");
// }

// // debuggin for the maze
// string[] mazeRows = File.ReadAllLines("map.txt");
// 
// for(int i = 0; i< mazeRows.Count(); i++)
// {
//     for(int j = 0; j<mazeRows[i].Length; j++)
//     {
//         Console.Write(mazeRows[i][j]);
//     }
//     Console.WriteLine();
// }
// 
// for(int i = 0; i< mazeRows.Count(); i++)
// {
//     for(int j = 0; j<mazeRows[i].Length; j++)
//     {
//         Console.Write($"{j} ");
//     }
//     Console.WriteLine();
// }

// // exponents with Iterative and recursion.
// Console.Clear();
// Console.Write(exponentIterative(3,3));
// Console.WriteLine();
// Console.Write(exponentRecursive(5,3));
// Console.WriteLine();
// 
// int exponentIterative (int x, int y)
// {
//     int num = 1;
//     num = x;
//     for(int i = 1; i<y; i++)
//     {
//         num = num * x;
//     }
//     return num;
// }
// int exponentRecursive(int x,int y)
// {
//     if(y == 0)
//     {
//         return 1;
//     }
//     return x * exponentRecursive(x,y-1);
// }


// (string, int) nameAndAge = ("name", 23);
// List<(string name, int age)> people = new List<(string name, int age)>(){("Billy", 34),("Jean", 25),("Henry", 49)};
// 
// Console.WriteLine($"{people[1].name},{people[1].age}"); 

// List<int> nums = new List<int> ();
// 
// nums.Add(1);
// nums.Add(2);
// nums.Add(3);
// nums.Add(4);
// nums.Add(5);
// 
// foreach(int num in nums)
// {
//     Console.Write($"{num} ");
// }
// Console.WriteLine();
// List<int> newNums = nums;
// foreach(int i in newNums)
// {
//     Console.Write($"{i} ");
// }
// Console.WriteLine();    
// 
// List<int> someNums = new List<int>() {(5),(4),(3),(2),(1)};
// foreach(int j in someNums)
// {
//     Console.Write($"{j} ");
// }
// Console.Write(someNums.Remove(3));
// Console.WriteLine();

// string phrase = "The quick brown fox jumps over the lazy dog.";
// List<char> listPhrase = phrase.ToList();
// //Console.Write(listPhrase[0]);
// listPhrase.Sort();
// listPhrase.Reverse();
// while(listPhrase.Remove('a') != false)
// {
//     listPhrase.Remove('a');
// }
// while(listPhrase.Remove('e') != false)
// {
//     listPhrase.Remove('e');
// }
// while(listPhrase.Remove('i') != false)
// {
//     listPhrase.Remove('i');
// }
// while(listPhrase.Remove('o') != false)
// {
//     listPhrase.Remove('o');
// }
// while(listPhrase.Remove('u') != false)
// {
//     listPhrase.Remove('u');
// }
// while(listPhrase.Remove(' ') != false)
// {
//     listPhrase.Remove(' ');
// }
// 
// foreach(char letter in listPhrase)
// {
//     Console.Write($"{letter}");
// }
// Console.WriteLine();
// 
// Console.Write(listPhrase.IndexOf('z'));
// Console.WriteLine();

/*
Console.Clear();
int x = 0;
int y = 0;
int cx = 0;
int cy = 0;
int mazePoints = 0;
string[] mazeLines = File.ReadAllLines("maze1.txt");


foreach(string line in mazeLines)
{
    Console.WriteLine(line);
}

char[][] mazeChar = mazeLines.Select(item => item.ToArray()).ToArray();

Console.SetCursorPosition(x,y);

do
{
    var keyPressed = Console.ReadKey(true).Key;
    if(keyPressed == ConsoleKey.W)
    {
        if(tryMove(x, y, "n", mazeChar) == true)
        {
            y --;
        }
        
    }else if(keyPressed == ConsoleKey.S)
    {    
        if(tryMove(x, y, "s", mazeChar) == true)
        {
            y ++;
        }
    }else if(keyPressed == ConsoleKey.A)
    {     
        if(tryMove(x, y, "e", mazeChar) == true)
        {
            x--;   
        }
    }else if (keyPressed == ConsoleKey.D)
    {    
        if(tryMove(x, y, "w", mazeChar) == true)
        {
            x++;
        }
    }
    Console.SetCursorPosition(x,y);

    //Move each '%' in the maze
    for(int i = 0; i<mazeChar.Length; i++)
    {
        for(int j = 0; j<mazeChar[i].Length; j++)
        {   
            if(mazeChar[i][j] == '%')
            {

            }
        }
    }

    if(mazeChar[y][x] == '^')
    {
        //listMaze[x][y].Replace("^", " ");
        mazeChar[y][x] = ' ';
        Console.Write(" ");
        mazePoints = mazePoints + 10;
        Console.SetCursorPosition(0,21);
        Console.WriteLine($"Your score is {mazePoints}");
        Console.SetCursorPosition(x,y);
    }

    if(mazeChar[y][x] == '$')
    {
        mazeChar[y][x] = ' ';
        Console.Write(" ");
        mazePoints = mazePoints + 20;
        Console.SetCursorPosition(0,21);
        Console.WriteLine($"Your score is {mazePoints}");
        Console.SetCursorPosition(x,y);
    }

    if(mazeChar[y][x] == '&')
    {
        mazeChar[y][x] = ' ';
        Console.Write(" ");
        mazePoints = mazePoints + 30;
        Console.SetCursorPosition(0,21);
        Console.WriteLine($"Your score is {mazePoints}");
        Console.SetCursorPosition(x,y);    
    }

    string testString = "";
    foreach(char[] symbol in mazeChar)
    {
        foreach(char sym in symbol)
        {
            testString = testString + sym;
        }
    }

    if(testString.Contains('^') == false)
    {
        for(int i = 0; i<mazeChar.Count(); i++)
        {
            //Console.Write($"{mazeChar[i][0]}");
            for(int j = 0; j<mazeChar[i].Count(); j++)
            {
                if(mazeChar[i][j] == '|')
                {
                    mazeChar[i][j] = ' ';
                    Console.SetCursorPosition(j,i);
                    Console.Write(" ");
                }
            }
        }
        Console.SetCursorPosition(x,y);
    }

    if(testString.Contains('$') == false)
    {
        for(int i = 0; i<mazeChar.Count(); i++)
        {
            //Console.Write($"{mazeChar[i][0]}");
            for(int j = 0; j<mazeChar[i].Count(); j++)
            {
                if(mazeChar[i][j] == '-')
                {
                    mazeChar[i][j] = ' ';
                    Console.SetCursorPosition(j,i);
                    Console.Write(" ");
                }
            }
        }
    Console.SetCursorPosition(x,y);
    }

    if(testString.Contains('&') == false)
    {
        for(int i = 0; i<mazeChar.Count(); i++)
        {
            //Console.Write($"{mazeChar[i][0]}");
            for(int j = 0; j<mazeChar[i].Count(); j++)
            {
                if(mazeChar[i][j] == '=')
                {
                    mazeChar[i][j] = ' ';
                    Console.SetCursorPosition(j,i);
                    Console.Write(" ");
                }
            }
        }
    Console.SetCursorPosition(x,y);
    }

    if(mazeChar[y][x] == '#')
    {
        break;
    }
}while(true);

bool tryMove(int x, int y, string direction, char[][] maze)
{
    //mazeChar[y][x+1] == '|'
    if(direction == "w")
    {
        if(x+1 > mazeChar[y].Length || mazeChar[y][x+1] == '*' || mazeChar[y][x+1] == '|' || mazeChar[y][x+1] == '-' || mazeChar[y][x+1] == '=')
        {
            return false;
        }else 
        {
            return true;
        }
    }else if(direction == "e")
    {
        if(x-1 < 0 || mazeChar[y][x-1] == '*' || mazeChar[y][x-1] == '|' || mazeChar[y][x-1] == '-' || mazeChar[y][x-1] == '=')
        {
            return false;
        }else
        {
            return true;
        }
    }else if(direction == "s")
    { 
        if(y+1 > mazeChar.Count() || mazeChar[y+1][x] == '*' || mazeChar[y+1][x] == '|' || mazeChar[y+1][x] == '-' || mazeChar[y+1][x] == '=')
        {
            return false;
        }else 
        {
            return true;
        }
    }else if (direction == "n")
    {
        if (y-1 < 0 || mazeChar[y-1][x] == '*' || mazeChar[y-1][x] == '|' || mazeChar[y-1][x] == '-' || mazeChar[y-1][x] == '=')
        {
            return false;
        }else 
        {
            return true;
        }
    }else 
    {
        return false;
    }
}
*/