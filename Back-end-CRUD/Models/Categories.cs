using System.ComponentModel.DataAnnotations.Schema;

namespace Back_end_CRUD.Models
{
    public class Categories
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Posts> PostsFK { get; set; }


    }
}
