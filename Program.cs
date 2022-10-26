//Angelica Ayala
//Date Revised: 10/24/2022
//Mini Challenge #4: Greater Than Or Less Than
//----------Description--------
//Declared a data type and variable
//Created an output asking for a number
//Created a user input that will convert into an interger
//Created another output asking for number 2
//Created another user input that will conver into an interger
//Created an "if" statement that will show if number 1 is greater than, less than or equal to number 2
//Created an "if" statement that will show if number 2 is greater than, less than or equal to number 1

// Peer reviewed by: Saul Suazo
//Date:10/25/22
//Review: Code works!

int num1;
int num2;

Console.WriteLine("Enter a number");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
num2 =Convert.ToInt32(Console.ReadLine());

if(num1==num2)
{
    Console.WriteLine("It is a draw.");
}
else if(num1>num2)
{
    Console.WriteLine($"{num1} is greater than {num2}.");
}
else
{
    Console.WriteLine($"{num1} is less than {num2}.");
}

if(num2==num1)
{
    Console.WriteLine("It is a draw.");
}
else if(num2>num1)
{
    Console.WriteLine($"{num2} is greater than {num1}.");
}
else
{
    Console.WriteLine($"{num2} is less than {num1}.");
}



 