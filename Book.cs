namespace BisectTest
{
    public class Book
    {
        public string? Author { get; set; }
        public string? BookName { get; set; }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        internal double WholeSalePrice { get; set; }
        internal double DiscontinuedPrice { get; set; }
        public void ComputePrice()
        {
            Price = WholeSalePrice + (WholeSalePrice * .5);
        }
        public void ComputeDiscountPrice()
        {
            DiscountPrice = Price * 2;
        }
        public void ComputeDiscontinued()
        {
            DiscontinuedPrice = DiscontinuedPrice * 0.8;
        }

    }
}