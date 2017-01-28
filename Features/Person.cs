using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    public class Person
    {
        public string FirstName { get; set; } = "Marouan";
        public string LastName { get; set; } = "REJEB";

        //Deconstruction
        public void Deconstruct(out string first, out string last)
        {
            first = FirstName;
            last = LastName;
        }

        //Expression-Bodied Everything
        public override string ToString() => $"Hello blog";
    }
}
