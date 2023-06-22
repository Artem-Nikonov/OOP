using DeviceControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

namespace MeasuringDevice
{

    public abstract class MeasureDataDevice : IEventEnabledMeasuringDevice
    {
        protected Units unitsToUse;
        protected int[] dataCaptured;
        protected int mostRecentMeasure;
        protected DeviceController controller;
        protected DeviceType measurementType;
        private TextWriter? loggingFileWriter;
        protected bool disposed;

        /// <summary>
        /// Converts the raw data collected by the measuring device into a metric value.
        /// </summary>
        /// <returns>The latest measurement from the device converted to metric units.</returns>
        public abstract decimal MetricValue();
        /// <summary>
        /// Converts the raw data collected by the measuring device into an imperial value.
        /// </summary>
        ///<returns>The latest measurement from the device converted to imperial units.</returns>
        public abstract decimal ImperialValue();
        /// <summary>
        /// Starts the measuring device.
        /// </summary>
        /// 

        public void StartCollecting()
        {
            if (controller != null) return;
            loggingFileWriter = new StreamWriter("streamfile.txt");
            disposed = false;
            controller = DeviceController.StartDevice(measurementType);
            GetMeasurements();
        }

        /// <summary>
        /// Stops the measuring device.
        /// </summary>
        public void StopCollecting()
        {
            if (controller != null)
            {
                controller.StopDevice();
                controller = null;
            }
            dataCollector?.CancelAsync();

            loggingFileWriter?.Close();
            loggingFileWriter = null;
        }

        private BackgroundWorker dataCollector;

        private void GetMeasurements()
        {
            dataCollector = new BackgroundWorker();
            dataCollector.WorkerSupportsCancellation = true;
            dataCollector.WorkerReportsProgress = true;
            dataCollector.DoWork += new DoWorkEventHandler(dataCollector_DoWork);
            dataCollector.ProgressChanged += new ProgressChangedEventHandler(dataCollector_ProgressChanged);
            dataCollector.RunWorkerAsync();
        }

        //сбор и хранение данных измерений.
        void dataCollector_DoWork(object? sender, DoWorkEventArgs e)
        {
            dataCaptured = new int[10];
            int i = 0;
            while (!dataCollector.CancellationPending)
            {
                dataCaptured[i] = controller.TakeMeasurement();
                mostRecentMeasure = dataCaptured[i];
                if (disposed) break;
                loggingFileWriter?.WriteLine($"Измерение - {MostRecentMeasure}");
                dataCollector.ReportProgress(0);
                i= i>=9 ? 0 : i+1;
            }
        }

        //метод запускается при возникновении события ProgressChanged.
        private void dataCollector_ProgressChanged(object? sender, ProgressChangedEventArgs e) => OnNewMeasurementTaken();
        
        public int[] GetRawData() => dataCaptured;
        
        //событие 
        public event EventHandler? NewMeasurementTaken;

        //метод для вызова события
        protected virtual void OnNewMeasurementTaken() => NewMeasurementTaken?.Invoke(this, null); 

        public string GetLoggingFile() =>  "";

        public void Dispose()
        {
            disposed = true;
            dataCollector?.Dispose();
            loggingFileWriter?.Close();

        }

        //геттер поля unitsToUse 
        public Units UnitsToUse => unitsToUse;

        //геттер поля dataCaptured
        public int[] DataCaptured => dataCaptured;

        //геттер поля mostRecentMeasure
        public int MostRecentMeasure => mostRecentMeasure;

       public string LoggingFileName { get; set; }

      
    }



    public class MeasureLengthDevice : MeasureDataDevice
    {
        public MeasureLengthDevice(Units units)
        {
            unitsToUse = units;
            measurementType = DeviceType.LENGTH;
        }

        public override decimal MetricValue()
        {
            if (unitsToUse == Units.Metric)
            {
                return mostRecentMeasure;
            }
            else
            {
                return mostRecentMeasure * 25.4m;
            }
        }

        public override decimal ImperialValue()
        {
            if (unitsToUse == Units.Imperial)
            {
                return mostRecentMeasure;
            }
            else
            {
                return mostRecentMeasure * 0.03937m;
            }
        }
    }


    public class MeasureMassDevice : MeasureDataDevice
    {
        public MeasureMassDevice(Units units)
        {
            unitsToUse = units;
            measurementType = DeviceType.MASS;
        }

        public override decimal MetricValue()
        {
            if (unitsToUse == Units.Metric)
            {
                return mostRecentMeasure;
            }
            else
            {
                return mostRecentMeasure * 0.4536m;
            }
        }

        public override decimal ImperialValue()
        {
            if (unitsToUse == Units.Imperial)
            {
                return mostRecentMeasure;
            }
            else
            {
                return mostRecentMeasure * 2.2046m;
            }
        }
    }
}
