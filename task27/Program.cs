// Задача 27
// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

Console.Clear();
int sum = 0;
System.Console.Write("введите число:");
string num = Console.ReadLine();
for (int i = 0; i < num.Length; i++)
{
    string line;
    line = Convert.ToString(num[i]);
    int number = Convert.ToInt32(line);
    sum += number;
}
System.Console.WriteLine("сумма равна: "  + sum);
