// Задача 21

// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53  

// Console.WriteLine("Введите размерность пространства: ");
// int n = Convert.ToInt32(Console.ReadLine());
int i = 0;


int n=2;
int[] arrayA = new int[n]; //массив с точки А
int[] arrayB = new int[n]; //массив с точки B


Console.WriteLine("Введите координаты точки A: ");
for (i = 0; i < n; i++)
{
    arrayA[i] = Convert.ToInt32(Console.ReadLine());

}
Console.Write("Вывод введенных координат точки А ( ");
for (i = 0; i < n; i++)
    Console.Write(arrayA[i] + ", ");
Console.WriteLine(" )");

Console.WriteLine("Введите координаты точки B: ");
for (i = 0; i < n; i++)
{
    arrayB[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Вывод введенных координат точки B ( ");

for (i = 0; i < n; i++)
    Console.Write(arrayB[i] + " ");
Console.Write(")");

// Находим расстояние между точками в n мерном пространстве

 double res=0; 
 for (int j=0; j<n; j++)
 {
     res=res+Math.Pow((arrayA[j]-arrayB[j]),2);    
 }

double distance = Math.Sqrt(res); 
Console.WriteLine($"Расстояние между точками в n-мерном пространстве {distance}");