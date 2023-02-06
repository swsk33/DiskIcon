using System.Drawing;
using System.IO;

namespace Swsk33.DiskIcon.Strategy.Impl
{
	/// <summary>
	/// 普通图片文件加载策略，包括jpg, png, bmp, tif
	/// </summary>
	public class NormalImageLoadStrategy : ImageLoadStrategy
	{
		public Image ImageLoad(string path)
		{
			Stream imageStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
			byte[] imageBytes = new byte[imageStream.Length];
			imageStream.Read(imageBytes, 0, imageBytes.Length);
			imageStream.Close();
			Stream imageMemoryStream = new MemoryStream(imageBytes);
			Image image = Image.FromStream(imageMemoryStream);
			imageMemoryStream.Close();
			return image;
		}
	}
}