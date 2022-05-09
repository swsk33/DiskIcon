using Swsk33.ReadAndWriteSharp.FileUtil;
using System;
using System.IO;
using System.Windows.Forms;

namespace Swsk33.DiskIcon.Model
{
	/// <summary>
	/// 配置类（单例模式）
	/// </summary>
	[Serializable]
	public class Config
	{
		/// <summary>
		/// 程序配置主目录
		/// </summary>
		public static readonly string CFG_DIR_PATH = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.config\\diskIcon\\";

		/// <summary>
		/// 程序配置文件路径
		/// </summary>
		public static readonly string CFG_FILE_PATH = CFG_DIR_PATH + "diskIcon.dicfg";

		/// <summary>
		/// 图标大小字段
		/// </summary>
		private int iconSize = 128;

		/// <summary>
		/// 图标大小
		/// </summary>
		public int IconSize { get => iconSize; set => iconSize = value; }

		/// <summary>
		/// 私有化构造器
		/// </summary>
		private Config() { }

		/// <summary>
		/// 配置单例
		/// </summary>
		private static Config instance;

		/// <summary>
		/// 获取配置对象
		/// </summary>
		/// <returns>配置对象</returns>
		public static Config GetConfig()
		{
			if (instance == null)
			{
				ReadFromLocal();
			}
			return instance;
		}

		/// <summary>
		/// 从本地读取配置
		/// </summary>
		public static void ReadFromLocal()
		{
			// 若配置文件不存在则写入一个新的
			if (!Directory.Exists(CFG_DIR_PATH))
			{
				Directory.CreateDirectory(CFG_DIR_PATH);
			}
			if (!File.Exists(CFG_FILE_PATH))
			{
				instance = new Config();
				WriteToLocal();
				return;
			}
			// 否则读取配置
			try
			{
				instance = BinaryUtils.ReadObjectFromFile<Config>(CFG_FILE_PATH);
			}
			catch (Exception)
			{
				MessageBox.Show("读取配置失败！请删除\"C:\\Users\\你的用户名\\.config\\diskIcon\"目录然后再试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
		}

		/// <summary>
		/// 将当前配置写入本地
		/// </summary>
		public static void WriteToLocal()
		{
			BinaryUtils.WriteObjectToFile(CFG_FILE_PATH, instance);
		}
	}
}