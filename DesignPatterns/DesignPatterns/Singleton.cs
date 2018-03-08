using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Singleton
    {
        private int counter = 0;
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter : " + counter);
        }

        public static Singleton getInstance()
        {
            Singleton instance = null;
            if (instance == null)
                instance = new Singleton();

            return instance;
        }

        public void PrintOutput(string message)
        {
            Console.WriteLine(message);
        }
    }
}
