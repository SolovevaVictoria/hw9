// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void print_n_1(int n){
//     if (n == 0) return;
//     System.Console.Write($"{n} ");
//     print_n_1(n - 1); 
// }

// print_n_1(15);



// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int sum_m_n(int m, int n){
//     if (m > n) return 0;
//     return m + sum_m_n(m + 1, n);
// }


// System.Console.WriteLine(sum_m_n(1, 15));
// System.Console.WriteLine(sum_m_n(4, 8));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int A(int m, int n){
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return A(m - 1, 1);
    return A(m - 1, A(m, n - 1));
}


System.Console.WriteLine(A(2, 3));
System.Console.WriteLine(A(3, 2));
System.Console.WriteLine("Введите m и n");
System.Console.WriteLine($"Значение функции: {A(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()))}");