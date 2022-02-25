﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPoo
{
    public abstract class Employee : IPay
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate{ get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}, " +
                $"Birth: {BirthDate}, " +
                $"Hiring: {HiringDate}, " +
                $"Is Active: {IsActive}";
        }
    }
}
