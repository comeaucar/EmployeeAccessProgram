using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest1
{
    class Employee
    {
        //states for employee

        private int employeeID;
        private string firstName;
        private string lastName;
        private string jobTitle;
        private int timesAccessed;

        //constructor
        public Employee(int employeeID, string firstName, string lastName, string jobTitle)
        {
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobTitle = jobTitle;
            this.timesAccessed = 0;
        }

        //behaviours
        public string getInfo()
        {
            string data = "Employee ID: " + employeeID + "\n";
            data += "First Name: " + firstName + "\n";
            data += "Last Name: " + lastName + "\n";
            data += "Job Title: " + jobTitle + "\n";
            data += "Times Accessed: " + timesAccessed;

            return data + "\n";

        }

        public int getEmployeeID()
        {
            return this.employeeID;
        }

        public string getJobTitle()
        {
            return this.jobTitle;
        }

        public void incrementTimesAccessed()
        {
            this.timesAccessed++;
        }

        public int getTimesAccessed()
        {
            return this.timesAccessed;
        }
    }
}
