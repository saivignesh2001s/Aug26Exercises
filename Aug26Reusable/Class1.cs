using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug26Reusable
{
    public class Student
    {
        public int id;
        public string name;
        public int age;
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public void print()
        {
            Console.Write("{0}\t {1}\t {2}\n", id, name, age);
        }

    }
    public class Str
    {
        public string name;
    }
}
