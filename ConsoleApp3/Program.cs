namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded : ");
            int eded = Convert.ToInt32(Console.ReadLine());
            if (eded % 2 == 0)   //Daxil edilen eded cutduse
            {
                Console.WriteLine("Daxil etdiyiniz eded cut");
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz eded tek");
            }
            Console.ReadKey();
        }
    }
}