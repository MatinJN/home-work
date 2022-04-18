using System;
using System.Collections.Generic;
using System.Text;

namespace home_work_18._04._22.Models
{
    internal class Company
    {
        private string _name;
        
        public string Name 
        {
            get => _name;
            set
            {
                bool check = true;
                while (check)
                {
                    bool checksymbol = false;

                    if (char.IsUpper(value[0]))
                    {
                        foreach (char item in value)
                        {
                            
                            if (char.IsSymbol(item))
                            {
                                checksymbol = true;
                            }
                            else
                            {
                                Console.WriteLine("sirket adinin icinde simvol ola bilmez");
                            }
                                check = false;
                            _name = value;

                        }  
                    }
                    else
                    {
                        Console.WriteLine("sirket adinin ilk herfi boyuk olmalidir");
                        break;
                    }

                }
                
                
            }
        }

        public int limit;
        public Employee[] Employees;
        public Company()
        {
            Employees=new Employee[0];
        }
        public void AddEmployee(Employee employee)
        {
            if (Employees.Length > limit)
            {
                Array.Resize(ref Employees, Employees.Length+1);
                Employees[Employees.Length-1] = employee;
                return;
            }
            else
            {
                Console.WriteLine("sirket doludu gozleyin ixtisarlasma olarsa biz siznen elaqe saxlayacagiq");
            }
           
        }
        public Employee[] GetEmployees() => Employees;


    }
}
