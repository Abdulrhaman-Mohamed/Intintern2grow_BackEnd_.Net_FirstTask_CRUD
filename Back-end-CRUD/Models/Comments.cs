using System.ComponentModel.DataAnnotations.Schema;

namespace Back_end_CRUD.Models
{
    public class Comments
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }

        public int PostId { get; set; }
        public Posts Posts { get; set; }

        public int UserId { get; set; }

        public Users Users { get; set; }
    }
}
