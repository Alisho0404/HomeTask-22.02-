using Domain;

namespace Infrastructure;

public class DepartmentService
{
 public List<Department>_departments=new List<Department>(); 
 public List<Department> GetDepartments()
 {
    return _departments;
 } 
 public void AddDepartments(Department add) 
 { 
_departments.Add(add);

 } 
 public int CountDepartments()
 {
return _departments.Count;
 }
}
