﻿using System;
using System.Management;
using NUnit.Framework;

namespace AmpsBoxTests.ManagementObjectTests
{
    [TestFixture]
    public class ManagementObjectTests
    {
        [Test]
        public void Test1()
        {
             ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * from Win32_PnPEntity WHERE Name LIKE '%COM%'");
            foreach (var device in searcher.Get())
            {
                if (device.GetPropertyValue("Name").ToString().Contains("(COM"))
                {
                    var thing = device.GetPropertyValue("StatusInfo");

                    Console.WriteLine(thing);
                }
            }
        }
    }
}