using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FlipThisPic
{
    public partial class FlipPicForm : Form
    {
        public FlipPicForm()
        {
            InitializeComponent();
            SaveNewRadio.Checked = true;
            SingleImageRadio.Checked = true;
        }

        private void SelectFilesButton_Click(object sender, EventArgs e)
        {
            if(ImageSelectDialog.ShowDialog() == DialogResult.OK)
            {
                ImagePathTextBox.Text = ImageSelectDialog.FileName;
            }
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(FolderPathTextBox.Text))
            {
                FolderDialog.SelectedPath = FolderPathTextBox.Text;
            }
            FolderDialog.ShowNewFolderButton = false;
            if(FolderDialog.ShowDialog() == DialogResult.OK)
            {
                FolderPathTextBox.Text = FolderDialog.SelectedPath;
            }
        }

        private void ImageOpenButton_Click(object sender, EventArgs e)
        {
            if(!File.Exists(ImagePathTextBox.Text))
            {
                MessageBox.Show(Resources.ERROR_FOLDER_NOT_FOUND, Resources.ERROR_CAPTION);
                return;
            }
            System.Diagnostics.Process.Start("explorer.exe", "/select, \"" + ImagePathTextBox.Text + "\"");
        }

        private void FolderOpenButton_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(FolderPathTextBox.Text))
            {
                MessageBox.Show(Resources.ERROR_FOLDER_NOT_FOUND, Resources.ERROR_CAPTION);
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
            if(Directory.Exists(FolderPathTextBox.Text))
            {
                FolderDialog.SelectedPath = FolderPathTextBox.Text;
            }
            FolderDialog.ShowNewFolderButton = true;
            if(FolderDialog.ShowDialog() == DialogResult.OK)
            {
                SaveToFolderTextBox.Text = FolderDialog.SelectedPath;
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            MainGroupBox.Enabled = false;
            if(SingleImageRadio.Checked)
            {
                ConvertOneFile();
            }
            else if(ImageFolderRadio.Checked)
            {
                ConvertFolder();
            }
            else
            {
                MessageBox.Show(Resources.CONVERT_OPTION_NOT_SELECTED, Resources.ERROR_CAPTION);
            }
            MainGroupBox.Enabled = true;
        }

        private void ConvertOneFile()
        {
            string filePath = ImagePathTextBox.Text;
            string savePath = GetSavePathByAttributes(filePath);
            RotateSaveImage(filePath, savePath);
            if(savePath != null && MessageBox.Show(Resources.ROTATE_SUCCESSFULY, Resources.SUCCESS_CAPTION, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("explorer.exe", "/select, \"" + savePath + "\"");
            }
        }

        private void ConvertFolder()
        {
            string imageFolder = FolderPathTextBox.Text;
            if(!Directory.Exists(imageFolder))
            {
                MessageBox.Show(Resources.IMAGE_FOLDER_NOT_EXIST, Resources.ERROR_CAPTION);
                return;
            }
            string saveFolder = "";
            string[] filePaths = Directory.GetFiles(imageFolder);
            foreach(string filePath in filePaths)
            {
                try
                { using(Image.FromFile(filePath)) { } } // checks if file is image
                catch { continue; }
                string savePath = GetSavePathByAttributes(filePath);
                RotateSaveImage(filePath, savePath);
                if(savePath == "")
                { saveFolder = Path.GetDirectoryName(savePath); }
            }
            if(MessageBox.Show(Resources.ROTATE_SUCCESSFULY, Resources.SUCCESS_CAPTION, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(saveFolder == "")
                { System.Diagnostics.Process.Start("explorer.exe", imageFolder); }
                else
                { System.Diagnostics.Process.Start("explorer.exe", saveFolder); }
            }
        }

        private void RotateSaveImage(string imagePath, string savePath)
        {
            using(Image image = new Bitmap(Image.FromFile(imagePath)))
            {
                RotateByAttributes(image).Save(savePath);
            }
        }

        private Bitmap RotateByAttributes(Image bitmap)
        {
            return ImageRotation.RotateFlip(bitmap, (float)AngleNumberBox.Value,
                FlipVerticallyCheckBox.Checked, FlipHorizontallyCheckBox.Checked);
        }

        private string GetSavePathByAttributes(string imagePath)
        {
            string savePath;
            if(SaveNewRadio.Checked)
            {
                int count = 0;
                do
                {
                    savePath = Path.GetDirectoryName(imagePath) + "\\";
                    savePath += Path.GetFileNameWithoutExtension(imagePath) + "_" + ++count;
                    savePath += Path.GetExtension(imagePath);
                } while(File.Exists(savePath));
            }
            else if(SaveOverwriteRadio.Checked)
            {
                savePath = imagePath;
            }
            else if(SaveOverwriteRadio.Checked)
            {
                string folderPath = SaveToFolderTextBox.Text;
                if(!Directory.Exists(folderPath))
                {
                    folderPath = Path.GetDirectoryName(imagePath) + "\\rotated";
                    Directory.CreateDirectory(folderPath);
                }
                savePath = folderPath + "\\r_" + Path.GetFileName(imagePath);
            }
            else
            { savePath = null; }
            return savePath;
        }
    }
}
