using ODataWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataWebAPI.DB
{
    public class Employeedb
    {
            private static Employeedb instance = null;
            public static Employeedb Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Employeedb();
                    }
                    return instance;
                }
            }
            public List<Employee> Employees { get; set; }

            private Employeedb()
            {
                this.Reset();
                this.Initialize();
            }
            public void Reset()
            {
                this.Employees = new List<Employee>();

            }
            public void Initialize()
            {
                this.Employees.AddRange(new List<Employee>
            {
                new Employee()
                {
                    Empid = Guid.NewGuid(),
                    EName = "Arnav",
                    Department="Dynamics 365/CRM"

                },
                new Employee()
                {
                    Empid = Guid.NewGuid(),
                    EName = "Diksha",
                    Department="Dynamics 365/CRM"

                },
                new Employee()
                {
                    Empid = Guid.NewGuid(),
                    EName = "Anil",
                    Department = "Dynamics 365 Operation"
                },
                new Employee()
                {
                    Empid = Guid.NewGuid(),
                    EName = "Sunil",
                    Department = "Dynamics 365 Operation"
                }
            });
            }
        }
    }
