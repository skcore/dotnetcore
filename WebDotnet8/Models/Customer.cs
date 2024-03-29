﻿namespace WebDotnet8.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }
        //public int StateID { get; set; }
        public string? Department { get; set; }

        public string? City { get; set; }



        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { ID = 1, Name = $"Jhon", Salary = 1000, Department = "HR", City = "Alabama" });
            customers.Add(new Customer { ID = 2, Name = $"Mix", Salary = 2000, Department = "Marketing", City = "California" });
            customers.Add(new Customer { ID = 3, Name = $"Source", Salary = 3000, Department = "IT", City = "Alabama" });
            customers.Add(new Customer { ID = 4, Name = $"Camel", Salary = 4000, Department = "Finance", City = "California" });
            customers.Add(new Customer { ID = 5, Name = $"Gane", Salary = 5000, Department = "IT", City = "Alabama" });
            customers.Add(new Customer { ID = 6, Name = $"Gemini", Salary = 6000, Department = "HR", City = "California" });
            customers.Add(new Customer { ID = 7, Name = $"Emppp", Salary = 7000, Department = "Marketing", City = "Alabama" });
            customers.Add(new Customer { ID = 8, Name = $"Sini", Salary = 8000, Department = "Finance", City = "Colorado" });
            customers.Add(new Customer { ID = 9, Name = $"Boini", Salary = 9000, Department = "IT", City = "Alabama" });
            customers.Add(new Customer { ID = 10, Name = $"Loin", Salary = 10000, Department = "Marketing", City = "Alabama" });
            customers.Add(new Customer { ID = 1, Name = $"Jhon", Salary = 1000, Department = "HR", City = "California" });
            customers.Add(new Customer { ID = 2, Name = $"Mix", Salary = 2000, Department = "Marketing", City = "Alabama" });
            customers.Add(new Customer { ID = 3, Name = $"Source", Salary = 3000, Department = "IT", City = "California" });
            customers.Add(new Customer { ID = 4, Name = $"Camel", Salary = 4000, Department = "Finance", City = "Alabama" });
            customers.Add(new Customer { ID = 5, Name = $"Gane", Salary = 5000, Department = "IT", City = "Alabama" });
            customers.Add(new Customer { ID = 6, Name = $"Gemini", Salary = 6000, Department = "HR", City = "Colorado" });
            customers.Add(new Customer { ID = 7, Name = $"Emppp", Salary = 7000, Department = "Marketing", City = "California" });
            customers.Add(new Customer { ID = 8, Name = $"Sini", Salary = 8000, Department = "Finance", City = "Alabama" });
            customers.Add(new Customer { ID = 9, Name = $"Boini", Salary = 9000, Department = "IT", City = "Colorado" });
            customers.Add(new Customer { ID = 10, Name = $"Loin", Salary = 10000, Department = "Marketing", City = "California" });


            return customers;
        }
    }
    public class State
    {
        public int ID { get; set; }
        public string? Name { get; set; }
    }
    public partial class SampleData
    {
        public static readonly IEnumerable<State> States = new[] {
            new State {
                ID = 1,
                Name = "Alabama"
            },
            new State {
                ID = 2,
                Name = "Alaska"
            },
            new State {
                ID = 3,
                Name = "Arizona"
            },
            new State {
                ID = 4,
                Name = "Arkansas"
            },
            new State {
                ID = 5,
                Name = "California"
            },
            new State {
                ID = 6,
                Name = "Colorado"
            },
            new State {
                ID = 7,
                Name = "Connecticut"
            },
            new State {
                ID = 8,
                Name = "Delaware"
            },
            new State {
                ID = 9,
                Name = "District of Columbia"
            },
            new State {
                ID = 10,
                Name = "Florida"
            },
            new State {
                ID = 11,
                Name = "Georgia"
            },
            new State {
                ID = 12,
                Name = "Hawaii"
            },
            new State {
                ID = 13,
                Name = "Idaho"
            },
            new State {
                ID = 14,
                Name = "Illinois"
            },
            new State {
                ID = 15,
                Name = "Indiana"
            },
            new State {
                ID = 16,
                Name = "Iowa"
            },
            new State {
                ID = 17,
                Name = "Kansas"
            },
            new State {
                ID = 18,
                Name = "Kentucky"
            },
            new State {
                ID = 19,
                Name = "Louisiana"
            },
            new State {
                ID = 20,
                Name = "Maine"
            },
            new State {
                ID = 21,
                Name = "Maryland"
            },
            new State {
                ID = 22,
                Name = "Massachusetts"
            },
            new State {
                ID = 23,
                Name = "Michigan"
            },
            new State {
                ID = 24,
                Name = "Minnesota"
            },
            new State {
                ID = 25,
                Name = "Mississippi"
            },
            new State {
                ID = 26,
                Name = "Missouri"
            },
            new State {
                ID = 27,
                Name = "Montana"
            },
            new State {
                ID = 28,
                Name = "Nebraska"
            },
            new State {
                ID = 29,
                Name = "Nevada"
            },
            new State {
                ID = 30,
                Name = "New Hampshire"
            },
            new State {
                ID = 31,
                Name = "New Jersey"
            },
            new State {
                ID = 32,
                Name = "New Mexico"
            },
            new State {
                ID = 33,
                Name = "New York"
            },
            new State {
                ID = 34,
                Name = "North Carolina"
            },
            new State {
                ID = 35,
                Name = "Ohio"
            },
            new State {
                ID = 36,
                Name = "Oklahoma"
            },
            new State {
                ID = 37,
                Name = "Oregon"
            },
            new State {
                ID = 38,
                Name = "Pennsylvania"
            },
            new State {
                ID = 39,
                Name = "Rhode Island"
            },
            new State {
                ID = 40,
                Name = "South Carolina"
            },
            new State {
                ID = 41,
                Name = "South Dakota"
            },
            new State {
                ID = 42,
                Name = "Tennessee"
            },
            new State {
                ID = 43,
                Name = "Texas"
            },
            new State {
                ID = 44,
                Name = "Utah"
            },
            new State {
                ID = 45,
                Name = "Vermont"
            },
            new State {
                ID = 46,
                Name = "Virginia"
            },
            new State {
                ID = 47,
                Name = "Washington"
            },
            new State {
                ID = 48,
                Name = "West Virginia"
            },
            new State {
                ID = 49,
                Name = "Wisconsin"
            },
            new State {
                ID = 50,
                Name = "Wyoming"
            },
            new State {
                ID = 51,
                Name = "North Dakota"
            }
        };
    }
}
