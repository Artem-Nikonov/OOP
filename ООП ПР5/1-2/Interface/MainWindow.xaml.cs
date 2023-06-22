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

namespace Interface

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IMeasuringDevice? device;
        public MainWindow()
        {
            InitializeComponent();
            comboBox.Items.Add("Метрическая система");
            comboBox.Items.Add("Имперская система");

        }

        private void CreateMeasureLengthDeviceButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (comboBox.SelectedItem == null) return;

            switch (comboBox.SelectedItem)
            {
                case "Метрическая система":
                    device = new MeasureLengthDevice(Units.Metric);
                    break;
                case "Имперская система":
                    device = new MeasureLengthDevice(Units.Imperial);
                    break;
            }
        }

        private void StartCollectingButton_Click(object sender, RoutedEventArgs e)
        {
            device?.StartCollecting();
        }

        private void GetRawDataButton_Click(object sender, RoutedEventArgs e)
        {
            RawData.Content = "";
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
        }

        private void StopCollectingButton_Click(object sender, RoutedEventArgs e)
        {
            device?.StopCollecting();
        }
    }
}
