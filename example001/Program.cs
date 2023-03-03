int GetValueFromUser(string messageForUser)
{
  int value = 0;
  bool flag = false;

  while (!flag)
  {
    Console.Write(messageForUser);
    flag = int.TryParse(Console.ReadLine(), out value);
  }

  return value;
}

void FillMatrix(int[,] matrix, int min, int max)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = new Random().Next(min, max);
    }
  }
}

string JoinMatrix(int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);

  string result = String.Empty; // ""
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      result += $"{matrix[i, j],4} ";
    }
    result += "\n";
  }

  return result;
}



int[,] SwapLinesMatrix(int[,] matrix)
{
  int columns = matrix.GetLength(1);
  int lastRow = matrix.GetLength(0) - 1;
  int temp = 0;
  for (int i = 0; i < columns; i++)
  {
    temp = matrix[0, i];
    matrix[0, i] = matrix[lastRow, i];
    matrix[lastRow, i] = temp;
  }

  return matrix;
}

int lines = GetValueFromUser("Введите количество строк: ");
int colums = GetValueFromUser("Введите количество столбцов: ");
if (lines <= 0 || colums <= 0)
{
  Console.WriteLine("Массив не является двумерным.");
  return;
}
int[,] matrix = new int[lines, colums];

FillMatrix(matrix);
ShowMatrixGood(matrix);
int[,] result = SwapLinesMatrix(matrix);
Console.WriteLine();
ShowMatrixGood(result);
