using ClosedXML.Excel;
using PFE.CustomObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Shared
{
    public static class Exporter
    {
        public static void exportExel(string path, DataTable dataTable)
        {
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dataTable, "Survey results");
            wb.SaveAs(path);
        }

        public static void exportExel(string path, List<ExcelTab> tabs)
        {
            XLWorkbook wb = new XLWorkbook();
            foreach(ExcelTab tab in tabs)
            {
                wb.Worksheets.Add(tab.data, tab.tabName);
            }
            wb.SaveAs(path);
        }

        public static void exportCsv(string path, string separator, DataTable dataTable)
        {
            if(separator != "," && separator != ";")
            {
                separator = ";";
            }

            StreamWriter sw = new StreamWriter(path, false);
            //headers  
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                sw.Write(dataTable.Columns[i]);
                if (i < dataTable.Columns.Count - 1)
                {
                    sw.Write(separator);
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(separator))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dataTable.Columns.Count - 1)
                    {
                        sw.Write(separator);
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
}
