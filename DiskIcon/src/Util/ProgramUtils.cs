namespace DiskIcon.Util
{
	/// <summary>
	/// 程序实用类
	/// </summary>
	public class ProgramUtils
	{
		/// <summary>
		/// 将字符串用双引号包围
		/// </summary>
		/// <param name="origin">原字符串</param>
		/// <returns>双引号包围字符串</returns>
		public static string SurroundByQuote(string origin)
		{
			return "\"" + origin + "\"";
		}
	}
}