// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int[,] ArrayGenerator(){
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

void ValueCheck(int[,] array, int value){
    int check = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == value) check=value;
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
    if (check !=0) System.Console.WriteLine(check);
    else  System.Console.WriteLine($"{value} -> такого числа в массиве нет");
}

int[,] newArray = ArrayGenerator();

System.Console.Write("Введите число - ");
int value1 = int.Parse(System.Console.ReadLine());

ValueCheck(newArray, value1);