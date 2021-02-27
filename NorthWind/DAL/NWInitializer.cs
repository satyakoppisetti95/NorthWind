using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthWind.Models;

namespace Northwind.DAL
{
    public class NWInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<NorthwindContext>
    {

        private readonly Dictionary<int, Supplier> Suppliers = new Dictionary<int, Supplier>();
        private readonly Dictionary<int, Category> Categories = new Dictionary<int, Category>();
        private readonly Dictionary<int, Shipper> Shippers = new Dictionary<int, Shipper>();
        private readonly Dictionary<int, Product> Products = new Dictionary<int, Product>();

        protected override void Seed(NorthwindContext context)
        {
            SeedCategories(context);

            SeedShippers(context);

            SeedSuppliers(context);

            SeedProducts(context);
        }


        private void SeedCategories(NorthwindContext context)
        {
            Categories.Add(1, new Category
            {
                CategoryName = "Beverages",
                Description = "Soft drinks, coffees, teas, beers, and ales",
                Picture = null
            });

            Categories.Add(2, new Category
            {
                CategoryName = "Condiments",
                Description = "Sweet and savory sauces, relishes, spreads, and seasonings",
                Picture = null
            });

            Categories.Add(3, new Category
            {
                CategoryName = "Confections",
                Description = "Desserts, candies, and sweet breads",
                Picture = null
            });

            Categories.Add(4, new Category
            {
                CategoryName = "Dairy Products",
                Description = "Cheeses",
                Picture = null
            });

            Categories.Add(5, new Category
            {
                CategoryName = "Grains/Cereals",
                Description = "Breads, crackers, pasta, and cereal",
                Picture = null
            });

            Categories.Add(6, new Category
            {
                CategoryName = "Meat/Poultry",
                Description = "Prepared meats",
                Picture = null
            });

            Categories.Add(7, new Category
            {
                CategoryName = "Produce",
                Description = "Dried fruit and bean curd",
                Picture = null
            });

            Categories.Add(8, new Category
            {
                CategoryName = "Seafood",
                Description = "Seaweed and fish",
                Picture = null
            });

            foreach (var category in Categories.Values)
            {
                context.Categories.Add(category);
            }

            context.SaveChanges();

        }


        private void SeedShippers(NorthwindContext context)
        {
            Shippers.Add(1, new Shipper { CompanyName = "Speedy Express", Phone = "(503) 555-9831" });
            Shippers.Add(2, new Shipper { CompanyName = "United Package", Phone = "(503) 555-3199" });
            Shippers.Add(3, new Shipper { CompanyName = "Federal Shipping", Phone = "(503) 555-9931" });

            foreach (var shipper in Shippers.Values)
            {
                context.Shippers.Add(shipper);
            }

            context.SaveChanges();
        }

