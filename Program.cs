internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrix = new int[10, 10];
        for (int i = 0; i < matrix.GetLength(0); i++)// unit matrix 10x10
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = 1;
            }
        }
        const string file = "dane.txt";

        using (var streamWriter = new StreamWriter(file))// save to file
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    streamWriter.Write(matrix[i, j] + " ");// save every element of matrix
                }
                streamWriter.WriteLine();// matrix form: new line after writing all row
            }
        }

        try
        {
            // Reading and displaying data from a file
            var fileContent = File.ReadAllLines(file);
            foreach (var row in fileContent)
            {
                Console.WriteLine(row);// display 1 row
            }
        }
        catch (FileNotFoundException)//Error handling when file does not exist
        {
            Console.WriteLine("File not found");
        }
        Console.ReadKey();
    }
}