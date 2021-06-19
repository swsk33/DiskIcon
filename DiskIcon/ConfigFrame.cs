using Swsk33.ReadAndWriteSharp;
using System;
using System.Windows.Forms;

namespace DiskIcon
{
	public partial class ConfigFrame : Form
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

		public ConfigFrame()
		{
			InitializeComponent();
		}

		private void ConfigFrame_Load(object sender, EventArgs e)
		{
			IconSizeValue.SelectedItem = Convert.ToString(Program.GlobalConfig.IconSize);
			CheckUpdate.Checked = Program.GlobalConfig.CheckUpdate;
		}

		private void ConfigFrame_MouseDown(object sender, MouseEventArgs e)
		{
			Cursor = Cursors.Cross;
			mouseAtX = e.X;
			mouseAtY = e.Y;
			isMouseDown = true;
		}

		private void ConfigFrame_MouseMove(object sender, MouseEventArgs e)
		{
			if (isMouseDown)
			{
				Left = MousePosition.X - mouseAtX;
				Top = MousePosition.Y - mouseAtY;
			}
		}

		private void ConfigFrame_MouseUp(object sender, MouseEventArgs e)
		{
			Cursor = Cursors.Default;
			isMouseDown = false;
		}

		private void save_Click(object sender, EventArgs e)
		{
			Program.GlobalConfig.IconSize = int.Parse(IconSizeValue.SelectedItem.ToString());
			Program.GlobalConfig.CheckUpdate = CheckUpdate.Checked;
			BinaryUtils.WriteObjectToFile(Program.CFG_FILE_PATH, Program.GlobalConfig);
			Close();
		}
	}
}