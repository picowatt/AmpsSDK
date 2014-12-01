﻿using System;
using AmpsBoxSdk.Commands;
using AmpsBoxSdk.Devices;
using FalkorSDK.Data.Signals;
using FalkorSDK.Data.Events;

namespace AmpsBoxTests.Devices
{
    using System.IO.Ports;

    using FalkorSDK.Channel;
    using FalkorSDK.IO.Ports;

    using NUnit.Framework;

    using Xunit;

    [TestFixture]
    class DeviceCommandTest
    {
        [Test]
        public async void CommandText()
        {
            AmpsCommandProvider provider = AmpsCommandFactory.CreateCommandProvider("2.0b");

            Console.WriteLine("Testing Commands: {0}", provider.GetSupportedVersions());

            AmpsBox ampsBox = new AmpsBox();
            var fsp = new FalkorSerialPort(new SerialPort("COM12") { BaudRate = 19200, Handshake = Handshake.XOnXOff, NewLine = "\n", Parity = Parity.Even });
            ampsBox.Port = fsp;

           ampsBox.Open();
            for (int i = 0; i < 5; i++)
            {
                var version = await ampsBox.GetVersion();
                Console.WriteLine(version);
            }
        }

        [Test]
        public async void CommandSignalTable()
        {
            AmpsCommandProvider provider = AmpsCommandFactory.CreateCommandProvider("2.0b");

            Console.WriteLine("Testing Commands: {0}", provider.GetSupportedVersions());
            AmpsBox ampsBox = new AmpsBox();
            var fsp = new FalkorSerialPort(new SerialPort("COM12") { BaudRate = 19200, Handshake = Handshake.XOnXOff, NewLine = "\n", Parity = Parity.Even });
            ampsBox.Port = fsp;
            ampsBox.Open();
           await ampsBox.LoadTimeTableAsync(new SignalTable());
        }
    }
}
