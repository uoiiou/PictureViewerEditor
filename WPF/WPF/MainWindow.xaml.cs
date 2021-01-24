using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
using Files;
using ImageManipulation;

namespace WPF
{
    public partial class MainWindow : Window
    {
        private DrawInfo di;
        private FilesHandler files;
        private float zoomvalue = 1f;
        private int rotatevalue = 0;
        private bool isMouseDown = false;
        private int width, height;

        public MainWindow()
        {
            files = new FilesHandler();
            di = new DrawInfo();
            InitializeComponent();
        }

        private void bChooseFile_Click(object sender, RoutedEventArgs e)
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
            files.showItemsOnLVWPF(lbListOfFiles);
        }

        private void initComponents()
        {
            sBrightness.IsEnabled = true;
            sContrast.IsEnabled = true;
            bRed.IsEnabled = true;
            bGreen.IsEnabled = true;
            bBlue.IsEnabled = true;
            bZoomIn.IsEnabled = true;
            bZoomOut.IsEnabled = true;
            tbRotateValue.IsEnabled = true;
            bRotate.IsEnabled = true;
            cpColorPicker.IsEnabled = true;
            sPenSize.IsEnabled = true;
            bSave.IsEnabled = true;

            sBrightness.Value = 0;
            sContrast.Value = 0;
            zoomvalue = 1f;
            rotatevalue = 0;
            cImage.RenderTransform = new RotateTransform(rotatevalue, cImage.ActualWidth / 2, cImage.ActualHeight / 2);
            tbRotateValue.Text = "";
            cpColorPicker.SelectedColor = System.Windows.Media.Colors.Black;
            sPenSize.Value = 5;

            width = (int) cImage.ActualWidth;
            height = (int) cImage.ActualHeight;
        }

        private BitmapImage convertImageToBitmap(System.Drawing.Image img)
        {
            using (var memory = new MemoryStream())
            {
                img.Save(memory, ImageFormat.Bmp);
                memory.Position = 0;

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }

        private void applyChanges(Image image)
        {
            BitmapImage bitmapImage = convertImageToBitmap(image);

            cImage.Width = bitmapImage.PixelWidth;
            cImage.Height = bitmapImage.PixelHeight;
            cImage.Background = new ImageBrush(bitmapImage);
        }

        private void lb_MouseUp(object sender, EventArgs e)
        {
            int index = lbListOfFiles.SelectedIndex;

            if (index != -1)
            {
                initComponents();

                String fullfilename = files.getFileNameByIndex(index);
                applyChanges(Image.FromFile(fullfilename));
            }
        }

        private void sBrightness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BrightnessHandler bh = new BrightnessHandler();
            applyChanges(bh.toBright(files.getSelectedImage(), (float)sBrightness.Value));
        }

        private void sContrast_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ContrastHandler ch = new ContrastHandler();
            applyChanges(ch.toContrast(files.getSelectedImage(), (float)sContrast.Value));
        }

        private void bRed_Click(object sender, RoutedEventArgs e)
        {
            RGBHandler rgbHandler = new RGBHandler();
            applyChanges(rgbHandler.toRGB(files.getSelectedImage(), ImageManipulation.Colors.RED));
        }

        private void bGreen_Click(object sender, RoutedEventArgs e)
        {
            RGBHandler rgbHandler = new RGBHandler();
            applyChanges(rgbHandler.toRGB(files.getSelectedImage(), ImageManipulation.Colors.GREEN));
        }

        private void bBlue_Click(object sender, RoutedEventArgs e)
        {
            RGBHandler rgbHandler = new RGBHandler();
            applyChanges(rgbHandler.toRGB(files.getSelectedImage(), ImageManipulation.Colors.BLUE));
        }

        private void bZoomIn_Click(object sender, RoutedEventArgs e)
        {
            cImage.Children.Clear();

            ZoomHandler zh = new ZoomHandler();
            zoomvalue += 0.1f;
            Image image = zh.toZoom(files.getSelectedImage(), zoomvalue);

            if (image.Width > width || image.Height > height)
                zoomvalue -= 0.1f;
            else
                applyChanges(image);

            applyChanges(zh.toZoom(files.getSelectedImage(), zoomvalue));
        }

        private void bZoomOut_Click(object sender, RoutedEventArgs e)
        {
            cImage.Children.Clear();

            ZoomHandler zh = new ZoomHandler();
            zoomvalue -= 0.1f;
            applyChanges(zh.toZoom(files.getSelectedImage(), zoomvalue));
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

        private void bRotate_Click(object sender, RoutedEventArgs e)
        {
            if (checkRotateValue(tbRotateValue.Text))
            {
                rotatevalue += int.Parse(tbRotateValue.Text);
                cImage.RenderTransform = new RotateTransform(rotatevalue, cImage.ActualWidth / 2, cImage.ActualHeight / 2);
            }
            else
                System.Windows.Forms.MessageBox.Show("Rotate value empty", "Rotate value Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1, System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly);
        }

        private void cImage_MouseDown(object sender, System.Windows.Input.MouseEventArgs e)
        {
            isMouseDown = true;

            di.OX = (int) e.GetPosition(cImage).X;
            di.OY = (int) e.GetPosition(cImage).Y;
        }

        private void cImage_MouseUp(object sender, System.Windows.Input.MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void cImage_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Line line = new Line();

                line.StrokeThickness = sPenSize.Value;
                line.Stroke = new SolidColorBrush(cpColorPicker.SelectedColor.Value);

                line.X1 = di.OX;
                line.Y1 = di.OY;
                line.X2 = e.GetPosition(cImage).X;
                line.Y2 = e.GetPosition(cImage).Y;

                di.OX = (int)e.GetPosition(cImage).X;
                di.OY = (int)e.GetPosition(cImage).Y;

                cImage.Children.Add(line);
            }
        }

        private void bSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPG image (*.jpg)|*.jpg|" +
                          "JPEG image (*.jpeg)|*.jpeg|" +
                          "PNG image (*.png)|*.png|" +
                          "BMP image (*.bmp)|*.bmp";
            sfd.ShowDialog();

            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
            RenderTargetBitmap rtb = new RenderTargetBitmap((int) canvasBorder.ActualWidth, (int) canvasBorder.ActualHeight, 1 / 96, 1 / 96, PixelFormats.Pbgra32);
            rtb.Render(cImage);

            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(rtb));
            encoder.Save(fs);
            fs.Close();
        }
    }
}