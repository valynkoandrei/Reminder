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
    public partial class mainForm : Form
    {
        private static System.Timers.Timer aTimer;

        public mainForm()
        {
            InitializeComponent();

            SetTimer();
        }

        private static void SetTimer()
        {
            aTimer = new System.Timers.Timer(1000);

            aTimer.Elapsed += aTimer_Elapsed;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void aTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            for(int i=0; i<Data.time.Count();i++ )
                if(DateTime.Now.ToShortDateString() == Data.date[i] && DateTime.Now.ToLongTimeString() == Data.time[i]+":00")
                    MessageBox.Show(Data.date[i] + " " + Data.time[i] + "\n\n" + Data.myEvent[Data.time[i]], "Напоминание!");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Data.selectedDate = calendar.SelectionRange.Start.ToShortDateString();
            
            Array.Resize<string>(ref Data.date, Data.date.Count() + 1);
            Data.date[Data.date.Count() - 1] = Data.selectedDate;

            addForm form = new addForm();
            form.ShowDialog();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            Data.selectedDate = calendar.SelectionRange.Start.ToShortDateString();

            viewForm form = new viewForm();
            form.ShowDialog();
        }
    }

    static class Data
    {
        public static Dictionary<string, string> myEvent = new Dictionary<string, string>();
        public static string[] date = new string[0];
        public static string[] time = new string[0];
        public static string selectedDate { get; set; }
    }
}
