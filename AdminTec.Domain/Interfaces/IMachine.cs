namespace AdminTec.Domain.Interfaces
{
    internal interface IMachine
    {
        int Id { get; set; }
        string SerialNumber { get; set; }
        string Model { get; set; }
        string Location { get; set; }
        string IP { get; set; }
        long CounterBnWCopies { get; set; }
        long CounterBnWPrints { get; set; }
        long CounterColorCopies { get; set; }
        long CounterColorPrints { get; set; }
    }
}