using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_and_await_Csharp_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Get_Characters_Count()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(Application.StartupPath + "\\textdata.txt"))

            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);

            }

            return count;
        }

        private async  void BtnProcessFile_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(Get_Characters_Count);
            task.Start();

            lblCount.Text = "يتم الآن حساب عدد الأحرف في الملف ";
            int count = await task;
            lblCount.Text = count.ToString() + " حرف في الملف "; 
        }
    }
}
