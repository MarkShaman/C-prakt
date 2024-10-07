using System;


namespace pz1
{
    internal class Task3
    {
       
          
           
         public void ARR()
        {
         
            int[] X = new int[34];
            Random rand = new Random();

            
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rand.Next(1, 101);
            }

           
            int minValue = X[0];
            int maxValue = X[0];

            for (int i = 1; i < X.Length; i++)
            {
                if (X[i] < minValue)
                {
                    minValue = X[i];
                }
                if (X[i] > maxValue)
                {
                    maxValue = X[i];
                }
            }

           
            Console.WriteLine("Масив X:");
            foreach (int num in X)
            {
                Console.Write(num + " ");
            }

           
            Console.WriteLine($"\nМінімальне значення: {minValue}");
            Console.WriteLine($"Максимальне значення: {maxValue}");
        }
    }
}



