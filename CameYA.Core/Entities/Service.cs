namespace CameYA.Core.Entities
{
    public class Service : UserEntity
    {
        public string Id_service { get; set; }
        public int dni_client { get; set; }
        public int dni_worker { get; set; }
        public string city { get; set; }
        public  long total { get; set; }
        public string status { get; set; }
        public double client_rate { get; set; }
        public double worker_rate { get; set; }
        public DateTime date_programmed { get; set; }

    }
}
