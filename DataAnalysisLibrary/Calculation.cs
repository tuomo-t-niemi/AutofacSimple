using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLibrary;

namespace DataAnalysisLibrary
{
    public class Calculation
    {
        public void Histogram(int dataSet)
        {
            Logger logger = new Logger();
            logger.Log("Calculating histogram");
            Console.WriteLine($"Calculated histogram from dataset: {dataSet}");
        }
    }
}
