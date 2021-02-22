using AdminPanelService.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace AdminPanelService.Helpers
{
    public static class SqlDataHelper
    {
        private static SqlParameter _getParam(string name, object value, ParameterDirection direction)
        {
            return new SqlParameter
            {
                Direction = direction,
                ParameterName = name,
                Value = value
            };
        }

        private  static List<SqlParameter> _getListParams<T>(IDictionary<string, T> dictionary, ParameterDirection direction)
        {
            var listParams = new List<SqlParameter>();

            foreach (KeyValuePair<string, T> el in dictionary)
            {
                listParams.Add(_getParam(el.Key, el.Value, direction));
            }

            return listParams;
        }

        public static SqlParameter[] GetSQLParamsArray(IDictionary<string, object> inParams, IDictionary<string, string> outParams = null)
        {
            var listParams = new List<SqlParameter>();

            listParams.AddRange(_getListParams(inParams, ParameterDirection.Input));

            if (outParams != null)
            {
                listParams.AddRange(_getListParams(outParams, ParameterDirection.Output));
            }

            return listParams.ToArray();
        }
    }
}
