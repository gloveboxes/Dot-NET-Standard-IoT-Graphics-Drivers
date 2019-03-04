﻿
using System.Drawing;
using static Glovebox.Graphics.Drivers.LedDriver;

namespace Glovebox.Graphics.Drivers {
    
    public interface ILedDriver {

        int PanelsPerFrame { get; }
        // void SetBlinkRate(LedDriver.BlinkRate blinkrate);

        BlinkRate Blink {set;}

        byte Brightness { set; }
        // void SetBrightness(byte level);
        void SetFrameState(LedDriver.Display state);
        void Write(Color[] frame);
        // void Write(ulong[] frame);
    }
}