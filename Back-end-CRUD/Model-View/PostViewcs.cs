namespace Back_end_CRUD.Model_View
{
    public class PostViewcs
    {
        public string PostTitle { get; set; }
        public string PostContent { get; set; }

        public IFormFile Image { get; set; }

        public int? UserID { get; set; }
    }
}
