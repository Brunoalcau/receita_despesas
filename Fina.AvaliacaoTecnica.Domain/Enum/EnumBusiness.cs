using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.AvaliacaoTecnica.Domain.Enum
{
    public enum EnumBusiness
    {
        [Description("Despesa")]
        Expenses ,
        [Description("Receita")]
        Recipes,
    }
}
