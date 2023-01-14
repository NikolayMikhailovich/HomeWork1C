//# Написать программу которая на вход принимает 2 числа и показывает большее

Console.Write("Введите первое число > ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число > ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
  Console.Write("Первое число больше второго");

}
else if (number1 < number2)
  {
    Console.Write("Второе число больше первого");
  }
