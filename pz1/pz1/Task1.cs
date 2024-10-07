using System;

namespace pz1
{
    public class Task1
    {
        public void StartTask1()
        {
            int[] Numb = { 5, 6, 95 };

            foreach (int i in Numb)
            {
                if (i >= 1 && i <= 37)
                {
                    Console.WriteLine($"num:{i}");
                }
            }
        }
    }
}
