// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
 Console.WriteLine("Введите 5-ти значное число: ");
 int x=Convert.ToInt32(Console.ReadLine());

// определяем длину числа
int Len(int arg1)
{
 int i = 2;
    while ((arg1 / 10) > 1)
    {
        arg1 = arg1 / 10;
        i++;
    }
    int len = i;
    return len;  
}
int lenNum=Len(x);

Console.WriteLine($"Количество цифр в числе {lenNum}"); 

 int[] arrRev = new int[lenNum];
 int[] arr = new int[lenNum];
 int[] mass1 = new int[lenNum];
int [] CreateFillArr(int x, int lenNum)
{  
    for (int z = lenNum-1; z >=0; z--)   
    {
        arr[z] = x % 10;
        x = x / 10;
       Console.Write($"{arr[z]} ");      
    }
    return arr;
}
int [] mass=CreateFillArr(x, lenNum);
Console.WriteLine();
int [] FillArrRev(int x, int lenNum)
{    
  for (int i =lenNum-1; i>=0 ;i--)   
    {     
       mass1[i] = mass[lenNum-i-1];             
      Console.Write($"{mass1[i]} ");      
    }
    return arrRev;
}
int [] massRev=FillArrRev(x, lenNum);
Console.WriteLine();

bool flag=false;

for(int k=0; k<lenNum/2; k++)
{
  if (mass[k] == mass1[k]) flag=true;
  else flag=false;
}
if (flag==true)
{
    Console.WriteLine("Данное число является полиндромом");
}
else Console.WriteLine("Данное число не является полиндромом");