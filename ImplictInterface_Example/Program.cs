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
//This is normal Interfce or implicit interfce example.here method names are not same in any interfces.
//Due to that we can call interface implented methods by using child class object.
            Developer devObj=new Developer();
            devObj.DisplayData();//Here directly calling the methods by using child class object.
            devObj.Work();
            devObj.StudentDataDisplay();
            Console.ReadLine();
        }
    }
}
/*
 *In C#, interface methods can be implemented in two ways:

✅ Implicit Interface Implementation

✅ Explicit Interface Implementation
🔹 1. Implicit Interface Implementation
==================================================
👉 Method is implemented normally (public).
👉 You can call it using the object directly.
✔ Method must be public
✔ Can call using class object directly
*/