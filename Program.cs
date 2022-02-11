namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            for(short i =0; i < 10; i++)
            {
                
                if(i% 2== 0)
                {
                    continue;
                }

                Console.WriteLine("El:" + i);
            }
        }

    }

}