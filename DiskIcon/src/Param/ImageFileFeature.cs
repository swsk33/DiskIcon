﻿namespace Swsk33.DiskIcon.Param
{
	/// <summary>
	/// 常用的图片文件头尾信息
	/// </summary>
	public class ImageFileFeature
	{
		/// <summary>
		/// ICON图标文件-文件头模板
		/// </summary>
		public static readonly byte[] ICON_HEAD_TEMPLATE = {
			0x00, 0x00, 0x01, 0x00, 0x01, 0x00, 0x80, 0x80, 0x00, 0x00, 0x00, 0x00, 0x20, 0x00, 0xC4, 0x6E,
			0x00, 0x00, 0x16, 0x00, 0x00, 0x00
		};
	}
}