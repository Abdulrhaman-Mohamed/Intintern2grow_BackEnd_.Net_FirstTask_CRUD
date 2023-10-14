using System.ComponentModel.DataAnnotations.Schema;

namespace Back_end_CRUD.Models
{
    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Role { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }


        public virtual ICollection<Posts> Posts { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }


    }
}
