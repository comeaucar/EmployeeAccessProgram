using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LabTest1
{
    class FloorAccessManager
    {
        //states for floorAccessManager

        private Employee[] accessList;
        private int maxEmployees;
        private int numEmployees;
        private int floorNumber;
        private int totalTimesAccessed;


        //constructor that initiates variables
        public FloorAccessManager(int maxEmployees, int floorNumber)
        {
            this.maxEmployees = maxEmployees;
            this.accessList = new Employee[maxEmployees];
            this.floorNumber = floorNumber;
            this.numEmployees = 0;
            this.totalTimesAccessed = 0;
        }

        public Boolean addEmployee(int employeeID, string firstName, string lastName, string jobTitle)
        {

            //first check that we have room to store another employee

            if (numEmployees < maxEmployees)
            {
                this.accessList[numEmployees] = new Employee(employeeID, firstName, lastName, jobTitle);
                WriteLine("Employee Added Successfully");
                numEmployees++;
                return true;
            }
            else WriteLine("Capacity Reached");
            return false;
        }

        //checks if employee has access to this floor based on their employeeID
        private Boolean checkStaff(int employeeID)
        {
            for(int i = 0; i < numEmployees; i++)
            {
                if(this.accessList[i].getEmployeeID() == employeeID)
                {
                    WriteLine("Employee Does Have Access");
                    return true;
                }

            }
            WriteLine("Employee Does Not Have Access");
            return false;
        }

        //returns all employees on this floor
        public string viewEmployeesWithAccess()
        {
            string s = "";

            for(int i = 0; i < numEmployees; i++)
            {
                s += accessList[i].getInfo() + "\n";
            }

            WriteLine("\nAll Employees With Access\n");
            return s + "\n";
        }

        public string viewMostFrequentEmployee()
        {
            string s = "";
            int[] arr = new int[numEmployees];
            int largestAccessNum;

            for(int i = 0; i < numEmployees; i++)
            {
                arr[i] += accessList[i].getTimesAccessed();
            }

            //store all employees timesAccessed into an array then sort it to get the highest value

            Array.Sort(arr);
            largestAccessNum = arr[numEmployees - 1];

            for(int i = 0; i < numEmployees; i++)
            {
                if(accessList[i].getTimesAccessed() == largestAccessNum)
                {
                    s += accessList[i].getInfo();
                    
                }
            }
            //return info for employee whose timesAccessed equals greatest times accessed
            WriteLine("\nMost Frequent Employee: ");
            return s + "\n";
        }

        //tracks amount of times employee enters floor
        public Boolean allowEntry(int employeeID)
        {
            for(int i = 0; i < numEmployees; i++)
            {
                if(accessList[i].getEmployeeID() == employeeID)
                {
                    WriteLine("Access Granted");
                    accessList[i].incrementTimesAccessed();
                    return true;
                }
            }

            WriteLine("Could not located employee");
            return false;
        }
        
        //returns current floor number
        public int getFloorNumber()
        {
            return this.floorNumber;
        }

        //returns number of employees on this floor
        public int getNumberEmployees()
        {
            return this.numEmployees;
        }
    }
}
