using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Attributes
{
    public class StringValue : Attribute
    {
        private readonly string _value;
        public string Value { get => _value; }

        public StringValue(string value)
        {
            _value = value;
        }
    }
}
