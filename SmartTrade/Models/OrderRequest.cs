namespace SmartTrade.Models
{
    public class OrderRequest
    {
        public int AccountType { get; set; } = 1;

        public string InstrumentId { get; set; }

        public int OrderSide { get; set; }

        public int OrderType { get; set; } = 1;

        public int RequestType { get; set; } = 1;

        public int ValidityType { get; set; } = 1;

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime? ValidityDate { get; set; }
    }
}
