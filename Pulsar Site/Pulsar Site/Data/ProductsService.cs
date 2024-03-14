using Microsoft.AspNetCore.Mvc.Diagnostics;
using Newtonsoft.Json;
using Pulsar_Site.Models;

namespace Pulsar_Site.Data
{
    static public class ProductsService
    {
        static public List<Product> AllProducts = new List<Product>();

        static public void PopulateService()
        {
            string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
            string jsonFilePath = System.IO.Path.Combine(projectRoot, "Data/AllProducts.json");

            string jsonText = System.IO.File.ReadAllText(jsonFilePath);
            AllProducts = JsonConvert.DeserializeObject<List<Product>>(jsonText);
            Console.WriteLine("Product list successful populated!");
        }

        static public List<Product> ListByCategory(string category)
        {
            return AllProducts.Where(x => x.Category == category).ToList();
        }

        static public Product GetByAcronym(string href)
        {
            var product = AllProducts.Find(x => x.Href == "/produtos/" + href);
            if (product == null) throw new KeyNotFoundException("Nenhum produto encontrado com esse ID");
            return product;
        }

    }
}

