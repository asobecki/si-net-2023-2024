namespace w2routing.Domain.Entities
{

    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Price { get; set; }
        public String Category { get; set; }

        public Product()
        {
            Name = Price = Category = "";
        }

        public Product(int id, String name, String price, String category)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
        }
    }
}
