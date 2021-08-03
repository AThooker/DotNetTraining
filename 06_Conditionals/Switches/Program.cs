using System;

System.Console.WriteLine("How you feelin' yo? 1-5: ");
string theFeels = Console.ReadLine();

switch(theFeels)
{
    case "5":
    System.Console.WriteLine("Lucky");
    break;

    case "4":
    System.Console.WriteLine("Not quite");
    break;

    case "3":
    System.Console.WriteLine("Seen better days huh?");
    break;

    case "2":
    System.Console.WriteLine("Oh no");
    break;

    case "1":
    System.Console.WriteLine("Try again tomorrow");
    break;
    
    default:
    System.Console.WriteLine("I said 1-5 you goon");
    break;
}

System.Console.WriteLine("Whats yo nombre?");
string nm = Console.ReadLine();
var greeting = nm switch
{
    "Austin" => "Hey guy", "Carl" => "Hey Other guy", _ => "Who you be?"
};

System.Console.WriteLine(greeting);
