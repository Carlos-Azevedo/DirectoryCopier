namespace CopyDirectory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCopiedFolder = new System.Windows.Forms.TextBox();
            this.btnOriginSearch = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDestSearch = new System.Windows.Forms.Button();
            this.txtDestPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCopiedFolder
            // 
            this.txtCopiedFolder.Location = new System.Drawing.Point(6, 19);
            this.txtCopiedFolder.Name = "txtCopiedFolder";
            this.txtCopiedFolder.Size = new System.Drawing.Size(336, 20);
            this.txtCopiedFolder.TabIndex = 0;
            // 
            // btnOriginSearch
            // 
            this.btnOriginSearch.Location = new System.Drawing.Point(348, 16);
            this.btnOriginSearch.Name = "btnOriginSearch";
            this.btnOriginSearch.Size = new System.Drawing.Size(75, 23);
            this.btnOriginSearch.TabIndex = 1;
            this.btnOriginSearch.Text = "Search";
            this.btnOriginSearch.UseVisualStyleBackColor = true;
            this.btnOriginSearch.Click += new System.EventHandler(this.btnOriginSearch_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(151, 142);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(150, 51);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOriginSearch);
            this.groupBox1.Controls.Add(this.txtCopiedFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 49);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copied Folder";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDestSearch);
            this.groupBox2.Controls.Add(this.txtDestPath);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 49);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination Folder";
            // 
            // btnDestSearch
            // 
            this.btnDestSearch.Location = new System.Drawing.Point(348, 16);
            this.btnDestSearch.Name = "btnDestSearch";
            this.btnDestSearch.Size = new System.Drawing.Size(75, 23);
            this.btnDestSearch.TabIndex = 1;
            this.btnDestSearch.Text = "Search";
            this.btnDestSearch.UseVisualStyleBackColor = true;
            this.btnDestSearch.Click += new System.EventHandler(this.btnDestSearch_Click);
            // 
            // txtDestPath
            // 
            this.txtDestPath.Location = new System.Drawing.Point(6, 19);
            this.txtDestPath.Name = "txtDestPath";
            this.txtDestPath.Size = new System.Drawing.Size(336, 20);
            this.txtDestPath.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 205);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCopy);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "DirectoryCopier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCopiedFolder;
        private System.Windows.Forms.Button btnOriginSearch;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDestSearch;
        private System.Windows.Forms.TextBox txtDestPath;
    }
}

