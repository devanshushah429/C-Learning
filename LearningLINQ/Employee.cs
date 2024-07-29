using System.Collections.Generic;

namespace LearningLINQ
{//';,
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public string City { get; set; }

        public List<Employee> GetAllEmployees()
        {
            return new List<Employee> {
                new Employee { ID = 1, Name = "Alice", Position = "Manager", Salary = 75000m, Department = "HR", City = "New York" },
                new Employee { ID = 2, Name = "Bob", Position = "Developer", Salary = 65000m, Department = "IT", City = "San Francisco" },
                new Employee { ID = 3, Name = "Charlie", Position = "Analyst", Salary = 60000m, Department = "Finance", City = "Chicago" },
                new Employee { ID = 4, Name = "David", Position = "Designer", Salary = 62000m, Department = "Marketing", City = "Los Angeles" },
                new Employee { ID = 5, Name = "Eva", Position = "Tester", Salary = 58000m, Department = "Quality Assurance", City = "Seattle" },
                new Employee { ID = 6, Name = "Frank", Position = "HR Specialist", Salary = 57000m, Department = "HR", City = "Boston" },
                new Employee { ID = 7, Name = "Grace", Position = "Support", Salary = 55000m, Department = "Customer Service", City = "Austin" },
                new Employee { ID = 8, Name = "Hannah", Position = "Sales", Salary = 63000m, Department = "Sales", City = "Denver" },
                new Employee { ID = 9, Name = "Ian", Position = "Marketing Specialist", Salary = 59000m, Department = "Marketing", City = "Miami" },
                new Employee { ID = 10, Name = "Jane", Position = "Admin", Salary = 54000m, Department = "Administration", City = "Philadelphia" }
            };
        }
    }
}
