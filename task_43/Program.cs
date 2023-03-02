namespace task_43
{
    internal class Program
    {
        static int GetConvertUserMassedge(string userMassedge)
        {
            int result = 0;
            while (true)
            {
                Console.Write(userMassedge);
                bool convert = int.TryParse(Console.ReadLine(), out result);
                if (convert) return result;
                else Console.WriteLine($"Ошибка! Введенная информация не корректна. Попробуйте еще раз.");
            }
        }
        static (double, double) GetPointInterseption(double firstAngularCoefficient, double secondAngularCoefficient,
            double firstCoefficient, double secondCoefficient) 
        {
            double diffAngularCoefficient = firstAngularCoefficient - secondAngularCoefficient;
            double diffCoefficient = secondCoefficient - firstCoefficient;
            double coordinateX = diffCoefficient / diffAngularCoefficient;
            double coordinateY = secondAngularCoefficient * coordinateX + secondCoefficient;            

            return (coordinateX, coordinateY);
        }
//        Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//        заданных уравнениями y = k1* x + b1, y = k2* x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//        b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
        static void Main(string[] args)
        {
            double cofficientB1 = GetConvertUserMassedge("Введите коэффициент В1: ");
            double cofficientK1 = GetConvertUserMassedge("Введите коэффициент К1: ");
            double cofficientB2 = GetConvertUserMassedge("Введите коэффициент В2: ");
            double cofficientK2 = GetConvertUserMassedge("Введите коэффициент К2: ");

            (double coordinateX, double coordinateY) = GetPointInterseption(cofficientK1, cofficientK2,  
                cofficientB1, cofficientB2);

            Console.WriteLine($"Координаты пересечения двух прямых,\nзаданных  " +
                $"уравнениями y = k1* x + b1, y = k2* x + b2; ( {coordinateX}, {coordinateY} )");
        }
    }
}