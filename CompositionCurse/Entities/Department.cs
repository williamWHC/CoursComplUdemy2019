using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionCurse.Entities
{
    class Department
    {
        public string Name { get; set; }

        //Contrutor
        public Department()
        {

        }

        public Department(string name)
        {
            Name = name;
        }
    }
}
