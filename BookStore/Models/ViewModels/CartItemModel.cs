namespace BookStore.Models.ViewModels
{
    public class CartItemModel
    {
        public int ItemId { get; set; }
        public string PhotoName { get; set; }
        public string BookName { get; set; }
        public decimal BookPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPriceOfOneCartItem { get; set; }
    }
}
