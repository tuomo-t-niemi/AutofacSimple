using BusinessLogicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacSimple
{
    public class Application : IApplication
    {
        IBusinessLogic _busenessLogic;

        public Application(IBusinessLogic busenessLogic)
        {
            _busenessLogic = busenessLogic;
        }

        public void Run()
        {
            _busenessLogic.ProcessData();
        }
    }
}
