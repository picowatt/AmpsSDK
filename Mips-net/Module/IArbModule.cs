﻿using System.Collections.Generic;
using System.Reactive;
using System.Threading.Tasks;
using Mips_net.Device;


namespace Mips_net.Module
{
    public interface IArbModule
    {
        Task<Unit> SetArbMode(string module, ArbMode mode);
        Task<ArbMode> GetArbMode(string module);
        Task<Unit> SetArbFrequency(string module, double frequencyInHz);
        Task<int> GetArbFrequency(string module);
        Task<Unit> SetArbVoltsPeakToPeak(string module, double peakToPeakVolts);
        Task<int> GetArbVoltsPeakToPeak(string module);
        Task<Unit> SetArbOffsetVoltage(string module, double value);
        Task<int> GetArbOffsetVoltage(string module);
        Task<Unit> SetAuxOutputVoltage(string module, double value);
        Task<int> GetAuxOutputVoltage(string module);
        Task<Unit> StopArb(string module);
        Task<Unit> StartArb(string module);
        Task<Unit> SetTwaveDirection(string module, TWaveDirection direction);
        Task<TWaveDirection> GetTwaveDirection(string module);
        Task<Unit> SetWaveform(string module, IEnumerable<int> points);
	    Task<IEnumerable<int>> GetWaveform(string module);
	    Task<Unit> SetWaveformType(string module, ArbWaveForms waveForms);
	    Task<ArbWaveForms> GetWaveformType(string module);
	    Task<Unit> SetBufferLength(string module, int length);
	    Task<int> GetBufferLength(string module);
	    Task<Unit> SetBufferRepeat(string module, int count);
	    Task<int> GetBufferRepeat(string module);
	    Task<Unit> SetAllChannelValue(string module, int value);
	    Task<Unit> SetChannelValue(string module, string channle, int value);
	    Task<Unit> SetChannelRange(string module, string channel, int start, int stop, int range);
    }
}