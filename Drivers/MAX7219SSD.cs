using System;
using System.Threading.Tasks;
// using Windows.Devices.Enumeration;
// using Windows.Devices.Spi;
using System.Device.Spi;
using System.Device.Spi.Drivers;
using Glovebox.Graphics.Interfaces;

namespace Glovebox.Graphics.Drivers
{
    public class MAX7219SSD : MAX7219, ISevenSegmentDriver, IDisposable
    {
        public MAX7219SSD(int numberOfPanels = 1, Rotate rotate = Rotate.None, Transform transform = Transform.None, ChipSelect chipSelect = ChipSelect.CE0, string SPIControllerName = "SPI0") :
        base(numberOfPanels, rotate, transform, chipSelect, BusId.BusId0)
        {

        }
    }
}
