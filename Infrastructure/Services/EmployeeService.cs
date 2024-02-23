using Domain;
namespace Infrastructure; 


public class EmployeeService
{
    public List<Employee>_employees=new List<Employee>(); 

    public List<Employee> GetEmployees()
    {
        return _employees;
    }  

    public void AddEmployees(Employee add)
    {
        _employees.Add(add);
    } 

    public int CountEmployees()
    {
        return _employees.Count();
    }
}
