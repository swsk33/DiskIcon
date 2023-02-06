
namespace Swsk33.DiskIcon
{
	partial class MainGUI
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
			this.title = new System.Windows.Forms.Label();
			this.close = new System.Windows.Forms.Button();
			this.mainTitle = new System.Windows.Forms.Label();
			this.tip1 = new System.Windows.Forms.Label();
			this.tip2 = new System.Windows.Forms.Label();
			this.picLabel = new System.Windows.Forms.PictureBox();
			this.diskLabel = new System.Windows.Forms.PictureBox();
			this.imagePathValue = new System.Windows.Forms.TextBox();
			this.diskPathValue = new System.Windows.Forms.TextBox();
			this.selectPic = new System.Windows.Forms.Button();
			this.selectDrive = new System.Windows.Forms.Button();
			this.ok = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.about = new System.Windows.Forms.Button();
			this.setup = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picLabel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.diskLabel)).BeginInit();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.BackColor = System.Drawing.Color.Transparent;
			this.title.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.title.ForeColor = System.Drawing.Color.Chartreuse;
			this.title.Location = new System.Drawing.Point(5, 8);
			this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(103, 16);
			this.title.TabIndex = 0;
			this.title.Text = "图标修改工具";
			// 
			// close
			// 
			this.close.BackColor = System.Drawing.Color.Transparent;
			this.close.BackgroundImage = global::Swsk33.DiskIcon.IconImage.close;
			this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.close.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.close.FlatAppearance.BorderSize = 0;
			this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close.Location = new System.Drawing.Point(423, 5);
			this.close.Margin = new System.Windows.Forms.Padding(2);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(22, 22);
			this.close.TabIndex = 1;
			this.close.UseVisualStyleBackColor = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// mainTitle
			// 
			this.mainTitle.AutoSize = true;
			this.mainTitle.BackColor = System.Drawing.Color.Transparent;
			this.mainTitle.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.mainTitle.ForeColor = System.Drawing.Color.Black;
			this.mainTitle.Location = new System.Drawing.Point(116, 48);
			this.mainTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mainTitle.Name = "mainTitle";
			this.mainTitle.Size = new System.Drawing.Size(208, 21);
			this.mainTitle.TabIndex = 0;
			this.mainTitle.Text = "储存器图标修改工具";
			// 
			// tip1
			// 
			this.tip1.AutoSize = true;
			this.tip1.BackColor = System.Drawing.Color.Transparent;
			this.tip1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tip1.ForeColor = System.Drawing.Color.Purple;
			this.tip1.Location = new System.Drawing.Point(158, 81);
			this.tip1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.tip1.Name = "tip1";
			this.tip1.Size = new System.Drawing.Size(125, 12);
			this.tip1.TabIndex = 2;
			this.tip1.Text = "杀毒软件报毒请允许！";
			// 
			// tip2
			// 
			this.tip2.AutoSize = true;
			this.tip2.BackColor = System.Drawing.Color.Transparent;
			this.tip2.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tip2.ForeColor = System.Drawing.Color.Green;
			this.tip2.Location = new System.Drawing.Point(52, 97);
			this.tip2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.tip2.Name = "tip2";
			this.tip2.Size = new System.Drawing.Size(341, 12);
			this.tip2.TabIndex = 2;
			this.tip2.Text = "使用过程中出现任何异常，请退出后再右键以管理员身份运行！";
			// 
			// picLabel
			// 
			this.picLabel.BackColor = System.Drawing.Color.Transparent;
			this.picLabel.BackgroundImage = global::Swsk33.DiskIcon.IconImage.pic;
			this.picLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picLabel.Location = new System.Drawing.Point(38, 128);
			this.picLabel.Name = "picLabel";
			this.picLabel.Size = new System.Drawing.Size(38, 38);
			this.picLabel.TabIndex = 3;
			this.picLabel.TabStop = false;
			// 
			// diskLabel
			// 
			this.diskLabel.BackColor = System.Drawing.Color.Transparent;
			this.diskLabel.BackgroundImage = global::Swsk33.DiskIcon.IconImage.disk;
			this.diskLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.diskLabel.Location = new System.Drawing.Point(38, 185);
			this.diskLabel.Name = "diskLabel";
			this.diskLabel.Size = new System.Drawing.Size(38, 38);
			this.diskLabel.TabIndex = 3;
			this.diskLabel.TabStop = false;
			// 
			// imagePathValue
			// 
			this.imagePathValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.imagePathValue.Location = new System.Drawing.Point(102, 134);
			this.imagePathValue.Multiline = true;
			this.imagePathValue.Name = "imagePathValue";
			this.imagePathValue.ReadOnly = true;
			this.imagePathValue.Size = new System.Drawing.Size(207, 29);
			this.imagePathValue.TabIndex = 4;
			this.imagePathValue.WordWrap = false;
			// 
			// diskPathValue
			// 
			this.diskPathValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.diskPathValue.Location = new System.Drawing.Point(102, 191);
			this.diskPathValue.Multiline = true;
			this.diskPathValue.Name = "diskPathValue";
			this.diskPathValue.ReadOnly = true;
			this.diskPathValue.Size = new System.Drawing.Size(207, 29);
			this.diskPathValue.TabIndex = 4;
			this.diskPathValue.WordWrap = false;
			// 
			// selectPic
			// 
			this.selectPic.BackColor = System.Drawing.Color.Transparent;
			this.selectPic.Cursor = System.Windows.Forms.Cursors.Default;
			this.selectPic.FlatAppearance.BorderSize = 0;
			this.selectPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.selectPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.selectPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.selectPic.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.selectPic.ForeColor = System.Drawing.Color.Blue;
			this.selectPic.Location = new System.Drawing.Point(329, 134);
			this.selectPic.Name = "selectPic";
			this.selectPic.Size = new System.Drawing.Size(100, 29);
			this.selectPic.TabIndex = 5;
			this.selectPic.Text = "选择图片";
			this.selectPic.UseVisualStyleBackColor = false;
			this.selectPic.Click += new System.EventHandler(this.selectPic_Click);
			// 
			// selectDrive
			// 
			this.selectDrive.BackColor = System.Drawing.Color.Transparent;
			this.selectDrive.Cursor = System.Windows.Forms.Cursors.Default;
			this.selectDrive.FlatAppearance.BorderSize = 0;
			this.selectDrive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.selectDrive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.selectDrive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.selectDrive.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.selectDrive.ForeColor = System.Drawing.Color.OrangeRed;
			this.selectDrive.Location = new System.Drawing.Point(329, 191);
			this.selectDrive.Name = "selectDrive";
			this.selectDrive.Size = new System.Drawing.Size(100, 29);
			this.selectDrive.TabIndex = 5;
			this.selectDrive.Text = "选择储存器";
			this.selectDrive.UseVisualStyleBackColor = false;
			this.selectDrive.Click += new System.EventHandler(this.selectDrive_Click);
			// 
			// ok
			// 
			this.ok.BackColor = System.Drawing.Color.Transparent;
			this.ok.Cursor = System.Windows.Forms.Cursors.Default;
			this.ok.FlatAppearance.BorderSize = 0;
			this.ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ok.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ok.Location = new System.Drawing.Point(72, 253);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(117, 29);
			this.ok.TabIndex = 5;
			this.ok.Text = "一键修改图标";
			this.ok.UseVisualStyleBackColor = false;
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// clear
			// 
			this.clear.BackColor = System.Drawing.Color.Transparent;
			this.clear.Cursor = System.Windows.Forms.Cursors.Default;
			this.clear.FlatAppearance.BorderSize = 0;
			this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.clear.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.clear.ForeColor = System.Drawing.Color.Purple;
			this.clear.Location = new System.Drawing.Point(240, 253);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(105, 29);
			this.clear.TabIndex = 5;
			this.clear.Text = "清除图标";
			this.clear.UseVisualStyleBackColor = false;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// about
			// 
			this.about.BackColor = System.Drawing.Color.Transparent;
			this.about.BackgroundImage = global::Swsk33.DiskIcon.IconImage.about;
			this.about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.about.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.about.FlatAppearance.BorderSize = 0;
			this.about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.about.Location = new System.Drawing.Point(370, 235);
			this.about.Margin = new System.Windows.Forms.Padding(2);
			this.about.Name = "about";
			this.about.Size = new System.Drawing.Size(78, 78);
			this.about.TabIndex = 6;
			this.about.UseVisualStyleBackColor = false;
			this.about.Click += new System.EventHandler(this.about_Click);
			// 
			// setup
			// 
			this.setup.BackColor = System.Drawing.Color.Transparent;
			this.setup.BackgroundImage = global::Swsk33.DiskIcon.IconImage.setup;
			this.setup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.setup.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.setup.FlatAppearance.BorderSize = 0;
			this.setup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.setup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.setup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.setup.Location = new System.Drawing.Point(405, 41);
			this.setup.Margin = new System.Windows.Forms.Padding(2);
			this.setup.Name = "setup";
			this.setup.Size = new System.Drawing.Size(32, 32);
			this.setup.TabIndex = 7;
			this.setup.UseVisualStyleBackColor = false;
			this.setup.Click += new System.EventHandler(this.setup_Click);
			// 
			// MainGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Swsk33.DiskIcon.BackgroundImage.mainbg;
			this.ClientSize = new System.Drawing.Size(450, 315);
			this.Controls.Add(this.setup);
			this.Controls.Add(this.about);
			this.Controls.Add(this.selectDrive);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.selectPic);
			this.Controls.Add(this.diskPathValue);
			this.Controls.Add(this.imagePathValue);
			this.Controls.Add(this.diskLabel);
			this.Controls.Add(this.picLabel);
			this.Controls.Add(this.tip2);
			this.Controls.Add(this.tip1);
			this.Controls.Add(this.close);
			this.Controls.Add(this.mainTitle);
			this.Controls.Add(this.title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainGUI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "储存器图标修改工具";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainGUI_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainGUI_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainGUI_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.picLabel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.diskLabel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Label mainTitle;
		private System.Windows.Forms.Label tip1;
		private System.Windows.Forms.Label tip2;
		private System.Windows.Forms.PictureBox picLabel;
		private System.Windows.Forms.PictureBox diskLabel;
		private System.Windows.Forms.TextBox imagePathValue;
		private System.Windows.Forms.TextBox diskPathValue;
		private System.Windows.Forms.Button selectPic;
		private System.Windows.Forms.Button selectDrive;
		private System.Windows.Forms.Button ok;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button about;
		private System.Windows.Forms.Button setup;
	}
}

