using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPoo
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HoursValue { get; set; } 
        public override decimal GetValueToPay()
        {
            return HoursValue * (decimal)Hours;  
        }

        public override string ToString()
        {
            return $"Empleado Por Horas: \n{base.ToString()}" +
                $"\n\tHours Trabajadas.....: {$"{Hours:N2}",18}" +
                $"\n\tHours Value..........: {$"{HoursValue:C2}",18}" +
                $" \n\tValue to pay ........: {$"{GetValueToPay():C2}",18}\n";
        }
    }
}
