using Swsk33.DiskIcon.Param;
using Swsk33.DiskIcon.Strategy.Context;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Swsk33.DiskIcon
{
	static class Program
	{
		/// <summary>
		/// 程序自身位置
		/// </summary>
		public static readonly string SELF_PATH = Process.GetCurrentProcess().MainModule.FileName;

		/// <summary>
		/// 运行模式
		/// </summary>
		public static AppMode GlobalAppMode;

		/// <summary>
		/// 应用程序的主入口点
		/// 命令行参数说明：
		/// DiskIcon 启动模式 图片路径
		/// 
		/// 启动模式：
		/// g 正常模式启动，此时图片路径不生效（通常不手动使用该模式，直接运行程序会自动使用该模式）
		/// i 快速设定图标模式
		/// c 快速裁剪图片模式
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			/**
			 * 当不使用命令行传入参数时，直接打开主程序（会自动加上g, a.png占位）
			 * 当传入参数时，参数一有如下两种情况：
			 * 1，参数一为i，代表快捷制作图标并设定，这时参数二为输入图片路径
			 * 2，参数一为c，代表快捷裁剪图片，这时参数二为输入图片路径
			 */
			if (args.Length == 0)
			{
				args = new string[] { "g", "a.png" };
				GlobalAppMode = AppMode.MAIN_GUI;
			}
			// 调用启动策略上下文启动
			LaunchContext.DoStrategy(args);
		}
	}
}