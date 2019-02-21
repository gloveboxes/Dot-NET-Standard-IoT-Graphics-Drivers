
namespace Glovebox.Graphics.Drivers
{
    public interface ISevenSegmentDriver 
    {
        int PanelsPerFrame { get; }
        void SetBrightness(byte level);
        void SetFrameState(LedDriver.Display state);
        void Write(ulong[] frame);
    }
}