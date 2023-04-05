﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Person
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public int BirthYear { get; set; }

        public int Age(int currentYear)
        {
            return currentYear - BirthYear;
        }


    }
}
