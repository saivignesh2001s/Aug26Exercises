using Aug26Reusable;
namespace Aug26Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of students");
            int n=Convert.ToInt32(Console.ReadLine());
            Students[] student = new Students[n];
            for(int i = 0; i < n; i++)
            {
                student[i]=new Students();
                Console.WriteLine("Enter the {0} id", i + 1);
                student[i].ID=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name");
                student[i].Name = Console.ReadLine();
                Console.WriteLine("Enter age");
                student[i].Age = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < student.Length; i++)
            {
                student[i].print();
            }
            Console.ReadLine();

        }
    }
    
    }
