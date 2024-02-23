namespace Domain;

public class Employee
{
    public string FirstName  { get; set; } 
    public string  LastName { get; set; } 
    public DateTime BirthDate { get; set; } 
    public decimal Salary { get; set; }  
    public List<string> Phones { get; set; }  
    public Department Department { get; set; }
}
