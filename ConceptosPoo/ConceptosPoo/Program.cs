// See https://aka.ms/new-console-template for more information
using ConceptosPoo;

Console.WriteLine("Conceptos Poo");
Console.WriteLine("==============");

Date date1 = new Date(2024,2,29);
Date date2 = new Date(2022,5,30);
try
{
    Console.WriteLine(date1);
    Console.WriteLine(date2);
}
catch (Exception error)
{
  Console.WriteLine(error.Message);
}
