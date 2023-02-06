using Swsk33.DiskIcon.Param;
using Swsk33.DiskIcon.Strategy.Context;
using System.Drawing;

namespace Swsk33.DiskIcon.Strategy.Impl
{
	/// <summary>
	/// 快速设定图标模式启动
	/// </summary>
	public class QuickIconSetLaunchStrategy : LaunchStrategy
	{
		public void Launch(string[] args)
		{
			Program.GlobalAppMode = AppMode.QUICK_ICO_MODE;
			Image image = ImageLoadContext.LoadImage(ImageCategory.NORMAL, args[1]);
			if (image == null)
			{
				return;
			}
			new QuickSetIcon(image).ShowDialog();
		}
	}
}