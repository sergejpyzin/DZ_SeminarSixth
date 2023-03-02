namespace task_from_the_teacher
{
    internal class Program
    {
        static int GetCheckingForPositivity()
        {
            int quantityPositivityNumber = 0;
            int userNumber;
            while (true)
            {
                Console.WriteLine("Введите число: ");
                string userMassedge = Console.ReadLine();
                if (userMassedge == "stop" || userMassedge == "стоп" || userMassedge == "ыещз")
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
            Console.WriteLine($"Количество чисел больше нуля равно {count}");
        }
    }
}