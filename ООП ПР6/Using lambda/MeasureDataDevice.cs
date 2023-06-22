using DeviceControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MeasuringDevice
{

    public abstract class MeasureDataDevice : IEventEnabledMeasuringDevice
    {
        protected Units unitsToUse;
        protected int[] dataCaptured;
        protected int mostRecentMeasure;
        protected DeviceController controller;
        protected DeviceType measurementType;


        public int[] GetRawData() => dataCaptured;
        public string GetLoggingFile() => "";
        private TextWriter? loggingFileWriter;
        protected bool disposed;
        //геттер поля unitsToUse 
        public Units UnitsToUse => unitsToUse;
        //геттер поля dataCaptured
        public int[] DataCaptured => dataCaptured;
        //геттер поля mostRecentMeasure
        public int MostRecentMeasure => mostRecentMeasure;
        public string? LoggingFileName { get; set; }
        //событие 
        public event EventHandler? NewMeasurementTaken;


        protected int heartBeatIntervalTime;
        public int HeartBeatInterval { get; protected set; }

        public event HeartBeatEventHandler HeartBeat;

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
            loggingFileWriter = new StreamWriter(LoggingFileName);
            disposed = false;
            controller = DeviceController.StartDevice(measurementType);
            GetMeasurements();
            StartHeartBeat();
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
        private BackgroundWorker heartBeatTimer;

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
        
        
        private void StartHeartBeat()
        {
            heartBeatTimer = new BackgroundWorker();
            heartBeatTimer.WorkerSupportsCancellation = true;
            heartBeatTimer.WorkerReportsProgress = true;
            heartBeatTimer.DoWork+= (o, args) =>
            {
                while (!heartBeatTimer.CancellationPending)
                {
                    Thread.Sleep(HeartBeatInterval);
                    if (disposed) break;
                    heartBeatTimer.ReportProgress(0);
                }
            };

            heartBeatTimer.ProgressChanged += (o, args) => OnHeartBeat();
            heartBeatTimer.RunWorkerAsync();
        }

        //методы для вызова событий
        protected virtual void OnNewMeasurementTaken() => NewMeasurementTaken?.Invoke(this, null);

        protected virtual void OnHeartBeat() => HeartBeat?.Invoke(this, new HeartBeatEventArgs());

        public void Dispose()
        {
            disposed = true;
            dataCollector?.Dispose();
            heartBeatTimer?.Dispose();
            loggingFileWriter?.Close();
        }
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
        public MeasureMassDevice(Units units, int heartBeatInterval)
        {
            unitsToUse = units;
            measurementType = DeviceType.MASS;
            HeartBeatInterval = heartBeatInterval;
        }

        public MeasureMassDevice(Units deviceUnits, string logFileName) : this(deviceUnits, 1000)
        {
            LoggingFileName = logFileName;
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
