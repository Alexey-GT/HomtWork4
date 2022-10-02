/*
//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число А в натуральную степень В
Console.Clear();
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите натуральную степень числа ");
int b = Math.Abs(int.Parse(Console.ReadLine()!));
int a_Pow_b = FuncPow(a, b);
Console.WriteLine($"{a_Pow_b}");

int FuncPow(int a, int b)
{
    int c = a;
    for (int i=1; i<b; i++)
    {
        c = c * a;
    }
    return c;
}*/


/*
//Напишите программу, которая принимает на вход число 
//и выдает сумму цифр в числе
Console.Clear();
Console.WriteLine("Введите целое число ");
int num = Math.Abs(int.Parse(Console.ReadLine()!));
int sum = FuncSum(num);
Console.WriteLine($"{sum}");

int FuncSum(int n)
{
    int s = 0;
    while (n != 0)
    {
        s = s + n%10;
        n = n /10;
    }
    return s;
}*/


/*
//Напишите программу, которая задает массив из 8 элементов
//и выводит их на экран
Console.Clear();
int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i=0; i<array.Length; i++)
    {
        array[i] = rand.Next();
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
    {
       Console.Write(array[i]);
       if (i == array.Length-1)
       {
            Console.Write("]");
       }
       else
       {
            Console.Write(", ");
       }
    }
}*/