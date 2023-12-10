namespace LibraryLab6._2
{
    public class Class1
    {
        public static double ArrayMas(int i, int j)
        {
            double calc = Math.Pow(Math.Log(7 * i + j + 3, 3), 3) - (-Math.Exp(i + j));
            return calc;
        }
        public static double Vector(double[,] mas)
        {
            double resultVector = 0;
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                resultVector = 0;
                for (int j = 0; j < mas.GetLength(0); j++) 
                {
                    resultVector += mas[j, i] > 0 ? Math.Pow(mas[j, i], 2): 0;
                }
                Console.Write($"вектор столбца {i + 1} = {resultVector:F2}");
                Console.WriteLine();
            }
            return resultVector;
        }
        public static double Function(double[,] mas)
        {
            double max = 0, min = 0;
            int maxI = 0, minI = 0;
            for (int i = 0; i < mas.GetLength (1); i++)
            {
                double resultVector = 0;
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    resultVector += mas[j, i] > 0 ? Math.Pow(mas[j, i], 2) : 0;
                }
                for (int j = 0; j < 1; j++) min = resultVector;
                if (resultVector > max)
                {
                    max = resultVector;
                    maxI = i;
                }
                if (resultVector < min)
                {
                    min = resultVector;
                    minI = i;
                }
            }
            Console.WriteLine($"функция = {maxI * minI}");
            return maxI * minI;
        }
    }
}