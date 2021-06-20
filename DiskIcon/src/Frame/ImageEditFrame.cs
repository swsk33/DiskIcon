using DiskIcon.Model;
using DiskIcon.Param;
using DiskIcon.Util;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
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
		/// 裁剪框
		/// </summary>
		private CropFrame cropFrame;

		/// <summary>
		/// 储存器路径
		/// </summary>
		private string diskPath;

		public ImageEditFrame()
		{
			CheckForIllegalCrossThreadCalls = false;
			InitializeComponent();
		}

		/// <summary>
		/// 以一个图像初始化一个裁剪窗口（模态框）
		/// </summary>
		/// <param name="image">原图像</param>
		public void initEditFrame(Image image)
		{
			initImageArgs(image);
			ShowDialog();
		}

		/// <summary>
		/// 以一个图像初始化一个裁剪窗口并指定待设定图标的储存器（模态框）
		/// </summary>
		/// <param name="image">原图像</param>
		/// <param name="diskPath">储存器</param>
		public void initEditFrame(Image image, string diskPath)
		{
			this.diskPath = diskPath;
			initImageArgs(image);
			ShowDialog();
		}

		/// <summary>
		/// 初始化窗口内图像及其参数
		/// </summary>
		/// <param name="inputImage">输入图像</param>
		private void initImageArgs(Image inputImage)
		{
			this.inputImage.Image = inputImage;
			double ratio = (double)inputImage.Width / inputImage.Height;
			//确定图片域
			if (ratio > 1)
			{
				imageInBoxWidth = this.inputImage.Width;
				imageInBoxHeight = (int)(imageInBoxWidth / ratio);
				imageInBoxX = 0;
				imageInBoxY = (this.inputImage.Height - imageInBoxHeight) / 2;
			}
			else
			{
				imageInBoxHeight = this.inputImage.Height;
				imageInBoxWidth = (int)(imageInBoxHeight * ratio);
				imageInBoxY = 0;
				imageInBoxX = (this.inputImage.Width - imageInBoxWidth) / 2;
			}
			cropFrame = new CropFrame(this.inputImage, new Rectangle(imageInBoxX, imageInBoxY, imageInBoxWidth, imageInBoxHeight));
		}

		/// <summary>
		/// 根据裁剪框位置，获取相对于原图的裁剪区的图片
		/// </summary>
		/// <returns>裁剪部分图片</returns>
		private Image getCropImage()
		{
			/**
			 * 预览图中裁剪框位置及大小
			 */
			int XInBox = cropFrame.CropFrameOutlineRectangle.X - imageInBoxX;
			int YInBox = cropFrame.CropFrameOutlineRectangle.Y - imageInBoxY;
			int sideLengthInBox = cropFrame.CropFrameOutlineRectangle.Width;
			/**
			 * 原图对比于预览图比例
			 */
			double ratio = (double)inputImage.Image.Width / imageInBoxWidth;
			/**
			 * 计算出在原图上的裁剪区域
			 */
			int finalX = (int)(ratio * XInBox);
			int finalY = (int)(ratio * YInBox);
			int finalSideLength = (int)(ratio * sideLengthInBox);
			return ImageUtils.CropImage(inputImage.Image, new Rectangle(finalX, finalY, finalSideLength, finalSideLength));
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

		private void start_Click(object sender, System.EventArgs e)
		{
			cropTip.Visible = true;
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
			if (Program.GlobalAppMode == AppMode.IMAGE_CROP_MODE)
			{
				Application.Exit();
			}
			else
			{
				Dispose();
			}
		}

		private void saveIcon_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Title = "保存ico文件至";
			dialog.Filter = "图标文件(*.ico)|*.ico";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Image icon = getCropImage();
				bool success = ImageUtils.SaveToIcon(icon, dialog.FileName);
				icon.Dispose();
				if (success)
				{
					MessageBox.Show("已保存ico文件至：" + dialog.FileName, "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("保存失败！请检查是否有写入权限！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void savePng_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Title = "保存png文件至";
			dialog.Filter = "便携式网络图形(*.png)|*.png";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Image image = getCropImage();
				image.Save(dialog.FileName, ImageFormat.Png);
				image.Dispose();
				if (File.Exists(dialog.FileName))
				{
					MessageBox.Show("已保存png文件至：" + dialog.FileName, "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("保存失败！请检查是否有写入权限！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void ImageEditFrame_Load(object sender, System.EventArgs e)
		{
			if (Program.GlobalAppMode == AppMode.IMAGE_CROP_MODE)
			{
				doNotCrop.Visible = false;
				apply.Visible = false;
			}
			else
			{
				doNotCrop.Visible = true;
				apply.Visible = true;
			}
		}

		private void apply_Click(object sender, System.EventArgs e)
		{
			Image icon = getCropImage();
			loading.Visible = true;
			Application.DoEvents();
			new Thread(() =>
			{
				FileUtils.SetDiskIcon(diskPath, icon);
				MessageBox.Show("设定图标完成！若没有立即生效，请重启电脑、重新插拔设备或者以管理员身份运行程序再试！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
				loading.Visible = false;
				icon.Dispose();
			}).Start();
		}

		private void doNotCrop_Click(object sender, System.EventArgs e)
		{
			loading.Visible = true;
			Application.DoEvents();
			new Thread(() =>
			{
				FileUtils.SetDiskIcon(diskPath, inputImage.Image);
				MessageBox.Show("设定图标完成！若没有立即生效，请重启电脑、重新插拔设备或者以管理员身份运行程序再试！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
				loading.Visible = false;
			}).Start();
		}
	}
}