using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeviceControl
{
    public enum DeviceType
    {
        LENGTH, MASS
    }


    public interface IControllableDevice
    {
        void StartDevice();
        void StopDevice();
        int GetLatestMeasure();
    }


    public class DeviceController : IDisposable
    {
        private IControllableDevice device;

        /// <summary>
        /// A factory method to create a start a new instance of a device.
        /// </summary>
        /// <param name="MeasurementType">Specifies which type of device to start. Must be MASS or LENGTH.</param>
        /// <returns>An instance of the DeviceController class with the controlled device in the started state.</returns>
        public static DeviceController StartDevice(DeviceType MeasurementType)
        {
            DeviceController controller = new DeviceController();
            switch (MeasurementType)
            {
                case DeviceType.LENGTH:
                    controller.device = new LengthMeasuringDevice();
                    break;
                case DeviceType.MASS:
                    controller.device = new MassMeasuringDevice();
                    break;
            }
            if (controller.device != null)
            {
                controller.device.StartDevice();
            }

            return controller;
        }

        /// <summary>
        /// Stops the controlled device.
        /// </summary>
        public void StopDevice()
        {
            device.StopDevice();
        }

        /// <summary>
        /// Forces the controlled device to record a measurement.
        /// </summary>
        /// <returns>The measurement taken by the device.</returns>
        public int TakeMeasurement()
        {
            return device.GetLatestMeasure();
        }

        /// <summary>
        /// Disposes the device.
        /// </summary>
        public void Dispose()
        {
        }
    }


    internal class LengthMeasuringDevice : IControllableDevice
    {
        Random random;

        public LengthMeasuringDevice()
        {
            random = new Random();
        }

        public void StartDevice()
        {
            // Start the device.           
        }

        public void StopDevice()
        {
            // Stop the device.
        }

        public int GetLatestMeasure()
        {
            return random.Next(1000);
        }
    }


    internal class MassMeasuringDevice : IControllableDevice
    {
        Random random;

        public MassMeasuringDevice()
        {
            random = new Random();
        }

        public void StartDevice()
        {
            // Start the device.
        }

        public void StopDevice()
        {
            // Stop the device.
        }

        public int GetLatestMeasure()
        {
            Thread.Sleep(500);
            return random.Next(1390);
        }
    }
}
