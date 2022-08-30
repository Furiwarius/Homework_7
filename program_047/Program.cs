// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
int m = 3;
int n = 4;

double [,] newArray = new double[m,n];

double[,] Filling(double[,] array){
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            array[i,j] = Convert.ToDouble(random.Next(-1000,1000)/10.0);
        }
    }

    return array;
}

void PrintArray(double[,]array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}


Filling(newArray);
PrintArray(newArray);
