//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine ("Введите число:   ");
int Number = Convert.ToInt32 (Console.ReadLine());

if ((Number < 10000) || (Number > 100000)) 
{
    Console.WriteLine ("Не является пятизначным числом");
}

else
{
    int P = Number % 10;
    Console.WriteLine ("Первая цифра с конца числа:   " + P);
    int L = (Number / 10000) % 10;
    Console.WriteLine ("Первая цифра с начала числа:  " + L);
    int PTwo = (Number % 100) / 10;
    Console.WriteLine ("Вторая цифра с конца числа:   " + PTwo);
    int LTwo = (Number / 1000) % 10;
    Console.WriteLine ("Вторая цифра с начала числа:  " + LTwo);
    if ((P == L) && (PTwo == LTwo)) 
    {
        Console.WriteLine ("Является палиндромом");
    }

    else
    {
        Console.WriteLine ("Не является палиндромом");
    } 
    
}