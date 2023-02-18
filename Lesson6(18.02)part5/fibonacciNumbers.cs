namespace Lesson6_18._02_part5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int i = 0;
            //i=i++;
            //i=i++;
            //i=++i;
            //i=i++;
            //i=i--;
            //i=++i;
            //Console.WriteLine(i);


            //int n = int.Parse(Console.ReadLine());
            //int a = 0;
            //Console.WriteLine(a);
            //int b = 1;
            //Console.WriteLine(b);
            //int c;
            //for(int i = 0; i < n; i++)
            //{
            //    c = a + b;
            //    Console.WriteLine(c);
            //    a = b + c;
            //    Console.WriteLine(a);
            //    b = a + c;
            //    Console.WriteLine(b);
            //}

            Console.WriteLine(Factorial(2));
            


        }
        public static long Factorial(int i)
        {
            if (i == 1 || i == 0)
                return 1;
            else
            return i * Factorial(i - 1);
            
        }

    }
}