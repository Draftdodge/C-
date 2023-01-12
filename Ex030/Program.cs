// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] array = new int[8];
//int[] array1 = new int[8]{1,3,4,5,6,7,8,9};
//int[] array1 = new int[]{1,3,4,5,6,7,8,9};
//int[] array1 = new []{1,3,4,5,6,7,8,9};
//int[] array1 = {1,3,4,5,6,7,8,9};

FillArray(array);

OutArray(array);


void FillArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next(0, 2);
    }
}


void OutArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }

}