﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.Interfaces
{
    public interface IHasSeoMetaData
    {

        string SeoPageTitle { set; get; }

        string SeoAlias { set; get; }

        string SeoKeyWords { set; get; }

        string SeoDecription { set; get; }

    }
}
