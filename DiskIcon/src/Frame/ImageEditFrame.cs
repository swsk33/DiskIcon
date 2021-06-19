using DiskIcon.Model;
using DiskIcon.Util;
using System.Drawing;
using System.Windows.Forms;

namespace DiskIcon
{
	public partial class ImageEditFrame : Form
	{
		/// <summary>
		/// 鼠标按下时在窗口/组件中的x坐标
		/// </summary>
		private int mouseAtX;

		/// <summary>
		/// 鼠标按下时在窗口/组件中的y坐标
		/// </summary>
		private int mouseAtY;

		/// <summary>
		/// 鼠标是否在窗口/组件上是按下状态
		/// </summary>
		private bool isMouseDown = false;

		/// <summary>
		/// 图片相对于图片盒子所在真实x坐标
		/// </summary>
		private int imageInBoxX;

		/// <summary>
		/// 图片相对于图片盒子所在真实y坐标
		/// </summary>
		private int imageInBoxY;

		/// <summary>
		/// 盒子里图片宽
		/// </summary>
		private int imageInBoxWidth;

		/// <summary>
		/// 盒子里图片高
		/// </summary>
		private int imageInBoxHeight;

		/// <summary>
		/// 原始图片
		/// </summary>
		private Image originImage;

		/// <summary>
		/// 裁剪框
		/// </summary>
		private CropFrame cropFrame;

		public ImageEditFrame()
		{
			InitializeComponent();
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

		public void initEditFrame(Image image)
		{
			inputImage.Image = image;
			originImage = image;
			double ratio = (double)originImage.Width / originImage.Height;
			//确定图片域
			if (ratio > 1)
			{
				imageInBoxWidth = inputImage.Width;
				imageInBoxHeight = (int)(imageInBoxWidth / ratio);
				imageInBoxX = 0;
				imageInBoxY = (inputImage.Height - imageInBoxHeight) / 2;
			}
			else
			{
				imageInBoxHeight = inputImage.Height;
				imageInBoxWidth = (int)(imageInBoxHeight * ratio);
				imageInBoxY = 0;
				imageInBoxX = (inputImage.Width - imageInBoxWidth) / 2;
			}
			cropFrame = new CropFrame(inputImage, new Rectangle(imageInBoxX, imageInBoxY, imageInBoxWidth, imageInBoxHeight));
			Show();
		}

		private void start_Click(object sender, System.EventArgs e)
		{
			start.Enabled = false;
			circleMode.Enabled = true;
			saveIcon.Enabled = true;
			savePng.Enabled = true;
			apply.Enabled = true;
			doNotCrop.Enabled = false;
			int sideLength = imageInBoxHeight;
			if (imageInBoxWidth < imageInBoxHeight)
			{
				sideLength = imageInBoxWidth;
			}
			cropFrame.ProceedCutBox(imageInBoxX, imageInBoxY, (int)(sideLength * 0.9), false);
		}

		private void circleMode_CheckedChanged(object sender, System.EventArgs e)
		{
			int x = cropFrame.CropFrameOutlineRectangle.X;
			int y = cropFrame.CropFrameOutlineRectangle.Y;
			int sideLength = cropFrame.CropFrameOutlineRectangle.Width;
			cropFrame.ProceedCutBox(x, y, sideLength, circleMode.Checked);
		}

		private void close_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}