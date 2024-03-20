using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class FileSystem : Form
    {
        public FileSystem()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Open_Btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All Files | *.*", ValidateNames = true, Multiselect = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string s in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(s);
                        ListViewItem item = new ListViewItem(fi.Name);
                        item.SubItems.Add(fi.FullName);
                        listView1.Items.Add(item);

                    }
                }
            }
        }

        private void Remove_Btn_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(FileName_txt.Text);
            item.SubItems.Add(FilePath_txt.Text);
            listView1.Items.Add(item);
        }
    }
}
