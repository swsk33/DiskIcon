using DiskIcon.Util;
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

		/// <summary>
		/// 右键菜单-设置图标的显示名
		/// </summary>
		private static readonly string SET_ICON_MENU_NAME = "将该图片设为储存器图标";

		/// <summary>
		/// 右键菜单-裁剪图片的显示名
		/// </summary>
		private static readonly string CROP_IMAGE_MENU_NAME = "将该图片转为ico/裁剪图标/制作头像";

		public ConfigFrame()
		{
			CheckForIllegalCrossThreadCalls = false;
			InitializeComponent();
		}

		private void ConfigFrame_Load(object sender, EventArgs e)
		{
			bool custom = true;
			foreach (string size in IconSizeValue.Items)
			{
				if (Convert.ToString(Program.GlobalConfig.IconSize).Equals(size))
				{
					custom = false;
					IconSizeValue.SelectedItem = size;
					break;
				}
			}
			if (custom)
			{
				isCustom.Checked = true;
				customValue.Enabled = true;
				IconSizeValue.Enabled = false;
				customValue.Text = Convert.ToString(Program.GlobalConfig.IconSize);
				IconSizeValue.SelectedIndex = 4;
			}
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
			if (isCustom.Checked)
			{
				if (customValue.Text.Equals(""))
				{
					MessageBox.Show("请填写自定义边长！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				int size;
				try
				{
					size = int.Parse(customValue.Text);
				}
				catch
				{
					MessageBox.Show("自定义边长值只能包含数字且必须在1-255之间！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (size < 1 || size > 255)
				{
					MessageBox.Show("自定义边长必须在1-255之间！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				Program.GlobalConfig.IconSize = size;
			}
			else
			{
				Program.GlobalConfig.IconSize = int.Parse(IconSizeValue.SelectedItem.ToString());
			}
			BinaryUtils.WriteObjectToFile(Program.CFG_FILE_PATH, Program.GlobalConfig);
			Dispose();
		}

		private void isCustom_CheckedChanged(object sender, EventArgs e)
		{
			if (isCustom.Checked)
			{
				customValue.Enabled = true;
				IconSizeValue.Enabled = false;
			}
			else
			{
				customValue.Enabled = false;
				IconSizeValue.Enabled = true;
			}
		}

		private void addRight_Click(object sender, EventArgs e)
		{
			bool addIconOption = RegUtils.OperateFileOrDirRightMenu(SET_ICON_MENU_NAME, Program.SELF_PATH, ProgramUtils.SurroundByQuote(Program.SELF_PATH) + " i " + ProgramUtils.SurroundByQuote("%l"), true);
			bool addCropOption = RegUtils.OperateFileOrDirRightMenu(CROP_IMAGE_MENU_NAME, Program.SELF_PATH, ProgramUtils.SurroundByQuote(Program.SELF_PATH) + " c " + ProgramUtils.SurroundByQuote("%l"), true);
			if (addIconOption && addCropOption)
			{
				MessageBox.Show("已成功添加右键快捷操作菜单！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("添加失败！请检查是否有管理员权限！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void rmRight_Click(object sender, EventArgs e)
		{
			bool rmIconOption = RegUtils.OperateFileOrDirRightMenu(SET_ICON_MENU_NAME, "", false);
			bool rmCropOption = RegUtils.OperateFileOrDirRightMenu(CROP_IMAGE_MENU_NAME, "", false);
			if (rmIconOption && rmCropOption)
			{
				MessageBox.Show("已成功移除右键快捷操作菜单！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("移除失败！请检查是否有管理员权限！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}