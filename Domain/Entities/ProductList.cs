namespace Domain.Entities
{
    public class ProductList
    {
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
