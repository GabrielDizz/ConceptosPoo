// See https://aka.ms/new-console-template for more information
using ConceptosPoo;

Console.WriteLine("Conceptos Poo");
Console.WriteLine("==============");

Employee empleado1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Gabriel",
    LastName =  "Dizzett Utria",
    BirthDate = new Date(1973,7,29),
    HiringDate = new Date(2000,9,11),
    IsActive = true,
    Salary = 2540200.00M    
};
Console.WriteLine(empleado1);

Employee empleado2 = new CommissionEmployee()
{
    Id = 2010,
    FirstName = "Berenice Cecilia",
    LastName = "Sarmiento Avila",
    BirthDate = new Date(1977, 11, 22),
    HiringDate = new Date(2010, 6, 10),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
};
Console.WriteLine(empleado2);

Employee empleado3 = new HourlyEmployee()
{
    Id = 3010,
    FirstName = "Baldomero Sanin",
    LastName = "Dizzett Parra",
    BirthDate = new Date(1945, 11, 22),
    HiringDate = new Date(1984, 6, 10),
    IsActive = true,
    Hours = 240.5F,
    HoursValue = 23456M
};
Console.WriteLine(empleado3);