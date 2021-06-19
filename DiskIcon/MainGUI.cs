using System;
using System.Windows.Forms;

namespace DiskIcon
{
	public partial class MainGUI : Form
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

		public MainGUI()
		{
			InitializeComponent();
		}

		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MainGUI_MouseDown(object sender, MouseEventArgs e)
		{
			Cursor = Cursors.Cross;
			mouseAtX = e.X;
			mouseAtY = e.Y;
			isMouseDown = true;
		}

		private void MainGUI_MouseMove(object sender, MouseEventArgs e)
		{
			if (isMouseDown)
			{
				Left = MousePosition.X - mouseAtX;
				Top = MousePosition.Y - mouseAtY;
			}
		}

		private void MainGUI_MouseUp(object sender, MouseEventArgs e)
		{
			Cursor = Cursors.Default;
			isMouseDown = false;
		}

		private void setup_Click(object sender, EventArgs e)
		{
			new ConfigFrame().Show();
		}

		private void selectPic_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Multiselect = false;
			dialog.Title = "请选择图片文件";
			dialog.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				picPathValue.Text = dialog.FileName;
			}
		}

		private void selectDrive_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.Description = "请选择磁盘（如果选择到磁盘中的文件夹只会选定其所在磁盘）";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				string selectPath = dialog.SelectedPath;
				diskPathValue.Text = selectPath.Substring(0, selectPath.IndexOf("\\") + 1);
			}
		}
	}
}
