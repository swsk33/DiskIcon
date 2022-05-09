using Swsk33.DiskIcon.Param;
using System;
using System.Diagnostics;
using System.Drawing;
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
		/// 支持的图片格式
		/// </summary>
		public static readonly string[] SUPPORT_IMAGE_FORMAT = { "jpg", "jpeg", "png", "bmp", "tif", "tiff" };

		/// <summary>
		/// 运行模式
		/// </summary>
		public static AppMode GlobalAppMode;

		/// <summary>
		/// 快速调用模式下的图片地址
		/// </summary>
		public static string QuickModeImage;

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			/**
			 * 当不使用命令行传入参数时，直接打开主程序
			 * 当传入参数时，参数一有如下两种情况：
			 * 1，参数一为i，代表快捷制作图标并设定，这时参数二为输入图片路径
			 * 2，参数一为c，代表快捷裁剪图片，这时参数二为输入图片路径
			 */
			if (args.Length == 0)
			{
				GlobalAppMode = AppMode.MAIN_GUI;
				Application.Run(new MainGUI());
			}
			else
			{
				if (args.Length < 2)
				{
					MessageBox.Show("缺少参数！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				string imagePath = args[1];
				if (Array.IndexOf(SUPPORT_IMAGE_FORMAT, imagePath.Substring(imagePath.LastIndexOf(".") + 1)) == -1)
				{
					string support = "";
					foreach (string f in SUPPORT_IMAGE_FORMAT)
					{
						support = support + f + "、";
					}
					support = support.Substring(0, support.Length - 1);
					MessageBox.Show("图片格式不支持！目前支持的格式：" + support, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (args[0].Equals("i"))
				{
					GlobalAppMode = AppMode.QUICK_ICO_MODE;
					QuickModeImage = args[1];
					new QuickSetIcon().Show();
					Application.Run();
				}
				else if (args[0].Equals("c"))
				{
					GlobalAppMode = AppMode.IMAGE_CROP_MODE;
					QuickModeImage = args[1];
					Image image = Image.FromFile(QuickModeImage);
					new ImageEditFrame().initEditFrame(image);
					image.Dispose();
				}
				else
				{
					MessageBox.Show("参数错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}