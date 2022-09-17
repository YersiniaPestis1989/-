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
