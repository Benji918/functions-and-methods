namespace functions_methods
{
    internal class Program
    {
        //Field (can also be called global vairable)
        static int result;
        static void Main(string[] args)
        {

            // calling method
            result = AddIntegers(2, 2);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static int AddIntegers(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
