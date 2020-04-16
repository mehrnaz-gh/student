using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ormt
{
    class Student
    {
        private ICollection<Student> _student;

        public int ID { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "نام")]
        public string Name { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "ایمیل")]
        public string Email { get; set; }

        public virtual ICollection<Student> GetStudent()
        {
            return _student;
        }

        public virtual void SetStudent(ICollection<Student> value)
        {
            _student = value;
        }
    }
}
