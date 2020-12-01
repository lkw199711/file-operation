﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lkw;

namespace 文件操作
{
    public partial class Form1 : Form
    {
        int i = 0;

        Lkw lkw = new Lkw();

        ImageCodecInfo jgpEncoder;

        // 创建一个EncoderParameters对象.
        // 一个EncoderParameters对象有一个EncoderParameter数组对象
        EncoderParameters myEncoderParameters = new EncoderParameters(1);

        EncoderParameter myEncoderParameter;

        //创建一个Endoder对象
        System.Drawing.Imaging.Encoder myEncoder =
            System.Drawing.Imaging.Encoder.Quality;
        public Form1()
        {
            InitializeComponent();

            jgpEncoder = GetEncoder(ImageFormat.Jpeg);

            myEncoderParameter = new EncoderParameter(myEncoder, 100L);//这里的50L用来设置保存时的图片质量
                                                                                       //测试时400多K的图片保存为100多K，图片失真也不是很厉害
            myEncoderParameters.Param[0] = myEncoderParameter;
        }
        /// <summary>
        /// 文件夹选择按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 文件选择按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            // 文件名选取
            DialogResult result = fileSelected.ShowDialog();

            if (result == DialogResult.OK) //另外一种判断办法 if (df.ShowDialog(this) == DialogResult.OK)   
            {
                //将中的数据库目录地址赋于类全局变量数据库根目录   
                string fileName = fileSelected.FileName;

                if (string.IsNullOrEmpty(fileName))
                {
                    lkw.msbox("文件夹路径不能为空");
                    return;
                }

                fileText.Text = fileName;
            }
        }
        /// <summary>
        /// 根据关键字替换,更改文件名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void replaceFileNameBtn_Click(object sender, EventArgs e)
        {
            string path = folderText.Text;
            string oldStr = replaceOldText.Text;
            string newStr = replaceNewText.Text;

            folder_operation(path, "replace", oldStr, newStr);
        }

