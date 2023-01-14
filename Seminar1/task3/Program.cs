// Написать программу котораяна вход принимает число и выдает является ли число четным

Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
  Console.WriteLine("число четное");
}
else
{
  Console.WriteLine("Число нечетное");
}