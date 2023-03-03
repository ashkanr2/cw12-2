namespace web_app.Models
{
    public static class DataStorage
    {
        public static List<Product> Products=new();

         static DataStorage()
        {
            Products.Add(new Product
            {
                Id = 1,
                Name = "Iphone ",
                Color = "#8A2BE2",
                Model = "14",
                Code = 5002,
                Brand = Brand.Apple
                
            });
            Products.Add(new Product
            {
                Id = 2,
                Name = "sumsung ",
                Color = "#8A2BE3",
                Model = "s22",
                Code = 2005,
                Brand = Brand.Sumsung

            }); Products.Add(new Product
            {
                Id = 3,
                Name = "xiaomi ",
                Color = "#FF0000",
                Model = "one x",
                Code = 1024,
                Brand = Brand.Xiaomi

            }); Products.Add(new Product
            {
                Id = 4,
                Name = "Iphone ",
                Color = "#4682B4",
                Model = "13 pro max",
                Code = 8006,
                Brand = Brand.Apple

            });
        }
    }
}
