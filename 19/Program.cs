// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine()!);
int res=Natural(num1,num2);
System.Console.WriteLine("Результат возведения в степень второго числа:" + res);
System.Console.Write("Для продолжения нажмите любую клавишу: ");
Console.ReadKey();
//Функция:
int Natural (int a, int b)
{
int res = Convert.ToInt32(Math.Pow(a, b));
return res;
}