using Swsk33.DiskIcon.Param;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Swsk33.DiskIcon.Strategy.Impl
{
	/// <summary>
	/// Icon图标文件保存策略
	/// </summary>
	public class IconImageSaveStrategy : ImageSaveStrategy
	{
		public bool SaveImage(Image image, string path, int width, int height)
		{
			// 把原图并缩放到指定大小
			Image originResized = new Bitmap(image, new Size(width, height));
			// 存放缩放后的原图的内存流
			MemoryStream originImageStream = new MemoryStream();
			// 将原图以png格式写入到内存流
			originResized.Save(originImageStream, ImageFormat.Png);
			// Icon的文件字节内容
			List<byte> iconBytes = new List<byte>();
			// 先加载Icon文件头
			iconBytes.AddRange(ImageFileFeature.ICON_HEAD_TEMPLATE);
			// 文件头的第7和8位分别是图标的宽高，修改为设定值，不可大于255
			iconBytes[6] = (byte)width;
			iconBytes[7] = (byte)height;
			// 文件头的第15到第18位是原图片内容部分大小
			byte[] size = BitConverter.GetBytes((int)originImageStream.Length);
			iconBytes[14] = size[0];
			iconBytes[15] = size[1];
			iconBytes[16] = size[2];
			iconBytes[17] = size[3];
			// 追加原图字节内容
			iconBytes.AddRange(originImageStream.ToArray());
			// 利用文件流保存为Icon文件
			Stream iconFileStream = new FileStream(path, FileMode.Create);
			iconFileStream.Write(iconBytes.ToArray(), 0, iconBytes.Count);
			// 关闭所有流并释放内存
			iconFileStream.Close();
			originImageStream.Close();
			originResized.Dispose();
			return File.Exists(path);
		}
	}
}