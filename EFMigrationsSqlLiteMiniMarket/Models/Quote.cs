﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFMigrationsSqlLiteMiniMarket.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
