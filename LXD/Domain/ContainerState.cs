﻿using System.Collections.Generic;

namespace LXD.Domain
{
    public class ContainerState : RemoteObject
    {
        public string Status;
        public int StatusCode;
        public Dictionary<string, StateDisk> Disk;
        public StateMemory Memory;
        public Dictionary<string, StateNetwork> Network;
        public long Pid;
        public long Processes;

        public struct StateDisk
        {
            public long Usage;
        }

        public struct StateMemory
        {
            public long Usage;
            public long UsagePeak;
            public long SwapUsage;
            public long SwapUsagePeak;
        }

        public struct StateNetwork
        {
            public NetworkAddress[] Addresses;
            public NetworkCounter[] Counters;

            public struct NetworkAddress
            {
                public string Family;
                public string Address;
                public string Netmask;
                public string Scope;
            }

            public struct NetworkCounter
            {
                public long BytesReceived;
                public long BytesSent;
                public long PacketsReceived;
                public long PacketsSent;
            }
        }
    }
}
