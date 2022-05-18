using ExamplePolymorphism.Entities;

Console.Clear();

Console.Write("Enter the number of employees: ");
int numberOfEmployees = int.Parse(Console.ReadLine());

List<Employee> listOfEmployees = new List<Employee>();

for (int i = 1; i <= numberOfEmployees; i++)
{
    Console.Clear();

    Console.WriteLine($"Employee #{i} data:\n");

    char isOutsourced = ' ';

    while (isOutsourced != 'y' && isOutsourced != 'n')
    {
        Console.Write("Outsourced (y/n): ");
        isOutsourced = char.Parse(Console.ReadLine());
    }


    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());

    if (isOutsourced == 'n')
    {
        listOfEmployees.Add(new Employee(name, hours, valuePerHour));
    }
    else
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine());

        listOfEmployees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
    }
}

Console.Clear();

Console.WriteLine("PAYMENTS:\n");

foreach (Employee employee in listOfEmployees)
{
    Console.WriteLine($"{employee.Name} - $ {employee.Payment()}");
}