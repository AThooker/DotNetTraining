using System;

bool isRaining = true;
bool isGoingOutside = false;

if(isRaining)
{
    System.Console.WriteLine("Tis raining");
}

if(isRaining ^ isGoingOutside)
{
    System.Console.WriteLine("I will only go outside if it is not raining");
}
else{
    System.Console.WriteLine("These can't both happen with XoR");
}

System.Console.WriteLine("How are you feeling today skip?: scale of 1-5:");

int input = Int32.Parse(Console.ReadLine());

if(input == 1)
{
    System.Console.WriteLine("Dang, hope your day gets better");
}
else if(input > 1 && input < 5)
{
    System.Console.WriteLine("Could be better, could be worse");
}
else
{
    System.Console.WriteLine("Good for you skip");
}