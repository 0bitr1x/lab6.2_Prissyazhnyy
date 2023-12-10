//сборник задач/тема 6/подтема 6.2/средний уровень/вариант 2
using LibraryLab6._2;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = 4;
        int m = 6;
        double[,] mas = new double[n,m];
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                mas[i, j] = Class1.ArrayMas(i, j);
                Console.Write($"{mas[i, j]:F2}  ");
            }
            Console.WriteLine();
        }
        Class1.Vector( mas );
        Class1.Function(mas);
    }
}
