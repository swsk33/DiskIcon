using System.Drawing;

namespace Swsk33.DiskIcon.Util
{
	/// <summary>
	/// 图片处理实用类
	/// </summary>
	public class ImageUtils
	{
		/// <summary>
		/// 裁剪图片
		/// </summary>
		/// <param name="originImage">原图片</param>
		/// <param name="region">裁剪的方形区域</param>
		/// <returns>裁剪后图片</returns>
		public static Image CropImage(Image originImage, Rectangle region)
		{
			Bitmap result = new Bitmap(region.Width, region.Height);
			Graphics graphics = Graphics.FromImage(result);
			graphics.DrawImage(originImage, new Rectangle(0, 0, region.Width, region.Height), region, GraphicsUnit.Pixel);
			return result;
		}
	}
}