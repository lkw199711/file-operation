using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lkw;

namespace 文件操作
{
    public partial class Form1 : Form
    {
        Lkw lkw = new Lkw();
        public Form1()
        {
            InitializeComponent();
        }

        private void selectFolderBtn_Click(object sender, EventArgs e)
        {
            // 文件名选取
            DialogResult result = folderSelected.ShowDialog();

            if (result == DialogResult.OK) //另外一种判断办法 if (df.ShowDialog(this) == DialogResult.OK)   
            {
                //将中的数据库目录地址赋于类全局变量数据库根目录   
                string folderPath = folderSelected.SelectedPath;

                if (string.IsNullOrEmpty(folderPath))
                {
                    lkw.msbox("文件夹路径不能为空");
                    return;
                }

                folderText.Text = folderPath;
            }
        }

        private void replaceFileNameBtn_Click(object sender, EventArgs e)
        {
            string path = folderText.Text;
            string oldStr = replaceOldText.Text;
            string newStr = replaceNewText.Text;

            folder_operation(path, oldStr, newStr);
        }

        /// <summary>
        /// 删除指定文件、文件夹
        /// </summary>
        /// <param name="dir">目录路径</param>
        /// <param name="delname">待删除文件或文件夹名称</param>
        public void folder_operation(string dir, string key, string newStr)
        {
            // 非文件夹
            if (!Directory.Exists(dir)) return;

            foreach (string fileName in Directory.GetFileSystemEntries(dir))
            {
                // 检索没有关键字
                if (!fileName.Contains(key)) {
                    // 递归继续寻找符合文件
                    folder_operation(fileName, key, newStr);
                    continue;
                }
                
                // 如果是目录,调用文件夹方法
                if (Directory.Exists(fileName)) Directory.Move(fileName, fileName.Replace(key, newStr));

                // 如果是文件,调用文件方法
                if (File.Exists(fileName)) File.Move(fileName, fileName.Replace(key, newStr));

            }

        }
    }
}
