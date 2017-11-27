using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SIT323_Project02
{
    class WriteHTML
    {
        public static string ExportDatatableToHtml(DataTable dt)
        {
            StringBuilder strHTMLBuilder = new StringBuilder();
            strHTMLBuilder.Append("<html >");
            strHTMLBuilder.Append("<head>");
            strHTMLBuilder.Append("</head>");
            strHTMLBuilder.Append("<body>");
            strHTMLBuilder.Append("<table border='2px black' cellpadding='5' cellspacing='2' bgcolor='lightyellow' style='font-family:Garamond'>");

            //strHTMLBuilder.Append("<tr >");
            //foreach (DataColumn myColumn in dt.Columns)
            //{
            //    strHTMLBuilder.Append("<td >");
            //    strHTMLBuilder.Append(myColumn.ColumnName);
            //    strHTMLBuilder.Append("</td>");

            //}
            //strHTMLBuilder.Append("</tr>");

            try
            {
                foreach (DataRow myRow in dt.Rows)
                {

                    strHTMLBuilder.Append("<tr >");
                    foreach (DataColumn myColumn in dt.Columns)
                    {

                        if (myRow[myColumn.ColumnName].ToString() == "*")
                        {
                            strHTMLBuilder.Append("<td width = '10px' heigth = '10px'>");
                            strHTMLBuilder.Append("&nbsp;");
                        }
                        else
                        {
                            strHTMLBuilder.Append("<td width = '10px' heigth = '10px' bgcolor = '#28FF28'>");
                            strHTMLBuilder.Append(myRow[myColumn.ColumnName].ToString());
                        }
                        strHTMLBuilder.Append("</td>");

                    }
                    strHTMLBuilder.Append("</tr>");
                }
            }
            catch (Exception e)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }

            //Close tags.  
            strHTMLBuilder.Append("</table>");
            strHTMLBuilder.Append("</body>");
            strHTMLBuilder.Append("</html>");

            string Htmltext = strHTMLBuilder.ToString();

            return Htmltext;

        }
    }
}
