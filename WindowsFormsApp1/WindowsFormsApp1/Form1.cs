using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {

        }

        private void Form_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog mapFolder = new FolderBrowserDialog();
            if (mapFolder.ShowDialog() == DialogResult.OK)
            {
                Form_Browse_Text.Text = mapFolder.SelectedPath;
            }
        }

        private void Form_Start_Click(object sender, EventArgs e)
        {
            string fileName = $"{AppDomain.CurrentDomain.BaseDirectory}\\Output.txt";
            string mapFolderDir = Form_Browse_Text.Text;
            string[] files = Directory.GetFiles(Form_Browse_Text.Text, "*.kfm", SearchOption.AllDirectories);
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = Path.GetFileNameWithoutExtension(files[i]);
            }
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter sw = File.CreateText(fileName))
            {
                for (int i = 0; i < files.Length; i++)
                {
                    sw.WriteLine($"[{files[i]} KFMapSummary]");
                    sw.WriteLine($"MapName = {files[i]}");
                    sw.WriteLine($"ScreenshotPathName = UI_MapPreview_TEX.UI_MapPreview_Placeholder");
                    sw.WriteLine("");
                }
            }
        }

        private void Form_Text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
