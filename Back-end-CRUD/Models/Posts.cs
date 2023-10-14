using System.ComponentModel.DataAnnotations.Schema;

namespace Back_end_CRUD.Models
{
    public class Posts
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public string? ImagePath { get; set; }
        public DateTime? PostData { get; set; }

        public int? UserId { get; set; }

        public Users? Users { get; set; }


        public virtual ICollection<Comments>? CommentsFK { get; set; }
        public virtual ICollection<Categories>? CategoriesFK { get; set; }


    }
}
