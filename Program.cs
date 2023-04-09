

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число");
int a = Convert.ToInt32(Console.ReadLine());

void Number(int a)

{
    if (a < 0) Console.WriteLine($"{a} не натуральное число");
    if (a == 0) return;
    Console.Write("{0,4}", a);
    Number(a - 1);
}

Number(a);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.WriteLine("Введите значение M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение N");
// int n = Convert.ToInt32(Console.ReadLine());

// void Summa(int m, int n, int sum)
// {
//     if (m > n)
//     {
//         Console.Write($"Сумма натуральных элементов в промежутке от M до N : {sum}");
//         return;
//     }
//     sum = sum + (m++);
//     Summa(m, n, sum);
// }
// Summa(m, n, 0);


// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



// Console.WriteLine("Введите число M ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());

// int Akkerman = Akk(m, n);

// Console.Write($" Функция Аккермана = {Akkerman}");

// int Akk(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return Akk(m - 1, 1);
//     else return Akk(m - 1, Akk(m, n - 1));
// }

// return Akk(m, n);


// Console.Write($"Функция Аккермана для чисел A({m},{n}) = {Akk(m, n)}");