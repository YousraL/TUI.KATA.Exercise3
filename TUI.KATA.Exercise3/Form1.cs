using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUI.KATA.Exercise3.DTO;
using TUI.KATA.Exercise3.Services;

namespace TUI.KATA.Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "txt files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    DTO.File f = new DTO.File() { Path = openFileDialog.FileName };
                    string fileContent = FileServices.ReadFile(f);
                    richTextBox1.Text = fileContent;
                }
                catch (Exception ex)
                {
                    richTextBox1.Text = string.Format("Exception : {0} ", ex.Message);
                }
                
            }
        }
    }
}
