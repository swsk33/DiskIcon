using System;
using System.Windows.Forms;

namespace DiskIcon
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
			InitializeComponent();
		}

		private void close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mouseDownEvent(object sender, MouseEventArgs e)
		{
			Cursor = Cursors.Cross;
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
	}
}