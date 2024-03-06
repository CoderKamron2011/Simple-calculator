

int number ,number_2;
System.Console.Write("Enter first number: ");
number = int.Parse(Console.ReadLine());
System.Console.Write("Enter first number: ");
number_2 = int.Parse(Console.ReadLine());
string amal;
System.Console.Write("amalni kiriting: ");
amal = Console.ReadLine();
number = ((int)number);

//business logic
if (amal == "+")
{
    System.Console.WriteLine(number + number_2);
}
else if (amal == "-")
{
    System.Console.WriteLine(number - number_2);
}
else if (amal == "*")
{
    System.Console.WriteLine(number * number_2);
}
else if (amal == "/")
{
    System.Console.WriteLine(number / number_2);
}

