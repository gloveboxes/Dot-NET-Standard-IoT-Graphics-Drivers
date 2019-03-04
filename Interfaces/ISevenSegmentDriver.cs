
using Glovebox.Graphics.Drivers;

namespace Glovebox.Graphics.Interfaces
{
    public interface ISevenSegmentDriver 
    {
        int PanelsPerFrame { get; }
        // void SetBrightness(byte level);
        byte Brightness { set; }
        
        void SetFrameState(LedDriver.Display state);
        void Write(ulong[] frame);
    }
}