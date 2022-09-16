// Задача 47
// Console.WriteLine("Введите количество строк массива");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива");
// int n = Convert.ToInt32(Console.ReadLine());

//FillArray(m, n);

// void FillArray(int line, int column)
// {
//     double[,] array = new double[m, n];

//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(random.Next(-100, 100) / 10.0);
//             Console.Write($"{array[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 50

// Random random = new Random();
// int[,] array = new int[3, 4];
// Console.WriteLine("Введите поисковое число");
// int search = Convert.ToInt32(Console.ReadLine());

// string result = string.Empty;

// SearchCount(search);
// void SearchCount(int count)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToInt32(random.Next(1, 10));
//             Console.Write($"{array[i, j]} ");
//             if (array[i, j] == count)
//             {
//                 result = ($"Число находится на строке {i + 1} столбце {j + 1}");
//             }
//             else result = "Данного числа в массиве нет";
//         }
//         Console.WriteLine();
//     };
//     Console.WriteLine(result);
// }


// Задача 52

int[,] array = new int[3, 3];
int column1 = 0;
int column2 = 0;
int column3 = 0;

Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Convert.ToInt32(random.Next(1, 10));
        Console.Write($"{array[i, j]} ");
        if (j == 0) column1 += array[i, j];
        else if (j == 1) column2 += array[i, j];
        else if (j == 2) column3 += array[i, j];
    }
    Console.WriteLine();
}


Console.WriteLine();
Console.WriteLine($"Среднее арифметическое первого столбца: {Average(column1)}");
Console.WriteLine($"Среднее арифметическое второго столбца: {Average(column2)}");
Console.WriteLine($"Среднее арифметическое третьего столбца: {Average(column3)}");



double Average(int column)
{
    double average = Math.Round(((column/30.0) * 10.0), 1);
    return average;
}