// *Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int countRows = EnterNumber("Введите кол-во строк массива: ");
int countCols = EnterNumber("Введите кол-во столбцов массива: ");
int countNum = EnterNumber("Введите число, с которого начинать заполнять массив по спирали:");

int[,] array2D = CreateMatrixSpirally(countRows, countCols, countNum);
Console.WriteLine("Массив, заполненный спирально:");
PrintMatrix(array2D);


int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateMatrixSpirally(int rows, int columns, int countFrom)
{
    int[,] matrix = new int[rows, columns];
    int leftHorizontalBorder = 0;
    int rightHorizontalBorder = matrix.GetLength(1) - 1;
    int upperVerticalBorder = 0;
    int bottomVerticalBorder = matrix.GetLength(0) - 1;
    int stepHorizontal = 1;
    int stepVertical = 0;
    int countAll = rows * columns;
    int i = 0;
    int j = 0;

    for (int count = countFrom; count < countAll + countFrom; count++)
    {
        matrix[i, j] = count;
        if (j == rightHorizontalBorder && stepHorizontal == 1)
        {
            // дошли до правого свободного края:
            // - двигаемся только вниз
            // - увеличиваем верхнюю границу
            stepHorizontal = 0;
            stepVertical = 1;
            upperVerticalBorder++; 
        }
        else if (j == leftHorizontalBorder && stepHorizontal == -1)
        {
            // дошли до левого свободного края:
            //  - уменьшаем нижнюю границу
            //  - двигаемся только вверх
            stepHorizontal = 0;
            stepVertical = -1;
            bottomVerticalBorder--; 
        }
        else if (i == bottomVerticalBorder && stepVertical == 1)
        {
            // дошли до нижнего свободного края
            //  - двигаемся только влево
            //  - уменьшаем правую границу
            stepVertical = 0;
            stepHorizontal = -1;
            rightHorizontalBorder--; 
        }
        else if (i == upperVerticalBorder && stepVertical == -1)
        {
            // дошли до верхнего свободного края:
            //  - двигаемся только вправо
            //  - увеличиваем левую границу
            stepHorizontal = 1;
            stepVertical = 0;
            leftHorizontalBorder++; 
        }
        i += stepVertical;
        j += stepHorizontal;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        Console.Write($"[{matrix[i, 0], 5}");
        for (int j = 1; j < matrix.GetLength(1); j++) 
            Console.Write($", {matrix[i, j], 5}");
        Console.WriteLine(" ]");
    }
}
