namespace Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
        public enum role { User, Admin }
        public string phone_number { get; set; }
    }
}