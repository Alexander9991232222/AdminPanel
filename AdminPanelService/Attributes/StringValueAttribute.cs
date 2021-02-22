using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Attributes
{
    sealed class StringValueAttribute : Attribute
    {
        private readonly string _value;
        public string Value { get => _value; }

        public StringValueAttribute(string value)
        {
            _value = value;
        }
    }
}
