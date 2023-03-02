namespace task_41
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
        static int[] GetFilledArray(int value)
        {
            int[] array = new int[value];
            for (int i = 0; i < value; i++)
            {
                array[i] = GetConvertUserMassedge("Введите число: ");
            }
            return array;
        }
        static int GetCheckingForPositivity(int [] array)
        {
            int quantityPositivityNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    quantityPositivityNumber++;
                }                
            }
            return quantityPositivityNumber;
        }
        static void PrintArray(int[] array)
        {
            Console.WriteLine($"[ {string.Join(", ", array)} ]");
        }

        //        Задача 41: Пользователь вводит с клавиатуры M чисел.
        //        Посчитайте, сколько чисел больше 0 ввёл пользователь.
        //        0, 7, 8, -2, -2 -> 2
        //        1, -7, 567, 89, 223-> 3
        static void Main(string[] args)
        {
            int numberM = GetConvertUserMassedge("Введите количество чисел: ");           
            int count = GetCheckingForPositivity(GetFilledArray(numberM));
            Console.WriteLine(count);
        }
    }
}