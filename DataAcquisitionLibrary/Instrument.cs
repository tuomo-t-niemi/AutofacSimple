using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLibrary;

namespace DataAcquisitionLibrary
{
    public class Instrument : IInstrument
    {
        ILogger _logger;

        public Instrument(ILogger logger)
        {
            _logger = logger;
        }

        public int Measure()
        {
            _logger.Log("Measuring data");
            int dataSet = (new Random()).Next();
            Console.WriteLine($"Measured dataset: {dataSet}");
            return dataSet;
        }
    }
}
