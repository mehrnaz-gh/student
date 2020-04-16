using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ormt
{
    internal class StudentContext : DbContext
    {
        public StudentContext() : base("ormt")
        {

        }
        public ISet<Student> Student
        {
            get;
            set;
        }
        public object Database { get; internal set; }
    }
}