        /// <summary>
        /// 删除指定文件、文件夹
        /// </summary>
        /// <param name="dir">目录路径</param>
        /// <param name="delname">待删除文件或文件夹名称</param>
        public void folder_operation(string dir, string type, string key0 = "", string key1 = "")
        {
            // 非文件夹
            if (!Directory.Exists(dir)) return;

            //根据关键字删除
            if (type == "keyword-delete")
            {
                // 删除关键字
                string key = key0;

                foreach (string fileName in Directory.GetFileSystemEntries(dir))
                {

                    // 检索没有关键字
                    if (!fileName.Contains(key))
                    {
                        // 递归继续寻找符合文件
                        folder_operation(fileName, type, key);
                        continue;
                    }
                    lkw.log("找到文件");
                    // 删除文件
                    delete(fileName);
                }

                return;
            }

            //根据md5删除
            if (type == "md5-delete")
            {
                // 删除关键字
                string sampleFile = key0;
                // 样本文件的md5值
                string sampleMd5 = GetMD5HashFromFile(sampleFile);

                foreach (string fileName in Directory.GetFileSystemEntries(dir))
                {
                    // 目标为文件夹
                    if (Directory.Exists(fileName))
                    {
                        // 递归继续寻找符合文件
                        folder_operation(fileName, type, sampleFile);
                        continue;
                    }

                    // md5值不相同,则跳出
                    if (!(GetMD5HashFromFile(fileName) == sampleMd5)) continue;

                    // md5值相同,则删除文件
                    delete(fileName);
                }

                return;
            }

            //替换文件名
            if (type == "replace")
            {
                // 被替换关键字
                string oldStr = key0;
                // 替换关键字
                string newStr = key1;

                foreach (string fileName in Directory.GetFileSystemEntries(dir))
                {

                    // 检索没有关键字
                    if (!fileName.Contains(oldStr))
                    {
                        // 递归继续寻找符合文件
                        folder_operation(fileName, type, oldStr, newStr);
                        continue;
                    }

                    // 替换文件名
                    replace(fileName, oldStr, newStr);
                }

                return;
            }

            //添加前缀尾缀
            /**
             * 添加前缀尾缀功能目前不带有遍历目录树特性
             * 也不对文件夹进行操作
             */
            if (type == "prefix" || type == "tails")
            {
                // 被替换关键字
                string key = key0;

                foreach (string fileName in Directory.GetFileSystemEntries(dir))
                {
                    // 获取不带路径的文件名
                    string name = Path.GetFileName(fileName);
                    string newStr = (type == "prefix" ? key + name : name + key);

                    // 如果目标非文件,跳出
                    if (!File.Exists(fileName)) continue;

                    // 替换文件名
                    replace(fileName, name, newStr);
                }

                return;
            }

            if (type == "merge")
            {
                foreach (string fileName in Directory.GetFileSystemEntries(dir))
                {
                    if (Directory.Exists(fileName))
                    {
                        folder_operation(fileName, type, key0);
                        continue;
                    }
                    // 获取不带路径的文件名
                    string name = Path.GetFileName(fileName);

                    // 获取文件扩展名
                    string strExt = Path.GetExtension(fileName);

                    string newName = dir.Substring(0, dir.LastIndexOf(@"\") + 1) + (i++).ToString() + strExt;

                    File.Move(fileName, newName);
                }

                return;
            }

            if (type == "serial")
            {
                int serial = 0;
                foreach (string fileName in Directory.GetFileSystemEntries(dir))
                {
                    if (Directory.Exists(fileName))
                    {
                        folder_operation(fileName, type);
                        continue;
                    }
                    // 获取文件扩展名
                    string suffix = Path.GetExtension(fileName);

                    File.Move(fileName, dir + "\\" + (++serial).ToString() + suffix);
                }

                return;
            }

            //裁切图片
            if (type == "cutting")
            {
                //输出目录
                string outPath = key0;
                //单个图片的长度
                int curLength = int.Parse(key1);
                //文件索引
                int fileNum = 0;

                foreach (string fileName in Directory.GetFileSystemEntries(dir))
                {
                    if (Directory.Exists(fileName))
                    {
                        //文件夹递归操作
                        lkw.NewWork(() => { folder_operation(fileName, type, key0, key1); });
                        continue;
                    }

                    //图片文件实例化
                    Bitmap pic = new Bitmap(fileName);
                    //宽度
                    int width = pic.Width;
                    //图片数量索引
                    int num = 0;


                    // 获取不带路径不带扩展名的文件名
                    string name = Path.GetFileNameWithoutExtension(fileName);

                    //上层目录
                    string topPath = dir.Substring(0, dir.LastIndexOf(@"\") + 1);

                    //获取当前文件夹名
                    string folderName = dir.Substring(dir.LastIndexOf(@"\") + 1);

                    //新目录路径
                    string newPath = outPath + "\\" + folderName + "\\";

                    //新建目录(Bitmap.save无法存储没有目录的文件夹,所以要先创建不存在的路径)
                    if (!Directory.Exists(newPath)) { Directory.CreateDirectory(newPath); }

                    // 获取文件扩展名
                    string strExt = Path.GetExtension(fileName);

                    //循环直到分割完所有高度
                    while ((pic.Height - curLength * num) > 0)
                    {
                        //剩下的高度
                        int leftHeight = pic.Height - curLength * num;
                        //当前新建图片单元的高度
                        int height = leftHeight > curLength ? curLength : leftHeight;
                        //新建空图片
                        Bitmap newPic = new Bitmap(width, height);

                        for (int y = 0; y < height; y++)
                        {
                            for (int x = 0; x < width; x++)
                            {
                                //获取旧图片的色彩,设置给新的图片单元
                                newPic.SetPixel(x, y, pic.GetPixel(x, y + num * curLength));
                            }
                        }

                        //存储文件
                        newPic.Save(newPath + (num + fileNum).ToString() + strExt, jgpEncoder, myEncoderParameters);

                        //释放Bitmap资源(图片单元)
                        newPic.Dispose();

                        //图片单元数量索引递增
                        num++;
                    }

                    /*
                     释放Bitmap资源(整个文件)
                    如果不使用Bitmap.Dispose释放内存
                    在使用bitMap到一定数量的时候会报错"内存不足"
                    我也不知道为什么会这样,明明有16g内存
                     */
                    pic.Dispose();

                    //源图片文件索引递增
                    fileNum += num;
                }
            }
        }

        /// <summary>
        /// 获取文件MD5值
        /// </summary>
        /// <param name="fileName">文件绝对路径</param>
        /// <returns>MD5值</returns>
        public static string GetMD5HashFromFile(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("GetMD5HashFromFile() fail,error:" + ex.Message);
            }
        }
        /// <summary>
        /// 根据关键字批量删除文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void batchDeleteBtn_Click(object sender, EventArgs e)
        {
            string path = folderText.Text;
            string key = deleteKeyText.Text;
            folder_operation(path, "keyword-delete", key);
        }
        private void md5DeleteBtn_Click(object sender, EventArgs e)
        {
            string path = folderText.Text;
            string file = fileText.Text;
            folder_operation(path, "md5-delete", file);
        }
        /// <summary>
        /// 删除文件或目录
        /// </summary>
        /// <param name="fileName">文件路径</param>
        public void delete(string fileName)
        {
            // 如果是目录,调用文件夹方法
            if (Directory.Exists(fileName)) Directory.Delete(fileName, true);
            lkw.log(fileName);
            // 如果是文件,调用文件方法
            if (File.Exists(fileName)) File.Delete(fileName);
            lkw.log(fileName);
        }
        /// <summary>
        /// 删除文件或目录
        /// </summary>
        /// <param name="fileName">文件路径</param>
        public void replace(string fileName, string oldStr, string newStr)
        {
            // 如果是目录,调用文件夹方法
            if (Directory.Exists(fileName)) Directory.Move(fileName, fileName.Replace(oldStr, newStr));

            // 如果是文件,调用文件方法
            if (File.Exists(fileName)) File.Move(fileName, fileName.Replace(oldStr, newStr));
        }

        private void addPrefixBtn_Click(object sender, EventArgs e)
        {
            string path = folderText.Text;
            string prefix = prefixText.Text;
            folder_operation(path, "prefix", prefix);
        }

        private void addTailsBtn_Click(object sender, EventArgs e)
        {
            string path = folderText.Text;
            string tails = tailsText.Text;
            folder_operation(path, "tails", tails);
        }

        private void merFileBtn_Click(object sender, EventArgs e)
        {
            string path = folderText.Text;
            folder_operation(path, "merge", "");
        }

        private void serialRenameBtn_Click(object sender, EventArgs e)
        {
            string path = folderText.Text;
            folder_operation(path, "serial");
        }

        private void cutPicBtn_Click(object sender, EventArgs e)
        {
            string path = folderText.Text;
            string newPath = outFolderText.Text;
            string length = curLengthText.Text;

            long compress = long.Parse(compressText.Text);

            myEncoderParameter = new EncoderParameter(myEncoder, compress);

            myEncoderParameters.Param[0] = myEncoderParameter;

            //裁切图片操作 参数一为源路径 参数二为裁切类型标识 参数三输出路径 参数四为单元图片长度
            lkw.NewWork(() => { folder_operation(path, "cutting", newPath, length); });

        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
