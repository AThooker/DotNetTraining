using System;

string first = "The cars we sell are ";
string second = "BMW, Lexus, and Mercedes.";

string concatenatedResult = first + "" + second;

Console.WriteLine(concatenatedResult);

string firstName = "Jenn";
string lastName = "Williams";

string compositeResult = string.Format("Her name is {0} {1}", firstName, lastName);

System.Console.WriteLine(compositeResult);
System.Console.WriteLine("{0} {1}", firstName, lastName);
