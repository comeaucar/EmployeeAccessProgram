using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LabTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carter Comeau (101253879)

            //construct floorAccessManager
            FloorAccessManager ResearchLevel = new FloorAccessManager(10, 1);
            
            //Add Employees
            ResearchLevel.addEmployee(2988, "Tony", "Stark", "Manager");
            ResearchLevel.addEmployee(8927, "Peter", "Parker", "Researcher1");
            ResearchLevel.addEmployee(6712, "David", "Banner", "Researcher1");
            ResearchLevel.addEmployee(9822, "Max", "Richardson", "Supervisor");

            //Log everytime employee access' floor
            ResearchLevel.allowEntry(6712);
            ResearchLevel.allowEntry(8927);
            ResearchLevel.allowEntry(6712);
            ResearchLevel.allowEntry(7753);
            ResearchLevel.allowEntry(9822);
            ResearchLevel.allowEntry(6712);
         

            //test methods 
            Console.WriteLine(ResearchLevel.viewMostFrequentEmployee());

            Console.WriteLine(ResearchLevel.viewEmployeesWithAccess());
  
            Console.ReadKey();

        }
    }
}
