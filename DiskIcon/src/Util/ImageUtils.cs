using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

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
			Bitmap result = new Bitmap(region.Width, region.Height);
			Graphics graphics = Graphics.FromImage(result);
			graphics.DrawImage(originImage, 0, 0, region, GraphicsUnit.Pixel);
			return result;
		}

		/// <summary>
		/// 图片保存为ico文件
		/// </summary>
		/// <param name="origin">原图片</param>
		/// <param name="destination">输出ico文件路径</param>
		/// <returns>是否保存成功</returns>
		public static bool SaveToIcon(Image origin, string destination)
		{
			Image image = new Bitmap(origin, new Size(Program.GlobalConfig.IconSize, Program.GlobalConfig.IconSize));
			MemoryStream bitMapStream = new MemoryStream();
			MemoryStream iconStream = new MemoryStream();
			image.Save(bitMapStream, ImageFormat.Png);
			BinaryWriter iconWriter = new BinaryWriter(iconStream);
			iconWriter.Write((short)0);
			iconWriter.Write((short)1);
			iconWriter.Write((short)1);
			iconWriter.Write((byte)image.Width);
			iconWriter.Write((byte)image.Height);
			iconWriter.Write((short)0);
			iconWriter.Write((short)0);
			iconWriter.Write((short)32);
			iconWriter.Write((int)bitMapStream.Length);
			iconWriter.Write(22);
			//写入图像体至目标图标内存流
			iconWriter.Write(bitMapStream.ToArray());
			//保存流，并将流指针定位至头部以Icon对象进行读取输出为文件
			iconWriter.Flush();
			iconWriter.Seek(0, SeekOrigin.Begin);
			Stream iconFileStream = new FileStream(destination, FileMode.Create);
			Icon icon = new Icon(iconStream);
			icon.Save(iconFileStream);
			iconFileStream.Close();
			iconWriter.Close();
			iconStream.Close();
			bitMapStream.Close();
			icon.Dispose();
			image.Dispose();
			return File.Exists(destination);
		}
	}
}