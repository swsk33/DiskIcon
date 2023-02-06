using System.Drawing;

namespace Swsk33.DiskIcon.Strategy
{
	/// <summary>
	/// 图片保存策略
	/// </summary>
	public interface ImageSaveStrategy
	{
		/// <summary>
		/// 保存路径
		/// </summary>
		/// <param name="image">图片对象</param>
		/// <param name="path">保存位置</param>
		/// <param name="width">保存图片宽</param>
		/// <param name="height">保存图片高</param>
		/// <returns>是否保存成功</returns>
		bool SaveImage(Image image, string path, int width, int height);
	}
}