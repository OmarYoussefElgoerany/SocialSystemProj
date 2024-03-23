namespace SystemApi.SystemDAL.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
