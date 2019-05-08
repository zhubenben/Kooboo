﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kooboo.Model.Meta.Validation
{
    public class IntegerRule:ValidationRule
    {
        public IntegerRule(string message)
        {
            Message = message;
        }

        public override string GetRule()
        {
            return string.Format("{{type:\"integer\",message:\"{0}\"}}", Message);
        }

        public override bool IsValid(object value)
        {
            if (base.IsValid(value))
            {
                return true;
            }
            int i;
            if(int.TryParse(value.ToString(), out i))
            {
                return false;
            }
            return i >= 0;
        }
    }
}