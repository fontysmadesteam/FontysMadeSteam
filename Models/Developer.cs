using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Developer
    {
        public string Name { get; private set; }

        public Developer(string name)
        {
            Name = name;
        }
    }
}
