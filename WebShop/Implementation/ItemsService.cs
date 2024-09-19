using WebShop.Model;

namespace WebShop.Implementation
{

    public class ItemsService
    {
        public List<ItemData> Items { get; set; }
        public List<ItemData> CartItems { get; set; }

        public ItemsService()
        {
            Items = [];
            CartItems = [];
        }

        public void AddItem(ItemData item)
        {
            Items.Add(item);
        }

        public void AddItemToCart(ItemData item)
        {
            CartItems.Add(item);
        }

        public void RemoveFromCart(ItemData item)
        {
            CartItems.Remove(CartItems.First(i => i.Id == item.Id));
        }
    }
}
