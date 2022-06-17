using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeasuringDevice
{
    public interface ILoggingMeasuringDevice :IMeasuringDevice
    {

        /// <summary>
        /// Return the file name of the logging file for the device.
        /// </summary>
        /// <returns>The file name for the logging file.</returns>
        string GetLoggingFile();
    }
}
