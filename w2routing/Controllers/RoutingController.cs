using Microsoft.AspNetCore.Mvc;
using w2routing.Domain.Entities;

namespace w2routing.Controllers
{
    public class RoutingController : Controller
    {
        private Dictionary<int, Product> catalog = new Dictionary<int, Product>();

        public RoutingController()
        {
            InitializeCatalog();
        }

        // 1. CRUD
        //
        // 2. Potem dodanie walidacji po pokazaniu bindowania

        private void InitializeCatalog()
        {
            catalog = new Dictionary<int, Product>
            {
                {1, new Product(1, "Samsung Galaxy S10", "3000.20", "Smartphone")},
                {2, new Product(2, "Apple iPhone XS Max", "4900.00", "Smartphone")},
                {3, new Product(3, "Apple MacBook Pro", "9900.00", "Laptop")}
            };
        }
    }
}
