namespace Web.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
