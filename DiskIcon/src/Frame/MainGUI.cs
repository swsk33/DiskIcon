using System;
using System.Diagnostics;
using System.Drawing;
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
			CheckForIllegalCrossThreadCalls = false;
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
			new ConfigFrame().ShowDialog();
		}

		private void selectPic_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Multiselect = false;
			dialog.Title = "请选择图片文件";
			dialog.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp;*.tif;*.tiff";
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

		private void ok_Click(object sender, EventArgs e)
		{
			if (picPathValue.Text.Equals(""))
			{
				MessageBox.Show("请指定图片！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (diskPathValue.Text.Equals(""))
			{
				MessageBox.Show("请指定驱动器！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Image inputImage = Image.FromFile(picPathValue.Text);
			new ImageEditFrame().initEditFrame(inputImage, diskPathValue.Text);
			inputImage.Dispose();
		}

		private void clear_Click(object sender, EventArgs e)
		{
			new ClearIcon().ShowDialog();
		}

		private void about_Click(object sender, EventArgs e)
		{
			Process.Start("https://gitee.com/swsk33/DiskIcon");
		}
	}
}
