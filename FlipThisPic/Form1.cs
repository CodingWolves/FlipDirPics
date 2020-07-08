using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipThisPic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SaveNewRadio.Checked = true;
            SingleImageRadio.Checked = true;
        }

        private void SelectFilesButton_Click(object sender, EventArgs e)
        {
            if (ImageSelectDialog.ShowDialog() == DialogResult.OK)
            {
                ImagePathTextBox.Text = ImageSelectDialog.FileName;
            }
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(FolderPathTextBox.Text))
                FolderDialog.SelectedPath = FolderPathTextBox.Text;
            FolderDialog.ShowNewFolderButton = false;
            if (FolderDialog.ShowDialog() == DialogResult.OK)
            {
                FolderPathTextBox.Text = FolderDialog.SelectedPath;
            }
        }

        private void ImageOpenButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(ImagePathTextBox.Text))
            {
                MessageBox.Show("Error File not found", "Error");
                return;
            }
            System.Diagnostics.Process.Start("explorer.exe", "/select, \""+ImagePathTextBox.Text+"\"");
        }

        private void FolderOpenButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(FolderPathTextBox.Text))
            {
                MessageBox.Show("Error Folder not found", "Error");
                return;
            }
            System.Diagnostics.Process.Start("explorer.exe", FolderPathTextBox.Text);
        }

        private void SingleImageRadio_CheckedChanged(object sender, EventArgs e)
        {
            SingleImagePanel.Enabled = SingleImageRadio.Checked;
        }

        private void ImageFolderRadio_CheckedChanged(object sender, EventArgs e)
        {
            ImageFolderPanel.Enabled = ImageFolderRadio.Checked;
        }

        private void SaveToFolderRadio_CheckedChanged(object sender, EventArgs e)
        {
            SaveToFolderSelectButton.Visible = SaveToFolderRadio.Checked;
            SaveToFolderTextBox.Visible = SaveToFolderRadio.Checked;
        }

        private void SaveToFolderShowButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(FolderPathTextBox.Text))
                FolderDialog.SelectedPath = FolderPathTextBox.Text;
            FolderDialog.ShowNewFolderButton = true;
            if (FolderDialog.ShowDialog() == DialogResult.OK)
            {
                SaveToFolderTextBox.Text = FolderDialog.SelectedPath;
            }
        }


        private void ConvertButton_Click(object sender, EventArgs e)
        {
            MainGroupBox.Enabled = false;
            if (SingleImageRadio.Checked)
            {
                string savePath = RotateSaveImagePath(ImagePathTextBox.Text);

                if (savePath != null && MessageBox.Show("Rotated Successfully!\nDo you want to open the containing folder?", "Success", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("explorer.exe", "/select, \"" + savePath + "\"");
                }
            }
            else if (ImageFolderRadio.Checked)
            {
                string imageFolder = FolderPathTextBox.Text;
                string saveFolder = "";
                if (Directory.Exists(imageFolder))
                {
                    string[] filePaths = Directory.GetFiles(imageFolder);
                    foreach (string filePath in filePaths)
                    {
                        try { using (Bitmap.FromFile(filePath)) { } }
                        catch { continue; }
                        string result = RotateSaveImagePath(filePath);
                        //Thread th = new Thread(new ParameterizedThreadStart(RotateSaveSingleImage));
                        //th.Start(filePath);

                        if (saveFolder == "" && result != null)
                        {
                            saveFolder = Path.GetDirectoryName(result);
                        }
                    }

                    if (MessageBox.Show("Rotated Successfully!\nDo you want to open the containing folder?", "Success", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (saveFolder == "")
                        { System.Diagnostics.Process.Start("explorer.exe", imageFolder); }
                        else
                        { System.Diagnostics.Process.Start("explorer.exe", saveFolder); }
                    }
                }
                else
                {
                    MessageBox.Show("Image folder does not exist", "Error");
                }
            }
            MainGroupBox.Enabled = true;
        }


        private string RotateSaveImagePath(string imagePath)
        {
            if (!File.Exists(imagePath))
            {
                MessageBox.Show("Error File not found", "Error");
                return null;
            }

            string savePath = GetSavePathByAttributes(imagePath);

            using (Image originalImage = Image.FromFile(imagePath))
            {
                using (Bitmap processedImage = new Bitmap(originalImage)) // uses a lot of memory
                {
                    RotateByAtrributes(processedImage).Save(savePath, originalImage.RawFormat);
                }
            }
            return savePath;
        }

        private Bitmap RotateByAtrributes(Image bitmap)
        {
            float angle = (float)AngleNumberBox.Value;
            return ImageRotation.RotateFlip(bitmap, angle, FlipVerticallyCheckBox.Checked, FlipHorizontallyCheckBox.Checked);
        }

        private string GetSavePathByAttributes(string imagePath)
        {
            string savePath;
            if (SaveNewRadio.Checked)
            {
                int count = 0;
                do
                {
                    savePath = Path.GetDirectoryName(imagePath) + "\\";
                    savePath += Path.GetFileNameWithoutExtension(imagePath) + "_" + (++count).ToString();
                    savePath += Path.GetExtension(imagePath);
                } while (File.Exists(savePath));
            }
            else if (SaveOverwriteRadio.Checked)
            {
                savePath = imagePath;
            }
            else // (SaveToFolderRadio.Checked)
            {
                string folderPath = SaveToFolderTextBox.Text;
                if (!Directory.Exists(folderPath))
                {
                    folderPath = Path.GetDirectoryName(imagePath) + "\\rotated";
                    Directory.CreateDirectory(folderPath);
                }
                savePath = folderPath + "\\r_" + Path.GetFileName(imagePath);
            }
            return savePath;
        }
    }
}
