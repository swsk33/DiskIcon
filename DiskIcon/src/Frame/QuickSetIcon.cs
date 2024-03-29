﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Swsk33.DiskIcon
{
	public partial class QuickSetIcon : Form
	{
		/// <summary>
		/// 鼠标按下时在窗口中的x坐标
		/// </summary>
		private int mouseAtX;

		/// <summary>
		/// 鼠标按下时在窗口中的y坐标
		/// </summary>
		private int mouseAtY;

		/// <summary>
		/// 鼠标是否在窗口上是按下状态
		/// </summary>
		private bool isMouseDown = false;

		/// <summary>
		/// 传入的原图
		/// </summary>
		private Image inputImage;

		/// <summary>
		/// 构造函数，需传入已读取的原图对象
		/// </summary>
		/// <param name="inputImage"></param>
		public QuickSetIcon(Image inputImage)
		{
			CheckForIllegalCrossThreadCalls = false;
			InitializeComponent();
			this.inputImage = inputImage;
		}

		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void mouseDownEvent(object sender, MouseEventArgs e)
		{
			Cursor = Cursors.SizeAll;
			mouseAtX = e.X;
			mouseAtY = e.Y;
			isMouseDown = true;
		}

		private void mouseMoveEvent(object sender, MouseEventArgs e)
		{
			if (isMouseDown)
			{
				Left = MousePosition.X - mouseAtX;
				Top = MousePosition.Y - mouseAtY;
			}
		}

		private void mouseUpEvent(object sender, MouseEventArgs e)
		{
			Cursor = Cursors.Default;
			isMouseDown = false;
		}

		private void select_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.Description = "请选择磁盘（如果选择到磁盘中的文件夹只会选定其所在磁盘）";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				string selectPath = dialog.SelectedPath;
				DiskValue.Text = selectPath.Substring(0, selectPath.IndexOf("\\") + 1);
			}
		}

		private void ok_Click(object sender, EventArgs e)
		{
			if (DiskValue.Text.Equals(""))
			{
				MessageBox.Show("请指定要修改图标的磁盘！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string diskPath = DiskValue.Text;
			new ImageEditFrame().initEditFrame(inputImage, diskPath);
		}
	}
}