using Back_end_CRUD.Model_View;
using Back_end_CRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.Extensions.Hosting;

namespace Back_end_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloggerController : ControllerBase
    {
        private readonly ApplicationDbcontext _dbcontext;
        public BloggerController(ApplicationDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet("Posts")]
        //Put your Index Page
        public IActionResult GetPosts(int indexPage=0)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok( _dbcontext.Posts.Take(10).Skip(10*indexPage).ToList());
        }




        [HttpPost("Create")]
        public IActionResult CreatePosts([FromForm]PostViewcs posts)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if(_dbcontext.Users.FirstOrDefault(o => o.Id == posts.UserID) == null)
                return BadRequest("Please Check UserID");

            var fileName = Path.GetRandomFileName() + ".jpg";
            var filePath = Path.Combine("wwwroot/PostsImages",
            fileName);

            using (var stream = System.IO.File.Create(filePath))
            {
                 posts.Image.CopyTo(stream);
            }

            var newpost = new Posts
            {
                PostContent = posts.PostContent,
                PostData = DateTime.Now,
                PostTitle = posts.PostTitle,
                ImagePath = fileName,
                UserId = posts.UserID
            };
            _dbcontext.Posts.Add(newpost);
            _dbcontext.SaveChanges();


            return Ok(posts);
        }



        // can Update Your Post But if Your Post doesn't have image before it can be update or added  
        [HttpPut("Update")]
        public IActionResult UpdatePosts([FromForm] PostViewcs posts , int Post )
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var Post_Db = _dbcontext.Posts.FirstOrDefault(o => o.Id == Post);
            if(Post_Db == null)
                return BadRequest("No Post Like it");

            if(Post_Db.ImagePath.Any())
            {
                var filePath = Path.Combine("wwwroot/PostsImages",
                    Post_Db.ImagePath);


                using (var stream = System.IO.File.Create(filePath))
                {
                    posts.Image.CopyTo(stream);
                }
            }

            Post_Db.PostData=DateTime.Now;
            Post_Db.PostContent=posts.PostContent;
            Post_Db.PostTitle=posts.PostTitle;

            _dbcontext.Posts.Update(Post_Db);
            _dbcontext.SaveChanges();
            return Ok(posts);




        }


        [HttpDelete]
        public IActionResult DeletePosts(int PostID)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var Post_Db = _dbcontext.Posts.FirstOrDefault(o => o.Id == PostID);
            if (Post_Db == null)
                return BadRequest("No Post Like it");

            if (Post_Db.ImagePath.Any())
            {
                var filePath = Path.Combine("wwwroot/PostsImages",
                    Post_Db.ImagePath);

                System.IO.File.Delete(filePath);
            }

            _dbcontext.Posts.Remove(Post_Db);
            _dbcontext.SaveChanges();

            return NoContent();
        }

    }
}
