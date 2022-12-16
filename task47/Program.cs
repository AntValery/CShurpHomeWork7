/*Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/ 

double GetRandomNumber(double minimum, double maximum)
{ 
    Random random = new Random();
    return Math.Round((random.NextDouble() * (maximum - minimum) + minimum), 2);
}

void FillArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            array[i,j] = GetRandomNumber(-100, 100);
        }
    }
}

void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} "); 
        }
        Console.WriteLine();
    }
}

double[,] array = new double[3,4];
FillArray(array);
PrintArray(array);