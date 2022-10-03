using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCollections.Entities
{
    internal class Student
    {
        public Student()
        {
        }

        public int StudentNumber { get; set; }

        public Student(int studentNumber)
        {
            StudentNumber = studentNumber;
        }
    }
}
