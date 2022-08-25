using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatecensusAnalyser.POCO
{
    public class CensusAnalyserException: Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND, 
            INVALID_FILE_TYPE, 
            INCORRECT_HEADER,
            NO_SUCH_COUNTRY,
            INCORRECT_DELIMITER,
        }
        public ExceptionType exceptionType;
      
        public CensusAnalyserException(string message, ExceptionType exceptionType) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
