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
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IInstrument _instrument;
        ICalculation _calculation;

        public BusinessLogic(ILogger logger, IInstrument instrument, ICalculation calculation)
        {
            _logger = logger;
            _instrument = instrument;
            _calculation = calculation;
        }

        public void ProcessData()
        {
            _logger.Log("Starting new measurement ...");
            int dataSet = _instrument.Measure();
            _logger.Log("Measurement acquired. Starting analysis ...");
            _calculation.Histogram(dataSet);
            _logger.Log("Analysis completed.");
        }
    }
}