        private void SeedSuppliers(NorthwindContext context)
        {
            Suppliers.Add(1, new Supplier { CompanyName = "Exotic Liquids", ContactName = "Charlotte Cooper", ContactTitle = "Purchasing Manager", Address = "49 Gilbert St.", City = "London", PostalCode = "EC1 4SD", Fax = "", Phone = "(171) 555-2222", HomePage = "" });
            Suppliers.Add(2, new Supplier { CompanyName = "New Orleans Cajun Delights", ContactName = "Shelley Burke", ContactTitle = "Order Administrator", Address = "P.O. Box 78934", City = "New Orleans", Region = "LA", PostalCode = "70117", Fax = "", Phone = "(100) 555-4822", HomePage = "#CAJUN.HTM#" });
            Suppliers.Add(3, new Supplier { CompanyName = "Grandma Kelly's Homestead", ContactName = "Regina Murphy", ContactTitle = "Sales Representative", Address = "707 Oxford Rd.", City = "Ann Arbor", Region = "MI", PostalCode = "48104", Fax = "(313) 555-3349", Phone = "(313) 555-5735", HomePage = "" });
            Suppliers.Add(4, new Supplier { CompanyName = "Tokyo Traders", ContactName = "Yoshi Nagase", ContactTitle = "Marketing Manager", Address = "9-8 Sekimai Musashino-shi", City = "Tokyo", PostalCode = "100", Fax = "", Phone = "(03) 3555-5011", HomePage = "" });
            Suppliers.Add(5, new Supplier { CompanyName = "Cooperativa de Quesos 'Las Cabras'", ContactName = "Antonio del Valle Saavedra", ContactTitle = "Export Administrator", Address = "Calle del Rosal 4", City = "Oviedo", Region = "Asturias", PostalCode = "33007", Fax = "", Phone = "(98) 598 76 54", HomePage = "" });
            Suppliers.Add(6, new Supplier { CompanyName = "Mayumi's", ContactName = "Mayumi Ohno", ContactTitle = "Marketing Representative", Address = "92 Setsuko Chuo-ku", City = "Osaka", PostalCode = "545", Fax = "", Phone = "(06) 431-7877", HomePage = "Mayumi's (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/mayumi.htm#" });
            Suppliers.Add(7, new Supplier { CompanyName = "Pavlova, Ltd.", ContactName = "Ian Devling", ContactTitle = "Marketing Manager", Address = "74 Rose St. Moonie Ponds", City = "Melbourne", Region = "Victoria", PostalCode = "3058", Fax = "(03) 444-6588", Phone = "(03) 444-2343", HomePage = "" });
            Suppliers.Add(8, new Supplier { CompanyName = "Specialty Biscuits, Ltd.", ContactName = "Peter Wilson", ContactTitle = "Sales Representative", Address = "29 King's Way", City = "Manchester", PostalCode = "M14 GSD", Fax = "", Phone = "(161) 555-4448", HomePage = "" });
            Suppliers.Add(9, new Supplier { CompanyName = "PB Knäckebröd AB", ContactName = "Lars Peterson", ContactTitle = "Sales Agent", Address = "Kaloadagatan 13", City = "Göteborg", PostalCode = "S-345 67", Fax = "031-987 65 91", Phone = "031-987 65 43", HomePage = "" });
            Suppliers.Add(10, new Supplier { CompanyName = "Refrescos Americanas LTDA", ContactName = "Carlos Diaz", ContactTitle = "Marketing Manager", Address = "Av. das Americanas 12.890", City = "Sao Paulo", PostalCode = "5442", Fax = "", Phone = "(11) 555 4640", HomePage = "" });
            Suppliers.Add(11, new Supplier { CompanyName = "Heli Süßwaren GmbH & Co. KG", ContactName = "Petra Winkler", ContactTitle = "Sales Manager", Address = "Tiergartenstraße 5", City = "Berlin", PostalCode = "10785", Fax = "", Phone = "(010) 9984510", HomePage = "" });
            Suppliers.Add(12, new Supplier { CompanyName = "Plutzer Lebensmittelgroßmärkte AG", ContactName = "Martin Bein", ContactTitle = "International Marketing Mgr.", Address = "Bogenallee 51", City = "Frankfurt", PostalCode = "60439", Fax = "", Phone = "(069) 992755", HomePage = "Plutzer (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/plutzer.htm#" });
            Suppliers.Add(13, new Supplier { CompanyName = "Nord-Ost-Fisch Handelsgesellschaft mbH", ContactName = "Sven Petersen", ContactTitle = "Coordinator Foreign Markets", Address = "Frahmredder 112a", City = "Cuxhaven", PostalCode = "27478", Fax = "(04721) 8714", Phone = "(04721) 8713", HomePage = "" });
            Suppliers.Add(14, new Supplier { CompanyName = "Formaggi Fortini s.r.l.", ContactName = "Elio Rossi", ContactTitle = "Sales Representative", Address = "Viale Dante, 75", City = "Ravenna", PostalCode = "48100", Fax = "(0544) 60603", Phone = "(0544) 60323", HomePage = "#FORMAGGI.HTM#" });
            Suppliers.Add(15, new Supplier { CompanyName = "Norske Meierier", ContactName = "Beate Vileid", ContactTitle = "Marketing Manager", Address = "Hatlevegen 5", City = "Sandvika", PostalCode = "1320", Fax = "", Phone = "(0)2-953010", HomePage = "" });
            Suppliers.Add(16, new Supplier { CompanyName = "Bigfoot Breweries", ContactName = "Cheryl Saylor", ContactTitle = "Regional Account Rep.", Address = "3400 - 8th Avenue Suite 210", City = "Bend", Region = "OR", PostalCode = "97101", Fax = "", Phone = "(503) 555-9931", HomePage = "" });
            Suppliers.Add(17, new Supplier { CompanyName = "Svensk Sjöföda AB", ContactName = "Michael Björn", ContactTitle = "Sales Representative", Address = "Brovallavägen 231", City = "Stockholm", PostalCode = "S-123 45", Fax = "", Phone = "08-123 45 67", HomePage = "" });
            Suppliers.Add(18, new Supplier { CompanyName = "Aux joyeux ecclésiastiques", ContactName = "Guylène Nodier", ContactTitle = "Sales Manager", Address = "203, Rue des Francs-Bourgeois", City = "Paris", PostalCode = "75004", Fax = "(1) 03.83.00.62", Phone = "(1) 03.83.00.68", HomePage = "" });
            Suppliers.Add(19, new Supplier { CompanyName = "New England Seafood Cannery", ContactName = "Robb Merchant", ContactTitle = "Wholesale Account Agent", Address = "Order Processing Dept. 2100 Paul Revere Blvd.", City = "Boston", Region = "MA", PostalCode = "02134", Fax = "(617) 555-3389", Phone = "(617) 555-3267", HomePage = "" });
            Suppliers.Add(20, new Supplier { CompanyName = "Leka Trading", ContactName = "Chandra Leka", ContactTitle = "Owner", Address = "471 Serangoon Loop, Suite #402", City = "Singapore", PostalCode = "0512", Fax = "", Phone = "555-8787", HomePage = "" });
            Suppliers.Add(21, new Supplier { CompanyName = "Lyngbysild", ContactName = "Niels Petersen", ContactTitle = "Sales Manager", Address = "Lyngbysild Fiskebakken 10", City = "Lyngby", PostalCode = "2800", Fax = "43844115", Phone = "43844108", HomePage = "" });
            Suppliers.Add(22, new Supplier { CompanyName = "Zaanse Snoepfabriek", ContactName = "Dirk Luchte", ContactTitle = "Accounting Manager", Address = "Verkoop Rijnweg 22", City = "Zaandam", PostalCode = "9999 ZZ", Fax = "(12345) 1210", Phone = "(12345) 1212", HomePage = "" });
            Suppliers.Add(23, new Supplier { CompanyName = "Karkki Oy", ContactName = "Anne Heikkonen", ContactTitle = "Product Manager", Address = "Valtakatu 12", City = "Lappeenranta", PostalCode = "53120", Fax = "", Phone = "(953) 10956", HomePage = "" });
            Suppliers.Add(24, new Supplier { CompanyName = "G'day, Mate", ContactName = "Wendy Mackenzie", ContactTitle = "Sales Representative", Address = "170 Prince Edward Parade Hunter's Hill", City = "Sydney", Region = "NSW", PostalCode = "2042", Fax = "(02) 555-4873", Phone = "(02) 555-5914", HomePage = "G'day Mate (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/gdaymate.htm#" });
            Suppliers.Add(25, new Supplier { CompanyName = "Ma Maison", ContactName = "Jean-Guy Lauzon", ContactTitle = "Marketing Manager", Address = "2960 Rue St. Laurent", City = "Montréal", Region = "Québec", PostalCode = "H1J 1C3", Fax = "", Phone = "(514) 555-9022", HomePage = "" });
            Suppliers.Add(26, new Supplier { CompanyName = "Pasta Buttini s.r.l.", ContactName = "Giovanni Giudici", ContactTitle = "Order Administrator", Address = "Via dei Gelsomini, 153", City = "Salerno", PostalCode = "84100", Fax = "(089) 6547667", Phone = "(089) 6547665", HomePage = "" });
            Suppliers.Add(27, new Supplier { CompanyName = "Escargots Nouveaux", ContactName = "Marie Delamare", ContactTitle = "Sales Manager", Address = "22, rue H. Voiron", City = "Montceau", PostalCode = "71300", Fax = "", Phone = "85.57.00.07", HomePage = "" });
            Suppliers.Add(28, new Supplier { CompanyName = "Gai pâturage", ContactName = "Eliane Noz", ContactTitle = "Sales Representative", Address = "Bat. B 3, rue des Alpes", City = "Annecy", PostalCode = "74000", Fax = "38.76.98.58", Phone = "38.76.98.06", HomePage = "" });
            Suppliers.Add(29, new Supplier { CompanyName = "Forêts d'érables", ContactName = "Chantal Goulet", ContactTitle = "Accounting Manager", Address = "148 rue Chasseur", City = "Ste-Hyacinthe", Region = "Québec", PostalCode = "J2S 7S8", Fax = "(514) 555-2921", Phone = "(514) 555-2955", HomePage = "" });

            foreach (var supplier in Suppliers.Values)
            {
                context.Suppliers.Add(supplier);
            }

            context.SaveChanges();
        }



