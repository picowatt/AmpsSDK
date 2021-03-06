﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AmpsBoxSignalTableDisplayFormatter.cs" company="">
//   
// </copyright>
// <summary>
//   TODO The amps box signal Table display formatter.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AmpsBoxSdk.Data
{
    using System;

    /// <summary>
    /// TODO The amps box signal Table display formatter.
    /// </summary>
    public class AmpsBoxSignalTableDisplayFormatter : ISignalTableFormatter<AmpsSignalTable, double>
    {
        #region Public Methods and Operators

        /// <summary>
        /// Formats a Table into the AMPS box readable time Table.
        /// </summary>
        /// <param name="table">
        /// </param>
        /// <param name="converter">
        /// The converter.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string FormatTable(AmpsSignalTable table, ITimeUnitConverter<double> converter)
        {
            //IEnumerable<double> times = table.StartTimes;
            //times = times.OrderBy(x => x);
            //StringBuilder timeBuilder = new StringBuilder();

            //TimeUnits units = TimeUnits.Seconds;

            //foreach (double time in times)
            //{
            //    IEnumerable<SignalElement> signals = table.GetSignals(time);

            //    timeBuilder.AppendFormat("\t-----------------------------------------------\n");

            //    foreach (var signal in signals)
            //    {
            //        double xTime = converter.ConvertTo(table.ExecutionData.TimeUnits, units, signal.StartTime);

            //        var output = signal as AnalogStepElement;
            //        if (output != null)
            //        {
            //            timeBuilder.AppendFormat("\t{0}\t{1}\t{2:F0}\n", xTime, signal.Channel, output.Value);
            //        }
            //    }
            //}

            //string eventData = timeBuilder.ToString();

            //return string.Format(
            //    "Table: {0}\n\tLength:\t{1}\n\tTime Units:\t{2}\n{3}", 
            //    table.ExecutionData.Name, 
            //    converter.ConvertTo(table.ExecutionData.TimeUnits, units, table.Length), 
            //    units, 
            //    eventData);

            throw new NotImplementedException();
        }

        #endregion
    }
}