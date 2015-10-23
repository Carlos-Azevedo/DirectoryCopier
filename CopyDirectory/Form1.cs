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
    public partial class Form1 : Form
    {
        public String CopyFilePath;
        public String DestinationFolderPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOriginSearch_Click(object sender, EventArgs e)
        {
            DialogResult sourceFolder = this.folderBrowserDialog1.ShowDialog();
            if (sourceFolder == DialogResult.OK)
            {
                this.txtCopiedFolder.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnDestSearch_Click(object sender, EventArgs e)
        {
            DialogResult sourceFolder = this.folderBrowserDialog1.ShowDialog();
            if (sourceFolder == DialogResult.OK)
            {
                this.txtDestPath.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

            ICopy copy = new Copy();
            IHistoryHandler historyBox = new HistoryView();
            copy.OnHistoryUpdate += new HistoryUpdateEventHandler(historyBox.UpdateHistory);
            historyBox.Display();
            copy.CopyFolder(this.txtCopiedFolder.Text, this.txtDestPath.Text);
        }
    }
}
