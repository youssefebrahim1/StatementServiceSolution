namespace StatementServiceAPI.Models
{
    public class Statement
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
