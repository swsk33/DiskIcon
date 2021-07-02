
namespace DiskIcon
{
	partial class ImageEditFrame
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageEditFrame));
			this.title = new System.Windows.Forms.Label();
			this.inputImage = new System.Windows.Forms.PictureBox();
			this.start = new System.Windows.Forms.Button();
			this.doNotCropOrDirectSaveImage = new System.Windows.Forms.Button();
			this.applyOrDirectSaveIco = new System.Windows.Forms.Button();
			this.saveIcon = new System.Windows.Forms.Button();
			this.saveImageFile = new System.Windows.Forms.Button();
			this.showInnerCircle = new System.Windows.Forms.CheckBox();
			this.close = new System.Windows.Forms.Button();
			this.cropTip = new System.Windows.Forms.Label();
			this.loading = new System.Windows.Forms.PictureBox();
			this.showReferLine = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.inputImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.BackColor = System.Drawing.Color.Transparent;
			this.title.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.title.ForeColor = System.Drawing.Color.Blue;
			this.title.Location = new System.Drawing.Point(4, 6);
			this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(176, 16);
			this.title.TabIndex = 1;
			this.title.Text = "图标修改工具-图片裁剪";
			// 
			// inputImage
			// 
			this.inputImage.BackColor = System.Drawing.Color.Transparent;
			this.inputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inputImage.Location = new System.Drawing.Point(11, 42);
			this.inputImage.Name = "inputImage";
			this.inputImage.Size = new System.Drawing.Size(361, 343);
			this.inputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.inputImage.TabIndex = 2;
			this.inputImage.TabStop = false;
			// 
			// start
			// 
			this.start.BackColor = System.Drawing.Color.Transparent;
			this.start.Cursor = System.Windows.Forms.Cursors.Default;
			this.start.FlatAppearance.BorderSize = 0;
			this.start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.start.ForeColor = System.Drawing.Color.Blue;
			this.start.Location = new System.Drawing.Point(11, 424);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(111, 54);
			this.start.TabIndex = 6;
			this.start.Text = "开始裁剪";
			this.start.UseVisualStyleBackColor = false;
			this.start.Click += new System.EventHandler(this.start_Click);
			// 
			// doNotCropOrDirectSaveImage
			// 
			this.doNotCropOrDirectSaveImage.BackColor = System.Drawing.Color.Transparent;
			this.doNotCropOrDirectSaveImage.Cursor = System.Windows.Forms.Cursors.Default;
			this.doNotCropOrDirectSaveImage.FlatAppearance.BorderSize = 0;
			this.doNotCropOrDirectSaveImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.doNotCropOrDirectSaveImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.doNotCropOrDirectSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.doNotCropOrDirectSaveImage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.doNotCropOrDirectSaveImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.doNotCropOrDirectSaveImage.Location = new System.Drawing.Point(260, 454);
			this.doNotCropOrDirectSaveImage.Name = "doNotCropOrDirectSaveImage";
			this.doNotCropOrDirectSaveImage.Size = new System.Drawing.Size(113, 24);
			this.doNotCropOrDirectSaveImage.TabIndex = 6;
			this.doNotCropOrDirectSaveImage.Text = "不裁剪直接应用";
			this.doNotCropOrDirectSaveImage.UseVisualStyleBackColor = false;
			this.doNotCropOrDirectSaveImage.Click += new System.EventHandler(this.doNotCropOrDirectSaveImage_Click);
			// 
			// applyOrDirectSaveIco
			// 
			this.applyOrDirectSaveIco.BackColor = System.Drawing.Color.Transparent;
			this.applyOrDirectSaveIco.Cursor = System.Windows.Forms.Cursors.Default;
			this.applyOrDirectSaveIco.Enabled = false;
			this.applyOrDirectSaveIco.FlatAppearance.BorderSize = 0;
			this.applyOrDirectSaveIco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.applyOrDirectSaveIco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.applyOrDirectSaveIco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.applyOrDirectSaveIco.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.applyOrDirectSaveIco.ForeColor = System.Drawing.Color.Fuchsia;
			this.applyOrDirectSaveIco.Location = new System.Drawing.Point(260, 424);
			this.applyOrDirectSaveIco.Name = "applyOrDirectSaveIco";
			this.applyOrDirectSaveIco.Size = new System.Drawing.Size(113, 24);
			this.applyOrDirectSaveIco.TabIndex = 6;
			this.applyOrDirectSaveIco.Text = "裁剪并应用图标";
			this.applyOrDirectSaveIco.UseVisualStyleBackColor = false;
			this.applyOrDirectSaveIco.Click += new System.EventHandler(this.applyOrDirectSaveIco_Click);
			// 
			// saveIcon
			// 
			this.saveIcon.BackColor = System.Drawing.Color.Transparent;
			this.saveIcon.Cursor = System.Windows.Forms.Cursors.Default;
			this.saveIcon.Enabled = false;
			this.saveIcon.FlatAppearance.BorderSize = 0;
			this.saveIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.saveIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.saveIcon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.saveIcon.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.saveIcon.ForeColor = System.Drawing.Color.Blue;
			this.saveIcon.Location = new System.Drawing.Point(131, 424);
			this.saveIcon.Name = "saveIcon";
			this.saveIcon.Size = new System.Drawing.Size(123, 24);
			this.saveIcon.TabIndex = 6;
			this.saveIcon.Text = "裁剪并另存为ico";
			this.saveIcon.UseVisualStyleBackColor = false;
			this.saveIcon.Click += new System.EventHandler(this.saveIcon_Click);
			// 
			// saveImageFile
			// 
			this.saveImageFile.BackColor = System.Drawing.Color.Transparent;
			this.saveImageFile.Cursor = System.Windows.Forms.Cursors.Default;
			this.saveImageFile.Enabled = false;
			this.saveImageFile.FlatAppearance.BorderSize = 0;
			this.saveImageFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.saveImageFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.saveImageFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.saveImageFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.saveImageFile.ForeColor = System.Drawing.Color.Indigo;
			this.saveImageFile.Location = new System.Drawing.Point(131, 454);
			this.saveImageFile.Name = "saveImageFile";
			this.saveImageFile.Size = new System.Drawing.Size(123, 24);
			this.saveImageFile.TabIndex = 6;
			this.saveImageFile.Text = "裁剪并另存为图片";
			this.saveImageFile.UseVisualStyleBackColor = false;
			this.saveImageFile.Click += new System.EventHandler(this.saveImageFile_Click);
			// 
			// showInnerCircle
			// 
			this.showInnerCircle.AutoSize = true;
			this.showInnerCircle.BackColor = System.Drawing.Color.Transparent;
			this.showInnerCircle.Enabled = false;
			this.showInnerCircle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.showInnerCircle.Location = new System.Drawing.Point(11, 396);
			this.showInnerCircle.Name = "showInnerCircle";
			this.showInnerCircle.Size = new System.Drawing.Size(96, 16);
			this.showInnerCircle.TabIndex = 7;
			this.showInnerCircle.Text = "显示圆形参照";
			this.showInnerCircle.UseVisualStyleBackColor = false;
			this.showInnerCircle.CheckedChanged += new System.EventHandler(this.cropFrameReferSign);
			// 
			// close
			// 
			this.close.BackColor = System.Drawing.Color.Transparent;
			this.close.BackgroundImage = global::DiskIcon.IconImage.close;
			this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.close.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.close.FlatAppearance.BorderSize = 0;
			this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close.Location = new System.Drawing.Point(360, 3);
			this.close.Margin = new System.Windows.Forms.Padding(2);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(22, 22);
			this.close.TabIndex = 8;
			this.close.UseVisualStyleBackColor = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// cropTip
			// 
			this.cropTip.AutoSize = true;
			this.cropTip.BackColor = System.Drawing.Color.Transparent;
			this.cropTip.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cropTip.ForeColor = System.Drawing.Color.Red;
			this.cropTip.Location = new System.Drawing.Point(260, 392);
			this.cropTip.Name = "cropTip";
			this.cropTip.Size = new System.Drawing.Size(113, 24);
			this.cropTip.TabIndex = 9;
			this.cropTip.Text = "拖动右下角调整大小\r\n拖动裁剪框调整位置";
			this.cropTip.Visible = false;
			// 
			// loading
			// 
			this.loading.BackColor = System.Drawing.Color.Transparent;
			this.loading.Image = global::DiskIcon.IconImage.loading;
			this.loading.Location = new System.Drawing.Point(221, 391);
			this.loading.Name = "loading";
			this.loading.Size = new System.Drawing.Size(24, 24);
			this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.loading.TabIndex = 10;
			this.loading.TabStop = false;
			this.loading.Visible = false;
			// 
			// showReferLine
			// 
			this.showReferLine.AutoSize = true;
			this.showReferLine.BackColor = System.Drawing.Color.Transparent;
			this.showReferLine.Enabled = false;
			this.showReferLine.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.showReferLine.Location = new System.Drawing.Point(117, 396);
			this.showReferLine.Name = "showReferLine";
			this.showReferLine.Size = new System.Drawing.Size(96, 16);
			this.showReferLine.TabIndex = 7;
			this.showReferLine.Text = "显示格网参照";
			this.showReferLine.UseVisualStyleBackColor = false;
			this.showReferLine.CheckedChanged += new System.EventHandler(this.cropFrameReferSign);
			// 
			// ImageEditFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DiskIcon.BackgroundImage.cutbg;
			this.ClientSize = new System.Drawing.Size(385, 490);
			this.Controls.Add(this.loading);
			this.Controls.Add(this.cropTip);
			this.Controls.Add(this.close);
			this.Controls.Add(this.showReferLine);
			this.Controls.Add(this.showInnerCircle);
			this.Controls.Add(this.applyOrDirectSaveIco);
			this.Controls.Add(this.doNotCropOrDirectSaveImage);
			this.Controls.Add(this.saveImageFile);
			this.Controls.Add(this.saveIcon);
			this.Controls.Add(this.start);
			this.Controls.Add(this.title);
			this.Controls.Add(this.inputImage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ImageEditFrame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "图片裁剪";
			this.Load += new System.EventHandler(this.ImageEditFrame_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfigFrame_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConfigFrame_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConfigFrame_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.inputImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.PictureBox inputImage;
		private System.Windows.Forms.Button start;
		private System.Windows.Forms.Button doNotCropOrDirectSaveImage;
		private System.Windows.Forms.Button applyOrDirectSaveIco;
		private System.Windows.Forms.Button saveIcon;
		private System.Windows.Forms.Button saveImageFile;
		private System.Windows.Forms.CheckBox showInnerCircle;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Label cropTip;
		private System.Windows.Forms.PictureBox loading;
		private System.Windows.Forms.CheckBox showReferLine;
	}
}