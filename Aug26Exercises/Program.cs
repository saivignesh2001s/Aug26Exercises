using Aug26Reusable;
namespace Aug26Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Products> product = new List<Products>();
           
                Console.WriteLine("1.ADD\t 2.Remove\n");
                int inp = Convert.ToInt32(Console.ReadLine());
                switch (inp)
                {
                    case 1:
                        Console.WriteLine("Enter no. of products");
                        int m=Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < m; i++)
                        {
                            Console.WriteLine("Enter Product Id");
                            int str = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter name");
                            string pt = Console.ReadLine();
                            product.Add(new Products { ID = str, Name = pt });
                        }

                        break;
                    case 2:

                        if (product.Count == 0)
                        {
                            Console.WriteLine("Can't delete in null");
                        }
                        else
                        {
                            Console.WriteLine("Enter Product Id to delete");
                            int n = Convert.ToInt32(Console.ReadLine());
                            Products emp = product.ElementAt(n);
                            product.Remove(emp);
                        }
                        break;
                    default:
                        break;

                }
            Console.WriteLine("Do you want to remove? enter 1 ");
            int p=Convert.ToInt32(Console.ReadLine());
            if (p == 1)
            {
                if (product.Count == 0)
                {
                    Console.WriteLine("Can't delete in null");
                }
                else
                {
                    Console.WriteLine("Enter Product Id to delete");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Products emp = product.ElementAt(n);
                    product.Remove(emp);
                    foreach (var item in product)
                        item.Display();
                }
            }
            else
            {
                foreach(var item in product)
                item.Display();
            }
            Console.ReadLine();
               
        }
    }
}
    
