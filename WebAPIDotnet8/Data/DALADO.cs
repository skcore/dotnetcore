using Microsoft.Data.SqlClient;
using System.Data;
using WebAPIDotnet8.Entities;

namespace WebAPIDotnet8.Data
{
    public class DALADO
    {
        string? conStr = string.Empty;
        List<CovidLog> covidLogs = new List<CovidLog>();
        CovidLog covidLog;
        public DALADO()
        {
            var builder = WebApplication.CreateBuilder();
            this.conStr = builder.Configuration.GetConnectionString("DefaultConnection");
        }

        public List<CovidLog> DeleteCovidLogs(int logID)
        {
            SqlConnection conn = new SqlConnection(conStr);

            if (conn.State != ConnectionState.Open)
                conn.Open();

            SqlCommand cmd = new SqlCommand("delete from covidLogs where Id=@Id", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = logID;
            cmd.ExecuteNonQuery();

            conn.Close();

            covidLogs = GetcovidLogs();

            return covidLogs;
        }

        public CovidLog GetCovid(int logID)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(conStr);
            if (conn.State != ConnectionState.Open)
                conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from covidLogs where Id=@Id", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("Id", SqlDbType.Int).Value = logID;
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    covidLog = new CovidLog
                    {
                        Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                        Name = Convert.ToString(dt.Rows[0]["Name"]),
                        Covidlogmsg = Convert.ToString(dt.Rows[0]["Covidlogmsg"]),
                        CreatedDate = Convert.ToDateTime(dt.Rows[0]["CreatedDate"])
                    };
                }
            }

            conn.Close();

            return covidLog;
        }

        public List<CovidLog> GetcovidLogs()
        {
            DataSet ds = new DataSet();

            SqlConnection conn = new SqlConnection(conStr);
            if (conn.State != ConnectionState.Open)
                conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from covidLogs", conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(ds);

            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        covidLog = new CovidLog
                        {
                            Id =Convert.ToInt32(dr["Id"]),
                            Name = Convert.ToString(dr["Name"]),
                            Covidlogmsg = Convert.ToString(dr["Covidlogmsg"]),
                            CreatedDate = Convert.ToDateTime(dr["CreatedDate"])
                        };

                        covidLogs.Add(covidLog);
                    }
                }
            }

            conn.Close();

            return covidLogs;
        }

        public List<CovidLog> SaveCovidLogs(CovidLog covidLog)
        {
            SqlConnection conn = new SqlConnection(conStr);

            if (conn.State != ConnectionState.Open)
                conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.covidLogs(Name,Covidlogmsg,CreatedDate)values(@Name,@Covidlogmsg,@CreatedDate)", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = covidLog.Name;
            cmd.Parameters.Add("@Covidlogmsg", SqlDbType.NVarChar).Value = covidLog.Covidlogmsg;
            cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = covidLog.CreatedDate;
            cmd.ExecuteNonQuery();

            conn.Close();

            covidLogs = GetcovidLogs();

            return covidLogs;
        }

        public CovidLog UpdateCovidLogs(CovidLog covidLogIP)
        {
            SqlConnection conn = new SqlConnection(conStr);

            if (conn.State != ConnectionState.Open)
                conn.Open();

            SqlCommand cmd = new SqlCommand("update dbo.covidLogs set Name=@Name,Covidlogmsg=@Covidlogmsg,CreatedDate=@CreatedDate where Id=@Id", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = covidLogIP.Id;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = covidLogIP.Name;
            cmd.Parameters.Add("@Covidlogmsg", SqlDbType.NVarChar).Value = covidLogIP.Covidlogmsg;
            cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = covidLogIP.CreatedDate;
            cmd.ExecuteNonQuery();

            conn.Close();

            covidLog = GetCovid(covidLogIP.Id);

            return covidLog;
        }

    }
}
