using System.ComponentModel;

namespace AdminTec.Domain.Enums
{
    public enum MachineType
    {
        [Description("Multifuncional a Blanco y Negro")]
        BnW = 0,

        [Description("Multifuncional a Color")]
        Color = 1,

        [Description("Impresora")]
        Printer = 2,

        [Description("Copiadora")]
        Copier = 3
    }
}