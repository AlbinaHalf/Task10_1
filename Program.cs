// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

Console.WriteLine("Etner the number");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number < 10)
{
   Console.WriteLine("There is no second digit"); 
}
else
{
    string number1 = number.ToString();
    Console.WriteLine(number1[1]);
}