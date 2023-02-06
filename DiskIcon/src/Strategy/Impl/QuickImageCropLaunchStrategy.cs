using Swsk33.DiskIcon.Param;
using Swsk33.DiskIcon.Strategy.Context;
using System.Drawing;

namespace Swsk33.DiskIcon.Strategy.Impl
{
	/// <summary>
	/// 快速裁切图片模式启动
	/// </summary>
	public class QuickImageCropLaunchStrategy : LaunchStrategy
	{
		public void Launch(string[] args)
		{
			Program.GlobalAppMode = AppMode.IMAGE_CROP_MODE;
			Image image = ImageLoadContext.LoadImage(ImageCategory.NORMAL, args[1]);
			if (image == null)
			{
				return;
			}
			new ImageEditFrame().initEditFrame(image);
		}
	}
}