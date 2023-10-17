using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ConstructoriDemo
{
    internal class Program
    {
        static void Main()
        {
            var man = new Manufacturer();
            man.Name = "Georgi";
            var man2 = new Manufacturer("Atanas","+359-953-67-23");
            var man3 = new Manufacturer("Hristiqn", "+359888753", "vuzdoh.com","hristiqn@abv.bg");
            var manufactures = new List<Manufacturer>()
            {
            new Manufacturer
            {
                Id = 1,
                Name = "Lex",
                Telephone = "0883368643",
                Email="lex@yahoo.com",
                WebSiteURL="www.lex-company.com"
            },
            new Manufacturer()
            {
                Id = 2,
                Name = "Krasi",
                Telephone = "0883368999",
                Email = "krasi-white-magic@abv.bg",
                WebSiteURL = "www.krasi-plant.com"
            }
        };            
            Manufacturer.Add(new Manufacturer());
            Manufacturer.Add(new Manufacturer("Puma", "+359888753", "puma.com", "puma@abv.bg"));


        }
        Product product = new Product()
        {
            Name = "Prah za prane LEX",
            Description = "Hitriqt nachin za prane Lex, Rex i t.n...",
            PriceBGN = 12.43m,
            WeightKgs = 2,
            ProductType = ProductType.CleaningSupplies,
            Manufacturer = manufacturers,
            ExpiratinoDate = DateTime.ParseExact("02-10/2024", "dd-MM/yyyy", CultureInfo.InvariantCulture)
        };
        private static Manufacturer manufacturers;
    }

    public class manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string WebSiteURL { get; set; }
        public manufacturer()
        {

        }
    }


    public class Product
    {
        public decimal PriceBGN { get; set; }
        public DateTime ExpiratinoDate { get; set; }
        public double WeightKgs { get; set; }
        public ProductType ProductType { get; set; }
        public string Description { get; set; }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Manufacturer Manufacturer { get; set; }

    }

    public enum ProductType
    {
        Food, BeverageAlcohol, BeverageNonAlcohol, CleaningSupplies, Clothing
    }
    public class Manufacturer
    {
        private string telephone;
        public string Telephone { get => telephone; set => telephone = value; }
        public int Id { get; set; }
        public string Name { get; set; } = "Asen";
        public string WebSiteURL { get; set; }
        public string Email { get; set; }
        public Manufacturer()
        {
            Name = "Genadi";
        }
        public Manufacturer(string name, string phoneNumber) 
        {
            Name = name;
            Telephone = phoneNumber;
        }

        public Manufacturer(string name, string webSiteURL, string Telephone, string email)
        {

            Name = name;
            this.telephone = telephone;
            WebSiteURL = webSiteURL;
            Telephone = telephone;
            Email = email;
        }

        public void ChangeName()
        {
            Name = "Mitko";
        }

        internal static void Add(Manufacturer manufacturer)
        {
            throw new NotImplementedException();
        }
    }
}