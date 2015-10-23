using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDirectory
{
    public interface ICopy
    {
        /// <summary>
        /// Method that copies all contents from one folder to another
        /// </summary>
        /// <param name="origin">
        /// Folder to be copied.
        /// </param>
        /// <param name="destination">
        /// Folder in which to put copy
        /// </param>
        void CopyFolder(String origin, String destination);

        event HistoryUpdateEventHandler OnHistoryUpdate;
    }

    public interface IHistoryHandler
    {
        void UpdateHistory(object sender, HistoryUpdateEventArgs e);

        void Display();
    }
    
    public delegate void HistoryUpdateEventHandler(object sender, HistoryUpdateEventArgs e);

    public class HistoryUpdateEventArgs : EventArgs
    {
        public String UpdatedHistory;

        public int CurrentProgress;

        public HistoryUpdateEventArgs(string history, int currentProgress)
        {
            this.CurrentProgress = currentProgress;
            this.UpdatedHistory = history;
        }
    }
}
