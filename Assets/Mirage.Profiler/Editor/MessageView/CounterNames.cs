﻿namespace Mirage.NetworkProfiler.ModuleGUI.MessageView
{
    internal struct CounterNames
    {
        public readonly string Count;
        public readonly string Bytes;
        public readonly string PerSecond;

        public CounterNames(string count, string bytes, string perSecond)
        {
            Count = count;
            Bytes = bytes;
            PerSecond = perSecond;
        }
    }
}
