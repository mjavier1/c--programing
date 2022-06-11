namespace Functions
{
    internal class Program
    {

      /*//una func simple 
        static void hello(String name)
        {
            Console.WriteLine("\nHello"+name);
        }
      */

        static int sum(int x, int y) { 
            //matematica 
            
            return x + y; }


        static void Main(string[] args)
        {
            //   hello("udemy");  
            // Console.WriteLine("Hello, World!");
            int x = sum(3, 7);
          
            Console.WriteLine(x);
             Console.ReadKey();
        }
      
    }
}