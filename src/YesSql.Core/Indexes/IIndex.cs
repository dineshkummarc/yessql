﻿using System.Collections.Generic;
using System.Linq;
using YesSql.Core.Data.Models;

namespace YesSql.Core.Indexes
{
    public interface IIndex
    {
        int Id { get; set; }
        ICollection<Document> Documents { get; }
    }
}
