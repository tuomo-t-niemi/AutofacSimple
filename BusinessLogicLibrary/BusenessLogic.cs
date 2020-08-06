using DataAcquisitionLibrary;
using DataAnalysisLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLibrary;

namespace BusinessLogicLibrary
{
    public class BusenessLogic
    {
        public void ProcessData()
        {
            Logger logger = new Logger();
            logger.Log("Starting new measurement ...");
            Instrument instrument = new Instrument();
            int dataSet = instrument.Measure();
            logger.Log("Measurement acquired. Starting analysis ...");
            Calculation calculation = new Calculation();
            calculation.Histogram(dataSet);
            logger.Log("Analysis completed.");
        }
    }
}
