using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remember
{
    public partial class viewForm : Form
    {
        public viewForm()
        {
            InitializeComponent();

            for (int j = 0; j < Data.date.Count(); j++)
                if (Data.selectedDate == Data.date[j])
                    dataGridView1.Rows.Add(Data.time[j], Data.myEvent[Data.time[j]]);
        }
    }
}
