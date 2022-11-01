//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Введите число:   ");
int N = Convert.ToInt32 (Console.ReadLine());
int Tablica = 0;

while (N > 0)
{
    Tablica = N*N*N;
    Console.Write (Tablica + "  ");
    N = N - 1;
}

