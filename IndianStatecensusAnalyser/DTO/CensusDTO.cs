using System;
using System.Collections.Generic;
using System.Text;

//namespace IndianStatecensusAnalyser.DTO
namespace IndianStatecensusAnalyser.POCO // CensusDataDTO class is Inherited there;
{
    public class CensusDTO
    {
        public string state; //
        public long population; //
        public long area; //
        public long density;  //
        public int serialNumber;
        public string stateName;
        public int tin;
        public string stateCode;
        public double waterArea;
        public double landArea;
        public CensusDTO(CensusDataDAO censusDataDao)
        {
            this.state = censusDataDao.state;
            this.population = censusDataDao.population;
            this.area = censusDataDao.area;
            this.density = censusDataDao.density;
        }
        public CensusDTO(StateCodeDataDAO stateCodeDataDAO)
        {
            this.serialNumber = stateCodeDataDAO.serialNumber;
            this.stateName = stateCodeDataDAO.stateName;
            this.tin = stateCodeDataDAO.tin;
            this.stateCode = stateCodeDataDAO.stateCode;
        }
        /*
        public CensusDTO(PopulationDataDAO censusDataDAO)
        {
            this.state = censusDataDAO.state;
            this.population = censusDataDAO.population;
            this.area = censusDataDAO.area;
            this.density = censusDataDAO.density;
        }
        */

    }
}
