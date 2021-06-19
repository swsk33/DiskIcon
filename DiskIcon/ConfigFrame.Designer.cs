
namespace DiskIcon
{
	partial class ConfigFrame
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
			this.iconSizeLabel = new System.Windows.Forms.Label();
			this.IconSizeValue = new System.Windows.Forms.ComboBox();
			this.CheckUpdate = new System.Windows.Forms.CheckBox();
			this.addRight = new System.Windows.Forms.Button();
			this.rmRight = new System.Windows.Forms.Button();
			this.save = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.BackColor = System.Drawing.Color.Transparent;
			this.title.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.title.ForeColor = System.Drawing.Color.Black;
			this.title.Location = new System.Drawing.Point(147, 50);
			this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(54, 21);
			this.title.TabIndex = 1;
			this.title.Text = "设置";
			// 
			// iconSizeLabel
			// 
			this.iconSizeLabel.AutoSize = true;
			this.iconSizeLabel.BackColor = System.Drawing.Color.Transparent;
			this.iconSizeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.iconSizeLabel.ForeColor = System.Drawing.Color.Black;
			this.iconSizeLabel.Location = new System.Drawing.Point(20, 100);
			this.iconSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.iconSizeLabel.Name = "iconSizeLabel";
			this.iconSizeLabel.Size = new System.Drawing.Size(168, 16);
			this.iconSizeLabel.TabIndex = 2;
			this.iconSizeLabel.Text = "图标文件大小(边长)：";
			// 
			// IconSizeValue
			// 
			this.IconSizeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.IconSizeValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.IconSizeValue.FormattingEnabled = true;
			this.IconSizeValue.ItemHeight = 16;
			this.IconSizeValue.Items.AddRange(new object[] {
            "16",
            "32",
            "48",
            "64",
            "128",
            "192",
            "255"});
			this.IconSizeValue.Location = new System.Drawing.Point(189, 96);
			this.IconSizeValue.Name = "IconSizeValue";
			this.IconSizeValue.Size = new System.Drawing.Size(134, 24);
			this.IconSizeValue.TabIndex = 3;
			// 
			// CheckUpdate
			// 
			this.CheckUpdate.AutoSize = true;
			this.CheckUpdate.BackColor = System.Drawing.Color.Transparent;
			this.CheckUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.CheckUpdate.Location = new System.Drawing.Point(23, 135);
			this.CheckUpdate.Name = "CheckUpdate";
			this.CheckUpdate.Size = new System.Drawing.Size(123, 20);
			this.CheckUpdate.TabIndex = 4;
			this.CheckUpdate.Text = "启动检查更新";
			this.CheckUpdate.UseVisualStyleBackColor = false;
			// 
			// addRight
			// 
			this.addRight.BackColor = System.Drawing.Color.Transparent;
			this.addRight.Cursor = System.Windows.Forms.Cursors.Default;
			this.addRight.FlatAppearance.BorderSize = 0;
			this.addRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.addRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.addRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.addRight.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.addRight.ForeColor = System.Drawing.Color.Black;
			this.addRight.Location = new System.Drawing.Point(23, 173);
			this.addRight.Name = "addRight";
			this.addRight.Size = new System.Drawing.Size(140, 29);
			this.addRight.TabIndex = 6;
			this.addRight.Text = "添加/修复右键菜单";
			this.addRight.UseVisualStyleBackColor = false;
			// 
			// rmRight
			// 
			this.rmRight.BackColor = System.Drawing.Color.Transparent;
			this.rmRight.Cursor = System.Windows.Forms.Cursors.Default;
			this.rmRight.FlatAppearance.BorderSize = 0;
			this.rmRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.rmRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.rmRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rmRight.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.rmRight.ForeColor = System.Drawing.Color.Black;
			this.rmRight.Location = new System.Drawing.Point(189, 173);
			this.rmRight.Name = "rmRight";
			this.rmRight.Size = new System.Drawing.Size(140, 29);
			this.rmRight.TabIndex = 6;
			this.rmRight.Text = "移除右键菜单";
			this.rmRight.UseVisualStyleBackColor = false;
			// 
			// save
			// 
			this.save.BackColor = System.Drawing.Color.Transparent;
			this.save.BackgroundImage = global::DiskIcon.Resources.save;
			this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.save.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.save.FlatAppearance.BorderSize = 0;
			this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.save.Location = new System.Drawing.Point(154, 219);
			this.save.Margin = new System.Windows.Forms.Padding(2);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(36, 36);
			this.save.TabIndex = 7;
			this.save.UseVisualStyleBackColor = false;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// ConfigFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DiskIcon.Resources.setbg;
			this.ClientSize = new System.Drawing.Size(350, 270);
			this.Controls.Add(this.save);
			this.Controls.Add(this.rmRight);
			this.Controls.Add(this.addRight);
			this.Controls.Add(this.CheckUpdate);
			this.Controls.Add(this.IconSizeValue);
			this.Controls.Add(this.iconSizeLabel);
			this.Controls.Add(this.title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConfigFrame";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "图标修改工具-设置";
			this.Load += new System.EventHandler(this.ConfigFrame_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfigFrame_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConfigFrame_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConfigFrame_MouseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label iconSizeLabel;
		private System.Windows.Forms.Button addRight;
		private System.Windows.Forms.Button rmRight;
		private System.Windows.Forms.Button save;
		public System.Windows.Forms.ComboBox IconSizeValue;
		public System.Windows.Forms.CheckBox CheckUpdate;
	}
}