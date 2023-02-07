using System.Collections.Generic;

namespace MultiDataSourceGenericRepository.BL.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}
