// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] ArrayGenerator(){                                               // генерация массива
    Random random = new Random();
    int[,] array = new int[random.Next(2,6), random.Next(2,6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(100);
        }
    }
    return array;
}

double[] MeanOfColumns(int[,] array){                               // нахождение средних значений столбцов
    double[] mean = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            mean[j] += array[i,j];
        }
    }

    for (int i = 0; i < mean.Length; i++)
    {
        mean[i] = mean[i]/(array.GetLength(0));
    }

    return mean;
}

void PrintArray (int[,] array1, double[] meanArray) {             // вывод значений
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            System.Console.Write($"{array1[i,j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", meanArray)}");
}

int[,] newArray = ArrayGenerator();
double[] meanArray = MeanOfColumns(newArray);
PrintArray(newArray, meanArray);