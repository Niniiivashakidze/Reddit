using System;
using System.Collections.Generic;

namespace Reddit.Models
{
    public class Community
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<User> UserSubscribers { get; set; }
        public User Owner { get; set; }
    }
}