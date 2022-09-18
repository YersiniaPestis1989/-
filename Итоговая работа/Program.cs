

Console.Write("Введите количество элементов массива ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Clear();
string[] massive = new string[lenght];
FillArray(massive);
PrintArray(massive);
PrintWithIF(massive);

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
void PrintWithIF(string[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        Console.Write($"{array1[i]} ");
        count++;
        }
    }
}
