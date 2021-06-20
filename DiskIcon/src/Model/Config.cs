using System;

namespace DiskIcon.Model
{
	/// <summary>
	/// 配置类
	/// </summary>
	[Serializable]
	public class Config
	{

		private int iconSize;

		/// <summary>
		/// 无参构造器
		/// </summary>
		public Config()
		{

		}

		/// <summary>
		/// 带参构造器
		/// </summary>
		/// <param name="iconSize">icon大小</param>
		/// <param name="checkUpdate">是否检查更新</param>
		public Config(int iconSize, bool checkUpdate)
		{
			this.iconSize = iconSize;
		}

		/// <summary>
		/// icon图标大小（边长）
		/// </summary>
		public int IconSize
		{
			get
			{
				return iconSize;
			}

			set
			{
				iconSize = value;
			}
		}
	}
}