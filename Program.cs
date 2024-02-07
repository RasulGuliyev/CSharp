namespace FirstLessonProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.Write("Enter first number: ");
            int var1;
            while (true)
            {
                try
                {
                    var1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("You can enter int number!");
                }
            }
            
            Console.Write("Enter second number: ");
            int var2 = Convert.ToInt32(Console.ReadLine());

            int sum = Sum(var1, var2);

            Console.WriteLine("The sum of two numbers: " + sum);
        }  
        
        public static int Sum (int var1, int var2)
        {
            return var1 + var2;
        }
    }
}
