using Swsk33.DiskIcon.Strategy.Impl;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Swsk33.DiskIcon.Strategy.Context
{
	/// <summary>
	/// 启动策略上下文处理器
	/// </summary>
	public class LaunchContext
	{
		/// <summary>
		/// 策略容器
		/// </summary>
		private static readonly Dictionary<string, LaunchStrategy> STRATEGY_MAP = new Dictionary<string, LaunchStrategy>();

		/// <summary>
		/// 静态块初始化策略
		/// </summary>
		static LaunchContext()
		{
			STRATEGY_MAP.Add("g", new GUILaunchStrategy());
			STRATEGY_MAP.Add("i", new QuickIconSetLaunchStrategy());
			STRATEGY_MAP.Add("c", new QuickImageCropLaunchStrategy());
		}

		/// <summary>
		/// 执行策略
		/// </summary>
		/// <param name="args">启动参数</param>
		public static void DoStrategy(string[] args)
		{
			// 查错
			if (args.Length < 2)
			{
				MessageBox.Show("缺少参数！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!STRATEGY_MAP.ContainsKey(args[0]))
			{
				MessageBox.Show("策略不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			// 执行策略
			STRATEGY_MAP[args[0]].Launch(args);
		}
	}
}