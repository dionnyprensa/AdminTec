namespace AdminTec.Domain.Entities
{
    public class MfpBN : Interfaces.IBnW
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public double? CounterCopies { get; set; }
        public double CounterPrints { get; set; }
    }
}