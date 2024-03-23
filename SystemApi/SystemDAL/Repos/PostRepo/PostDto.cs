using SystemApi.SystemDAL.Models;

namespace SystemApi.SystemDAL.Repos.PostRepo
{
    public class PostDto
    {
        public string Name { get; set; } = string.Empty;
        public int UserId { get; set; }
    }
}
