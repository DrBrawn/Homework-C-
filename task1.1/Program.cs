// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(System.Console.ReadLine());
}

int value1 = Prompt("Введите первое число");
int value2 = Prompt("Введите второе число");

if (value1 > value2)
    System.Console.WriteLine($"Число {value1} больше {value2}");
    
else
    System.Console.WriteLine($"Число {value2} больше {value1}");
