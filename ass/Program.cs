namespace ass
{
    internal enum SIGN
    {
        PLUS,
        MINUS,
        MULTIPLY,
        DIVIDE
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        private static double Calculate(SIGN sign, double arg1, double arg2)
        {
            switch (sign)
            {
                case SIGN.PLUS:
                    return arg1 + arg2;
                case SIGN.MULTIPLY:
                    return arg1 * arg2;

                default:
                    break;
            }
            return 0d;
        }
    }
}
