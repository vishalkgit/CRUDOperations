using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperations
{
    public class EMPprogram
    {
        static void Main(string[] args)
        {
            EmployeeCRUD pcrud = new EmployeeCRUD();
            try
            {
                int a = 1;
                do
                {
                    Console.WriteLine("1.Employee List");
                    Console.WriteLine("2.Add Employee");
                    Console.WriteLine("3.Modify Employee");
                    Console.WriteLine("4.Delete Employee");
                    Console.WriteLine("5.Get Employee By Id");
                    Console.WriteLine("Select option from above");
                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            List<Employee> employees = pcrud.EmployeeList();
                            Console.WriteLine("Eid     Ename       ESal");
                            foreach (var item in employees)
                            {
                                Console.WriteLine(item);
                            }
                            break;

                        case 2:
                            Employee e1 = new Employee();
                            Console.WriteLine("Enter EId");
                            e1.EId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            e1.EName = Console.ReadLine();
                            Console.WriteLine("Enter Salary");
                            e1.ESal = Convert.ToInt32(Console.ReadLine());
                            pcrud.AddEmployee(e1);
                            Console.WriteLine("Added the EMployee");
                            break;

                        case 3:
                            Employee e2 = new Employee();
                            Console.WriteLine("Enter Existingn EId");
                            e2.EId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            e2.EName = Console.ReadLine();
                            Console.WriteLine("Enter Salary");
                            e2.ESal = Convert.ToInt32(Console.ReadLine());
                            pcrud.AddEmployee(e2);
                            Console.WriteLine("Employee Details Updated");
                            break;

                        case 4:

                            Console.WriteLine("Enter existing Id to delete");
                            int eid = Convert.ToInt32(Console.ReadLine());
                            pcrud.DeleteEmployee(eid);
                            Console.WriteLine("Deleted the EMployee");
                            break;


                        case 5:
                            Console.WriteLine("Enter existing Id");
                            int eid2 = Convert.ToInt32(Console.ReadLine());
                            Employee e3 = pcrud.GetEmployeeById(eid2);
                            Console.WriteLine(e3);
                            break;

                    }
                    Console.WriteLine("Press 1 for continue or 0 to exit");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                while (a == 1);
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            }
        }
    }

