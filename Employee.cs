using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperations
{
    public class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public int ESal {  get; set; }

        public override string ToString()
        {
            return$"{EId} ,{EName} {ESal}";
        }
    }

    public class EmployeeCRUD
    {

        List<Employee> Employees;
        public EmployeeCRUD()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee emp)
        {
            Employees.Add(emp);
        }

        public void ModifyEmployee(Employee emp)
        {
            {
                for (int i = 0; i < Employees.Count; i++)
                {
                    {
                        if (Employees[i].EId == emp.EId)
                        {
                            Employees[i].EName = emp.EName;
                            Employees[i].ESal = emp.ESal;
                            break;
                        }
                    }
                }
            }

        }


        public void DeleteEmployee(int EId)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].EId == EId)
                {
                    Employees.Remove(Employees[i]);
                    break;
                }
            }
        }

        public List<Employee> EmployeeList()
        {
            return Employees;
        }

        public Employee GetEmployeeById(int EId)
        {
            Employee e=new Employee();
            foreach(var item in Employees)
            {
                if(item.EId == EId)
                {
                    e.EId = item.EId;
                    e.EName = item.EName;
                    e.ESal = item.ESal;
                    break;
                }
            }
            return e;
        }

        
    }

}
