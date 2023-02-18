// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число");
string inputValue1 = System.Console.ReadLine();

System.Console.WriteLine("Введите второе число");
string inputValue2 = System.Console.ReadLine();

int value1 = Convert.ToInt32(inputValue1);
int value2 = Convert.ToInt32(inputValue2);

if (value1 > value2)
{
    System.Console.WriteLine($"Число {value1} больше {value2}");
}
else
{
    System.Console.WriteLine($"Число {value2} больше {value1}");
}
