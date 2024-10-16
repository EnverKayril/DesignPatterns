namespace DesignPattern.Composite.DAL
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int UpperCategoryId { get; set; }
        public IList<Product> Products { get; set; }
    }
}
