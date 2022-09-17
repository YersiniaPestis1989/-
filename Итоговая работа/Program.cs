// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.Write("Введите количество элементов массива ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Clear();
string[] massive = new string[lenght];
FillArray(massive);
PrintArray(massive);
int count = 0;
  for (int i = 0; i < lenght; i++)
    {
      if (massive[i].Length <= 3)
                    count++;
    }
Console.WriteLine("Чисел в массиве, удовлетворяющих условию, всего: " + count);
string[] massive2 = new string[count];
SecondArrayWithIF(massive, massive2);
PrintArray(massive2);
void FillArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Введите элемент массива ");
                    array[i] = Console.ReadLine();
                }
                Console.Clear();
            }
void PrintArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
// void CreateNewArray(string[] array, string[] array2)
// {
//  int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//     if(array[i].Length <= 3)
//         {
//         array2[count] = array[i];
//         count++;
//         }
//     else
//     {
//      (Convert.ToInt32(array2[count])) = 0;
//      count++;
//     }    
//     }
// }
// void PrintArray2(string[] array)
// {
//  for (int i = 0; i < array.Length; i++)
//  {
//     if((Convert.ToInt32(array[i]))!= 0)
//      Console.Write($"{array[i]} ");
//  }
//   Console.WriteLine();
//   }
// void CreateNewArray(string[] array)
// {
//  string[] array2 = new string[array.Length];;   
//  int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//     if(array[i].Length <= 3)
//         {
//         array2[count] = array[i];
//         Console.Write($"{array[i]} ");
//         count++;
//         }
//     }
// }