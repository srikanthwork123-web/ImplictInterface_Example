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
            devObj.DisplayData();//Here directly clling the methods.
            devObj.Work();
            Console.ReadLine();
        }
    }
}
/*
 *In C#, interface methods can be implemented in two ways:

✅ Implicit Interface Implementation

✅ Explicit Interface Implementation
🔹 1. Implicit Interface Implementation

👉 Method is implemented normally (public).
👉 You can call it using the object directly.
✔ Method must be public
✔ Can call using class object directly
