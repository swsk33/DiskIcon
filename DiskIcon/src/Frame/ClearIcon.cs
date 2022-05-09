using Swsk33.DiskIcon.Util;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Swsk33.DiskIcon
{
	public partial class ClearIcon : Form
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

		public ClearIcon()
		{
			CheckForIllegalCrossThreadCalls = false;
			InitializeComponent();
		}

		private void close_Click(object sender, EventArgs e)
		{
			Dispose();
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
				MessageBox.Show("请选择磁盘！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			loading.Visible = true;
			Application.DoEvents();
			new Thread(() =>
			{
				FileUtils.RemoveDiskIcon(DiskValue.Text);
				MessageBox.Show("清除图标完成！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
				loading.Visible = false;
			}).Start();
		}
	}
}