// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число");
string inputValue1 = System.Console.ReadLine();

System.Console.WriteLine("Введите второе число");
string inputValue2 = System.Console.ReadLine();

System.Console.WriteLine("Введите третье число");
string inputValue3 = System.Console.ReadLine();

int value1 = Convert.ToInt32(inputValue1);
int value2 = Convert.ToInt32(inputValue2);
int value3 = Convert.ToInt32(inputValue3);

int max = value1;
if (max < value2)
    max = value2;
if (max < value3)
    max = value3;

System.Console.WriteLine($"Число {max} максимальное");