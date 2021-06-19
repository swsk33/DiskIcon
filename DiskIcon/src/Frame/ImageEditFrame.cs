using DiskIcon.Model;
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
		private int imgX;

		/// <summary>
		/// 图片相对于图片盒子所在真实y坐标
		/// </summary>
		private int imgY;

		/// <summary>
		/// 盒子里图片宽
		/// </summary>
		private int imgWidth;

		/// <summary>
		/// 盒子里图片高
		/// </summary>
		private int imgHeight;

		/// <summary>
		/// 原始图片宽
		/// </summary>
		private double originImageWidth;

		/// <summary>
		/// 原始图片高
		/// </summary>
		private double originImageHeight;

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
			inputImg.Image = image;
			originImageWidth = image.Width;
			originImageHeight = image.Height;
			double ratio = originImageWidth / originImageHeight;
			//确定图片域
			if (ratio > 1)
			{
				imgWidth = inputImg.Width;
				imgHeight = (int)(imgWidth / ratio);
				imgX = 0;
				imgY = (inputImg.Height - imgHeight) / 2;
			}
			else
			{
				imgHeight = inputImg.Height;
				imgWidth = (int)(imgHeight * ratio);
				imgY = 0;
				imgX = (inputImg.Width - imgWidth) / 2;
			}
			cropFrame = new CropFrame(inputImg, new Rectangle(imgX, imgY, imgWidth, imgHeight));
			Show();
		}

		private void start_Click(object sender, System.EventArgs e)
		{
			start.Enabled = false;
			stop.Enabled = true;
			int sideLength = imgHeight;
			if (imgWidth < imgHeight)
			{
				sideLength = imgWidth;
			}
			cropFrame.ProceedCutBox(imgX, imgY, (int)(sideLength * 0.9), true);
		}

		private void stop_Click(object sender, System.EventArgs e)
		{
			cropFrame.DisposeCropFrame();
			start.Enabled = true;
			stop.Enabled = false;
		}
	}
}