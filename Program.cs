// Создаем двумерный рандомный массив
int[,] CreateRandom2DArray(int rows, int cols, int min, int max){
    int[,] array = new int[rows, cols];
    for(int i = 0 ; i <rows; i++){
        for(int j = 0; j<cols; j++){
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}

// Выводим двумерный массив в консоль
void Show2dArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {   Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    }
}









// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// сортировка пузырьком 
void BSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
}

//заменяем значения в стоке или столбце исходного массива на отсортированные значения
void Insert(bool isRow, int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
            dest[dim, k] = source[k];
        else
            dest[k, dim] = source[k];
    }
}

Console.Write("Введите количество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимального элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число максимального элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2DArray(rowCount, colCount, min, max);
Show2dArray(array);
Console.WriteLine();
Console.WriteLine("Сортировка по строкам:");
int[] row = new int[colCount];
for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < colCount; j++)
        row[j] = array[i, j];
    BSort(row);
    Insert(true, i, row, array);
}
Show2dArray(array);








// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

 /* 
int[] MinSummInRow(int[,] array){
    int[] summ = new int[array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {  
            for (int k = 0; k < array.GetLength(0); k++)
            {   
                if (i == k)
                {  
                    summ[k] = summ[k] + array[i,j];
                  
                    if(j == array.GetLength(0)-1){     
                        Console.WriteLine("Сумма = "+summ[k]+"  "+k+" строка");
                           
                    }
                }
            }
        }
    }
    return summ;
}

void MinEL(int[] array){
    int minElement = array[0];
    int stroka = 0;
        for (int i = 0; i <= array.Length-1; i++) {
            if (array[i] <= minElement){
                minElement = array[i];   //минимальный элемент
                stroka = i;  // номер строки в которой он  
                
            }
        } 
    Console.WriteLine($"Минимальная сумма {minElement} находится в {stroka} строке ");
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
if (rows < cols)
{
    Console.Write("Введите значение минимального элемента: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число максимального элемента: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = CreateRandom2DArray(rows, cols, min, max);
    Show2dArray(array); 
    Console.WriteLine();
    int[] minnn = MinSummInRow(array);
    Console.WriteLine();
    MinEL(minnn);
    
}
else
{
    Console.WriteLine("Введён не прямоугольный двумерный массив!");
}

  */









// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07