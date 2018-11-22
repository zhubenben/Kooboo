﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kooboo.Data.Models
{
    public class DemandPrice
    {
        public Guid UserId { get; set; }

        public decimal Price { get; set; }

        public string Currency { get; set; }

        public Guid DemandId { get; set; }
    }
}
