﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kooboo.Data.Infrastructure
{
    public class LocalInfra : IInfrastructure
    {
        public void Add(Guid OrganizationId, byte InfraType, int Amount, string Item)
        {
            return; 
        }

        public bool Test(Guid OrganizationId, byte InfraType, int amount)
        {
            return true; 
        }
    }
}
