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

namespace MondayDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getDrives();
        }

        void getDrives()
        {
            string[] drives = System.IO.Directory.GetLogicalDrives();

            foreach (string str in drives)
            {
                drivesComboBox.Items.Add(str);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                directoryListBox.Items.Clear();
                pathBox.Text = drivesComboBox.Text;
                string[] directoryList = Directory.GetDirectories(pathBox.Text);
                foreach (string str in directoryList)
                {
                    directoryListBox.Items.Add(str);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            getFiles(directoryListBox.SelectedItem.ToString(), "O");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            File.Delete(@directoryListBox.SelectedItem.ToString());
            getFiles(@pathBox.Text, "D");
        }

        public void getFiles(string selectedFolder, string filemode)
        {
            try
            {
                string[] directoryList = Directory.GetDirectories(@selectedFolder);
                string[] fileList = Directory.GetFiles(@selectedFolder);
                pathBox.Text = @selectedFolder;
                directoryListBox.Items.Clear();
                foreach (var directory in directoryList)
                {
                    directoryListBox.Items.Add(directory);
                }
                foreach (var file in fileList)
                {
                    directoryListBox.Items.Add(file);
                }
            }
            catch (Exception)
            {
                if (filemode.Equals("O"))
                {
                    MessageBox.Show("This is not directory.");
                }

            }
        }
    }
}
