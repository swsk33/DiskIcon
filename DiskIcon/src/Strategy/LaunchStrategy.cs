namespace Swsk33.DiskIcon.Strategy
{
	public interface LaunchStrategy
	{
		/// <summary>
		/// 启动方法
		/// </summary>
		/// <param name="args">传入的参数</param>
		void Launch(string[] args);
	}
}