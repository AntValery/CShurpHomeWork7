/*Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или 
же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] CreateArray(){
    int[,] array = new int[new Random().Next(3,6),
                           new Random().Next(3,6)];

    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            array[i,j] = new Random().Next(-100, 100);
        }
    }

    return array;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} "); 
        }
        Console.WriteLine();
    }
}

void GetElement(int[,] array){
    int str = Convert.ToInt32(Console.ReadLine());
    int column = Convert.ToInt32(Console.ReadLine());

    if (str >= array.GetLength(0) || str < 0 | 
    column >= array.GetLength(1) || column < 0) 
    Console.WriteLine("такого числа в массиве нет");
    else Console.WriteLine(array[str,column]);
}

int[,] array = CreateArray(); 
PrintArray(array);
GetElement(array);