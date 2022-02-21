
using System.Collections.Generic;

namespace RepositoryPattern.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
