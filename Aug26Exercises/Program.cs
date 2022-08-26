using Aug26Reusable;
using System.Security.Cryptography.X509Certificates;

namespace Aug26Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Str> strin = new LinkedList<Str>();
            strin.AddFirst(new Str { name = "Sai" });
            strin.AddBefore(strin.Last, new Str { name = "pawar" });
            strin.AddLast(new Str { name = "vignesh" });
            foreach(var item in strin)
            {
                Console.Write("{0}\t",item.name);
            }
            Console.WriteLine();
            strin.AddBefore(strin.Last.Previous, new Str { name = "Ajit" });
            foreach (var item in strin)
            {
                Console.Write("{0}\t", item.name);
            }
            Console.WriteLine();
            strin.AddAfter(strin.First.Next, new Str { name = "Manly" });
            foreach (var item in strin)
            {
                Console.Write("{0}\t", item.name);
            }
            Console.WriteLine();
            Console.WriteLine("Enter to remove");
            int m = Convert.ToInt32(Console.ReadLine());
            Str emp = strin.ElementAt(m);
            strin.Remove(emp);
            foreach (var item in strin)
            {
                Console.Write("{0}\t", item.name);
            }
            Console.WriteLine();

        }
    }
}
 