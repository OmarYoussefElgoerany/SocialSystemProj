using System.ComponentModel.DataAnnotations;

namespace SystemApi.SystemDAL.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public virtual List<Post> Posts { get; set; } = new List<Post>();
    }
}
