
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
			this.title = new System.Windows.Forms.Label();
			this.inputImage = new System.Windows.Forms.PictureBox();
			this.start = new System.Windows.Forms.Button();
			this.doNotCrop = new System.Windows.Forms.Button();
			this.apply = new System.Windows.Forms.Button();
			this.saveIcon = new System.Windows.Forms.Button();
			this.savePng = new System.Windows.Forms.Button();
			this.circleMode = new System.Windows.Forms.CheckBox();
			this.close = new System.Windows.Forms.Button();
			this.cropTip = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.inputImage)).BeginInit();
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
			// doNotCrop
			// 
			this.doNotCrop.BackColor = System.Drawing.Color.Transparent;
			this.doNotCrop.Cursor = System.Windows.Forms.Cursors.Default;
			this.doNotCrop.Enabled = false;
			this.doNotCrop.FlatAppearance.BorderSize = 0;
			this.doNotCrop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.doNotCrop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.doNotCrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.doNotCrop.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.doNotCrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.doNotCrop.Location = new System.Drawing.Point(260, 454);
			this.doNotCrop.Name = "doNotCrop";
			this.doNotCrop.Size = new System.Drawing.Size(112, 24);
			this.doNotCrop.TabIndex = 6;
			this.doNotCrop.Text = "不裁剪直接应用";
			this.doNotCrop.UseVisualStyleBackColor = false;
			// 
			// apply
			// 
			this.apply.BackColor = System.Drawing.Color.Transparent;
			this.apply.Cursor = System.Windows.Forms.Cursors.Default;
			this.apply.Enabled = false;
			this.apply.FlatAppearance.BorderSize = 0;
			this.apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.apply.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.apply.ForeColor = System.Drawing.Color.Fuchsia;
			this.apply.Location = new System.Drawing.Point(260, 424);
			this.apply.Name = "apply";
			this.apply.Size = new System.Drawing.Size(112, 24);
			this.apply.TabIndex = 6;
			this.apply.Text = "裁剪并应用图标";
			this.apply.UseVisualStyleBackColor = false;
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
			// savePng
			// 
			this.savePng.BackColor = System.Drawing.Color.Transparent;
			this.savePng.Cursor = System.Windows.Forms.Cursors.Default;
			this.savePng.Enabled = false;
			this.savePng.FlatAppearance.BorderSize = 0;
			this.savePng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.savePng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.savePng.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.savePng.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.savePng.ForeColor = System.Drawing.Color.Indigo;
			this.savePng.Location = new System.Drawing.Point(131, 454);
			this.savePng.Name = "savePng";
			this.savePng.Size = new System.Drawing.Size(123, 24);
			this.savePng.TabIndex = 6;
			this.savePng.Text = "裁剪并另存为png";
			this.savePng.UseVisualStyleBackColor = false;
			this.savePng.Click += new System.EventHandler(this.savePng_Click);
			// 
			// circleMode
			// 
			this.circleMode.AutoSize = true;
			this.circleMode.BackColor = System.Drawing.Color.Transparent;
			this.circleMode.Enabled = false;
			this.circleMode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.circleMode.Location = new System.Drawing.Point(12, 396);
			this.circleMode.Name = "circleMode";
			this.circleMode.Size = new System.Drawing.Size(110, 18);
			this.circleMode.TabIndex = 7;
			this.circleMode.Text = "显示圆形参照";
			this.circleMode.UseVisualStyleBackColor = false;
			this.circleMode.CheckedChanged += new System.EventHandler(this.circleMode_CheckedChanged);
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
			this.cropTip.Location = new System.Drawing.Point(258, 392);
			this.cropTip.Name = "cropTip";
			this.cropTip.Size = new System.Drawing.Size(113, 24);
			this.cropTip.TabIndex = 9;
			this.cropTip.Text = "拖动右下角调整大小\r\n拖动裁剪框调整位置";
			this.cropTip.Visible = false;
			// 
			// ImageEditFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DiskIcon.BackgroundImage.cutbg;
			this.ClientSize = new System.Drawing.Size(385, 490);
			this.Controls.Add(this.cropTip);
			this.Controls.Add(this.close);
			this.Controls.Add(this.circleMode);
			this.Controls.Add(this.apply);
			this.Controls.Add(this.doNotCrop);
			this.Controls.Add(this.savePng);
			this.Controls.Add(this.saveIcon);
			this.Controls.Add(this.start);
			this.Controls.Add(this.title);
			this.Controls.Add(this.inputImage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ImageEditFrame";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ImageEditFrame";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfigFrame_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConfigFrame_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConfigFrame_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.inputImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.PictureBox inputImage;
		private System.Windows.Forms.Button start;
		private System.Windows.Forms.Button doNotCrop;
		private System.Windows.Forms.Button apply;
		private System.Windows.Forms.Button saveIcon;
		private System.Windows.Forms.Button savePng;
		private System.Windows.Forms.CheckBox circleMode;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Label cropTip;
	}
}