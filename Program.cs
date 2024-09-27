/*      x=-1 x=0 x=1
y=-1    NW    N   NE
y=0     W     T    E
y=1    SW    S   SE  
*/
Console.Clear();
Console.WriteLine("Please give a X value between -1 and 1.");
int x = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Please give a Y value between -1 and 1.");
int y = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if(x == 0 && y == 0){
    Console.WriteLine("The enemy is here!");
}else if(x == -1 && y == -1 ) {
    Console.WriteLine("The enemy is NorthWest");
}else if(x == -1 && y == 0){
    Console.WriteLine("The enemy is West");
}else if(x == -1 && y == 1){
    Console.WriteLine("The enemy is SouthWest");
}else if (x == 0 && y == -1){
    Console.WriteLine("The enemy is North");
}else if (x == 0 && y == 1){
    Console.WriteLine("The enemy is South");
}else if (x == 1 && y == -1){
    Console.WriteLine("The enemy is NorthEast");
}else if (x == 1 && y == 0){
    Console.WriteLine("The enemy is East");
}else if (x == 1 && y == 1){
    Console.WriteLine("The enemy is SouthEast");
}else {
    Console.WriteLine("One or more of your values are out of range");
}