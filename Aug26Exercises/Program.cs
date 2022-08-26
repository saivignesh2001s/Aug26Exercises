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
    struct Students
    {
        public int id;
        public string name;
        public int age;
        public int ID
        {
            set { id= value; }
            get { return id; }
        }
        public string Name
        {
            set { name= value; }
            get { return name; }
        }
        public int Age
        {
            set { age= value; }
            get { return age; }
        }
    public void print()
    {
        Console.Write("{0}\t {1}\t {2}\n",id,name,age);
    }
}