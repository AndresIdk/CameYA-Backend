namespace CameYA.Core.DTOs
{
    public class ServiceDTO
    {
        public string id_service { get; set; }
        public int client_dni { get; set; }
        public int worker_dni { get; set; }
        public string city { get; set; }
        public long total { get; set; }
        public string status { get; set; }
        public double? client_rate { get; set; }
        public double? worker_rate { get; set; }
        public DateTime date_programmed { get; set; }
    }
}
