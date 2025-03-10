namespace Bloggy.Server.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public required string TopicStr { get; set; }
        public required string Description { get; set; }
        public required string Text { get; set; }
    }
}
