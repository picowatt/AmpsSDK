﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AmpsBox.cs" company="">
//   
// </copyright>
// <summary>
//   Communicates with a PNNL Amps Box
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using AmpsBoxSdk.Commands;
using AmpsBoxSdk.Io;
using AmpsBoxSdk.Modules;

namespace AmpsBoxSdk.Devices
{
    using System;
    using System.Runtime.Serialization;
    using System.Threading.Tasks;
    using AmpsBoxSdk.Data;
    /// <summary>
    /// Communicates with a PNNL Amps Box
    /// Non shared parts creation policy so that multiple amps boxes can exist in the system at once.
    /// </summary>
    [DataContract]
    internal sealed class AmpsBox : IAmpsBox
    {
        private AmpsBoxCommunicator communicator;
        #region Constants

        /// <summary>
        /// 
        /// </summary>
        public AmpsBox(AmpsBoxCommunicator communicator)
        {
            if (communicator == null)
            {
                throw new ArgumentNullException(nameof(communicator));
            }
            this.communicator = communicator;
            if (!this.communicator.IsOpen)
            {
                this.communicator.Open();
            }
            this.ClockFrequency = 16000000;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the clock frequency of the AMPS Box.
        /// </summary>   
        [DataMember]
        public int ClockFrequency { get; set; }

        [DataMember]
        public string Name { get; set; }
        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Returns a string representation of the current software configuration. 
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetConfig()
        {
            string ampsBoxData  = string.Empty;
            ampsBoxData         += string.Format("\tDevice Settings\n");

            ampsBoxData += "\n";
            ampsBoxData += string.Format("\tTable Settings\n");
            ampsBoxData += $"\t\tExt. Clock Freq: {this.ClockFrequency}\n";

            return ampsBoxData;
        }

        public async Task<Unit> SetDcBiasVoltage(string channel, int volts)
        {
           // AmpsMessage ampsMessage = new AmpsMessage("SDCB", "SDCB");
            var ampsmessage = Message.Create(AmpsCommand.SDCB, channel, volts.ToString());
            ampsmessage.WriteTo(communicator);
            var messagePacket = this.communicator.MessageSources;

            return await messagePacket.Select(bytes => Unit.Default).FirstAsync();
        }

        public async Task<int> GetDcBiasSetpoint(string channel)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetDcBiasReadback(string channel)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetDcBiasCurrentReadback(string channel)
        {
            throw new NotImplementedException();

        }

        public async Task<Unit> SetBoardDcBiasOffsetVoltage(int brdNumber, int offsetVolts)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetBoardDcBiasOffsetVoltage(int brdNumber)
        {
            throw new NotImplementedException();

        }

        public async Task<int> GetNumberDcBiasChannels()
        {
            throw new NotImplementedException();

        }

        public async Task<Unit> SetDigitalState(string channel, bool state)
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> PulseDigitalSignal(string channel)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> GetDigitalState(string channel)
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> SetDigitalDirection(string channel, DigitalDirection digitalDirection)
        {
            throw new NotImplementedException();
        }

        public async Task<DigitalDirection> GetDigitalDirection(string channel)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetNumberDigitalChannels()
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> SetPositiveHighVoltage(int volts)
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> SetNegativeHighVoltage(int volts)
        {
            throw new NotImplementedException();
        }

        public async Task<(double, double)> GetPositiveEsi()
        {
            throw new NotImplementedException();
        }

        public async Task<(double, double)> GetNegativeEsi()
        {
            throw new NotImplementedException();
        }

        public Task<Unit> TurnOnHeater()
        {
            throw new NotImplementedException();
        }

        public Task<Unit> TurnOffHeater()
        {
            throw new NotImplementedException();
        }

        public Task<Unit> SetTemperatureSetpoint(int temperature)
        {
            throw new NotImplementedException();
        }

        public Task<int> ReadTemperature()
        {
            throw new NotImplementedException();
        }

        public Task<Unit> SetPidGain(int gain)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetVersion()
        {
            var ampsmessage = Message.Create(AmpsCommand.GVER);
            ampsmessage.WriteTo(communicator);
            var messagePacket = this.communicator.MessageSources;

            return await messagePacket.Select(bytes => bytes).Where(x => !string.IsNullOrEmpty(x)).FirstAsync();
        }

        public async Task<ErrorCodes> GetError()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetName()
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> SetName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> Reset()
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> Save()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<string>> GetCommands()
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> SetSerialBaudRate(int baudRate)
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> SetFrequency(string address, int frequency)
        {
            // TODO: figure out if all values of frequency are already in kHz
            // if(frequency < 500 || frequency > 5000)
            throw new NotImplementedException();
        }

        public async Task<int> GetFrequencySetting(string address)
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> SetRfDriveSetting(string address, int drive)
        {
            if (drive < 0 || drive > 255)
            {
                throw new ArgumentOutOfRangeException(nameof(drive), "Range must be between 0 and 255");
            }
            throw new NotImplementedException();
        }

        public async Task<int> GetRfDriveSetting(string address)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetRfChannelNumber()
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> AbortTimeTable()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Starts execution of time table.
        /// </summary>
        /// <returns></returns>
        public async Task<Unit> StartTimeTable()
        {
            throw new NotImplementedException();
        }

        public string LastTable { get; private set; }

        /// <summary>
        /// Sets the table mode for the amps / mips box.
        /// </summary>
        public async Task<Unit> SetMode(Modes mode)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Stop the time table of the device.
        /// </summary>
        /// <returns></returns>
        public async Task<Unit> StopTable()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads the Table onto the device
        /// </summary>
        /// <param name="table">
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<Unit> LoadTimeTable(AmpsSignalTable table)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Tells the AMPS box which clock to use: external or internal
        /// </summary>
        /// <param name="clockType">
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<Unit> SetClock(ClockType clockType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Set the device trigger.
        /// </summary>
        /// <param name="startTriggerType"></param>
        /// <returns></returns>
        public async Task<Unit> SetTrigger(StartTriggerTypes startTriggerType)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}