using Swsk33.DiskIcon.Param;
using Swsk33.DiskIcon.Strategy.Impl;
using Swsk33.ReadAndWriteSharp.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Swsk33.DiskIcon.Strategy.Context
{
	/// <summary>
	/// 图片加载策略上下文
	/// </summary>
	public class ImageLoadContext
	{
		/// <summary>
		/// 支持的图片格式
		/// </summary>
		private static readonly string[] SUPPORT_IMAGE_FORMAT = { "jpg", "jpeg", "png", "bmp", "tif", "tiff" };

		/// <summary>
		/// 策略容器
		/// </summary>
		private static readonly Dictionary<ImageCategory, ImageLoadStrategy> IMAGE_LOAD_MAP = new Dictionary<ImageCategory, ImageLoadStrategy>();

		/// <summary>
		/// 初始化策略
		/// </summary>
		static ImageLoadContext()
		{
			IMAGE_LOAD_MAP.Add(ImageCategory.NORMAL, new NormalImageLoadStrategy());
		}

		/// <summary>
		/// 执行加载图片策略
		/// </summary>
		/// <param name="type">加载图片类型</param>
		/// <param name="path">图片路径</param>
		/// <returns>加载的图片对象</returns>
		public static Image LoadImage(ImageCategory type, string path)
		{
			// 查错
			string fileFormat = FilePathUtils.GetFileFormat(path);
			if (fileFormat == null || Array.IndexOf(SUPPORT_IMAGE_FORMAT, fileFormat.ToLower()) == -1)
			{
				string support = "";
				foreach (string format in SUPPORT_IMAGE_FORMAT)
				{
					support = support + format + "、";
				}
				support = support.Substring(0, support.Length - 1);
				MessageBox.Show("图片格式不支持！目前支持的格式：" + support, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			if (!File.Exists(path))
			{
				MessageBox.Show("图片不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			// 执行策略
			return IMAGE_LOAD_MAP[type].ImageLoad(path);
		}
	}
}