using System.ComponentModel;

namespace AdminTec.Domain.Enums
{
    public enum VisitType
    {
        [Description("Cortesia")]
        Courtesy = 0,

        [Description("Mantenimiento Preventivo")]
        PM = 1,

        [Description("Mantenimiento Emergencia")]
        EM = 2,

        [Description("Cambio de Toner")]
        TonerChange = 3,

        [Description("Entranamiento Usuario")]
        UserTraining = 4,

        [Description("Instalación")]
        Installation = 5,

        [Description("Atasco")]
        PaperJam = 6
    }
}