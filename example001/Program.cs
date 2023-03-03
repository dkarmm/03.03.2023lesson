// Задача1: Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

// Создание матрицы. 
//     Размер зависит от пользователя.
// Заполнение рандом целыми.
// Вывод.
// Замена.


int GetSizeFromUser(string messageForUser)
{
    Console.Write(messageForUser);
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }

}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}



int[,] SwapLinesMatrix(int[,] matrix)
{
    int[,] temp = matrix;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp[0, i] = matrix[matrix.GetLength(0) - 1, i];
    }
        for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp[matrix.GetLength(0) - 1, i] = matrix[0, i];
    }
    return temp;
}

int lines = GetSizeFromUser("Введите количество строк: ");
int colums = GetSizeFromUser("Введите количество столбцов: ");
if (lines <= 0 || colums <= 0)
{
    Console.WriteLine("Массив не является двумерным.");
    return;
}
int[,] matrix = new int[lines, colums];

FillMatrix(matrix);
ShowMatrix(matrix);
int[,] result = SwapLinesMatrix(matrix);
Console.WriteLine();
ShowMatrix(result);
