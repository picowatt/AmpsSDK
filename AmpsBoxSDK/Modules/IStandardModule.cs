﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Reactive;
using AmpsBoxSdk.Devices;

namespace AmpsBoxSdk.Modules
{
    [InheritedExport]
    public interface IStandardModule
    {
        IObservable<string> GetVersion();
        IObservable<ErrorCodes> GetError();
        IObservable<string> GetName();
        IObservable<Unit> SetName(string name);
        IObservable<Unit> Reset();
        IObservable<Unit> Save();
        IObservable<IEnumerable<string>>  GetCommands();
        IObservable<Unit> SetSerialBaudRate(int baudRate);
    }
}