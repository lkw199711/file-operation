﻿namespace 文件操作
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
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.fileSelected = new System.Windows.Forms.OpenFileDialog();
            this.fileText = new System.Windows.Forms.TextBox();
            this.deleteKeyText = new System.Windows.Forms.TextBox();
            this.batchDeleteBtn = new System.Windows.Forms.Button();
            this.md5DeleteBtn = new System.Windows.Forms.Button();
            this.prefixText = new System.Windows.Forms.TextBox();
            this.tailsText = new System.Windows.Forms.TextBox();
            this.addPrefixBtn = new System.Windows.Forms.Button();
            this.addTailsBtn = new System.Windows.Forms.Button();
            this.merFileBtn = new System.Windows.Forms.Button();
            this.serialRenameBtn = new System.Windows.Forms.Button();
            this.outFolderText = new System.Windows.Forms.TextBox();
            this.outputFolderBtn = new System.Windows.Forms.Button();
            this.cutPicBtn = new System.Windows.Forms.Button();
            this.curLengthText = new System.Windows.Forms.TextBox();
            this.compressText = new System.Windows.Forms.TextBox();
            this.positionLengthText = new System.Windows.Forms.TextBox();
            this.posRenameBtn = new System.Windows.Forms.Button();
            this.setAssBtn = new System.Windows.Forms.Button();
            this.getAssBtn = new System.Windows.Forms.Button();
            this.btnArrange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderText
            // 
            this.folderText.Location = new System.Drawing.Point(45, 33);
            this.folderText.Name = "folderText";
            this.folderText.Size = new System.Drawing.Size(572, 21);
            this.folderText.TabIndex = 0;
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.Location = new System.Drawing.Point(633, 31);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.selectFolderBtn.TabIndex = 1;
            this.selectFolderBtn.Text = "选择目录";
            this.selectFolderBtn.UseVisualStyleBackColor = true;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // replaceFileNameBtn
            // 
            this.replaceFileNameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.replaceFileNameBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.replaceFileNameBtn.Location = new System.Drawing.Point(252, 140);
            this.replaceFileNameBtn.Name = "replaceFileNameBtn";
            this.replaceFileNameBtn.Size = new System.Drawing.Size(105, 59);
            this.replaceFileNameBtn.TabIndex = 2;
            this.replaceFileNameBtn.Text = "批量替换重命名";
            this.replaceFileNameBtn.UseVisualStyleBackColor = true;
            this.replaceFileNameBtn.Click += new System.EventHandler(this.replaceFileNameBtn_Click);
            // 
            // replaceOldText
            // 
            this.replaceOldText.Location = new System.Drawing.Point(45, 140);
            this.replaceOldText.Name = "replaceOldText";
            this.replaceOldText.Size = new System.Drawing.Size(187, 21);
            this.replaceOldText.TabIndex = 3;
            // 
            // replaceNewText
            // 
            this.replaceNewText.Location = new System.Drawing.Point(45, 178);
            this.replaceNewText.Name = "replaceNewText";
            this.replaceNewText.Size = new System.Drawing.Size(187, 21);
            this.replaceNewText.TabIndex = 4;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(633, 60);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(75, 23);
            this.selectFileBtn.TabIndex = 5;
            this.selectFileBtn.Text = "选择文件";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // fileSelected
            // 
            this.fileSelected.FileName = "openFileDialog1";
            // 
            // fileText
            // 
            this.fileText.Location = new System.Drawing.Point(45, 62);
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(572, 21);
            this.fileText.TabIndex = 6;
            // 
            // deleteKeyText
            // 
            this.deleteKeyText.Location = new System.Drawing.Point(428, 140);
            this.deleteKeyText.Name = "deleteKeyText";
            this.deleteKeyText.Size = new System.Drawing.Size(280, 21);
            this.deleteKeyText.TabIndex = 7;
            // 
            // batchDeleteBtn
            // 
            this.batchDeleteBtn.Location = new System.Drawing.Point(428, 176);
            this.batchDeleteBtn.Name = "batchDeleteBtn";
            this.batchDeleteBtn.Size = new System.Drawing.Size(126, 23);
            this.batchDeleteBtn.TabIndex = 8;
            this.batchDeleteBtn.Text = "根据关键字删除";
            this.batchDeleteBtn.UseVisualStyleBackColor = true;
            this.batchDeleteBtn.Click += new System.EventHandler(this.batchDeleteBtn_Click);
            // 
            // md5DeleteBtn
            // 
            this.md5DeleteBtn.Location = new System.Drawing.Point(575, 176);
            this.md5DeleteBtn.Name = "md5DeleteBtn";
            this.md5DeleteBtn.Size = new System.Drawing.Size(133, 23);
            this.md5DeleteBtn.TabIndex = 9;
            this.md5DeleteBtn.Text = "根据md5删除";
            this.md5DeleteBtn.UseVisualStyleBackColor = true;
            this.md5DeleteBtn.Click += new System.EventHandler(this.md5DeleteBtn_Click);
            // 
            // prefixText
            // 
            this.prefixText.Location = new System.Drawing.Point(45, 235);
            this.prefixText.Name = "prefixText";
            this.prefixText.Size = new System.Drawing.Size(187, 21);
            this.prefixText.TabIndex = 10;
            // 
            // tailsText
            // 
            this.tailsText.Location = new System.Drawing.Point(45, 284);
            this.tailsText.Name = "tailsText";
            this.tailsText.Size = new System.Drawing.Size(187, 21);
            this.tailsText.TabIndex = 11;
            // 
            // addPrefixBtn
            // 
            this.addPrefixBtn.Location = new System.Drawing.Point(252, 235);
            this.addPrefixBtn.Name = "addPrefixBtn";
            this.addPrefixBtn.Size = new System.Drawing.Size(105, 23);
            this.addPrefixBtn.TabIndex = 12;
            this.addPrefixBtn.Text = "添加前缀";
            this.addPrefixBtn.UseVisualStyleBackColor = true;
            this.addPrefixBtn.Click += new System.EventHandler(this.addPrefixBtn_Click);
            // 
            // addTailsBtn
            // 
            this.addTailsBtn.Location = new System.Drawing.Point(252, 282);
            this.addTailsBtn.Name = "addTailsBtn";
            this.addTailsBtn.Size = new System.Drawing.Size(105, 23);
            this.addTailsBtn.TabIndex = 13;
            this.addTailsBtn.Text = "添加尾缀";
            this.addTailsBtn.UseVisualStyleBackColor = true;
            this.addTailsBtn.Click += new System.EventHandler(this.addTailsBtn_Click);
            // 
            // merFileBtn
            // 
            this.merFileBtn.Location = new System.Drawing.Point(428, 233);
            this.merFileBtn.Name = "merFileBtn";
            this.merFileBtn.Size = new System.Drawing.Size(126, 23);
            this.merFileBtn.TabIndex = 14;
            this.merFileBtn.Text = "整合文件夹";
            this.merFileBtn.UseVisualStyleBackColor = true;
            this.merFileBtn.Click += new System.EventHandler(this.merFileBtn_Click);
            // 
            // serialRenameBtn
            // 
            this.serialRenameBtn.Location = new System.Drawing.Point(610, 233);
            this.serialRenameBtn.Name = "serialRenameBtn";
            this.serialRenameBtn.Size = new System.Drawing.Size(52, 23);
            this.serialRenameBtn.TabIndex = 15;
            this.serialRenameBtn.Text = "按序号";
            this.serialRenameBtn.UseVisualStyleBackColor = true;
            this.serialRenameBtn.Click += new System.EventHandler(this.serialRenameBtn_Click);
            // 
            // outFolderText
            // 
            this.outFolderText.Location = new System.Drawing.Point(45, 89);
            this.outFolderText.Name = "outFolderText";
            this.outFolderText.Size = new System.Drawing.Size(572, 21);
            this.outFolderText.TabIndex = 16;
            this.outFolderText.TextChanged += new System.EventHandler(this.outFolderText_TextChanged);
            // 
            // outputFolderBtn
            // 
            this.outputFolderBtn.Location = new System.Drawing.Point(633, 89);
            this.outputFolderBtn.Name = "outputFolderBtn";
            this.outputFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.outputFolderBtn.TabIndex = 17;
            this.outputFolderBtn.Text = "输出目录";
            this.outputFolderBtn.UseVisualStyleBackColor = true;
            // 
            // cutPicBtn
            // 
            this.cutPicBtn.Location = new System.Drawing.Point(575, 282);
            this.cutPicBtn.Name = "cutPicBtn";
            this.cutPicBtn.Size = new System.Drawing.Size(133, 23);
            this.cutPicBtn.TabIndex = 18;
            this.cutPicBtn.Text = "裁剪图片";
            this.cutPicBtn.UseVisualStyleBackColor = true;
            this.cutPicBtn.Click += new System.EventHandler(this.cutPicBtn_Click);
            // 
            // curLengthText
            // 
            this.curLengthText.Location = new System.Drawing.Point(428, 284);
            this.curLengthText.Name = "curLengthText";
            this.curLengthText.Size = new System.Drawing.Size(64, 21);
            this.curLengthText.TabIndex = 19;
            this.curLengthText.Text = "4000";
            // 
            // compressText
            // 
            this.compressText.Location = new System.Drawing.Point(498, 284);
            this.compressText.Name = "compressText";
            this.compressText.Size = new System.Drawing.Size(56, 21);
            this.compressText.TabIndex = 20;
            this.compressText.Text = "75";
            // 
            // positionLengthText
            // 
            this.positionLengthText.Location = new System.Drawing.Point(575, 234);
            this.positionLengthText.Name = "positionLengthText";
            this.positionLengthText.Size = new System.Drawing.Size(25, 21);
            this.positionLengthText.TabIndex = 21;
            // 
            // posRenameBtn
            // 
            this.posRenameBtn.Location = new System.Drawing.Point(670, 233);
            this.posRenameBtn.Name = "posRenameBtn";
            this.posRenameBtn.Size = new System.Drawing.Size(38, 23);
            this.posRenameBtn.TabIndex = 22;
            this.posRenameBtn.Text = "补位";
            this.posRenameBtn.UseVisualStyleBackColor = true;
            this.posRenameBtn.Click += new System.EventHandler(this.posRenameBtn_Click);
            // 
            // setAssBtn
            // 
            this.setAssBtn.Location = new System.Drawing.Point(575, 320);
            this.setAssBtn.Name = "setAssBtn";
            this.setAssBtn.Size = new System.Drawing.Size(133, 23);
            this.setAssBtn.TabIndex = 23;
            this.setAssBtn.Text = "设置字幕名称";
            this.setAssBtn.UseVisualStyleBackColor = true;
            this.setAssBtn.Click += new System.EventHandler(this.setAssBtn_Click);
            // 
            // getAssBtn
            // 
            this.getAssBtn.Location = new System.Drawing.Point(428, 320);
            this.getAssBtn.Name = "getAssBtn";
            this.getAssBtn.Size = new System.Drawing.Size(126, 23);
            this.getAssBtn.TabIndex = 24;
            this.getAssBtn.Text = "获取视频名称";
            this.getAssBtn.UseVisualStyleBackColor = true;
            this.getAssBtn.Click += new System.EventHandler(this.getAssBtn_Click);
            // 
            // btnArrange
            // 
            this.btnArrange.Location = new System.Drawing.Point(428, 362);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(126, 23);
            this.btnArrange.TabIndex = 25;
            this.btnArrange.Text = "韩漫章节整理(绅士漫画)";
            this.btnArrange.UseVisualStyleBackColor = true;
            this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.btnArrange);
            this.Controls.Add(this.getAssBtn);
            this.Controls.Add(this.setAssBtn);
            this.Controls.Add(this.posRenameBtn);
            this.Controls.Add(this.positionLengthText);
            this.Controls.Add(this.compressText);
            this.Controls.Add(this.curLengthText);
            this.Controls.Add(this.cutPicBtn);
            this.Controls.Add(this.outputFolderBtn);
            this.Controls.Add(this.outFolderText);
            this.Controls.Add(this.serialRenameBtn);
            this.Controls.Add(this.merFileBtn);
            this.Controls.Add(this.addTailsBtn);
            this.Controls.Add(this.addPrefixBtn);
            this.Controls.Add(this.tailsText);
            this.Controls.Add(this.prefixText);
            this.Controls.Add(this.md5DeleteBtn);
            this.Controls.Add(this.batchDeleteBtn);
            this.Controls.Add(this.deleteKeyText);
            this.Controls.Add(this.fileText);
            this.Controls.Add(this.selectFileBtn);
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
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.OpenFileDialog fileSelected;
        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.TextBox deleteKeyText;
        private System.Windows.Forms.Button batchDeleteBtn;
        private System.Windows.Forms.Button md5DeleteBtn;
        private System.Windows.Forms.TextBox prefixText;
        private System.Windows.Forms.TextBox tailsText;
        private System.Windows.Forms.Button addPrefixBtn;
        private System.Windows.Forms.Button addTailsBtn;
        private System.Windows.Forms.Button merFileBtn;
        private System.Windows.Forms.Button serialRenameBtn;
        private System.Windows.Forms.TextBox outFolderText;
        private System.Windows.Forms.Button outputFolderBtn;
        private System.Windows.Forms.Button cutPicBtn;
        private System.Windows.Forms.TextBox curLengthText;
        private System.Windows.Forms.TextBox compressText;
        private System.Windows.Forms.TextBox positionLengthText;
        private System.Windows.Forms.Button posRenameBtn;
        private System.Windows.Forms.Button setAssBtn;
        private System.Windows.Forms.Button getAssBtn;
        private System.Windows.Forms.Button btnArrange;
    }
}

