using System;
using System.Collections.Generic;
using System.Text;
using IdentityCoreApp.Data.Enums;

namespace IdentityCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
