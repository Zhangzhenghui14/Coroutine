/// <summary>
/// 按帧等待，传入的参数为帧数
/// </summary>
public class WaitForFrames : IWait
{
    private int _frames = 0;
    public WaitForFrames(int frames)
    {
        _frames = frames;
    }

    public bool Tick()
    {
        _frames -= 1;
        return _frames <= 0;
    }
}
