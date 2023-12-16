namespace WebAPIDotnet8.Entities
{
    public class CovidLog
    {
        public CovidLog()
        {
            
        }
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Covidlogmsg { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
