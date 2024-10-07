using System;



namespace pz1
{
    internal class Task4
    {
        public void TASK4()
        {

            {
                // Довжина масиву Х - 32
                int arrayLength = 34;

                // Створюємо масив X довжиною arrayLength
                int[] X = new int[arrayLength];

                Random random = new Random();

                // Заповнюємо масив X випадковими числами (включаючи негативні і нулі)
                for (int i = 0; i < arrayLength; i++)
                {
                    X[i] = random.Next(-50, 51); // Числа від -50 до 50
                }

                // Задане число М
                Console.Write("Введіть число M: ");
                int M = int.Parse(Console.ReadLine());

                // Формуємо новий масив Y, де елементи з масиву X більше по модулю числа M
                int[] Y = X.Where(x => Math.Abs(x) > M).ToArray();

                // Виводимо на екран масив X
                Console.WriteLine("Масив X: " + string.Join(", ", X));

                // Виводимо на екран число М
                Console.WriteLine("Число M: " + M);

                // Виводимо на екран масив Y
                Console.WriteLine("Масив Y (елементи з X, що більше за M по модулю): " + string.Join(", ", Y));
            }
        }
    }
}
