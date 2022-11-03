using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Student
    {
        public int ID { get; set; }

        public Student(int iD, string name, float gPA)
        {
            ID = iD;
            Name = name;
            GPA = gPA;
        }

        public string Name { get; set; }
        public float GPA { get; set; }

    }
}
