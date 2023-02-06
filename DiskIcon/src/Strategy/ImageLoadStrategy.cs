using System.Drawing;

namespace Swsk33.DiskIcon.Strategy
{
	/// <summary>
	/// 图片读取策略
	/// </summary>
	public interface ImageLoadStrategy
	{
		/// <summary>
		/// 读取图片，从文件加载
		/// </summary>
		/// <param name="path">图片文件路径</param>
		/// <returns>图片对象</returns>
		Image ImageLoad(string path);
	}
}