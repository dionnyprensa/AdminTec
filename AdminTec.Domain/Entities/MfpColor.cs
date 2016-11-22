namespace AdminTec.Domain.Entities
{
    public class MfpColor : Interfaces.IColor
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public double? CounterBnWCopies { get; set; }
        public double CounterBnWPrints { get; set; }
        public double? CounterColorCopies { get; set; }
        public double CounterColorPrints { get; set; }
    }
}