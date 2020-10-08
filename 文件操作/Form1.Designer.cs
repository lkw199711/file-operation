namespace 文件操作
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.folderText = new System.Windows.Forms.TextBox();
            this.folderSelected = new System.Windows.Forms.FolderBrowserDialog();
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.replaceFileNameBtn = new System.Windows.Forms.Button();
            this.replaceOldText = new System.Windows.Forms.TextBox();
            this.replaceNewText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // folderText
            // 
            this.folderText.Location = new System.Drawing.Point(45, 33);
            this.folderText.Name = "folderText";
            this.folderText.Size = new System.Drawing.Size(617, 21);
            this.folderText.TabIndex = 0;
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.Location = new System.Drawing.Point(682, 31);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(51, 23);
            this.selectFolderBtn.TabIndex = 1;
            this.selectFolderBtn.Text = "选择";
            this.selectFolderBtn.UseVisualStyleBackColor = true;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // replaceFileNameBtn
            // 
            this.replaceFileNameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.replaceFileNameBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.replaceFileNameBtn.Location = new System.Drawing.Point(263, 83);
            this.replaceFileNameBtn.Name = "replaceFileNameBtn";
            this.replaceFileNameBtn.Size = new System.Drawing.Size(105, 59);
            this.replaceFileNameBtn.TabIndex = 2;
            this.replaceFileNameBtn.Text = "批量替换重命名";
            this.replaceFileNameBtn.UseVisualStyleBackColor = true;
            this.replaceFileNameBtn.Click += new System.EventHandler(this.replaceFileNameBtn_Click);
            // 
            // replaceOldText
            // 
            this.replaceOldText.Location = new System.Drawing.Point(45, 83);
            this.replaceOldText.Name = "replaceOldText";
            this.replaceOldText.Size = new System.Drawing.Size(187, 21);
            this.replaceOldText.TabIndex = 3;
            // 
            // replaceNewText
            // 
            this.replaceNewText.Location = new System.Drawing.Point(45, 121);
            this.replaceNewText.Name = "replaceNewText";
            this.replaceNewText.Size = new System.Drawing.Size(187, 21);
            this.replaceNewText.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.replaceNewText);
            this.Controls.Add(this.replaceOldText);
            this.Controls.Add(this.replaceFileNameBtn);
            this.Controls.Add(this.selectFolderBtn);
            this.Controls.Add(this.folderText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderText;
        private System.Windows.Forms.FolderBrowserDialog folderSelected;
        private System.Windows.Forms.Button selectFolderBtn;
        private System.Windows.Forms.Button replaceFileNameBtn;
        private System.Windows.Forms.TextBox replaceOldText;
        private System.Windows.Forms.TextBox replaceNewText;
    }
}

