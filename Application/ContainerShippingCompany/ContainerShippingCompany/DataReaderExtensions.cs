using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle.DataAccess.Client
{
    /// <summary>
    /// Extends the Oracle.DataAccess.Client.DataReader with additional functionality.
    /// </summary>
    public static class DataReaderExtensions
    {
        /// <summary>
        /// Enables the DataReader to find values based on the given column instead of column index.
        /// The datatype is also correctly returned.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static T GetValueByColumn<T>(this OracleDataReader reader, string columnName) {
            int index = reader.GetOrdinal(columnName);

            var value = reader.GetValue(index);

            if (value is DBNull || value == null)
            {
                return default(T);
            }

            if (typeof(int) == typeof(T)) {
                return (T)(object)Convert.ToInt32(value);
            }
            else if (typeof(long) == typeof(T))
            {
                return (T)(object)(long)Convert.ToInt64(value);
            }

            return (T)value;
        }
    }
}
