using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace CopyDirectory
{
    public class Copy : ICopy
    {
        public event HistoryUpdateEventHandler OnHistoryUpdate;

        protected double TotalFileSize;

        protected double CurrentCopiedSize;

        protected void HistoryUpdate(HistoryUpdateEventArgs e)
        {
            if (OnHistoryUpdate != null)
            {
                OnHistoryUpdate(this, e);
            }
        }

        protected virtual void UpdateHistory(String s)
        {
            double ratio = this.CurrentCopiedSize / this.TotalFileSize;
            ratio *= 100;
            int progress = (int)Math.Round(ratio);
            HistoryUpdate(new HistoryUpdateEventArgs(s, progress));
        }
        
        protected double GetDirectorySize(string directory)
        {
            double size = 0;
            string[] files = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);
            FileInfo info = null;
            foreach(string file in files)
            {
                info = new FileInfo(file);
                size += info.Length;
            }
            return size;
        }

        public void CopyFolder(string origin, string destination)
        {
            if (!Directory.Exists(origin))
            {
                UpdateHistory("Unable to copy. The origin folder isn't accessible.");
                return;
            }
            else if(!Directory.Exists(destination))
            {
                UpdateHistory("Error opening Folder in which to copy.");
                return;
            }
            this.TotalFileSize = this.GetDirectorySize(origin);
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += this.bw_DoWork;
            bw.RunWorkerCompleted += this.bw_RunWorkerCompleted;
            CopyArgs args = new CopyArgs()
            {
                Origin = origin,
                Destination = destination
            };
            bw.WorkerReportsProgress = true;
            bw.ProgressChanged += this.bw_ReportProgess;
            bw.RunWorkerAsync(args);
        }

        private void bw_ReportProgess(object sender, ProgressChangedEventArgs e)
        {
            this.UpdateHistory((string)e.UserState);
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyArgs args = e.Argument as CopyArgs;
            this.RecursiveCopy(args.Origin, args.Destination, (BackgroundWorker)sender);
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.UpdateHistory("Copy Completed");
        }

        protected void RecursiveCopy(string origin, string destination, BackgroundWorker worker)
        {
            try
            {
                List<string> fileContents = new List<string>(Directory.GetFiles(origin));
                foreach (var file in fileContents)
                {
                    File.Copy(file, destination + Path.DirectorySeparatorChar + Path.GetFileName(file));
                    this.CurrentCopiedSize += new FileInfo(file).Length;
                    worker.ReportProgress(0, "Copied " + file);
                }
                List<string> dirContents = new List<string>(Directory.GetDirectories(origin));
                foreach (var dir in dirContents)
                {
                    worker.ReportProgress(0, "Copying Dir:" + dir);
                    String copiedDirPath = destination + Path.DirectorySeparatorChar + dir.Split(Path.DirectorySeparatorChar).Last();
                    Directory.CreateDirectory(copiedDirPath);
                    this.RecursiveCopy(dir, copiedDirPath, worker);
                }
            }
            catch (Exception e)
            {
                UpdateHistory(e.Message);
            }
        }
    }

    class CopyArgs : Object
    {
        public String Origin { get; set; }
        public String Destination { get; set; }
    }
}
