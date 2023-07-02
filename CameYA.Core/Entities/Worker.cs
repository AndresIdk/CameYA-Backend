namespace CameYA.Core.Entities
{
    public class Worker : UserEntity
    {
        public string detail { get; set; }
        public string category { get; set; }
        public long hour_price { get; set; }
    }
}
