using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumConsole
{
    public enum EnumTest
    {
        [Enum(Name1 = "项目一_1",Name2 = "项目一_2", Name3 = "项目一_3")]
        项目一,

        [Enum(Name1 = "项目二_1", Name2 = "项目二_2", Name3 = "项目二_3")]
        项目二,
        
        项目三,

        [Enum(Name1 = "项目四_1", Name2 = "项目四_2", Name3 = "项目四_3")]
        项目四,
    }
}
