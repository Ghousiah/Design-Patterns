using DesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************** Singleton *************************");
            Singleton instance = Singleton.getInstance();
            instance.PrintOutput("This is an implementation of singleton which belongs to the creational design pattern");
            instance.PrintOutput("Only single instance is created throughout the application");

            Console.WriteLine("*********************** Factory *************************");
            IEmployeeType emp;
            FactoryController.chooseType();
            try
            {
                emp = FactoryController.getEmployee(Convert.ToInt32(FactoryController.getEmployeeType().ToString()));
                emp.setEmployeeType();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
