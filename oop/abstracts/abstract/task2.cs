namespace abstracts
{
    internal class task2
    {
        static void Main(string[] args)
        {
            Payment p = new CreditCardPayment(1000, "sfjaifj85932");
            p.processPayment();
            Payment p2 = new PayPalPayment(10000, "vdfnjfj10238");
            p2.processPayment();
        }

        abstract class Payment
        {
            public double Amount;
            private string TransactionID;

            public Payment(double amount, string transactionID)
            {
                Amount = amount;
                TransactionID = transactionID;
            }

            public abstract void processPayment();
        }

        class CreditCardPayment : Payment
        {
            public CreditCardPayment(double amount, string transactionID) : base(amount, transactionID) {}
            public override void processPayment()
            {
                if (Amount > 100000)
                {
                    Console.WriteLine("Отказ: сумма превышает лимит");
                }
                else if (Amount <= 0)
                {
                    Console.WriteLine("Отказ: сумма ниже минимальной");
                }
                else
                {
                    Console.WriteLine("Успех: платеж завершен");
                }
            }
        }

        class PayPalPayment : Payment
        {
            public PayPalPayment(double amount, string transactionID) : base(amount, transactionID) { }
            public override void processPayment()
            {
                if (Amount > 100000)
                {
                    Console.WriteLine("Перенаправление на PayPal... Отказ: сумма превышает лимит");
                }
                else if (Amount <= 0)
                {
                    Console.WriteLine("Перенаправление на PayPal... Отказ: сумма ниже минимальной");
                }
                else
                {
                    Console.WriteLine($"Перенаправление на PayPal... Успех: оплата на сумму: {Amount} рублей завершена");
                }
            }
        }
    }
}
