using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLibrary;

namespace DataAcquisitionLibrary
{
    public class Instrument
    {
        public int Measure()
        {
            Logger logger = new Logger();
            logger.Log("Measuring data");
            int dataSet = (new Random()).Next();
            Console.WriteLine($"Measured dataset: {dataSet}");
            return dataSet;
        }
    }
}
