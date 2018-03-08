using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class clsContractEmployee : IEmployeeType
    {
        public void setEmployeeType()
        {
            Console.WriteLine("I'm a Contract Employee");
        }
    }
}
