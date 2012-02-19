using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace phssshaw.Lib
{
    public static class XEnum
    {
        public static string ValueToDescription(this Enum xenum) {          
            
            DescriptionAttribute[] attributes = (DescriptionAttribute[])xenum.GetType().GetField(xenum.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}