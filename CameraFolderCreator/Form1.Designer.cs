namespace CameraFolderCreator
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonCreateFolders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumberOfFolders = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStartingNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCreateFolders
            // 
            this.buttonCreateFolders.Location = new System.Drawing.Point(402, 328);
            this.buttonCreateFolders.Name = "buttonCreateFolders";
            this.buttonCreateFolders.Size = new System.Drawing.Size(170, 77);
            this.buttonCreateFolders.TabIndex = 0;
            this.buttonCreateFolders.Text = "Create Folders";
            this.buttonCreateFolders.UseVisualStyleBackColor = true;
            this.buttonCreateFolders.Click += new System.EventHandler(this.buttonCreateFolders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many folders?";
            // 
            // textBoxNumberOfFolders
            // 
            this.textBoxNumberOfFolders.Location = new System.Drawing.Point(518, 228);
            this.textBoxNumberOfFolders.Name = "textBoxNumberOfFolders";
            this.textBoxNumberOfFolders.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfFolders.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Strating Number";
            // 
            // textBoxStartingNum
            // 
            this.textBoxStartingNum.Location = new System.Drawing.Point(518, 279);
            this.textBoxStartingNum.Name = "textBoxStartingNum";
            this.textBoxStartingNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartingNum.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 508);
            this.Controls.Add(this.textBoxStartingNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumberOfFolders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateFolders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonCreateFolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumberOfFolders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStartingNum;
    }
}

