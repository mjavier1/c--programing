//marcos 
//programancion en udemy curso 
namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num {1,1,1,1,} 
            //igual funciona con el for que string 

            String[] customers = { "mj", "aguirre", "Rodriguez", "26" };
        //    Console.WriteLine(customers[2]);

            foreach(String customer in customers)
            {
                Console.WriteLine(customer);

            }

            Console.WriteLine("Hello, World!");
        }
    }
}