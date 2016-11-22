namespace AdminTec.Domain.Interfaces
{
    public interface IBnW : IMachine
    {
        double? CounterCopies { get; set; }
        double CounterPrints { get; set; }
    }
}