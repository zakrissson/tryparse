using System;

/*string n = "3";

int m = 4;

int r = n + m;

int y;
if (n=="3")
{
    y=3;
}

Console.WriteLine(r);

Console.ReadLine();*/
int age = 0;
bool success = false;

while (success != true)
{
System.Console.WriteLine("Your age:");
string input = Console.ReadLine();

//int age = int.Parse(input);

success = int.TryParse(input, out age);
}

if (success == true)
{
   if (age < 18)
{
    System.Console.WriteLine("Du får inte ta körkort");
}
else
{
    System.Console.WriteLine("Du får ta körkort");
}

Console.ReadLine(); 
}

