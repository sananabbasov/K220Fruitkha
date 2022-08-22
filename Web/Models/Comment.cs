﻿namespace Web.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
