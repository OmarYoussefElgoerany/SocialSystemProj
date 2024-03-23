namespace SystemApi.SystemDAL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public virtual List<Post> Posts { get; set; } = new List<Post>();
        public virtual List<Story> Stories { get; set; } = new List<Story>();
    }
}
