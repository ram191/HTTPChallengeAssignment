using System;
using System.Collections.Generic;

namespace AsyncAwaitProject
{
    public class Employee
    {
        public int Id { get; set; }
        public string Avatar_url { get; set; }
        public string Employee_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public DateTime Birthday { get; set; }
        public List<Addresses> Addresses { get; set; }
        public List<Phones> Phones { get; set; }
        public List<DateTime> Presence_list { get; set; }
        public int Salary { get; set; }
        public Department Department { get; set; }
        public Position Position { get; set; }
    }

    public class Addresses
    {
        public string Label { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }

    public class Phones
    {
        public string Label { get; set; }
        public string Phone { get; set; }
    }

    public class Department
    {
        public string Name { get; set; }
    }

    public class Position
    {
        public string Name { get; set; }
    }
}
