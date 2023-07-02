namespace CameYA.Core.Entities
{
    public abstract class UserEntity
    {
        public string Dni { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public double rate { get; set; }
    }
}
