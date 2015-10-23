using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyDirectory
{
    public partial class HistoryView : Form, IHistoryHandler
    {
        public HistoryView()
        {
            InitializeComponent();
        }

        public void UpdateHistory(object sender, HistoryUpdateEventArgs e)
        {
            this.lstBoxHistory.Items.Add(e.UpdatedHistory);
            this.progressBar1.Value = e.CurrentProgress;
            this.Refresh();
        }

        public void Display()
        {
            this.Show();
        }
    }
}
