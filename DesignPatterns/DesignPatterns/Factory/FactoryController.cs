using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class FactoryController
    {
        public static IEmployeeType getEmployee(int empType)
        {
            IEmployeeType emp=null;
            switch (empType)
            {
                case 1:
                    emp = new clsPermanentEmployee();
                    break;
                case 2:
                    emp = new clsContractEmployee();
                    break;
                default:
                    chooseType();
                    break;
            }
            return emp;
        }

        public static void chooseType()
        {
            Console.WriteLine("Choose the type of Employee:\n 1 - Permanent \n 2 - Contract");
        }

        public static string getEmployeeType()
        {
            try
            {
                string data = Console.ReadLine();
                if (string.IsNullOrEmpty(data))
                    return "Invalid Input";
                else
                {
                    data = (data == "Permanent" | data == "1") ? "1" : ((data == "Contract" | data == "2") ? "2" : "Incorrect data");
                }
                Console.WriteLine(data);                
                return data;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
