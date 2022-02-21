namespace RepositoryPattern.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string Warranty { get; set; }
        public string Detail { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
