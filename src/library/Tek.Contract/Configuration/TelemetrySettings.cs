﻿namespace Tek.Contract
{
    public class TelemetrySettings
    {
        public LoggingSettings Logging { get; set; }
        public MonitoringSettings Monitoring { get; set; }
        public ThrottlingSettings Throttling { get; set; }
    }
}