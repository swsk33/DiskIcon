
namespace DiskIcon
{
	partial class QuickSetIcon
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
			this.close = new System.Windows.Forms.Button();
			this.title = new System.Windows.Forms.Label();
			this.mainTitle = new System.Windows.Forms.Label();
			this.DiskValue = new System.Windows.Forms.TextBox();
			this.select = new System.Windows.Forms.Button();
			this.ok = new System.Windows.Forms.Button();
			this.SuspendLayout();
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
			this.close.Location = new System.Drawing.Point(324, 4);
			this.close.Margin = new System.Windows.Forms.Padding(2);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(22, 22);
			this.close.TabIndex = 2;
			this.close.UseVisualStyleBackColor = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.BackColor = System.Drawing.Color.Transparent;
			this.title.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.title.ForeColor = System.Drawing.Color.Blue;
			this.title.Location = new System.Drawing.Point(6, 8);
			this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(154, 14);
			this.title.TabIndex = 3;
			this.title.Text = "图标修改工具-快捷操作";
			// 
			// mainTitle
			// 
			this.mainTitle.AutoSize = true;
			this.mainTitle.BackColor = System.Drawing.Color.Transparent;
			this.mainTitle.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.mainTitle.ForeColor = System.Drawing.Color.Black;
			this.mainTitle.Location = new System.Drawing.Point(65, 44);
			this.mainTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mainTitle.Name = "mainTitle";
			this.mainTitle.Size = new System.Drawing.Size(209, 19);
			this.mainTitle.TabIndex = 4;
			this.mainTitle.Text = "请选择要修改的储存器";
			// 
			// DiskValue
			// 
			this.DiskValue.Location = new System.Drawing.Point(27, 78);
			this.DiskValue.Name = "DiskValue";
			this.DiskValue.Size = new System.Drawing.Size(144, 21);
			this.DiskValue.TabIndex = 5;
			// 
			// select
			// 
			this.select.BackColor = System.Drawing.Color.Transparent;
			this.select.Cursor = System.Windows.Forms.Cursors.Default;
			this.select.FlatAppearance.BorderSize = 0;
			this.select.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.select.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.select.ForeColor = System.Drawing.Color.Blue;
			this.select.Location = new System.Drawing.Point(188, 76);
			this.select.Name = "select";
			this.select.Size = new System.Drawing.Size(66, 24);
			this.select.TabIndex = 6;
			this.select.Text = "选择";
			this.select.UseVisualStyleBackColor = false;
			this.select.Click += new System.EventHandler(this.select_Click);
			// 
			// ok
			// 
			this.ok.BackColor = System.Drawing.Color.Transparent;
			this.ok.Cursor = System.Windows.Forms.Cursors.Default;
			this.ok.FlatAppearance.BorderSize = 0;
			this.ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ok.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ok.ForeColor = System.Drawing.Color.DarkMagenta;
			this.ok.Location = new System.Drawing.Point(260, 76);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(66, 24);
			this.ok.TabIndex = 6;
			this.ok.Text = "确认";
			this.ok.UseVisualStyleBackColor = false;
			// 
			// QuickSetIcon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DiskIcon.BackgroundImage.minibg;
			this.ClientSize = new System.Drawing.Size(350, 120);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.select);
			this.Controls.Add(this.DiskValue);
			this.Controls.Add(this.mainTitle);
			this.Controls.Add(this.title);
			this.Controls.Add(this.close);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "QuickSetIcon";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuickSetIcon";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMoveEvent);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label mainTitle;
		public System.Windows.Forms.TextBox DiskValue;
		private System.Windows.Forms.Button select;
		private System.Windows.Forms.Button ok;
	}
}