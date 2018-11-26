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

namespace EtriResultReadError
{
    public partial class Form1 : Form
    {
        private List<int> fileWordCount;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            #region 파일 불러오기

            if (textBoxInputWord.Text == "") return;

            List<string> filePathList = new List<string>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "check_taggedQ files (*.check_taggedQ)|*.check_taggedQ";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "복수파일 선택";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                resetTextBox();

                filePathList.AddRange(openFileDialog.FileNames);
                readFiles(filePathList);
            }
            #endregion
        }

        private void resetTextBox()
        {
            textBoxResult.Text = "";
            fileWordCount = new List<int>();
        }

        private void readFiles(IList<string> filePaths)
        {
            #region 파일 읽기
            string fileName = "";
            comboBoxFileList.Items.Clear();
        
            foreach (var item in filePaths)
            {
                try
                {
                    int index = item.LastIndexOf(@"\");
                    fileName = item.Substring(index + 1, item.Length - index - 1);
                    comboBoxFileList.Items.Add(fileName);
                   
                    fileWordCount.Add(readFile(item, textBoxInputWord.Text));
                }
                catch
                {
                    MessageBox.Show("오류파일은" + fileName);
                }
            }

            MessageBox.Show("파일 읽기 완료");
            #endregion
        }

        private int readFile(string filePath, string findWord)
        {
            #region 파일 읽기 Core
            int countWord = 0;
            FileStream fs_read = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader stream_read = new StreamReader(fs_read, System.Text.Encoding.UTF8);
            
            //한줄씩 읽으면서 단어 찾음
            while (stream_read.Peek() > -1)
            {
                String lineSentence = stream_read.ReadLine();

                if (lineSentence.Contains(findWord))
                {
                    countWord++;
                }
            }
           
            stream_read.Close();
            fs_read.Close();

            return countWord;
            #endregion
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxInputWord.Text = "";
        }

        private void comboBoxFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFileList.Text == "")
            {
                MessageBox.Show("파일을 선택해주세요");
                return;
            }
            else
            {
                int index = comboBoxFileList.SelectedIndex;
                textBoxResult.Text = fileWordCount[index].ToString();
            }
        }

        private void btnResultSum_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int i = 0; i < fileWordCount.Count; i++)
            {
                sum = sum + Convert.ToInt32(fileWordCount[i]);
            }

            MessageBox.Show(textBoxInputWord.Text +  "의 총개수는 " + sum.ToString());
        }

    



    }
}
