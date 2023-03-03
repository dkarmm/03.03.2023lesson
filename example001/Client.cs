using static MatrixService;

public static class Client
{
  public static void Run()
  {
    int lines = GetValueFromUser("Введите количество строк: ");
    int columns = GetValueFromUser("Введите количество столбцов: ");

    if (lines <= 0 || columns <= 0)
    {
      Console.WriteLine("Массив не является двумерным.");
      return;
    }

    int[,] matrix = new int[lines, columns];

    FillMatrix(matrix);
    Console.WriteLine(JoinMatrix(matrix));
    int[,] result = SwapLinesMatrix(matrix);

    Console.WriteLine(JoinMatrix(result));
  }
}