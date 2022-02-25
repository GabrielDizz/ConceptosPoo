namespace ConceptosPoo
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        public decimal Base { get; set; }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {
            return $"Empleado Con  Base Y   {base.ToString()}" +                
                $"\tBase.................: {$"{Base:C2}",18}";

        }
    }
}
