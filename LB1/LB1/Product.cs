using System;

namespace LB1
{
    public class Product
    {
        private string name = string.Empty;
        private decimal price;
        private int quantity;
        private DateTime lastUpdated;

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            LastUpdated = DateTime.Now;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                }
                name = value;
                UpdateTimestamp();
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Price cannot be negative.");
                }
                price = value;
                UpdateTimestamp();
            }
        }

        public int Quantity
        {
            get => quantity;
            private set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Quantity cannot be negative.");
                }
                quantity = value;
            }
        }

        public DateTime LastUpdated
        {
            get => lastUpdated;
            private set => lastUpdated = value;
        }

        public decimal TotalValue => Price * Quantity;

        public void Restock(int amount)
        {
            ValidateAmount(amount);
            Quantity += amount;
            UpdateTimestamp();
        }

        public void Sell(int amount)
        {
            ValidateAmount(amount);

            if (amount > Quantity)
            {
                Console.WriteLine("Недостатньо товару на складі!");
                return;
            }

            Quantity -= amount;
            UpdateTimestamp();
        }

        private void UpdateTimestamp()
        {
            LastUpdated = DateTime.Now;
        }

        private static void ValidateAmount(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount should be greater than 0.");
            }
        }

        public string GetInfo()
        {
            return $"Товар: {Name}, Ціна: {Price} грн, Кількість: {Quantity}, Загальна вартість: {TotalValue} грн, Останнє оновлення: {LastUpdated}";
        }
    }
}
