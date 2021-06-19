
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
			this.inputImg = new System.Windows.Forms.PictureBox();
			this.start = new System.Windows.Forms.Button();
			this.stop = new System.Windows.Forms.Button();
			this.doNotCrop = new System.Windows.Forms.Button();
			this.apply = new System.Windows.Forms.Button();
			this.saveIcon = new System.Windows.Forms.Button();
			this.savePng = new System.Windows.Forms.Button();
			this.circleMode = new System.Windows.Forms.CheckBox();
			this.reset = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.inputImg)).BeginInit();
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
			// inputImg
			// 
			this.inputImg.BackColor = System.Drawing.Color.Transparent;
			this.inputImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inputImg.Location = new System.Drawing.Point(11, 42);
			this.inputImg.Name = "inputImg";
			this.inputImg.Size = new System.Drawing.Size(361, 343);
			this.inputImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.inputImg.TabIndex = 2;
			this.inputImg.TabStop = false;
			// 
			// start
			// 
			this.start.BackColor = System.Drawing.Color.Transparent;
			this.start.Cursor = System.Windows.Forms.Cursors.Default;
			this.start.FlatAppearance.BorderSize = 0;
			this.start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.start.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.start.ForeColor = System.Drawing.Color.Blue;
			this.start.Location = new System.Drawing.Point(11, 424);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(100, 24);
			this.start.TabIndex = 6;
			this.start.Text = "开始裁剪";
			this.start.UseVisualStyleBackColor = false;
			this.start.Click += new System.EventHandler(this.start_Click);
			// 
			// stop
			// 
			this.stop.BackColor = System.Drawing.Color.Transparent;
			this.stop.Cursor = System.Windows.Forms.Cursors.Default;
			this.stop.Enabled = false;
			this.stop.FlatAppearance.BorderSize = 0;
			this.stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.stop.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.stop.ForeColor = System.Drawing.Color.Indigo;
			this.stop.Location = new System.Drawing.Point(11, 454);
			this.stop.Name = "stop";
			this.stop.Size = new System.Drawing.Size(100, 24);
			this.stop.TabIndex = 6;
			this.stop.Text = "确认裁剪";
			this.stop.UseVisualStyleBackColor = false;
			this.stop.Click += new System.EventHandler(this.stop_Click);
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
			this.doNotCrop.Location = new System.Drawing.Point(272, 454);
			this.doNotCrop.Name = "doNotCrop";
			this.doNotCrop.Size = new System.Drawing.Size(100, 24);
			this.doNotCrop.TabIndex = 6;
			this.doNotCrop.Text = "不裁剪直接应用";
			this.doNotCrop.UseVisualStyleBackColor = false;
			this.doNotCrop.Click += new System.EventHandler(this.stop_Click);
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
			this.apply.Location = new System.Drawing.Point(272, 424);
			this.apply.Name = "apply";
			this.apply.Size = new System.Drawing.Size(100, 24);
			this.apply.TabIndex = 6;
			this.apply.Text = "应用图标";
			this.apply.UseVisualStyleBackColor = false;
			this.apply.Click += new System.EventHandler(this.stop_Click);
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
			this.saveIcon.Location = new System.Drawing.Point(143, 424);
			this.saveIcon.Name = "saveIcon";
			this.saveIcon.Size = new System.Drawing.Size(100, 24);
			this.saveIcon.TabIndex = 6;
			this.saveIcon.Text = "另存为ico";
			this.saveIcon.UseVisualStyleBackColor = false;
			this.saveIcon.Click += new System.EventHandler(this.start_Click);
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
			this.savePng.Location = new System.Drawing.Point(143, 454);
			this.savePng.Name = "savePng";
			this.savePng.Size = new System.Drawing.Size(100, 24);
			this.savePng.TabIndex = 6;
			this.savePng.Text = "另存为png";
			this.savePng.UseVisualStyleBackColor = false;
			this.savePng.Click += new System.EventHandler(this.stop_Click);
			// 
			// circleMode
			// 
			this.circleMode.AutoSize = true;
			this.circleMode.BackColor = System.Drawing.Color.Transparent;
			this.circleMode.Enabled = false;
			this.circleMode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.circleMode.Location = new System.Drawing.Point(12, 396);
			this.circleMode.Name = "circleMode";
			this.circleMode.Size = new System.Drawing.Size(82, 18);
			this.circleMode.TabIndex = 7;
			this.circleMode.Text = "圆形模式";
			this.circleMode.UseVisualStyleBackColor = false;
			// 
			// reset
			// 
			this.reset.BackColor = System.Drawing.Color.Transparent;
			this.reset.Cursor = System.Windows.Forms.Cursors.Default;
			this.reset.Enabled = false;
			this.reset.FlatAppearance.BorderSize = 0;
			this.reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.reset.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.reset.ForeColor = System.Drawing.Color.Red;
			this.reset.Location = new System.Drawing.Point(272, 393);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(100, 24);
			this.reset.TabIndex = 8;
			this.reset.Text = "还原";
			this.reset.UseVisualStyleBackColor = false;
			// 
			// ImageEditFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DiskIcon.BackgroundImage.cutbg;
			this.ClientSize = new System.Drawing.Size(385, 490);
			this.Controls.Add(this.reset);
			this.Controls.Add(this.circleMode);
			this.Controls.Add(this.apply);
			this.Controls.Add(this.doNotCrop);
			this.Controls.Add(this.savePng);
			this.Controls.Add(this.saveIcon);
			this.Controls.Add(this.stop);
			this.Controls.Add(this.start);
			this.Controls.Add(this.title);
			this.Controls.Add(this.inputImg);
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
			((System.ComponentModel.ISupportInitialize)(this.inputImg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.PictureBox inputImg;
		private System.Windows.Forms.Button start;
		private System.Windows.Forms.Button stop;
		private System.Windows.Forms.Button doNotCrop;
		private System.Windows.Forms.Button apply;
		private System.Windows.Forms.Button saveIcon;
		private System.Windows.Forms.Button savePng;
		private System.Windows.Forms.CheckBox circleMode;
		private System.Windows.Forms.Button reset;
	}
}