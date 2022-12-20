// See https://aka.ms/new-console-template for more information

      
   //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.  

// Метод создания массива

 int[] CreateArray(int count)
 {
    return new int[count];
 }

 // Метод заполнения массива
 
 
  void Fill(int[]array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
       // Next() - заполнение случайными неотрицательными числами
        array[index] = int.Parse(Console.ReadLine());
        
        index ++; 
    }
} 



// // Печать массива
  string Print(int[]array)
{
    return String.Join(' ', array);
} 
// // Определение количества  чисел, больше 0 в массиве
    int count(int[]array)
   {
   int count = 0;
   int length = array.Length;
   
   for (int i = 0; i < length; i++)
   {
     if (array[i]> 0)
     count = count+1;
     
   }
     return count;
   }

//string? M_str = Console.ReadLine();
//int M = Convert.ToInt32(M_str);
int M = int.Parse(Console.ReadLine());


        int[]array = CreateArray(M);
        Fill(array);
        string array_text = Print(array);
        int numbercount = count(array);
        Console.WriteLine(array_text);
        Console.WriteLine(numbercount);
