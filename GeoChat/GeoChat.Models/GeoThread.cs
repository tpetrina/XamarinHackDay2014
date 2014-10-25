using System.Collections.Generic;

namespace GeoChat.Models
{
    public class GeoThread : Entity
    {
        public virtual GeoLocation Location { get; set; }
        public virtual IList<GeoMessage> GeoMessages { get; set; }

        public string Name { get; set; }
    }
}