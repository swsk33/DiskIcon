
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
			this.start.Location = new System.Drawing.Point(11, 395);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(65, 24);
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
			this.stop.Location = new System.Drawing.Point(82, 395);
			this.stop.Name = "stop";
			this.stop.Size = new System.Drawing.Size(65, 24);
			this.stop.TabIndex = 6;
			this.stop.Text = "确认裁剪";
			this.stop.UseVisualStyleBackColor = false;
			this.stop.Click += new System.EventHandler(this.stop_Click);
			// 
			// ImageEditFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DiskIcon.Resources.cutbg;
			this.ClientSize = new System.Drawing.Size(384, 484);
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
	}
}