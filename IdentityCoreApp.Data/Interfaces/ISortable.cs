using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityCoreApp.Data.Interfaces
{
    public interface ISortable
    {
        int SortOrder { set; get; }
    }
}
