using BusinessLogicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            BusenessLogic busenessLogic = new BusenessLogic();
            busenessLogic.ProcessData();
            Console.ReadLine();
        }
    }
}
