using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatecensusAnalyser.POCO
{
    public class CensusAnalyser
    {
        public enum Country  // for making class as like generic suppose we want to load some another country then we simply added in it
        {
            INDIA, US
        }
        // 
        Dictionary<string, CensusDTO> dataMap;

        /// <summary>
        /// Method for load Census data
        /// </summary>
        /// <param name="country"></param>
        /// <param name="csvFilePath"></param>
        /// <param name="dataHeaders"></param>
        /// <returns></returns>
        /// 
        
        public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, Country country, string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}
