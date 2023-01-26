// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

// -------------Метод---заполнения массива----------------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
// метод вывода массива на экран
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты. Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть вот так:
1 4 49 2
5 9 2 9
64 4 4 4

//Задача 49:
int[,] array = GetArray(3, 4, 1, 10);
PrintArray(array);
Console.WriteLine();
ReplaceArray(array);
Console.WriteLine();
PrintArray(array);
//-------------------------------------------------------

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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

void ReplaceArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if(i % 2 == 0 && j % 2 == 0){
                array[i, j] *= array[i, j];
            }
        }       
    }
}





//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//Сумма элементов главной диагонали: 1+9+2 = 12

Задача 51:
int[,] array = GetArray(3, 4, 1, 10);
int summ = SumElArray(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали ==> {summ}");
//-------------------------------------------------------

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

int SumElArray(int[,] array){
    int summ = 0;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if(i == j){
                summ += array[i, j];
            }
        }
    }
    return summ;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}




//**Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.
//---пример---
// m = 3, n = 4.

// 0 1 2 3

// 1 2 3 4

// 2 3 4 5

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetSum(rows, columns);
// PrintArray(array);


// // -------------Метод----------------------------
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetSum(int m, int n){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = i + j;
//         }
//     }
//     return result;
// }


//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 49 2
// 5 9 2 9
// 64 4 4 4

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// int[,] array2 = GetEvenIndexSquare(array);
// Console.WriteLine();
// PrintArray(array2);

// // -------------Метод----------------------------
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetEvenIndexSquare (int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             if(i % 2 == 0 && j % 2 == 0){
//             array[i,j]=array[i,j]*array[i,j];
//             }    
//         }
//     }
//     return array;
// }

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine($"Сумма элементов на главной диаганали равна {GetMianDiagonalSum(array)}");

// // -------------Метод----------------------------
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.Get
// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int GetMianDiagonalSum (int[,] array){
//     int result = 0;
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             if(i==j) {
//             result = result + array[i,j];
//             }    
//         }
//     }
//     return result;
// }