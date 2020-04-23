using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.Helpers
{
    public static class DataGridViewHelper
    {

        public static void PopulateWithList<T>(DataGridView dgv, IList<T> list, List<string> properties = null)
        {
            if (properties == null)
            {
                var listType = typeof(T);
                properties = listType.GetProperties().Select(i => i.Name).ToList();
            }

            dgv.ColumnCount = properties.Count();
            for(int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Name = properties[i];
            }

            foreach (var item in list)
            {
                string[] values = new string[dgv.ColumnCount];
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    values[i] = item.GetType().GetProperties()[i].GetValue(item).ToString();
                }
                dgv.Rows.Add(values);
            }
        }
    }
}
