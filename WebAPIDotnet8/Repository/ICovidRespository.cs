using WebAPIDotnet8.Entities;

namespace WebAPIDotnet8.Repository
{
    public interface ICovidRespository
    {
        List<CovidLog> GetcovidLogs();

        List<CovidLog> SaveCovidLogs(CovidLog covidLog);

        CovidLog GetCovid(int logID);

        CovidLog UpdateCovidLogs(CovidLog covidLog);

        List<CovidLog> DeleteCovidLogs(int logID);
    }
}
