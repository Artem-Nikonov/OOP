using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MeasuringDevice;
using DeviceControl;

namespace Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MeasureMassDevice? device;
        EventHandler newMeasurementTaken;
       

        public MainWindow()
        {
            InitializeComponent();
            comboBox.Items.Add(Units.Metric);
            comboBox.Items.Add(Units.Imperial);
        }

        private void StartCollectingButton_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedItem == null) return;
            if (device == null) device = new MeasureMassDevice((Units)comboBox.SelectedItem, "measurements.txt");

            device?.StartCollecting();
            newMeasurementTaken = new EventHandler(device_NewMeasurementTaken);
            device.NewMeasurementTaken += newMeasurementTaken;

            device.HeartBeat += (object sender, HeartBeatEventArgs args) =>
            {
                HeartBeats.Content = args.TimeStamp.ToString();
            };
        }

        private void device_NewMeasurementTaken(object sender, EventArgs e)
        {
            if (device != null)
            {
                mostRecentMeasureBox.Content = $"последнее значение{device.MostRecentMeasure}";
                metricValueBox.Content = $"Метрическое зн.:{device.MetricValue()}";
                imperialValueBox.Content = $"Имперское зн.: {device.ImperialValue()}";
                rawDataValues.ItemsSource = null;
                rawDataValues.ItemsSource = device.GetRawData();
            }
        }



        /*
        private void CreateMeasureMassDeviceButton_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedItem == null) return;
            device = new MeasureMassDevice((Units)comboBox.SelectedItem);
        }

        private void GetRawDataButton_Click(object sender, RoutedEventArgs e)
        {
            RawData.Content =$"{device?.GetType().ToString()}\n";
            if (device?.GetRawData() == null) return;

            int[] data = device.GetRawData();

            foreach (int i in data)
            {
                RawData.Content += $"{i}\n";
            }
        }

        private void GetMetricValueButton_Click(object sender, RoutedEventArgs e)
        {
            GetValue.Content = device?.MetricValue().ToString();
        }

        private void GetImperialValueButton_Click(object sender, RoutedEventArgs e)
        {
            GetValue.Content = device?.ImperialValue().ToString();
        }*/

        private void StopCollectingButton_Click(object sender, RoutedEventArgs e)
        {
            device?.StopCollecting();
            //if(device.NewMeasurementTaken != null) 
            device.NewMeasurementTaken -= newMeasurementTaken;
        }

        private void disposeButton_Click(object sender, RoutedEventArgs e)
        {
            device.Dispose();
        }
    }
}
