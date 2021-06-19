namespace DiskIcon.Param
{
	/// <summary>
	/// 对裁剪框状态的枚举
	/// </summary>
	public enum CropFrameStatus
	{
		/// <summary>
		/// 正在调整大小
		/// </summary>
		DRAFTING_SIZE,
		/// <summary>
		/// 正在被移动
		/// </summary>
		DRAFTING_MOVE,
		/// <summary>
		/// 鼠标不在裁剪框内
		/// </summary>
		OUT_OF_CROP
	}
}
