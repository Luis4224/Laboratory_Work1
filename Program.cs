namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа для расчета по двум формулам");
            double z1, z2;
            Console.Write("Введите параметр а: ");
            double a = Convert.ToInt32(Console.ReadLine());


            z1 = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) / (Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2 * a), 2));

            z2 = 2 * Math.Sin(a);

            Console.WriteLine("Решение по первой формуле " + z1);
            Console.WriteLine("Решение по второй формуле " + z2);
            



        }
    }

}