using Fina.AvaliacaoTecnica.Domain.Enum;
using System;
    
namespace Fina.AvaliacaoTecnica.Domain.Entities
{
    [Serializable]
    public class Business: EntityBase
    {
        public float Value { get; set; }

        public String Category { get; set; }

        public EnumBusiness Type { get; set; }

        public DateTime Date { get; set; }

        public String Observation { get; set; }
    }
}
