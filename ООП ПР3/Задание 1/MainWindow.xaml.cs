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

namespace Задание_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        uint counter= 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (counter != 0) textBlock1.Text += "\n";
            textBlock1.Text += $"({counter}) Завершение работы";
            Switch sw = new Switch();
            sw.DisconnectPowerGenerator(textBlock1);
            sw.VerifyPrimaryCoolantSystem(textBlock1);
            sw.VerifyBackupCoolantSystem(textBlock1);
            sw.GetCoreTemperature(textBlock1);
            sw.InsertRodCluster(textBlock1);
            sw.GetRadiationLevel(textBlock1);
            sw.SignalShutdownComplete(textBlock1);
            counter++;
        }
    }
    public enum CoolantSystemStatus { OK, Check, Fail }
    public enum SuccessFailureResult { Success, Fail}
    
    public class Switch
    {
        /// <summary>
        /// Utilty object for simulation
        /// </summary>
        private Random rand = new Random();
        /// <summary>
        /// Disconnect from the external power generation systems
        /// </summary>
        /// <returns>Success or Failure</returns>
        /// <exception cref="PowerGeneratorCommsException">Thrown when the physical switch cannot establish a connection to the power generation system</exception>
        public SuccessFailureResult DisconnectPowerGenerator(TextBlock textBlock)
        {
            SuccessFailureResult r = SuccessFailureResult.Fail;
            try
            {
                if (rand.Next(1, 10) > 2) r = SuccessFailureResult.Success;
                if (rand.Next(1, 20) > 18) throw new PowerGeneratorCommsException("Network failure accessing Power Generator monitoring system");
            }
            catch (PowerGeneratorCommsException exc)
            {
                textBlock.Text += $"\n\t*** Exception in step 1: {exc.Message}";
                //r = SuccessFailureResult.Fail;
            }

            return r;
        }
        
        /// <summary>
        /// Runs a diagnostic check against the primary coolant system
        /// </summary>
        /// <returns>Coolant System Status (OK, Fail, Check)</returns>
        /// <exception cref="CoolantTemperatureReadException">Thrown when the switch cannot read the temperature from the coolant system</exception>
        /// <exception cref="CoolantPressureReadException">Thrown when the switch cannot read the pressure from the coolant system</exception>
        public CoolantSystemStatus VerifyPrimaryCoolantSystem(TextBlock textBlock)
        {
            CoolantSystemStatus c = CoolantSystemStatus.Fail;
            try
            {
                int r = rand.Next(1, 10);
                if (r > 5)
                {
                    c = CoolantSystemStatus.OK;
                }
                else if (r > 2)
                {
                    c = CoolantSystemStatus.Check;
                }
                if (rand.Next(1, 20) > 18) throw new CoolantTemperatureReadException("Failed to read primary coolant system temperature");
                if (rand.Next(1, 20) > 18) throw new CoolantPressureReadException("Failed to read primary coolant system pressure");
            }
            catch(CoolantTemperatureReadException exc1)
            {
                textBlock.Text += $"\n\t*** Exception in step 2: {exc1.Message}";
            }
            catch (CoolantPressureReadException exc2)
            {
                textBlock.Text += $"\n\t*** Exception in step 2: {exc2.Message}";
            }

            return c;
        }
        
        /// <summary>
        /// Runs a diagnostic check against the backup coolant system
        /// </summary>
        /// <returns>Coolant System Status (OK, Fail, Check)</returns>
        /// <exception cref="CoolantTemperatureReadException">Thrown when the switch cannot read the temperature from the coolant system</exception>
        /// <exception cref="CoolantPressureReadException">Thrown when the switch cannot read the pressure from the coolant system</exception>
        public CoolantSystemStatus VerifyBackupCoolantSystem(TextBlock textBlock)
        {
            CoolantSystemStatus c = CoolantSystemStatus.Fail;
            try
            {
                int r = rand.Next(1, 10);
                if (r > 5)
                {
                    c = CoolantSystemStatus.OK;
                }
                else if (r > 2)
                {
                    c = CoolantSystemStatus.Check;
                }
                if (rand.Next(1, 20) > 19) throw new CoolantTemperatureReadException("Failed to read backup coolant system temperature");
                if (rand.Next(1, 20) > 19) throw new CoolantPressureReadException("Failed to read backup coolant system pressure");
            }
            catch(CoolantTemperatureReadException exc1)
            {
                textBlock.Text += $"\n\t*** Exception in step 3: {exc1.Message}";
            }
            catch(CoolantPressureReadException exc2)
            {
                textBlock.Text += $"\n\t*** Exception in step 3: {exc2.Message}";
            }
            
            return c;
        }

        /// <summary>
        /// Reads the temperature from the reactor core
        /// </summary>
        /// <returns>Temperature</returns>
        /// <exception cref="CoreTemperatureReadException">Thrown when the switch cannot access the temperature data</exception>
        public double GetCoreTemperature(TextBlock textBlock)
        {
            try
            {
                if (rand.Next(1, 20) > 18) throw new CoreTemperatureReadException("Failed to read core reactor system temperature");
            }
            catch(CoreTemperatureReadException exc)
            {
                textBlock.Text += $"\n\t*** Exception in step 4: {exc.Message}";
            }
            
            return rand.NextDouble() * 1000;
        }

        /// <summary>
        /// Instructs the reactor to insert the control rods to shut the reactor down
        /// </summary>
        /// <returns>Success or failure</returns>
        /// <exception cref="RodClusterReleaseException">Thrown if the switch device cannot read the rod position</exception>
        public SuccessFailureResult InsertRodCluster(TextBlock textBlock)
        {
            SuccessFailureResult r = SuccessFailureResult.Fail;
            try
            {
                if (rand.Next(1, 100) > 5) r = SuccessFailureResult.Success;
                if (rand.Next(1, 10) > 8) throw new RodClusterReleaseException("Sensor failure, cannot verify rod release");
            }
            catch(RodClusterReleaseException exc)
            {
                textBlock.Text += $"\n\t*** Exception in step 5: {exc.Message}";
            }
            
            return r;
        }

        /// <summary>
        /// Reads the radiation level from the reactor core
        /// </summary>
        /// <returns>Temperature</returns>
        /// <exception cref="CoreRadiationLevelReadException">Thrown when the switch cannot access the radiation level data</exception>
        public double GetRadiationLevel(TextBlock textBlock)
        {
            try
            {
                if (rand.Next(1, 20) > 18) throw new CoreRadiationLevelReadException("Failed to read core reactor system radiation levels");
            }
            catch(CoreRadiationLevelReadException exc)
            {
                textBlock.Text += $"\n\t*** Exception in step 6: {exc.Message}";
            }
            return rand.NextDouble() * 500;
        }

        /// <summary>
        /// Sends a broadcast message to PA system notofying shutdown complete
        /// </summary>
        /// <exception cref="SignallingException">Thrown if the switch cannot connect to the PA system over the network</exception>
        public void SignalShutdownComplete(TextBlock textBlock)
        {
            try
            {
                if (rand.Next(1, 20) > 18) throw new SignallingException("Network failure connecting to broadcast systems");
            }
            catch(SignallingException exc)
            {
                textBlock.Text += $"\n\t*** Exception in step 7: {exc.Message}";
            }
            
        }
    }
    public class PowerGeneratorCommsException : Exception
    {
        public PowerGeneratorCommsException(string message) : base(message) { }
    }
    public class CoolantSystemException : Exception
    {
        public CoolantSystemException(string message) : base(message) { }
    }
    public class CoolantTemperatureReadException : CoolantSystemException
    {
        public CoolantTemperatureReadException(string message) : base(message) { }
    }
    public class CoolantPressureReadException : CoolantSystemException
    {
        public CoolantPressureReadException(string message) : base(message) { }
    }
    public class CoreTemperatureReadException : Exception
    {
        public CoreTemperatureReadException(string message) : base(message) { }
    }
    public class CoreRadiationLevelReadException : Exception
    {
        public CoreRadiationLevelReadException(string message) : base(message) { }
    }
    public class RodClusterReleaseException : Exception
    {
        public RodClusterReleaseException(string message) : base(message) { }
    }
    public class SignallingException : Exception
    {
        public SignallingException(string message) : base(message) { }
    }

}
