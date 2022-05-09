using Swsk33.ReadAndWriteSharp.System;
using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace Swsk33.DiskIcon.Util
{
	/// <summary>
	/// 文件操作实用类
	/// </summary>
	public class FileUtils
	{
		/// <summary>
		/// 获取时间字符串作为文件名
		/// </summary>
		/// <returns>时间字符串</returns>
		public static string GetDateTimeFileName()
		{
			return DateTime.Now.ToString("yyMMddHHmmssfff") + ".ico";
		}

		/// <summary>
		/// 获取指定驱动器名称
		/// </summary>
		/// <param name="diskPath">盘符，例如C:\</param>
		/// <returns>指定驱动器名，若驱动器没有名字返回"无名盘"</returns>
		public static string GetDriveName(string diskPath)
		{
			DriveInfo[] totalDirves = DriveInfo.GetDrives();
			string driveName = "无名盘";
			foreach (DriveInfo info in totalDirves)
			{
				if (info.Name.Equals(diskPath) && !info.VolumeLabel.Equals(""))
				{
					driveName = info.VolumeLabel;
				}
			}
			return driveName;
		}

		/// <summary>
		/// 设定储存器图标
		/// </summary>
		/// <param name="diskPath">储存器</param>
		/// <param name="image">图像，作为图标</param>
		public static void SetDiskIcon(string diskPath, Image image)
		{
			string iconFileName = GetDateTimeFileName();
			RemoveDiskIcon(diskPath);
			ImageUtils.SaveToIcon(image, diskPath + iconFileName);
			File.WriteAllText(diskPath + "autorun.inf", "[AutoRun]\r\nicon=" + iconFileName, new UTF8Encoding(false));
			string originDiskName = GetDriveName(diskPath);
			TerminalUtils.RunCommand("label", diskPath.Substring(0, 2) + " ss");
			TerminalUtils.RunCommand("label", diskPath.Substring(0, 2) + " " + originDiskName);
			TerminalUtils.RunCommand("attrib", "+h " + diskPath + "autorun.inf");
			TerminalUtils.RunCommand("attrib", "+h " + diskPath + iconFileName);
		}

		/// <summary>
		/// 移除储存器图标
		/// </summary>
		/// <param name="diskPath">待移除图标的储存器</param>
		public static void RemoveDiskIcon(string diskPath)
		{
			string infPath = diskPath + "autorun.inf";
			if (!File.Exists(infPath))
			{
				return;
			}
			string[] infContent = File.ReadAllLines(infPath);
			foreach (string line in infContent)
			{
				if (line.StartsWith("icon="))
				{
					string iconPath = diskPath + line.Substring(line.IndexOf("=") + 1);
					File.Delete(iconPath);
					File.Delete(infPath);
					string originDiskName = GetDriveName(diskPath);
					TerminalUtils.RunCommand("label", diskPath.Substring(0, 2) + " ss");
					TerminalUtils.RunCommand("label", diskPath.Substring(0, 2) + " " + originDiskName);
					return;
				}
			}
		}
	}
}