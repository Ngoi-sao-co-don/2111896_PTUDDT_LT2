using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusStrip_OpenFileDialog
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFiledlg = new OpenFileDialog();
        SaveFileDialog saveFiledlg = new SaveFileDialog();  
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFiledlg.Title = "Open Dialog";
            openFiledlg.Multiselect = true;
            openFiledlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
                + "*.jpg;*.jpeg;*.gif;*.bmp;"
                + "*.tif;*.tiff;*.png|"
                + "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg | "
                + "GIF files (*.gif)|*.gif | "
                + "BMP files (*.bmp)|*.bmp | "
                + "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
                + "PNG files (*.png)|*.png|"
                + "All files (*.*)|*.*";
            openFiledlg.InitialDirectory = Environment.CurrentDirectory;
            if(openFiledlg.ShowDialog() == DialogResult.OK)
            {
                string [] filenames = openFiledlg.FileNames;
                for(int i = 0; i < filenames.Length; i++)
                    this.lvListFile.Items.Add(new ListViewItem(filenames[i]));
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvListFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lvListFile.SelectedItems.Count - 1;
            if(i >= 0)
            {
                ListViewItem lvitem = lvListFile.SelectedItems[0];
                this.pbImage.ImageLocation = lvitem.Text;
                toolStripStatusLabel1.Text = lvitem.Text;
            }    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFiledlg.Title = "Save file ..";
            saveFiledlg.Filter = "Image Files (JPEG, BMP, GIF, ..)"
                + "|(*.jpeg; *.jpg;)" +
                "Bitmap file (*.bmp)|*.bmp|" +
                "All files (*.*)|*.*";
            if(saveFiledlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image im = pbImage.Image;
                    im.Save(saveFiledlg.FileName);
                }
                catch
                {
                    MessageBox.Show("Loi luu anh");
                }
            }    
        }
    }
}
