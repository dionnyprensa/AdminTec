using System.ComponentModel;

namespace AdminTec.Domain.Enums
{
    public enum MachineType
    {
        [Description("Multifuncional a Blanco y Negro")]
        BnW = 0,

        [Description("Multifuncional a Color")]
        Color = 1,

        [Description("Impresora a Color")]
        PrinterColor = 2,

        [Description("Impresora a Blanco y Negro")]
        PrinterBnW = 3,

        [Description("Copiadora a Color")]
        CopierColor = 4,

        [Description("Copiadora a Blanco y Negro")]
        CopierBnW = 5
    }
}