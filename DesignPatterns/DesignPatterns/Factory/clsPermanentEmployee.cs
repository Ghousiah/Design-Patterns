using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class clsPermanentEmployee : IEmployeeType
    {
        public void setEmployeeType()
        {
            Console.WriteLine("I'm a Permanant Employee");
        }
    }
}
