namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double vatRate = 1.15;
            float discountRate, productPrice;

            Console.WriteLine("Enter the product price: ");
            productPrice = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the discount rate: ");
            discountRate = float.Parse(Console.ReadLine());

        }
    }
}