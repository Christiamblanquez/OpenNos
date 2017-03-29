﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenNos.Core;

namespace OpenNos.GameObject
{
    [PacketHeader("wp")]
    public class WpPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public short X { get; set; }

        [PacketIndex(1)]
        public short Y { get; set; }

        [PacketIndex(2)]
        public short Id { get; set; }

        [PacketIndex(3)]
        public short Unknown { get; set; }

        [PacketIndex(4)]
        public short LevelMinimum { get; set; }
        
        [PacketIndex(5)]
        public short LevelMaximum { get; set; }

        #endregion
    }
}