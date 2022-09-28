// Программа, которая выводит массив из 8 элементов, заполненный 0 и 1 в случ. порядке.
// [0,1,0,1,1,1,0,0]
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int [] array = new int [8]; // создание массива 
FillArray(array);
PrintArray(array);


// int [] array = new int [8]; - программа без методов
// for (int i = 0; i < array.Length; i++)  - программа без методов
// {
//     array[i] = new Random().Next(0,2); - программа без методов
//     Console.Write(array[i] + " ");  - программа без методов
// }
