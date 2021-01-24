namespace WF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bChooseFile = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.tbBrightnessValue = new System.Windows.Forms.TrackBar();
            this.tbRotateValue = new System.Windows.Forms.TextBox();
            this.bRotate = new System.Windows.Forms.Button();
            this.lRotate = new System.Windows.Forms.Label();
            this.lBright = new System.Windows.Forms.Label();
            this.lbListOfFiles = new System.Windows.Forms.ListBox();
            this.lContrast = new System.Windows.Forms.Label();
            this.tbContrastValue = new System.Windows.Forms.TrackBar();
            this.lRBG = new System.Windows.Forms.Label();
            this.bRed = new System.Windows.Forms.Button();
            this.bGreen = new System.Windows.Forms.Button();
            this.bBlue = new System.Windows.Forms.Button();
            this.bZoomIn = new System.Windows.Forms.Button();
            this.bZoomOut = new System.Windows.Forms.Button();
            this.lZoom = new System.Windows.Forms.Label();
            this.bChooseColor = new System.Windows.Forms.Button();
            this.lPen = new System.Windows.Forms.Label();
            this.tbPenSize = new System.Windows.Forms.TrackBar();
            this.bSaveFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightnessValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrastValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenSize)).BeginInit();
            this.SuspendLayout();
            // 
            // bChooseFile
            // 
            this.bChooseFile.Location = new System.Drawing.Point(201, 12);
            this.bChooseFile.Name = "bChooseFile";
            this.bChooseFile.Size = new System.Drawing.Size(274, 44);
            this.bChooseFile.TabIndex = 1;
            this.bChooseFile.Text = "Choose File";
            this.bChooseFile.UseVisualStyleBackColor = true;
            this.bChooseFile.Click += new System.EventHandler(this.bChooseFile_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(493, 12);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(1094, 739);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPicture.TabIndex = 1;
            this.pbPicture.TabStop = false;
            this.pbPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPicture_MouseDown);
            this.pbPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPicture_MouseMove);
            this.pbPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPicture_MouseUp);
            // 
            // tbBrightnessValue
            // 
            this.tbBrightnessValue.Enabled = false;
            this.tbBrightnessValue.Location = new System.Drawing.Point(201, 208);
            this.tbBrightnessValue.Maximum = 200;
            this.tbBrightnessValue.Minimum = -200;
            this.tbBrightnessValue.Name = "tbBrightnessValue";
            this.tbBrightnessValue.Size = new System.Drawing.Size(274, 56);
            this.tbBrightnessValue.TabIndex = 4;
            this.tbBrightnessValue.TabStop = false;
            this.tbBrightnessValue.TickFrequency = 10;
            this.tbBrightnessValue.Scroll += new System.EventHandler(this.tbBrightnessValue_Scroll);
            // 
            // tbRotateValue
            // 
            this.tbRotateValue.Enabled = false;
            this.tbRotateValue.Location = new System.Drawing.Point(201, 111);
            this.tbRotateValue.Name = "tbRotateValue";
            this.tbRotateValue.Size = new System.Drawing.Size(77, 27);
            this.tbRotateValue.TabIndex = 2;
            // 
            // bRotate
            // 
            this.bRotate.Enabled = false;
            this.bRotate.Location = new System.Drawing.Point(305, 109);
            this.bRotate.Name = "bRotate";
            this.bRotate.Size = new System.Drawing.Size(170, 30);
            this.bRotate.TabIndex = 3;
            this.bRotate.Text = "Rotate";
            this.bRotate.UseVisualStyleBackColor = true;
            this.bRotate.Click += new System.EventHandler(this.bRotate_Click);
            // 
            // lRotate
            // 
            this.lRotate.AutoSize = true;
            this.lRotate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lRotate.Location = new System.Drawing.Point(201, 77);
            this.lRotate.Name = "lRotate";
            this.lRotate.Size = new System.Drawing.Size(66, 20);
            this.lRotate.TabIndex = 9;
            this.lRotate.Text = "Rotation";
            // 
            // lBright
            // 
            this.lBright.AutoSize = true;
            this.lBright.Location = new System.Drawing.Point(201, 172);
            this.lBright.Name = "lBright";
            this.lBright.Size = new System.Drawing.Size(77, 20);
            this.lBright.TabIndex = 10;
            this.lBright.Text = "Brightness";
            // 
            // lbListOfFiles
            // 
            this.lbListOfFiles.FormattingEnabled = true;
            this.lbListOfFiles.HorizontalScrollbar = true;
            this.lbListOfFiles.ItemHeight = 20;
            this.lbListOfFiles.Location = new System.Drawing.Point(12, 12);
            this.lbListOfFiles.Name = "lbListOfFiles";
            this.lbListOfFiles.Size = new System.Drawing.Size(166, 744);
            this.lbListOfFiles.TabIndex = 0;
            this.lbListOfFiles.SelectedIndexChanged += new System.EventHandler(this.lbListOfFiles_SelectedIndexChanged);
            // 
            // lContrast
            // 
            this.lContrast.AutoSize = true;
            this.lContrast.Location = new System.Drawing.Point(201, 267);
            this.lContrast.Name = "lContrast";
            this.lContrast.Size = new System.Drawing.Size(64, 20);
            this.lContrast.TabIndex = 12;
            this.lContrast.Text = "Contrast";
            // 
            // tbContrastValue
            // 
            this.tbContrastValue.Enabled = false;
            this.tbContrastValue.Location = new System.Drawing.Point(201, 304);
            this.tbContrastValue.Maximum = 100;
            this.tbContrastValue.Minimum = -100;
            this.tbContrastValue.Name = "tbContrastValue";
            this.tbContrastValue.Size = new System.Drawing.Size(274, 56);
            this.tbContrastValue.TabIndex = 5;
            this.tbContrastValue.TabStop = false;
            this.tbContrastValue.TickFrequency = 5;
            this.tbContrastValue.Scroll += new System.EventHandler(this.tbContrastValue_Scroll);
            // 
            // lRBG
            // 
            this.lRBG.AutoSize = true;
            this.lRBG.Location = new System.Drawing.Point(201, 363);
            this.lRBG.Name = "lRBG";
            this.lRBG.Size = new System.Drawing.Size(37, 20);
            this.lRBG.TabIndex = 13;
            this.lRBG.Text = "RGB";
            // 
            // bRed
            // 
            this.bRed.Enabled = false;
            this.bRed.Location = new System.Drawing.Point(201, 396);
            this.bRed.Name = "bRed";
            this.bRed.Size = new System.Drawing.Size(84, 29);
            this.bRed.TabIndex = 6;
            this.bRed.Text = "Red";
            this.bRed.UseVisualStyleBackColor = true;
            this.bRed.Click += new System.EventHandler(this.bRed_Click);
            // 
            // bGreen
            // 
            this.bGreen.Enabled = false;
            this.bGreen.Location = new System.Drawing.Point(291, 396);
            this.bGreen.Name = "bGreen";
            this.bGreen.Size = new System.Drawing.Size(84, 29);
            this.bGreen.TabIndex = 7;
            this.bGreen.Text = "Green";
            this.bGreen.UseVisualStyleBackColor = true;
            this.bGreen.Click += new System.EventHandler(this.bGreen_Click);
            // 
            // bBlue
            // 
            this.bBlue.Enabled = false;
            this.bBlue.Location = new System.Drawing.Point(381, 396);
            this.bBlue.Name = "bBlue";
            this.bBlue.Size = new System.Drawing.Size(94, 29);
            this.bBlue.TabIndex = 8;
            this.bBlue.Text = "Blue";
            this.bBlue.UseVisualStyleBackColor = true;
            this.bBlue.Click += new System.EventHandler(this.bBlue_Click);
            // 
            // bZoomIn
            // 
            this.bZoomIn.Enabled = false;
            this.bZoomIn.Location = new System.Drawing.Point(201, 494);
            this.bZoomIn.Name = "bZoomIn";
            this.bZoomIn.Size = new System.Drawing.Size(133, 29);
            this.bZoomIn.TabIndex = 9;
            this.bZoomIn.Text = "Zoom In";
            this.bZoomIn.UseVisualStyleBackColor = true;
            this.bZoomIn.Click += new System.EventHandler(this.bZoomIn_Click);
            // 
            // bZoomOut
            // 
            this.bZoomOut.Enabled = false;
            this.bZoomOut.Location = new System.Drawing.Point(340, 494);
            this.bZoomOut.Name = "bZoomOut";
            this.bZoomOut.Size = new System.Drawing.Size(135, 29);
            this.bZoomOut.TabIndex = 10;
            this.bZoomOut.Text = "Zoom Out";
            this.bZoomOut.UseVisualStyleBackColor = true;
            this.bZoomOut.Click += new System.EventHandler(this.bZoomOut_Click);
            // 
            // lZoom
            // 
            this.lZoom.AutoSize = true;
            this.lZoom.Location = new System.Drawing.Point(201, 453);
            this.lZoom.Name = "lZoom";
            this.lZoom.Size = new System.Drawing.Size(49, 20);
            this.lZoom.TabIndex = 23;
            this.lZoom.Text = "Zoom";
            // 
            // bChooseColor
            // 
            this.bChooseColor.Enabled = false;
            this.bChooseColor.Location = new System.Drawing.Point(201, 595);
            this.bChooseColor.Name = "bChooseColor";
            this.bChooseColor.Size = new System.Drawing.Size(274, 29);
            this.bChooseColor.TabIndex = 11;
            this.bChooseColor.Text = "Choose Color";
            this.bChooseColor.UseVisualStyleBackColor = true;
            this.bChooseColor.Click += new System.EventHandler(this.bChooseColor_Click);
            // 
            // lPen
            // 
            this.lPen.AutoSize = true;
            this.lPen.Location = new System.Drawing.Point(200, 550);
            this.lPen.Name = "lPen";
            this.lPen.Size = new System.Drawing.Size(89, 20);
            this.lPen.TabIndex = 25;
            this.lPen.Text = "Pen Settings";
            // 
            // tbPenSize
            // 
            this.tbPenSize.Enabled = false;
            this.tbPenSize.Location = new System.Drawing.Point(201, 642);
            this.tbPenSize.Maximum = 30;
            this.tbPenSize.Minimum = 1;
            this.tbPenSize.Name = "tbPenSize";
            this.tbPenSize.Size = new System.Drawing.Size(274, 56);
            this.tbPenSize.TabIndex = 12;
            this.tbPenSize.Value = 5;
            // 
            // bSaveFile
            // 
            this.bSaveFile.Enabled = false;
            this.bSaveFile.Location = new System.Drawing.Point(201, 704);
            this.bSaveFile.Name = "bSaveFile";
            this.bSaveFile.Size = new System.Drawing.Size(274, 44);
            this.bSaveFile.TabIndex = 13;
            this.bSaveFile.Text = "Save File";
            this.bSaveFile.UseVisualStyleBackColor = true;
            this.bSaveFile.Click += new System.EventHandler(this.bSaveFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 763);
            this.Controls.Add(this.bSaveFile);
            this.Controls.Add(this.tbPenSize);
            this.Controls.Add(this.lPen);
            this.Controls.Add(this.bChooseColor);
            this.Controls.Add(this.lZoom);
            this.Controls.Add(this.bZoomOut);
            this.Controls.Add(this.bZoomIn);
            this.Controls.Add(this.bBlue);
            this.Controls.Add(this.bGreen);
            this.Controls.Add(this.bRed);
            this.Controls.Add(this.lRBG);
            this.Controls.Add(this.tbContrastValue);
            this.Controls.Add(this.lContrast);
            this.Controls.Add(this.lbListOfFiles);
            this.Controls.Add(this.lBright);
            this.Controls.Add(this.lRotate);
            this.Controls.Add(this.bRotate);
            this.Controls.Add(this.tbRotateValue);
            this.Controls.Add(this.tbBrightnessValue);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.bChooseFile);
            this.Name = "MainForm";
            this.Text = "PictureViewer";
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightnessValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrastValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bChooseFile;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.TrackBar tbBrightnessValue;
        private System.Windows.Forms.TextBox tbRotateValue;
        private System.Windows.Forms.Button bRotate;
        private System.Windows.Forms.Label lRotate;
        private System.Windows.Forms.Label lBright;
        private System.Windows.Forms.ListBox lbListOfFiles;
        private System.Windows.Forms.Label lContrast;
        private System.Windows.Forms.TrackBar tbContrastValue;
        private System.Windows.Forms.Label lRBG;
        private System.Windows.Forms.Button bRed;
        private System.Windows.Forms.Button bGreen;
        private System.Windows.Forms.Button bBlue;
        private System.Windows.Forms.Button bZoomIn;
        private System.Windows.Forms.Button bZoomOut;
        private System.Windows.Forms.Label lZoom;
        private System.Windows.Forms.Button bChooseColor;
        private System.Windows.Forms.Label lPen;
        private System.Windows.Forms.TrackBar tbPenSize;
        private System.Windows.Forms.Button bSaveFile;
    }
}

