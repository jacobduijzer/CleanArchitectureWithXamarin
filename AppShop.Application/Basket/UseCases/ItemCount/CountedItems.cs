namespace AppShop.Application.Basket.UseCases.ItemCount
{
    public class CountedItems
    {
        public int Count { get; private set; }

        public CountedItems(int count)
        {
            Count = count;
        }
    }
}
