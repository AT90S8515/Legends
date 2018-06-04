﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Legends.Core.IO;

namespace Legends.Core.Protocol.Messages.Extended
{
    public class DieMessage : BaseMessage
    {
        public static PacketCmd PACKET_CMD = PacketCmd.PKT_S2C_Die_MapView;
        public override PacketCmd Cmd => PACKET_CMD;

        public static Channel CHANNEL = Channel.CHL_S2C;
        public override Channel Channel => CHANNEL;

        public int sourceNetId;

        public DieMessage()
        {

        }
        public DieMessage(int sourceNetId,int targetNetId):base(targetNetId)
        {
            this.sourceNetId = sourceNetId;
        }
        public override void Deserialize(LittleEndianReader reader)
        {
            throw new NotImplementedException();
        }

        public override void Serialize(LittleEndianWriter writer)
        {
            writer.WriteInt((int)0);
            writer.WriteByte((byte)0);
            writer.WriteInt(sourceNetId);
            writer.WriteByte((byte)0); // unk
            writer.WriteByte((byte)7); // unk
            writer.WriteInt((int)0); // Flags?
        }
    }
}