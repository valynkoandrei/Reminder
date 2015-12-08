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
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Data.myEvent.Add(timePicker.Value.ToShortTimeString(), messageTB.Text);

            Array.Resize<string>(ref Data.time, Data.time.Count() + 1);
            Data.time[Data.time.Count() - 1] = timePicker.Value.ToShortTimeString();

            this.Close();
        }
    }
}