        private void SeedProducts(NorthwindContext context)
        {
            Products.Add(1, new Product { ProductName = "Chai", Supplier = Suppliers[1], Category = Categories[1], QuantityPerUnit = "10 boxes x 20 bags", UnitPrice = 18.00m, UnitsInStock = 39, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            Products.Add(2, new Product { ProductName = "Chang", Supplier = Suppliers[1], Category = Categories[1], QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = 19.00m, UnitsInStock = 17, UnitsOnOrder = 40, ReorderLevel = 25, Discontinued = false });
            Products.Add(3, new Product { ProductName = "Aniseed Syrup", Supplier = Suppliers[1], Category = Categories[2], QuantityPerUnit = "12 - 550 ml bottles", UnitPrice = 10.00m, UnitsInStock = 13, UnitsOnOrder = 70, ReorderLevel = 25, Discontinued = false });
            Products.Add(4, new Product { ProductName = "Chef Anton's Cajun Seasoning", Supplier = Suppliers[2], Category = Categories[2], QuantityPerUnit = "48 - 6 oz jars", UnitPrice = 22.00m, UnitsInStock = 53, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(5, new Product { ProductName = "Chef Anton's Gumbo Mix", Supplier = Suppliers[2], Category = Categories[2], QuantityPerUnit = "36 boxes", UnitPrice = 21.35m, UnitsInStock = 0, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = true });
            Products.Add(6, new Product { ProductName = "Grandma's Boysenberry Spread", Supplier = Suppliers[3], Category = Categories[2], QuantityPerUnit = "12 - 8 oz jars", UnitPrice = 25.00m, UnitsInStock = 120, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false });
            Products.Add(7, new Product { ProductName = "Uncle Bob's Organic Dried Pears", Supplier = Suppliers[3], Category = Categories[7], QuantityPerUnit = "12 - 1 lb pkgs.", UnitPrice = 30.00m, UnitsInStock = 15, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            Products.Add(8, new Product { ProductName = "Northwoods Cranberry Sauce", Supplier = Suppliers[3], Category = Categories[2], QuantityPerUnit = "12 - 12 oz jars", UnitPrice = 40.00m, UnitsInStock = 6, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(9, new Product { ProductName = "Mishi Kobe Niku", Supplier = Suppliers[4], Category = Categories[6], QuantityPerUnit = "18 - 500 g pkgs.", UnitPrice = 97.00m, UnitsInStock = 29, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = true });
            Products.Add(10, new Product { ProductName = "Ikura", Supplier = Suppliers[4], Category = Categories[8], QuantityPerUnit = "12 - 200 ml jars", UnitPrice = 31.00m, UnitsInStock = 31, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(11, new Product { ProductName = "Queso Cabrales", Supplier = Suppliers[5], Category = Categories[4], QuantityPerUnit = "1 kg pkg.", UnitPrice = 21.00m, UnitsInStock = 22, UnitsOnOrder = 30, ReorderLevel = 30, Discontinued = false });
            Products.Add(12, new Product { ProductName = "Queso Manchego La Pastora", Supplier = Suppliers[5], Category = Categories[4], QuantityPerUnit = "10 - 500 g pkgs.", UnitPrice = 38.00m, UnitsInStock = 86, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(13, new Product { ProductName = "Konbu", Supplier = Suppliers[6], Category = Categories[8], QuantityPerUnit = "2 kg box", UnitPrice = 6.00m, UnitsInStock = 24, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
            Products.Add(14, new Product { ProductName = "Tofu", Supplier = Suppliers[6], Category = Categories[7], QuantityPerUnit = "40 - 100 g pkgs.", UnitPrice = 23.25m, UnitsInStock = 35, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(15, new Product { ProductName = "Genen Shouyu", Supplier = Suppliers[6], Category = Categories[2], QuantityPerUnit = "24 - 250 ml bottles", UnitPrice = 15.50m, UnitsInStock = 39, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
            Products.Add(16, new Product { ProductName = "Pavlova", Supplier = Suppliers[7], Category = Categories[3], QuantityPerUnit = "32 - 500 g boxes", UnitPrice = 17.45m, UnitsInStock = 29, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            Products.Add(17, new Product { ProductName = "Alice Mutton", Supplier = Suppliers[7], Category = Categories[6], QuantityPerUnit = "20 - 1 kg tins", UnitPrice = 39.00m, UnitsInStock = 0, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = true });
            Products.Add(18, new Product { ProductName = "Carnarvon Tigers", Supplier = Suppliers[7], Category = Categories[8], QuantityPerUnit = "16 kg pkg.", UnitPrice = 62.50m, UnitsInStock = 42, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(19, new Product { ProductName = "Teatime Chocolate Biscuits", Supplier = Suppliers[8], Category = Categories[3], QuantityPerUnit = "10 boxes x 12 pieces", UnitPrice = 9.20m, UnitsInStock = 25, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
            Products.Add(20, new Product { ProductName = "Sir Rodney's Marmalade", Supplier = Suppliers[8], Category = Categories[3], QuantityPerUnit = "30 gift boxes", UnitPrice = 81.00m, UnitsInStock = 40, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(21, new Product { ProductName = "Sir Rodney's Scones", Supplier = Suppliers[8], Category = Categories[3], QuantityPerUnit = "24 pkgs. x 4 pieces", UnitPrice = 10.00m, UnitsInStock = 3, UnitsOnOrder = 40, ReorderLevel = 5, Discontinued = false });
            Products.Add(22, new Product { ProductName = "Gustaf's Knäckebröd", Supplier = Suppliers[9], Category = Categories[5], QuantityPerUnit = "24 - 500 g pkgs.", UnitPrice = 21.00m, UnitsInStock = 104, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false });
            Products.Add(23, new Product { ProductName = "Tunnbröd", Supplier = Suppliers[9], Category = Categories[5], QuantityPerUnit = "12 - 250 g pkgs.", UnitPrice = 9.00m, UnitsInStock = 61, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false });
            Products.Add(24, new Product { ProductName = "Guaraná Fantástica", Supplier = Suppliers[10], Category = Categories[1], QuantityPerUnit = "12 - 355 ml cans", UnitPrice = 4.50m, UnitsInStock = 20, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = true });
            Products.Add(25, new Product { ProductName = "NuNuCa Nuß-Nougat-Creme", Supplier = Suppliers[11], Category = Categories[3], QuantityPerUnit = "20 - 450 g glasses", UnitPrice = 14.00m, UnitsInStock = 76, UnitsOnOrder = 0, ReorderLevel = 30, Discontinued = false });
            Products.Add(26, new Product { ProductName = "Gumbär Gummibärchen", Supplier = Suppliers[11], Category = Categories[3], QuantityPerUnit = "100 - 250 g bags", UnitPrice = 31.23m, UnitsInStock = 15, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(27, new Product { ProductName = "Schoggi Schokolade", Supplier = Suppliers[11], Category = Categories[3], QuantityPerUnit = "100 - 100 g pieces", UnitPrice = 43.90m, UnitsInStock = 49, UnitsOnOrder = 0, ReorderLevel = 30, Discontinued = false });
            Products.Add(28, new Product { ProductName = "Rössle Sauerkraut", Supplier = Suppliers[12], Category = Categories[7], QuantityPerUnit = "25 - 825 g cans", UnitPrice = 45.60m, UnitsInStock = 26, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = true });
            Products.Add(29, new Product { ProductName = "Thüringer Rostbratwurst", Supplier = Suppliers[12], Category = Categories[6], QuantityPerUnit = "50 bags x 30 sausgs.", UnitPrice = 123.79m, UnitsInStock = 0, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = true });
            Products.Add(30, new Product { ProductName = "Nord-Ost Matjeshering", Supplier = Suppliers[13], Category = Categories[8], QuantityPerUnit = "10 - 200 g glasses", UnitPrice = 25.89m, UnitsInStock = 10, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });
            Products.Add(31, new Product { ProductName = "Gorgonzola Telino", Supplier = Suppliers[14], Category = Categories[4], QuantityPerUnit = "12 - 100 g pkgs", UnitPrice = 12.50m, UnitsInStock = 0, UnitsOnOrder = 70, ReorderLevel = 20, Discontinued = false });
            Products.Add(32, new Product { ProductName = "Mascarpone Fabioli", Supplier = Suppliers[14], Category = Categories[4], QuantityPerUnit = "24 - 200 g pkgs.", UnitPrice = 32.00m, UnitsInStock = 9, UnitsOnOrder = 40, ReorderLevel = 25, Discontinued = false });
            Products.Add(33, new Product { ProductName = "Geitost", Supplier = Suppliers[15], Category = Categories[4], QuantityPerUnit = "500 g", UnitPrice = 2.50m, UnitsInStock = 112, UnitsOnOrder = 0, ReorderLevel = 20, Discontinued = false });
            Products.Add(34, new Product { ProductName = "Sasquatch Ale", Supplier = Suppliers[16], Category = Categories[1], QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = 14.00m, UnitsInStock = 111, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });
            Products.Add(35, new Product { ProductName = "Steeleye Stout", Supplier = Suppliers[16], Category = Categories[1], QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = 18.00m, UnitsInStock = 20, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });
            Products.Add(36, new Product { ProductName = "Inlagd Sill", Supplier = Suppliers[17], Category = Categories[8], QuantityPerUnit = "24 - 250 g  jars", UnitPrice = 19.00m, UnitsInStock = 112, UnitsOnOrder = 0, ReorderLevel = 20, Discontinued = false });
            Products.Add(37, new Product { ProductName = "Gravad lax", Supplier = Suppliers[17], Category = Categories[8], QuantityPerUnit = "12 - 500 g pkgs.", UnitPrice = 26.00m, UnitsInStock = 11, UnitsOnOrder = 50, ReorderLevel = 25, Discontinued = false });
            Products.Add(38, new Product { ProductName = "Côte de Blaye", Supplier = Suppliers[18], Category = Categories[1], QuantityPerUnit = "12 - 75 cl bottles", UnitPrice = 263.50m, UnitsInStock = 17, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });
            Products.Add(39, new Product { ProductName = "Chartreuse verte", Supplier = Suppliers[18], Category = Categories[1], QuantityPerUnit = "750 cc per bottle", UnitPrice = 18.00m, UnitsInStock = 69, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
            Products.Add(40, new Product { ProductName = "Boston Crab Meat", Supplier = Suppliers[19], Category = Categories[8], QuantityPerUnit = "24 - 4 oz tins", UnitPrice = 18.40m, UnitsInStock = 123, UnitsOnOrder = 0, ReorderLevel = 30, Discontinued = false });
            Products.Add(41, new Product { ProductName = "Jack's New England Clam Chowder", Supplier = Suppliers[19], Category = Categories[8], QuantityPerUnit = "12 - 12 oz cans", UnitPrice = 9.65m, UnitsInStock = 85, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            Products.Add(42, new Product { ProductName = "Singaporean Hokkien Fried Mee", Supplier = Suppliers[20], Category = Categories[5], QuantityPerUnit = "32 - 1 kg pkgs.", UnitPrice = 14.00m, UnitsInStock = 26, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = true });
            Products.Add(43, new Product { ProductName = "Ipoh Coffee", Supplier = Suppliers[20], Category = Categories[1], QuantityPerUnit = "16 - 500 g tins", UnitPrice = 46.00m, UnitsInStock = 17, UnitsOnOrder = 10, ReorderLevel = 25, Discontinued = false });
            Products.Add(44, new Product { ProductName = "Gula Malacca", Supplier = Suppliers[20], Category = Categories[2], QuantityPerUnit = "20 - 2 kg bags", UnitPrice = 19.45m, UnitsInStock = 27, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });
            Products.Add(45, new Product { ProductName = "Rogede sild", Supplier = Suppliers[21], Category = Categories[8], QuantityPerUnit = "1k pkg.", UnitPrice = 9.50m, UnitsInStock = 5, UnitsOnOrder = 70, ReorderLevel = 15, Discontinued = false });
            Products.Add(46, new Product { ProductName = "Spegesild", Supplier = Suppliers[21], Category = Categories[8], QuantityPerUnit = "4 - 450 g glasses", UnitPrice = 12.00m, UnitsInStock = 95, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(47, new Product { ProductName = "Zaanse koeken", Supplier = Suppliers[22], Category = Categories[3], QuantityPerUnit = "10 - 4 oz boxes", UnitPrice = 9.50m, UnitsInStock = 36, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(48, new Product { ProductName = "Chocolade", Supplier = Suppliers[22], Category = Categories[3], QuantityPerUnit = "10 pkgs.", UnitPrice = 12.75m, UnitsInStock = 15, UnitsOnOrder = 70, ReorderLevel = 25, Discontinued = false });
            Products.Add(49, new Product { ProductName = "Maxilaku", Supplier = Suppliers[23], Category = Categories[3], QuantityPerUnit = "24 - 50 g pkgs.", UnitPrice = 20.00m, UnitsInStock = 10, UnitsOnOrder = 60, ReorderLevel = 15, Discontinued = false });
            Products.Add(50, new Product { ProductName = "Valkoinen suklaa", Supplier = Suppliers[23], Category = Categories[3], QuantityPerUnit = "12 - 100 g bars", UnitPrice = 16.25m, UnitsInStock = 65, UnitsOnOrder = 0, ReorderLevel = 30, Discontinued = false });
            Products.Add(51, new Product { ProductName = "Manjimup Dried Apples", Supplier = Suppliers[24], Category = Categories[7], QuantityPerUnit = "50 - 300 g pkgs.", UnitPrice = 53.00m, UnitsInStock = 20, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            Products.Add(52, new Product { ProductName = "Filo Mix", Supplier = Suppliers[24], Category = Categories[5], QuantityPerUnit = "16 - 2 kg boxes", UnitPrice = 7.00m, UnitsInStock = 38, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false });
            Products.Add(53, new Product { ProductName = "Perth Pasties", Supplier = Suppliers[24], Category = Categories[6], QuantityPerUnit = "48 pieces", UnitPrice = 32.80m, UnitsInStock = 0, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = true });
            Products.Add(54, new Product { ProductName = "Tourtière", Supplier = Suppliers[25], Category = Categories[6], QuantityPerUnit = "16 pies", UnitPrice = 7.45m, UnitsInStock = 21, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            Products.Add(55, new Product { ProductName = "Pâté chinois", Supplier = Suppliers[25], Category = Categories[6], QuantityPerUnit = "24 boxes x 2 pies", UnitPrice = 24.00m, UnitsInStock = 115, UnitsOnOrder = 0, ReorderLevel = 20, Discontinued = false });
            Products.Add(56, new Product { ProductName = "Gnocchi di nonna Alice", Supplier = Suppliers[26], Category = Categories[5], QuantityPerUnit = "24 - 250 g pkgs.", UnitPrice = 38.00m, UnitsInStock = 21, UnitsOnOrder = 10, ReorderLevel = 30, Discontinued = false });
            Products.Add(57, new Product { ProductName = "Ravioli Angelo", Supplier = Suppliers[26], Category = Categories[5], QuantityPerUnit = "24 - 250 g pkgs.", UnitPrice = 19.50m, UnitsInStock = 36, UnitsOnOrder = 0, ReorderLevel = 20, Discontinued = false });
            Products.Add(58, new Product { ProductName = "Escargots de Bourgogne", Supplier = Suppliers[27], Category = Categories[8], QuantityPerUnit = "24 pieces", UnitPrice = 13.25m, UnitsInStock = 62, UnitsOnOrder = 0, ReorderLevel = 20, Discontinued = false });
            Products.Add(59, new Product { ProductName = "Raclette Courdavault", Supplier = Suppliers[28], Category = Categories[4], QuantityPerUnit = "5 kg pkg.", UnitPrice = 55.00m, UnitsInStock = 79, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(60, new Product { ProductName = "Camembert Pierrot", Supplier = Suppliers[28], Category = Categories[4], QuantityPerUnit = "15 - 300 g rounds", UnitPrice = 34.00m, UnitsInStock = 19, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(61, new Product { ProductName = "Sirop d'érable", Supplier = Suppliers[29], Category = Categories[2], QuantityPerUnit = "24 - 500 ml bottles", UnitPrice = 28.50m, UnitsInStock = 113, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false });
            Products.Add(62, new Product { ProductName = "Tarte au sucre", Supplier = Suppliers[29], Category = Categories[3], QuantityPerUnit = "48 pies", UnitPrice = 49.30m, UnitsInStock = 17, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(63, new Product { ProductName = "Vegie-spread", Supplier = Suppliers[7], Category = Categories[2], QuantityPerUnit = "15 - 625 g jars", UnitPrice = 43.90m, UnitsInStock = 24, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
            Products.Add(64, new Product { ProductName = "Wimmers gute Semmelknödel", Supplier = Suppliers[12], Category = Categories[5], QuantityPerUnit = "20 bags x 4 pieces", UnitPrice = 33.25m, UnitsInStock = 22, UnitsOnOrder = 80, ReorderLevel = 30, Discontinued = false });
            Products.Add(65, new Product { ProductName = "Louisiana Fiery Hot Pepper Sauce", Supplier = Suppliers[2], Category = Categories[2], QuantityPerUnit = "32 - 8 oz bottles", UnitPrice = 21.05m, UnitsInStock = 76, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(66, new Product { ProductName = "Louisiana Hot Spiced Okra", Supplier = Suppliers[2], Category = Categories[2], QuantityPerUnit = "24 - 8 oz jars", UnitPrice = 17.00m, UnitsInStock = 4, UnitsOnOrder = 100, ReorderLevel = 20, Discontinued = false });
            Products.Add(67, new Product { ProductName = "Laughing Lumberjack Lager", Supplier = Suppliers[16], Category = Categories[1], QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = 14.00m, UnitsInStock = 52, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            Products.Add(68, new Product { ProductName = "Scottish Longbreads", Supplier = Suppliers[8], Category = Categories[3], QuantityPerUnit = "10 boxes x 8 pieces", UnitPrice = 12.50m, UnitsInStock = 6, UnitsOnOrder = 10, ReorderLevel = 15, Discontinued = false });
            Products.Add(69, new Product { ProductName = "Gudbrandsdalsost", Supplier = Suppliers[15], Category = Categories[4], QuantityPerUnit = "10 kg pkg.", UnitPrice = 36.00m, UnitsInStock = 26, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });
            Products.Add(70, new Product { ProductName = "Outback Lager", Supplier = Suppliers[7], Category = Categories[1], QuantityPerUnit = "24 - 355 ml bottles", UnitPrice = 15.00m, UnitsInStock = 15, UnitsOnOrder = 10, ReorderLevel = 30, Discontinued = false });
            Products.Add(71, new Product { ProductName = "Flotemysost", Supplier = Suppliers[15], Category = Categories[4], QuantityPerUnit = "10 - 500 g pkgs.", UnitPrice = 21.50m, UnitsInStock = 26, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(72, new Product { ProductName = "Mozzarella di Giovanni", Supplier = Suppliers[14], Category = Categories[4], QuantityPerUnit = "24 - 200 g pkgs.", UnitPrice = 34.80m, UnitsInStock = 14, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            Products.Add(73, new Product { ProductName = "Röd Kaviar", Supplier = Suppliers[17], Category = Categories[8], QuantityPerUnit = "24 - 150 g jars", UnitPrice = 15.00m, UnitsInStock = 101, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
            Products.Add(74, new Product { ProductName = "Longlife Tofu", Supplier = Suppliers[4], Category = Categories[7], QuantityPerUnit = "5 kg pkg.", UnitPrice = 10.00m, UnitsInStock = 4, UnitsOnOrder = 20, ReorderLevel = 5, Discontinued = false });
            Products.Add(75, new Product { ProductName = "Rhönbräu Klosterbier", Supplier = Suppliers[12], Category = Categories[1], QuantityPerUnit = "24 - 0.5 l bottles", UnitPrice = 7.75m, UnitsInStock = 125, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false });
            Products.Add(76, new Product { ProductName = "Lakkalikööri", Supplier = Suppliers[23], Category = Categories[1], QuantityPerUnit = "500 ml", UnitPrice = 18.00m, UnitsInStock = 57, UnitsOnOrder = 0, ReorderLevel = 20, Discontinued = false });
            Products.Add(77, new Product { ProductName = "Original Frankfurter grüne Soße", Supplier = Suppliers[12], Category = Categories[2], QuantityPerUnit = "12 boxes", UnitPrice = 13.00m, UnitsInStock = 32, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });

            foreach (var product in Products.Values)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }


    }
}