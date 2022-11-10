/// <summary>
/// 等待一次循环（每次循环的时间间隔为一帧，所以也可以说是等待一帧）
/// 相等于unity协程中的yield return null 等待一帧
/// </summary>
public class ZNull : IWait
{
	public bool Tick()
	{
		return true;
	}
}
