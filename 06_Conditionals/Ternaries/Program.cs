using System;

Console.WriteLine("Enter Your Age: ");

string response = System.Console.ReadLine();
int age = int.Parse(response);

string output = age >= 18 ? "You can vote" : "You are too young, young person";

System.Console.WriteLine(output);

if(age >= 18)
{
    output = "You can vote";
}
else{
    output = "You can't vote, stupid";
}
System.Console.WriteLine("output");