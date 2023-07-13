

using ConsoleAppboloAdvanceC.classAll;
using HR;

decimal totalSalaries = 0;
List<IEmployee> employees = new List<IEmployee>();

SeedData(employees);


foreach (IEmployee employee in employees)
{
    totalSalaries += employee.Salary;
}

Console.WriteLine($"Total Annual Salaries (including bonus): {totalSalaries}");

//Console.WriteLine($"Total Annual Salaries (including bonus): {employees.Sum(e => e.Salary)}");

Console.ReadKey();



 static void SeedData(List<IEmployee> employess)
{
    IEmployee teacher1 = new Teacher
    {
        Id = 1,
        FirstName = "bakari",
        LastName = "esiashvi",
        Salary = 5
    };
    employess.Add(teacher1);

    IEmployee HeadOfDepartment1 = new HeadOfDepartment
    {
        Id = 1,
        FirstName = "levani",
        LastName = "datiashvili",
        Salary = 7
    };
    employess.Add(HeadOfDepartment1);

    IEmployee deputyHeadMaster1 = new DeputyHeadMaster
    {
        Id = 1,
        FirstName = "gio",
        LastName = "gelashvili",
        Salary = 2
    };
    employess.Add(deputyHeadMaster1);


    IEmployee headMaster1 = new HeadMaster
    {
        Id = 1,
        FirstName = "mate",
        LastName = "dvali",
        Salary = 3
    };
    employess.Add(headMaster1);
}
