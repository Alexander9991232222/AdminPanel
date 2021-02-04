using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdminPanelService.Extensions
{
    public static class DbCommandExtension
    {
        public static async Task<T> GetResultExecuteScalarAsync<T>(this DbCommand command)
        {
            var result = await command.ExecuteScalarAsync();
            return JsonSerializer.Deserialize<T>(result.ToString());
        } 
    }
}
