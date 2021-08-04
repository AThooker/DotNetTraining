using System;

string instructorName = "Austin";
string[] instructors = new string[] {"Mike", "Amanada", "Josh", instructorName};

foreach(var name in instructors)
{
    System.Console.WriteLine(name);
}

int[] nums = new int[] {1,2,-3,4,5,6};

foreach(var number in nums)
{
    if(number > 0)
    {
        System.Console.WriteLine("positive");
    }
    else
    {
        System.Console.WriteLine("neg");
    }
}