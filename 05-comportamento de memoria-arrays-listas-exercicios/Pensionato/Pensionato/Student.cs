using System;
using System.Collections.Generic;
using System.Text;

namespace Pensionato {
    class Student {
        public string Name { get; set; }
        public string Email { get; set; }

        public Student(string name, string email) {
            Name = name;
            Email = email;
        }
    }
}
