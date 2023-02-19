using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI_002
{
    // Dependent Class
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int CurrentGradeId { get; set; }
        public Grade Grades { get; set; }
    }
}
