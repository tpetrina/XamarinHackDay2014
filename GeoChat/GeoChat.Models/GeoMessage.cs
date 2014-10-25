using System;

namespace GeoChat.Models
{
    public class GeoMessage : Entity
    {
        public string Author { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
    }
}