using System.ComponentModel.DataAnnotations;

namespace SystemApi.SystemDAL.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Range(1, 6)]
        public int Rate { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int PostId { get; set; }
        public virtual Post? Post { get; set; }
    }
}
