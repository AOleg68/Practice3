//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Введите координату X первой точки:   ");
int X1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите координату Y первой точки:   ");
int Y1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите координату Z первой точки:   ");
int Z1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите координату X второй точки:   ");
int X2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите координату Y второй точки:   ");
int Y2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите координату Z второй точки:   ");
int Z2 = Convert.ToInt32 (Console.ReadLine());

int A = X2 - X1;
int B = Y2 - Y1;
int C = Z2 - Z1;

double Rasstoyanie = Math.Sqrt(A*A + B*B + C*C);

Console.WriteLine (Rasstoyanie);




