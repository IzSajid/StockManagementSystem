using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NSU_PMS
{
    public class ListViewFunctions
    {
        private static readonly ListViewFunctions _instance = new ListViewFunctions();

        // Private constructor to prevent instantiation
        private ListViewFunctions() { }

        // Public static property to access the instance
        public static ListViewFunctions Instance
        {
            get
            {
                return _instance;
            }
        }

        public bool IsValueExists(ListView listView, string val)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.SubItems[0].Text == val)
                {
                    return true;
                }
            }
            return false;
        }

        public double CalculateColumnSum(ListView listView, int columnIndex)
        {
            if (listView == null || listView.Items.Count == 0)
                return 0;

            double sum = 0;
            foreach (ListViewItem item in listView.Items)
            {
                if (double.TryParse(item.SubItems[columnIndex].Text, out double value))
                {
                    sum += value;
                }
            }
            return sum;
        }
    }
}
