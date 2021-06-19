using System.Drawing;

namespace DiskIcon.Util
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
			return new Bitmap(originImage).Clone(region, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
		}
	}
}