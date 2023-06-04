// ____________________________Задача 25___________________________
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.WriteLine("Введите число А");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число B");
// int num2=Convert.ToInt32(Console.ReadLine());

// int result=num1;
// int count=1;
// while (num2>count)
// {
//     result=result*num1;
//     count++;
// }
// Console.WriteLine("Ответ:");
//  Console.WriteLine(result);


// ______________________________Задача 27______________________________________________
//  Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());

// int sum=0;

// while (num>0)
// {
//     int x=num%10;
//     num=num/10;
//     sum=sum+x;
// }
// Console.WriteLine(sum);


// ____________________________Задача 29__________________________________________________
// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void CreateArray()
{
    int[] arr = new int[8];
    int count = 0;
    while(count < arr.Length)
    {
        arr [count] = new Random().Next(0,100);
        Console.Write($"{arr[count]},");
        count++;
    }
    
}
Console.Write ("[");
CreateArray();
Console.Write("]");
