namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("susen", "jygggkg@gmail.com");
            user.Name = "susen";
            user.Email = "jygggkg@gmail.com";


            Console.Write("Name daxil edin: ");
            user.Name = Console.ReadLine();

            do {
                Console.Write("Email daxil edin: ");
                user.Email = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(user.Email))
                {
                    Console.WriteLine("Email cannot be empty");
                }
            } while(user.Email == "");

            Customer customer = new Customer("susen", "jygggkg@gmail.com", 10);

            Console.Write($"Balance: {customer.Balance}");

            Admin admin = new Admin("susen", "jygggkg@gmail.com", "tttt");

            Console.WriteLine($"    Role: {admin.Role}");

            Product product = new Product("Computer", 2.4, 6);


            Console.WriteLine($"Name: {product.Name}  Price: {product.Price}   Stock: {product.Stock}");

            DerivedProductsPhone derivedProductsPhone = new DerivedProductsPhone("Computer", 2.4, 1, "ASUS", "shsh");

            Console.WriteLine($"Brand: {derivedProductsPhone.Brand}  Storage: {derivedProductsPhone.Storage}");

            Laptop laptop = new Laptop("Computer", 2.4, 1, 16, 7);

            Console.WriteLine($"Ram: {laptop.RAM}   Processor: {laptop.Processor} ");


            Order order = new Order("Anna", product, 1);

            Console.WriteLine($"Customer: {user.Name}");
            order.Methodd();

        }
    }
}














