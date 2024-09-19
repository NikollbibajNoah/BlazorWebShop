using System.Text.Json;
using System.Text.Json.Nodes;
using WebShop.Data;
using WebShop.Model;

namespace WebShop.Implementation
{
    public class ProductService
    {
        //public List<ItemData> Items { get; set; }
        public ProductService() {
      
        }

        public List<ItemData> GetItems()
        {
            List<ItemData> items = new List<ItemData>();

            var jsonString = File.ReadAllText("./Data/Data.json");
            List<DataModell> Data = JsonSerializer.Deserialize<List<DataModell>>(jsonString);

            for (var i = 0; i < Data.Count; i++)
            {
                ItemData temp = new ItemData();
                temp.Id = i;
                temp.Name = Data[i].Name;
                temp.Category = Data[i].Category;
                temp.Type = Data[i].Type;
                temp.Price = decimal.Parse(Data[i].Price);

                items.Add(temp);
            }

            return items;
        }

        //public async Task<List<ItemData>> LoadData()
        //{
        //    return await _httpClient.GetFromJsonAsync<List<ItemData>>("Data/Data.json");
        //}
    }
}
