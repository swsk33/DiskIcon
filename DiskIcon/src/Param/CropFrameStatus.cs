namespace Swsk33.DiskIcon.Param
{
	/// <summary>
	/// 对裁剪框状态的枚举
	/// </summary>
	public enum CropFrameStatus
	{
		/// <summary>
		/// 鼠标在拖动点上
		/// </summary>
		AT_DRAFT_POINT,
		/// <summary>
		/// 鼠标在裁剪框内部
		/// </summary>
		IN_CROP,
		/// <summary>
		/// 鼠标不在裁剪框内
		/// </summary>
		OUT_OF_CROP
	}
}