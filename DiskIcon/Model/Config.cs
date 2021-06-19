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

		private bool checkUpdate;

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
			this.checkUpdate = checkUpdate;
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

		/// <summary>
		/// 是否检测更新
		/// </summary>
		public bool CheckUpdate
		{
			get
			{
				return checkUpdate;
			}

			set
			{
				checkUpdate = value;
			}
		}
	}
}