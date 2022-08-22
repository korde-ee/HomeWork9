// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

void ShowNumsV(int m, int n)
{
    if (m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }
    if(n != m) ShowNumsV(m, n - 1);

    Console.Write(n + " ");
}
/*
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNumsV(m, n);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int SumNums(int m, int n)
{
    if(n != m) return n + SumNums(m, n - 1);
    return n;
}
/*
Console.Write("Введите число M: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int result = SumNums(m1, n1);
Console.WriteLine($"Сумма элементов {m1} - {n1} равна {result}");
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

int Akkerman(int n, int m)
{
    if(n == 0) return m + 1;
    else
        if((n != 0) && (m == 0))
            return Akkerman(n - 1, 1);
        else
            return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.Write("Введите число M: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int result = Akkerman(m1, n1);
Console.WriteLine($"Функция Аккермана для чисел {m1} и {n1} равна {result}");