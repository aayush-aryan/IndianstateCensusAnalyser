using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IndianStatecensusAnalyser.POCO
{
    public class CensusAdapter
    {
        string[] censusData;
        /// <summary>
        /// Method to return census data from csv file or return exception whenever we  getting it out;
        /// Path is class in system.io package and
        ///GetExtension() method returns including (.)extension of specified path of string;
        ///
        /// 
        /// </summary>
        /// <param name="csvFilePath"></param>
        /// <param name="dataHeaders"></param>
        /// <returns></returns>
        protected string[] GetCensusData(string csvFilePath, string dataHeaders)
        {
            if (!File.Exists(csvFilePath))//1st parameter to check file
            {
                throw new CensusAnalyserException("File Not Found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }
            if (Path.GetExtension(csvFilePath) != ".csv") //2nd parameter to check file
            {
                throw new CensusAnalyserException("Invalid File Type", CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE);
            }
            // ReadAllLines()- open the file and read all lines of file and then close the files
            //returns string array containing  all lines of file;
            censusData = File.ReadAllLines(csvFilePath);
            if (censusData[0] != dataHeaders) //3rd parameter to check file
            {
                throw new CensusAnalyserException("Incorrect header in Data", CensusAnalyserException.ExceptionType.INCORRECT_HEADER);
            }
            return censusData;
        }
    }
}
