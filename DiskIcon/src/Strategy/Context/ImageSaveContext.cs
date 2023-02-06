using Swsk33.DiskIcon.Param;
using Swsk33.DiskIcon.Strategy;
using Swsk33.DiskIcon.Strategy.Impl;
using System.Collections.Generic;
using System.Drawing;

namespace Swsk33.DiskIcon.src.Strategy.Context
{
	/// <summary>
	/// 图片保存策略上下文
	/// </summary>
	public class ImageSaveContext
	{
		/// <summary>
		/// 策略容器
		/// </summary>
		public static readonly Dictionary<ImageCategory, ImageSaveStrategy> IMAGE_SAVE_MAP = new Dictionary<ImageCategory, ImageSaveStrategy>();

		/// <summary>
		/// 初始化策略
		/// </summary>
		static ImageSaveContext()
		{
			IMAGE_SAVE_MAP.Add(ImageCategory.NORMAL, new NormalImageSaveStrategy());
			IMAGE_SAVE_MAP.Add(ImageCategory.ICON, new IconImageSaveStrategy());
		}

		/// <summary>
		/// 执行保存图片策略
		/// </summary>
		/// <param name="category">图片类型</param>
		/// <param name="image">图片对象</param>
		/// <param name="path">保存路径</param>
		/// <param name="width">图片宽</param>
		/// <param name="height">图片高</param>
		/// <returns>是否保存成功</returns>
		public static bool SaveImage(ImageCategory category, Image image, string path, int width, int height)
		{
			return IMAGE_SAVE_MAP[category].SaveImage(image, path, width, height);
		}
	}
}