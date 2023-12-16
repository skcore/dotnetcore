using WebAPIDotnet8.Entities;

namespace WebAPIDotnet8.Services
{
    public interface ICovidLogDataService
    {
        List<CovidLog> GetcovidLogs();

        List<CovidLog> SaveCovidLogs(CovidLog covidLog);

        CovidLog GetCovid(int logID);

        CovidLog UpdateCovidLogs(CovidLog covidLog);

        List<CovidLog> DeleteCovidLogs(int logID);
    } 
}
