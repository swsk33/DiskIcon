using Swsk33.ReadAndWriteSharp.Util;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Swsk33.DiskIcon.Strategy.Impl
{
	/// <summary>
	/// 常规图片保存策略，包括jpg, png, bmp, tif, gif
	/// </summary>
	public class NormalImageSaveStrategy : ImageSaveStrategy
	{
		/// <summary>
		/// 所有的导出格式对应表
		/// </summary>
		private static readonly Dictionary<string, ImageFormat> NORMAL_IMAGE_FORMAT = new Dictionary<string, ImageFormat>();

		/// <summary>
		/// 初始化导出格式对应表
		/// </summary>
		static NormalImageSaveStrategy()
		{
			NORMAL_IMAGE_FORMAT.Add("png", ImageFormat.Png);
			NORMAL_IMAGE_FORMAT.Add("jpg", ImageFormat.Jpeg);
			NORMAL_IMAGE_FORMAT.Add("jpeg", ImageFormat.Jpeg);
			NORMAL_IMAGE_FORMAT.Add("bmp", ImageFormat.Bmp);
			NORMAL_IMAGE_FORMAT.Add("tif", ImageFormat.Tiff);
			NORMAL_IMAGE_FORMAT.Add("tiff", ImageFormat.Tiff);
			NORMAL_IMAGE_FORMAT.Add("gif", ImageFormat.Gif);
		}

		public bool SaveImage(Image image, string path, int width, int height)
		{
			string format = FilePathUtils.GetFileFormat(path).ToLower();
			if (!NORMAL_IMAGE_FORMAT.ContainsKey(format))
			{
				MessageBox.Show("扩展名错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			Bitmap result = new Bitmap(image, new Size(width, height));
			result.Save(path, NORMAL_IMAGE_FORMAT[format]);
			result.Dispose();
			return File.Exists(path);
		}
	}
}