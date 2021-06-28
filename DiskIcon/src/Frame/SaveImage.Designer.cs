namespace DiskIcon
{
	partial class SaveImage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveImage));
			this.title = new System.Windows.Forms.Label();
			this.imageFormatLabel = new System.Windows.Forms.Label();
			this.imageFormatValue = new System.Windows.Forms.ComboBox();
			this.customValue = new System.Windows.Forms.TextBox();
			this.ok = new System.Windows.Forms.Button();
			this.containMax = new System.Windows.Forms.RadioButton();
			this.customSize = new System.Windows.Forms.RadioButton();
			this.sizeTipLabel = new System.Windows.Forms.Label();
			this.cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.BackColor = System.Drawing.Color.Transparent;
			this.title.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.title.ForeColor = System.Drawing.Color.Black;
			this.title.Location = new System.Drawing.Point(128, 44);
			this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(98, 21);
			this.title.TabIndex = 1;
			this.title.Text = "保存图片";
			// 
			// imageFormatLabel
			// 
			this.imageFormatLabel.AutoSize = true;
			this.imageFormatLabel.BackColor = System.Drawing.Color.Transparent;
			this.imageFormatLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.imageFormatLabel.ForeColor = System.Drawing.Color.Black;
			this.imageFormatLabel.Location = new System.Drawing.Point(55, 90);
			this.imageFormatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.imageFormatLabel.Name = "imageFormatLabel";
			this.imageFormatLabel.Size = new System.Drawing.Size(104, 16);
			this.imageFormatLabel.TabIndex = 2;
			this.imageFormatLabel.Text = "保存图片格式";
			// 
			// imageFormatValue
			// 
			this.imageFormatValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.imageFormatValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.imageFormatValue.FormattingEnabled = true;
			this.imageFormatValue.ItemHeight = 16;
			this.imageFormatValue.Items.AddRange(new object[] {
            "png",
            "jpg",
            "bmp",
            "tif",
            "gif"});
			this.imageFormatValue.Location = new System.Drawing.Point(174, 87);
			this.imageFormatValue.Name = "imageFormatValue";
			this.imageFormatValue.Size = new System.Drawing.Size(134, 24);
			this.imageFormatValue.TabIndex = 3;
			// 
			// customValue
			// 
			this.customValue.Enabled = false;
			this.customValue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.customValue.Location = new System.Drawing.Point(174, 181);
			this.customValue.Name = "customValue";
			this.customValue.Size = new System.Drawing.Size(134, 23);
			this.customValue.TabIndex = 8;
			// 
			// ok
			// 
			this.ok.BackColor = System.Drawing.Color.Transparent;
			this.ok.Cursor = System.Windows.Forms.Cursors.Default;
			this.ok.FlatAppearance.BorderSize = 0;
			this.ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ok.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ok.ForeColor = System.Drawing.Color.Black;
			this.ok.Location = new System.Drawing.Point(57, 224);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(83, 29);
			this.ok.TabIndex = 6;
			this.ok.Text = "保存";
			this.ok.UseVisualStyleBackColor = false;
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// containMax
			// 
			this.containMax.AutoSize = true;
			this.containMax.BackColor = System.Drawing.Color.Transparent;
			this.containMax.Checked = true;
			this.containMax.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.containMax.Location = new System.Drawing.Point(28, 155);
			this.containMax.Name = "containMax";
			this.containMax.Size = new System.Drawing.Size(151, 18);
			this.containMax.TabIndex = 9;
			this.containMax.TabStop = true;
			this.containMax.Text = "尽可能使用最大尺寸";
			this.containMax.UseVisualStyleBackColor = false;
			this.containMax.CheckedChanged += new System.EventHandler(this.RadioButtonChanged);
			// 
			// customSize
			// 
			this.customSize.AutoSize = true;
			this.customSize.BackColor = System.Drawing.Color.Transparent;
			this.customSize.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.customSize.Location = new System.Drawing.Point(28, 184);
			this.customSize.Name = "customSize";
			this.customSize.Size = new System.Drawing.Size(151, 18);
			this.customSize.TabIndex = 9;
			this.customSize.Text = "自定义尺寸(边长)：";
			this.customSize.UseVisualStyleBackColor = false;
			this.customSize.CheckedChanged += new System.EventHandler(this.RadioButtonChanged);
			// 
			// sizeTipLabel
			// 
			this.sizeTipLabel.AutoSize = true;
			this.sizeTipLabel.BackColor = System.Drawing.Color.Transparent;
			this.sizeTipLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.sizeTipLabel.ForeColor = System.Drawing.Color.Black;
			this.sizeTipLabel.Location = new System.Drawing.Point(25, 126);
			this.sizeTipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.sizeTipLabel.Name = "sizeTipLabel";
			this.sizeTipLabel.Size = new System.Drawing.Size(152, 16);
			this.sizeTipLabel.TabIndex = 2;
			this.sizeTipLabel.Text = "保存图片尺寸选项：";
			// 
			// cancel
			// 
			this.cancel.BackColor = System.Drawing.Color.Transparent;
			this.cancel.Cursor = System.Windows.Forms.Cursors.Default;
			this.cancel.FlatAppearance.BorderSize = 0;
			this.cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cancel.ForeColor = System.Drawing.Color.Black;
			this.cancel.Location = new System.Drawing.Point(204, 224);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(83, 29);
			this.cancel.TabIndex = 6;
			this.cancel.Text = "关闭";
			this.cancel.UseVisualStyleBackColor = false;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// SaveImage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DiskIcon.BackgroundImage.setbg;
			this.ClientSize = new System.Drawing.Size(350, 270);
			this.Controls.Add(this.imageFormatValue);
			this.Controls.Add(this.customValue);
			this.Controls.Add(this.customSize);
			this.Controls.Add(this.containMax);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.sizeTipLabel);
			this.Controls.Add(this.imageFormatLabel);
			this.Controls.Add(this.title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SaveImage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "图标修改工具-设置";
			this.Load += new System.EventHandler(this.SaveImage_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfigFrame_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConfigFrame_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConfigFrame_MouseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label imageFormatLabel;
		public System.Windows.Forms.ComboBox imageFormatValue;
		private System.Windows.Forms.TextBox customValue;
		private System.Windows.Forms.Button ok;
		private System.Windows.Forms.RadioButton containMax;
		private System.Windows.Forms.RadioButton customSize;
		private System.Windows.Forms.Label sizeTipLabel;
		private System.Windows.Forms.Button cancel;
	}
}