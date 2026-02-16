using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplictInterface_Example
{
    internal class Developer:IEmployee, IStudent
    {
        public void DisplayData()
        {
            Console.WriteLine("I am DispalyingData");
        }
        public  void Work()
        {
            Console.WriteLine("I am doing work");
        }
        public void StudentDataDisplay()
        {
            Console.WriteLine("I am student Data");
        }
    }
}
