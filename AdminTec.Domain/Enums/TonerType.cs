using System.ComponentModel;

namespace AdminTec.Domain.Enums
{
    public enum TonerType
    {
        [Description("Cyan")]
        C = 1,

        [Description("Magenta")]
        M = 2,

        [Description("Amarrillo")]
        Y = 3,

        [Description("Negro")]
        K = 4
    }
}