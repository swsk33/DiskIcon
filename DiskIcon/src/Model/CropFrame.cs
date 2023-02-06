using Swsk33.DiskIcon.Param;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Swsk33.DiskIcon.Model
{
	/// <summary>
	/// 裁剪框实例
	/// </summary>
	public class CropFrame
	{
		/// <summary>
		/// 指定绘制裁剪框的组件
		/// </summary>
		private Control drawComponent;

		/// <summary>
		/// 裁剪框绘制器
		/// </summary>
		private Graphics cropFrameBody;

		/// <summary>
		/// 裁剪框轮廓画笔
		/// </summary>
		private Pen cropFrameOutlinePen;

		/// <summary>
		/// 裁剪框内部圆轮廓画笔
		/// </summary>
		private Pen cropFrameInnerPen;

		/// <summary>
		/// 裁剪框内部参考格网画笔
		/// </summary>
		private Pen cropFrameReferPen;

		/// <summary>
		/// 裁剪框拖动点绘制笔刷
		/// </summary>
		private Brush cropFrameDraftBrush;

		/// <summary>
		/// 裁剪时内部圆和外部边框之间的蒙层
		/// </summary>
		private Brush cropFrameMaskBrush;

		private Rectangle cropFrameOutlineRectangle;

		/// <summary>
		/// 裁剪框拖动点
		/// </summary>
		private Rectangle cropFrameDraftPoint;

		/// <summary>
		/// 若划定限定区，则指定限定区域的具体矩形区域
		/// </summary>
		private Rectangle restrictedArea;

		/// <summary>
		/// 是否正在裁剪
		/// </summary>
		private bool isCropping;

		/// <summary>
		/// 是否正在调整裁剪框大小
		/// </summary>
		private bool isSizing;

		/// <summary>
		/// 是否划定裁剪框的移动限定区
		/// </summary>
		private bool doRestrict;

		/// <summary>
		/// 鼠标是否在控件上按下
		/// </summary>
		private bool isMouseDown = false;

		/// <summary>
		/// 鼠标在控件上点击时相对于裁剪框内的x坐标
		/// </summary>
		private int mouseAtX;

		/// <summary>
		/// 鼠标在控件上点击时相对于裁剪框内的y坐标
		/// </summary>
		private int mouseAtY;

		/// <summary>
		/// 是否显示内部裁剪圆
		/// </summary>
		private bool showInner;

		/// <summary>
		/// 是否显示参考线
		/// </summary>
		private bool showRefer;

		/// <summary>
		/// 裁剪框外轮廓
		/// </summary>
		public Rectangle CropFrameOutlineRectangle { get => cropFrameOutlineRectangle; set => cropFrameOutlineRectangle = value; }

		/// <summary>
		/// 构建没有限制区的裁剪框
		/// </summary>
		/// <param name="drawComponent">指定一个控件以在其上绘制裁剪框</param>
		public CropFrame(Control drawComponent)
		{
			doRestrict = false;
			this.drawComponent = drawComponent;
			//添加鼠标事件
			this.drawComponent.MouseDown += new MouseEventHandler(mouseDown);
			this.drawComponent.MouseMove += new MouseEventHandler(mouseMove);
			this.drawComponent.MouseUp += new MouseEventHandler(mouseUp);
		}

		/// <summary>
		/// 构建有限制区的裁剪框
		/// </summary>
		/// <param name="drawComponent">指定一个控件以在其上绘制裁剪框</param>
		/// <param name="restrictedArea">限制区矩形</param>
		public CropFrame(Control drawComponent, Rectangle restrictedArea)
		{
			this.drawComponent = drawComponent;
			// 添加鼠标事件
			this.drawComponent.MouseDown += new MouseEventHandler(mouseDown);
			this.drawComponent.MouseMove += new MouseEventHandler(mouseMove);
			this.drawComponent.MouseUp += new MouseEventHandler(mouseUp);
			// 设定限定区
			doRestrict = true;
			this.restrictedArea = restrictedArea;
		}

		private void mouseDown(object sender, MouseEventArgs e)
		{
			if (isCropping)
			{
				isMouseDown = true;
				mouseAtX = e.X - cropFrameOutlineRectangle.X;
				mouseAtY = e.Y - cropFrameOutlineRectangle.Y;
			}
		}

		private void mouseMove(object sender, MouseEventArgs e)
		{
			if (isCropping)
			{
				if (GetCropFrameStatus(e) == CropFrameStatus.AT_DRAFT_POINT || isSizing)
				{ //在调整裁剪框大小时，允许鼠标到裁剪框外部
					drawComponent.Cursor = Cursors.SizeNWSE;
					if (isMouseDown)
					{
						isSizing = true;
						int x = cropFrameOutlineRectangle.X;
						int y = cropFrameOutlineRectangle.Y;
						int sideLength = cropFrameOutlineRectangle.Width + (e.X - cropFrameOutlineRectangle.X - cropFrameOutlineRectangle.Width + e.Y - cropFrameOutlineRectangle.Y - cropFrameOutlineRectangle.Height) / 2;
						if (sideLength < 2)
						{
							sideLength = 2;
						}
						if (doRestrict)
						{
							if (x + sideLength > restrictedArea.Right)
							{
								sideLength = restrictedArea.Right - x - (int)cropFrameOutlinePen.Width;
							}
							if (y + sideLength > restrictedArea.Bottom)
							{
								sideLength = restrictedArea.Bottom - y - (int)cropFrameOutlinePen.Width;
							}
							ProceedCutBox(x, y, sideLength, showInner, showRefer);
						}
						else
						{
							ProceedCutBox(x, y, sideLength, showInner, showRefer);
						}
					}
				}
				else if (GetCropFrameStatus(e) == CropFrameStatus.IN_CROP)
				{
					drawComponent.Cursor = Cursors.SizeAll;
					if (!isSizing && isMouseDown)
					{ //只有在没有调整大小的时候才能拖动
						int x = e.X - mouseAtX;
						int y = e.Y - mouseAtY;
						int sideLength = cropFrameOutlineRectangle.Width;
						if (doRestrict)
						{
							if (x < restrictedArea.X)
							{
								x = restrictedArea.X;
							}
							else if (x + sideLength > restrictedArea.Right)
							{
								x = restrictedArea.Right - sideLength - (int)cropFrameOutlinePen.Width;
							}
							if (y < restrictedArea.Y)
							{
								y = restrictedArea.Y;
							}
							else if (y + sideLength > restrictedArea.Bottom)
							{
								y = restrictedArea.Bottom - sideLength - (int)cropFrameOutlinePen.Width;
							}
							ProceedCutBox(x, y, sideLength, showInner, showRefer);
						}
						else
						{
							ProceedCutBox(x, y, sideLength, showInner, showRefer);
						}
					}
				}
				else
				{
					drawComponent.Cursor = Cursors.Default;
				}
			}
		}

		private void mouseUp(object sender, MouseEventArgs e)
		{
			if (isCropping)
			{
				isMouseDown = false;
				isSizing = false;
			}
		}

		/// <summary>
		/// 打开/绘制裁剪框
		/// </summary>
		/// <param name="x">裁剪框x坐标</param>
		/// <param name="y">裁剪框y坐标</param>
		/// <param name="sideLength">裁剪框边长</param>
		/// <param name="showInnerCircle">是否显示内部圆</param>
		/// <param name="showReferLine">是否显示参考格网</param>
		public void ProceedCutBox(int x, int y, int sideLength, bool showInnerCircle, bool showReferLine)
		{
			isCropping = true;
			showInner = showInnerCircle;
			showRefer = showReferLine;
			drawComponent.Refresh();
			cropFrameBody = drawComponent.CreateGraphics();
			cropFrameBody.SmoothingMode = SmoothingMode.AntiAlias;
			cropFrameBody.InterpolationMode = InterpolationMode.HighQualityBicubic;
			cropFrameOutlinePen = new Pen(Color.Red, 2);
			cropFrameOutlineRectangle = new Rectangle(x, y, sideLength, sideLength);
			if (showInnerCircle)
			{
				cropFrameMaskBrush = new SolidBrush(Color.FromArgb(185, 63, 63, 70));
				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.AddRectangle(cropFrameOutlineRectangle);
				graphicsPath.AddEllipse(cropFrameOutlineRectangle);
				cropFrameBody.FillRegion(cropFrameMaskBrush, new Region(graphicsPath));
				cropFrameInnerPen = new Pen(Color.Blue, 1);
				cropFrameBody.DrawEllipse(cropFrameInnerPen, cropFrameOutlineRectangle);
			}
			if (showReferLine)
			{
				cropFrameReferPen = new Pen(Color.DarkGreen, 1.5f);
				double rate1 = 1.0 / 3.0;
				double rate2 = 2.0 / 3.0;
				cropFrameBody.DrawLine(cropFrameReferPen, (float)(x + rate1 * sideLength), y, (float)(x + rate1 * sideLength), y + sideLength);
				cropFrameBody.DrawLine(cropFrameReferPen, (float)(x + rate2 * sideLength), y, (float)(x + rate2 * sideLength), y + sideLength);
				cropFrameBody.DrawLine(cropFrameReferPen, x, (float)(y + rate1 * sideLength), x + sideLength, (float)(y + rate1 * sideLength));
				cropFrameBody.DrawLine(cropFrameReferPen, x, (float)(y + rate2 * sideLength), x + sideLength, (float)(y + rate2 * sideLength));
			}
			cropFrameDraftBrush = new SolidBrush(Color.Purple);
			cropFrameDraftPoint = new Rectangle(x + cropFrameOutlineRectangle.Width - 3, y + cropFrameOutlineRectangle.Height - 3, 6, 6);
			cropFrameBody.DrawRectangle(cropFrameOutlinePen, cropFrameOutlineRectangle);
			cropFrameBody.FillRectangle(cropFrameDraftBrush, cropFrameDraftPoint);
		}

		/// <summary>
		/// 关闭裁剪框
		/// </summary>
		public void DisposeCropFrame()
		{
			isCropping = false;
			cropFrameBody.Dispose();
			drawComponent.Refresh();
		}

		/// <summary>
		/// 获取鼠标所在裁剪框的位置以判断状态
		/// </summary>
		/// <param name="e">传入鼠标事件</param>
		/// <returns>裁剪框的状态常量</returns>
		public CropFrameStatus GetCropFrameStatus(MouseEventArgs e)
		{
			if (e.X >= cropFrameDraftPoint.X && e.X <= cropFrameDraftPoint.Right && e.Y >= cropFrameDraftPoint.Y && e.Y <= cropFrameDraftPoint.Bottom)
			{
				return CropFrameStatus.AT_DRAFT_POINT;
			}
			else if (e.X >= cropFrameOutlineRectangle.X && e.X <= cropFrameOutlineRectangle.Right && e.Y >= cropFrameOutlineRectangle.Y && e.Y <= cropFrameOutlineRectangle.Bottom)
			{
				return CropFrameStatus.IN_CROP;
			}
			else
			{
				return CropFrameStatus.OUT_OF_CROP;
			}
		}
	}
}