using AdminPanelService.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Helpers
{
    public static class StringEnum
    {
        public static string GetStringValue(this Enum value)
        {
            string output = null;
            Type type = value.GetType();

            FieldInfo fi = type.GetField(value.ToString());

            StringValue[] attrs = fi.GetCustomAttributes(
                        typeof(StringValue), 
                        false) as StringValue[];
            
            if(attrs.Length > 0)
            {
                output = attrs[0].Value;
            }

            return output;
        }
    }
}
