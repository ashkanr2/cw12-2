namespace web_app.Models
{
    public class ProductRepository
    {
        public List<Product> GeList()
        {
            return DataStorage.Products;
        }
        public Product? GetById(int id)
        {
            return DataStorage.Products.FirstOrDefault(x=>x.Id==id);
        }

        public void CreateProduct(Product prd)
        {
            prd.Id = GetLastId();
            DataStorage.Products.Add(prd);
        }
        public int GetLastId() 
        {
            
            var lastProductRecord = DataStorage.Products.OrderByDescending(o => o.Id).FirstOrDefault();
            if (lastProductRecord is null)
                return 1;
            else
                return lastProductRecord.Id + 1;
        }
    }
}
