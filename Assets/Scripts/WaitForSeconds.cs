/// <summary>
/// 按秒等待
/// </summary>
public class WaitForSeconds : IWait
{
    float _seconds = 0f;

    public WaitForSeconds(float seconds)
    {
        _seconds = seconds;
    }

    public bool Tick()
    {
        _seconds -= Time.deltaTime;
        return _seconds <= 0;
    }
}