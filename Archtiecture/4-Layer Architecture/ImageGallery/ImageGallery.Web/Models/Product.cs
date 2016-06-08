namespace ImageGallery.Web.Models
{
    public class Product
    {
        public int ProductId;
        public string Name;
        public string Description;
        public decimal Price;
        public Category Category;
    }

    public enum Category
    {
        Car,
        Airplane,
        Bicycle,
        Motorcycle
    }
}