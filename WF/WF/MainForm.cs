using System;
using System.Drawing;
using System.Windows.Forms;
using Files;
using ImageManipulation;

namespace WF
{
    public partial class MainForm : Form
    {
        private FilesHandler files;
        private DrawInfo di;
        private bool isMouseDown = false;

        public MainForm()
        {
            files = new FilesHandler();
            di = new DrawInfo();
            InitializeComponent();
        }

        private void initComponents()
        {
            tbRotateValue.Text = "";
            tbBrightnessValue.Value = 0;
            tbContrastValue.Value = 0;
            tbPenSize.Value = 5;

            bSaveFile.Enabled = true;
            tbRotateValue.Enabled = true;
            bRotate.Enabled = true;
            tbBrightnessValue.Enabled = true;
            tbContrastValue.Enabled = true;
            bRed.Enabled = true;
            bGreen.Enabled = true;
            bBlue.Enabled = true;
            bZoomIn.Enabled = true;
            bZoomOut.Enabled = true;
            bChooseColor.Enabled = true;
            tbPenSize.Enabled = true;
        }

        private void bChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files(*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|" +
                                    "JPG image (*.jpg)|*.jpg|" +
                                    "JPEG image (*.jpeg)|*.jpeg|" +
                                    "PNG image (*.png)|*.png|" +
                                    "BMP image (*.bmp)|*.bmp";
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();

            files.addItems(openFileDialog.FileNames);
            files.showItemsOnLVWF(lbListOfFiles);
        }

        private void lbListOfFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbListOfFiles.SelectedIndex;

            if (index != -1)
            {
                initComponents();
                String fullfilename = files.getFileNameByIndex(index);
                pbPicture.Image = Image.FromFile(fullfilename);
            }
        }

        private bool checkRotateValue(String str)
        {
            if (str.Length == 0)
                return false;

            String numbers = "0123456789";

            for (int i = 0; i < str.Length; i++)
            {
                if (!numbers.Contains(str[i]))
                    return false;
            }

            return true;
        }

        private void bRotate_Click(object sender, EventArgs e)
        {
            if (checkRotateValue(tbRotateValue.Text))
            {
                RotateHandler rh = new RotateHandler();
                pbPicture.Image = rh.toRotate(pbPicture.Image, int.Parse(tbRotateValue.Text));
            }
            else
                MessageBox.Show("Rotate value empty", "Rotate value Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void tbBrightnessValue_Scroll(object sender, EventArgs e)
        {
            BrightnessHandler bh = new BrightnessHandler();
            pbPicture.Image = bh.toBright(files.getSelectedImage(), tbBrightnessValue.Value);
        }

        private void tbContrastValue_Scroll(object sender, EventArgs e)
        {
            ContrastHandler ch = new ContrastHandler();
            pbPicture.Image = ch.toContrast(files.getSelectedImage(), tbContrastValue.Value);
        }

        private void bRed_Click(object sender, EventArgs e)
        {
            RGBHandler rbgHandler = new RGBHandler();
            pbPicture.Image = rbgHandler.toRGB(files.getSelectedImage(), Colors.RED);
        }

        private void bGreen_Click(object sender, EventArgs e)
        {
            RGBHandler rbgHandler = new RGBHandler();
            pbPicture.Image = rbgHandler.toRGB(files.getSelectedImage(), Colors.GREEN);
        }

        private void bBlue_Click(object sender, EventArgs e)
        {
            RGBHandler rbgHandler = new RGBHandler();
            pbPicture.Image = rbgHandler.toRGB(files.getSelectedImage(), Colors.BLUE);
        }

        private void bZoomIn_Click(object sender, EventArgs e)
        {
            ZoomHandler zh = new ZoomHandler();
            pbPicture.Image = zh.toZoom(pbPicture.Image, 1.1f);
        }

        private void bZoomOut_Click(object sender, EventArgs e)
        {
            ZoomHandler zh = new ZoomHandler();
            pbPicture.Image = zh.toZoom(pbPicture.Image, 0.9f);
        }

        private void pbPicture_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void pbPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true) 
            {
                bSaveFile.Enabled = false;

                if (di.OX != -1)
                {
                    DrawHandler dh = new DrawHandler();
                    dh.toDraw(di, e.X, e.Y, pbPicture.Handle, tbPenSize.Value);
                }

                di.OX = e.X;
                di.OY = e.Y;
            }
        }

        private void pbPicture_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            di.OX = di.OY = -1;
        }

        private void bChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();

            di.Color = cd.Color;
        }

        private void bSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPG image (*.jpg)|*.jpg|" +
                          "JPEG image (*.jpeg)|*.jpeg|" +
                          "PNG image (*.png)|*.png|" +
                          "BMP image (*.bmp)|*.bmp";
            sfd.ShowDialog();

            pbPicture.Image.Save(sfd.FileName);
        }
    }
}