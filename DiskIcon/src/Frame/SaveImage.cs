using Swsk33.DiskIcon.Util;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Swsk33.DiskIcon
{
	public partial class SaveImage : Form
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
		/// 待保存图片
		/// </summary>
		private Image originImage;

		/// <summary>
		/// 是否是正方形图片
		/// </summary>
		private bool isSquare;

		public SaveImage()
		{
			CheckForIllegalCrossThreadCalls = false;
			InitializeComponent();
		}

		public void initSaveImageDialog(Image image, bool isSquare)
		{
			this.isSquare = isSquare;
			originImage = image;
			ShowDialog();
		}

		private void ConfigFrame_MouseDown(object sender, MouseEventArgs e)
		{
			Cursor = Cursors.SizeAll;
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

		private void cancel_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void SaveImage_Load(object sender, System.EventArgs e)
		{
			imageFormatValue.SelectedIndex = 0;
			if (!isSquare)
			{
				customSize.Enabled = false;
			}
		}

		/// <summary>
		/// 单选按钮改变触发事件
		/// </summary>
		private void RadioButtonChanged(object sender, System.EventArgs e)
		{
			if (containMax.Checked)
			{
				customValue.Enabled = false;
			}
			else if (customSize.Checked)
			{
				customValue.Enabled = true;
			}
		}

		private void ok_Click(object sender, System.EventArgs e)
		{
			ImageFormat format;
			string saveFilter;
			switch (imageFormatValue.SelectedIndex)
			{
				case 0:
					format = ImageFormat.Png;
					saveFilter = "便携式网络图形(*.png)|*.png";
					break;
				case 1:
					format = ImageFormat.Jpeg;
					saveFilter = "联合图像专家组图形(*.jpg)|*.jpg";
					break;
				case 2:
					format = ImageFormat.Bmp;
					saveFilter = "位图格式(*.bmp)|*.bmp";
					break;
				case 3:
					format = ImageFormat.Tiff;
					saveFilter = "标记图像文件(*.tif)|*.tif";
					break;
				case 4:
					format = ImageFormat.Gif;
					saveFilter = "图形交换格式(*.gif)|*.gif";
					break;
				default:
					format = ImageFormat.Png;
					saveFilter = "便携式网络图形(*.png)|*.png";
					break;
			}
			int width = originImage.Width;
			int height = originImage.Height;
			if (isSquare && customSize.Checked)
			{
				if (customValue.Text.Equals(""))
				{
					MessageBox.Show("请填写保存图片边长！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				try
				{
					width = int.Parse(customValue.Text);
					height = width;
				}
				catch
				{
					MessageBox.Show("图片边长请输入整数！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Title = "保存图片为";
			dialog.Filter = saveFilter;
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				if (ImageUtils.SaveImageFile(originImage, format, width, height, dialog.FileName))
				{
					MessageBox.Show("已保存图片文件至：" + dialog.FileName, "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("保存失败！请检查是否有写入权限！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}