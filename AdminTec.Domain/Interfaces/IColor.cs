namespace AdminTec.Domain.Interfaces
{
    public interface IColor : IMachine
    {
        double? CounterBnWCopies { get; set; }
        double CounterBnWPrints { get; set; }
        double? CounterColorCopies { get; set; }
        double CounterColorPrints { get; set; }
    }
}