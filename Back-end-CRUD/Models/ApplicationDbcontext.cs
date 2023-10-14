using Microsoft.EntityFrameworkCore;

namespace Back_end_CRUD.Models
{
    public class ApplicationDbcontext: DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options ):base(options) { }

        public DbSet<Posts> Posts { get; set; }
        public DbSet<Categories> Categories  { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Comments> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Categories>()
                .HasKey(o => o.Id);

            modelBuilder.Entity<Users>()
    .HasKey(o => o.Id);

            modelBuilder.Entity<Posts>()
    .HasKey(o => o.Id);


            modelBuilder.Entity<Comments>()
    .HasKey(o => o.id   );

            modelBuilder.Entity<Posts>().
                HasMany<Categories>(o => o.CategoriesFK).
                WithMany(o => o.PostsFK);

            modelBuilder.Entity<Posts>()
                .HasMany<Comments>(o => o.CommentsFK)
                .WithOne(o => o.Posts)
                .HasForeignKey(o => o.PostId);

            modelBuilder.Entity<Users>()
                .HasMany<Comments>(o=>o.Comments)
                .WithOne(o => o.Users)
                .HasForeignKey(o => o.UserId);


            modelBuilder.Entity<Users>()
                .HasMany<Posts>(o => o.Posts)
                .WithOne(o => o.Users)
                .HasForeignKey(o => o.UserId);




        }

        
    }
}
