using System;
using System.Collections.Generic;

namespace Use
{
    class Adresse
    {
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string City_AndPO_Box { get; set; }
        public Adresse(string street, string house, string city)
        {
            StreetName = street;
            HouseNumber = house;
            City_AndPO_Box = city;
        }
        public override string ToString()
        {
            return string.Format($" {StreetName}, {HouseNumber}, {City_AndPO_Box}");
        }
    }
    abstract class Person
    {
        public string Name { get; }
        public int Age { get; }
        public Adresse Address { get; set; }
        public Person(string name, int age, Adresse address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
        public override string ToString()
        {
            return string.Format($"Name: {Name}\nAge: {Age}\nAdresse: {Address}");
        }
    }
    abstract class Worker : Person
    {
        public decimal Salary { get; set; }
        public Worker(string name, int age, Adresse address, decimal salary) : base(name, age, address)
        {
            Salary = salary;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nSalary: {Salary:C2}";
        }
    }
    class Arbeiter : Worker
    {
        public Arbeiter(string name, int age, Adresse address, decimal salary) : base(name, age, address, salary)
        {
        }
    }
    class Angestellter : Worker
    {
        public Angestellter(string name, int age, Adresse address, decimal salary) : base(name, age, address, salary)
        {
        }
    }
    class Client : Person
    {
        private List<Product> Products { get; set; }
        public Client(string name, int age, Adresse address) : base(name, age, address)
        {
            Products = new List<Product>();
        }
        public void BuyProduct(Product p, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Products.Add(p);
            }
        }
        public void BoughtProducts()
        {
            foreach (var item in Products)
            {
                Console.WriteLine(item);
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"\nBought: {Products.Count} Products";
        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public Product(string name)
        {
            ProductName = name;
        }
        public override string ToString()
        {
            return ProductName;
        }
    }
    class Fabric
    {
        public Adresse Address { get; set; }
        public List<Product> OurProducts { get; set; }
        public List<Client> OurClients { get; set; }
        public List<Worker> OurWorkers { get; set; }
        public Worker Manager { get; }
        public Fabric(Adresse adress)
        {
            Address = adress;
            OurProducts = new List<Product>();
            OurClients = new List<Client>();
            OurWorkers = new List<Worker>();
            Manager = new Angestellter("Mac Mars", 22, new Adresse("Learning-Street", "House 7", "1007 Book Slide City"), 6000m);
        }
        public void AddProduct(Product p)
        {
            if (!OurProducts.Contains(p))
                OurProducts.Add(p);
        }
        public void AddClient(Client c)
        {
            if (!OurClients.Contains(c))
                OurClients.Add(c);
        }
        public void AddWorker(Worker w)
        {
            if (!OurWorkers.Contains(w))
                OurWorkers.Add(w);
        }
        public void Products()
        {
            Console.WriteLine("We have {0} different types of products as listed below: ", OurProducts.Count);
            foreach (var item in OurProducts)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }
        public void Clients()
        {
            Console.WriteLine("Fabric clients: ");
            foreach (var item in OurClients)
            {
                Console.WriteLine($"{item}\n");
            }
        }
        public void Workers()
        {
            AddWorker(Manager);
            Console.WriteLine("Fabric workers: ");
            foreach (var item in OurWorkers)
            {
                Console.WriteLine($"{item}\n");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            var prod1 = new Product("Banana");
            var prod2 = new Product("Apple");
            var client3 = new Client("Ada Marshall", 20, new Adresse("Coding-Street", "House 14", "7001 Modern Technology City"));
            var fabric = new Fabric(new Adresse("Main-Street", "Bio-Manufacture", "1001 Main City"))
            {
                OurClients = new List<Client>()
                {
                    new Client("Albert Einstein", 50, new Adresse("Relativity-Street", "House 2", "3002 Modern Science City")),
                    new Client("Isaac Newton", 57, new Adresse("Force-Street", "House 3", "1001 Classic Science City"))
                },
                OurProducts = new List<Product>() { prod1, prod2, new Product("Orange"), new Product("Pineapple"),
                   new Product("Mango"), new Product("Kiwi")},
                OurWorkers = new List<Worker>()
                {
                    new Angestellter("Ted Mosby", 37, new Adresse("Main-Street", "House 11", "1001 Main City"), 4000m),
                    new Arbeiter("Panda", 29,  new Adresse("Side-Street", "House 22", "1001 Main City"), 4300m)
                }
            };

            //Available products
            fabric.Products();
            // Clients and their products or are buying products
            var client1 = fabric.OurClients[0];
            client1.BuyProduct(fabric.OurProducts[0], 4);
            client1.BuyProduct(fabric.OurProducts[2], 5);

            var client2 = fabric.OurClients[1];
            client2.BuyProduct(fabric.OurProducts[1], 33);
            client2.BuyProduct(fabric.OurProducts[3], 3);

            client3.BuyProduct(fabric.OurProducts[2], 5);
            client3.BuyProduct(fabric.OurProducts[3], 1);
            client3.BuyProduct(fabric.OurProducts[5], 4);

            //Display clients with their bought products
            //Console.WriteLine("First cleint with his/her stuff: ");
            //Console.WriteLine(client1);
            //client1.BoughtProducts();
            //Console.WriteLine("Second cleint with his/her stuff: ");
            //Console.WriteLine(client2);
            //client2.BoughtProducts(); 

            //Fabric workers
            //var worker1 = fabric.OurWorkers[0];
            //var worker2 = fabric.OurWorkers[1];
            //Console.WriteLine($"1. Worker: \n{worker1}\n");
            //Console.WriteLine($"2. Worker: \n{worker2}\n");
            fabric.Workers();

            //Add or actualize clients
            fabric.AddClient(client1);
            fabric.AddClient(client2);
            fabric.AddClient(client3);
            fabric.Clients();

        }
    }
}
