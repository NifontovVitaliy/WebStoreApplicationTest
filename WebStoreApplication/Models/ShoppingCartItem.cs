namespace WebStoreApplication.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Phone Phone { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
        public void AddAmount() => Amount++;
        public int RemoveAmount() => Amount--;
    }
}
