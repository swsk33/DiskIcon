using DiskIcon.Model;
using DiskIcon.Param;
using Swsk33.ReadAndWriteSharp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DiskIcon
{
	static class Program
	{
		/// <summary>
		/// 程序自身位置
		/// </summary>
		public static readonly string SELF_PATH = Process.GetCurrentProcess().MainModule.FileName;

		/// <summary>
		/// 程序配置主目录
		/// </summary>
		public static readonly string CFG_DIR_PATH = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.config\\diskIcon\\" ;

		/// <summary>
		/// 程序配置文件路径
		/// </summary>
		public static readonly string CFG_FILE_PATH = CFG_DIR_PATH + "diskIcon.cfg";

		/// <summary>
		/// 临时文件目录
		/// </summary>
		public static readonly string TMP_PATH = CFG_DIR_PATH + "tmp\\";

		/// <summary>
		/// 全局配置信息
		/// </summary>
		public static Config GlobalConfig;

		/// <summary>
		/// 运行模式
		/// </summary>
		public static readonly AppMode appMode;

		/// <summary>
		/// 初始化
		/// </summary>
		private static void Initialize()
		{
			if (!Directory.Exists(CFG_DIR_PATH))
			{
				Directory.CreateDirectory(CFG_DIR_PATH);
			}
			if (!File.Exists(CFG_FILE_PATH))
			{
				GlobalConfig = new Config(128, true);
				BinaryUtils.WriteObjectToFile(CFG_FILE_PATH, GlobalConfig);
				return;
			}
			GlobalConfig = BinaryUtils.ReadObjectFromFile<Config>(CFG_FILE_PATH);
		}

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Initialize();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new MainGUI());
			new ImageEditFrame().initEditFrame(Image.FromFile(@"C:\Users\swsk33\Pictures\头像与图标\init.jpg"));
			Application.Run();
		}
	}
}