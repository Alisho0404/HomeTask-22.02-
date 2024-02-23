using Domain;
using Infrastructure;

var department1=new Department(){
    Name="IT",
    Description="The heart of the company"
};
var department2=new Department(){
    Name="HR",
    Description="The wheal of the company" 
    
}; 

var employee1=new Employee();
employee1.FirstName="Alisho";
employee1.LastName="Sholangarov";
employee1.BirthDate=new DateTime(10/19/1999);
employee1.Salary=25000;
employee1.Department = department1;
  
var employee2=new Employee();
employee2.FirstName="Maksim";
employee2.LastName="Shosafoev";
employee2.BirthDate=new DateTime(09/19/1999);
employee2.Salary=25000;
employee2.Department = department2;
  
var departments=new DepartmentService();
departments.AddDepartments(department1);
departments.AddDepartments(department2); 

var employees=new EmployeeService();  
employees.AddEmployees(employee1);
employees.AddEmployees(employee2);

foreach(var employer in employees.GetEmployees())
{
    System.Console.WriteLine("Name: "+employer.FirstName);
    System.Console.WriteLine("Last name: "+employer.LastName +" "); 
    System.Console.WriteLine("Birth date: "+employer.BirthDate +" "); 
    System.Console.WriteLine("Salary: "+employer.Salary+" "); 
    System.Console.WriteLine("Department: "+employer.Department.Name+" ");
   
    System.Console.WriteLine("-----------------------------------------------------");
}

System.Console.WriteLine($"Total we have {employees.CountEmployees()} employee");
System.Console.WriteLine($"Total we have {departments.CountDepartments()} departments");



