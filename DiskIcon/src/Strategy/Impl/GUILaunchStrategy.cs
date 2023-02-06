using Swsk33.DiskIcon.Param;
using System.Windows.Forms;

namespace Swsk33.DiskIcon.Strategy.Impl
{
	/// <summary>
	/// 正常模式启动
	/// </summary>
	public class GUILaunchStrategy : LaunchStrategy
	{
		public void Launch(string[] args)
		{
			Program.GlobalAppMode = AppMode.MAIN_GUI;
			Application.Run(new MainGUI());
		}
	}
}