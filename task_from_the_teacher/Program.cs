namespace task_from_the_teacher
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
        static int GetCheckingForPositivity()
        {
            int quantityPositivityNumber = 0;
            int userNumber;
            while (true)
            {
                Console.WriteLine("Введите число: ");
                string userMassedge = Console.ReadLine();
                if (userMassedge == "stop")
                {
                    break;
                }
                else
                {
                    userNumber = Convert.ToInt32(userMassedge);
                    if (userNumber > 0)
                    {
                        quantityPositivityNumber++;
                    }
                }
            }
            return quantityPositivityNumber;
        }        
        static void Main(string[] args)
        {
            int count = GetCheckingForPositivity();
            Console.WriteLine(count);
        }
    }
}