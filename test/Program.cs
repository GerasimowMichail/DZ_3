 Console.WriteLine("Введите число: ");
 int x=Convert.ToInt32(Console.ReadLine());
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

  int[] arr = new int[lenNum];
  int[] arr1 = new int[lenNum];
  int [] mass1= new int[lenNum];

int [] CreateFillArr(int x, int lenNun)
{
 Console.Write("Массив: ");
    for (int z = (lenNum-1); z>=0; z--)   
    {     
        arr[z] = x % 10;
        x = x / 10;
       Console.Write($"{arr[z]} ");    
      }
      return arr;    
}  
int [] mass=CreateFillArr(x, lenNum);
Console.WriteLine();
// int [] mass1 = new int [lenNum];

Console.Write("Перевернутый ");

 Console.Write("Массив ");
    for (int i =lenNum-1; i>0 ;i--)   
    {     
       mass1[i] = mass[lenNum-i-1];             
      Console.Write($"{mass1[i]} ");      
    }

// bool flag=false;

// for(int i=0;  i=((lenNum-1)/2); i++)
// {
//     if (mass[i]== mass1[i]) flag=true;
   
// }
// if (flag==true)
// {
//     Console.WriteLine("Полиндром");
// }