using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace satisfactory_calculator
{
	static class Functions
	{
        /// <summary>
        /// Logs input to the trace.log file
        /// </summary>
        /// <param name="FormattedString"></param>
		public static void myLog(string FormattedString)
		{
			System.Diagnostics.Trace.WriteLine(FormattedString);
		}

        /// <summary>
        /// Logs input to the trace.log file
        /// </summary>
        /// <param name="IdentifierString"></param>
        /// <param name="machine"></param>
        public static void myLog(string IdentifierString, Machine machine)
		{
			string message =  string.Format("{0}:\n - Name: {1}\n - Ingredients: {2}\n - Power Usage: {3}\n - Current Recipe: {4}\n - Total: {5}",
				IdentifierString, machine.Name, machine.Ingredients.Count, machine.PowerUsage, machine.CurrentRecipe.Name, machine.Total);
			System.Diagnostics.Trace.WriteLine(message);
		}



        /// <summary>
        /// Converts a list into a Data Set
        /// Allows binding of lists to datagridviews
        /// </summary>
        /// <typeparam name="T">Class Type of List</typeparam>
        /// <param name="list">list to convert</param>
        /// <returns>Sytem.Data.DataSet</returns>
        public static DataSet ToDataSet<T>(this IList<T> list)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                //                           IF THIS IS NULL \/ THEN USE THIS------>
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            //go through each property on T and add each value to the table
            if (list.Count != 0)
            {
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    if (elementType.GetProperties().Count() != 0)
                    {
                        foreach (var propInfo in elementType.GetProperties())
                        {
                            row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            t.AcceptChanges();
            return ds;
        }
    }
}
