namespace IbryaichevDR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    // Ибряйчев Дмитрий Романович Ам-1-25
}



namespace YourProjectName
{
    class Program
    {
        static void Main(string[] args)
        {
            // тест функции (можно потом удалить или оставить)
            double result = Sqr(5);
            Console.WriteLine(result); // 25
        }

        // Добавляемая функция
        static public double Sqr(double X)
        {
            return X * X;
        }
    }
}