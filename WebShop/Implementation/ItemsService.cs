using WebShop.Model;

namespace WebShop.Implementation
{

    public class ItemsService
    {
        public List<ItemData> CartItems { get; set; }

        public ItemsService()
        {
            CartItems = [];
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
