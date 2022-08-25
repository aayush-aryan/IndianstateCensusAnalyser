using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndianStatecensusAnalyser.POCO
{
    public class IndianCensusAdapter : CensusAdapter
    {
        string[] censusData;
        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, string dataHeaders)
        {
            dataMap = new Dictionary<string, CensusDTO>();
            //calling GetCensusData() method to return census data in form of array from csv file;
            censusData = GetCensusData(csvFilePath, dataHeaders);
            foreach (string data in censusData.Skip(1)) // for skiping header 
            {
                if (!data.Contains(","))
                {
                    throw new CensusAnalyserException("File contains wrong delimiter", CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER);
                }
                //Split()- here split data seperated by , delimeter and store in array
                string[] column = data.Split(",");
                if (csvFilePath.Contains("IndiaStateCode.csv"))
                    dataMap.Add(column[1], new CensusDTO(new POCO.StateCodeDataDAO(column[0], column[1], column[2], column[3])));
                if (csvFilePath.Contains("IndiaStateCensusData.csv"))
                    dataMap.Add(column[0], new CensusDTO(new CensusDataDAO(column[0], column[1], column[2], column[3])));//state,population,area,density

            }
            return dataMap.ToDictionary(p => p.Key, p => p.Value);   //Enumerable static class
            //ToDictionary-return dictinary<TKey,Tvalue> selected from input sequence
            //Creates a dictionary<Tkey,value> according to specified key selector and element selector
        }
    }
}
