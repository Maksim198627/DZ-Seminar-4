// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
System.Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine()!);
int result= Summ(num);
System.Console.WriteLine("Сумма всех чисел введенного числа: " + result);
System.Console.Write("Для продолжения нажмите: ");
Console.ReadKey();

//Функция:
int Summ (int a)
{
int sum=0;
int count = a.ToString().Length;
for (int i= 0; i < count; i++)
{
    int curr = a % 10;
    a /= 10;
    sum += curr;
}
return sum;
}

System.Console.Write("Для продолжения нажмите любую клавишу: ");
Console.ReadKey();
