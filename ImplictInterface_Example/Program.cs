using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplictInterface_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer devObj=new Developer();
            devObj.DisplayData();
            devObj.Work();
            Console.ReadLine();
        }
    }
}
