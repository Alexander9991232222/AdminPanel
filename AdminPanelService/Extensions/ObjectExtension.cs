using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace AdminPanelService.Extensions
{
    public static class ObjectExtension
    {
        public static IDictionary<string, object> ToDictionary(this object obj)
        {
            var result = new Dictionary<string, object>();
            var prop = obj.GetType().GetProperties();

            foreach (var field in prop)
            {
                var key = field.GetCustomAttribute<ColumnAttribute>()?.Name ?? field.Name;
                var value = field.GetValue(prop);

                if (result.ContainsKey(key))
                {
                    throw new ArgumentException($"This key: [{key}] is already contained in dictionary");
                }

                result.Add(key, value);
            }

            return result;
        }
    }
}
