// Copyright 2021 (c) homuler and The Vignette Authors
// Licensed under MIT
// See LICENSE for details

using NUnit.Framework;
using Akihabara.Framework;
using Akihabara.Framework.Port;
using Akihabara.Framework.Packet;

namespace Akihabara.Tests.Framework.Packet
{
    [TestFixture]
    public class PacketTest
    {
        #region #At
        [Test]
        public void At_ShouldReturnNewPacketWithTimestamp()
        {
            var timestamp = new Timestamp(1);
            var packet = new BoolPacket(true).At(timestamp);

            Assert.True(packet.Get());
            Assert.AreEqual(packet.Timestamp(), timestamp);

            var newTimestamp = new Timestamp(2);
            var newPacket = packet.At(newTimestamp);

            Assert.IsInstanceOf<BoolPacket>(newPacket);
            Assert.True(newPacket.Get());
            Assert.AreEqual(newPacket.Timestamp(), newTimestamp);

            Assert.True(packet.Get());
            Assert.AreEqual(packet.Timestamp(), timestamp);
        }
        #endregion

        #region #DebugString
        [Test]
        public void DebugString_ShouldReturnDebugString_When_InstantiatedWithDefaultConstructor()
        {
            var packet = new BoolPacket();

            Assert.AreEqual(packet.DebugString(), "mediapipe::Packet with timestamp: Timestamp::Unset() and no data");
        }
        #endregion

        #region #DebugTypeName
        [Test]
        public void DebugTypeName_ShouldReturnTypeName_When_ValueIsNotSet()
        {
            var packet = new BoolPacket();

            Assert.AreEqual(packet.DebugTypeName(), "{empty}");
        }
        #endregion

        #region #RegisteredTypeName
        [Test]
        public void RegisteredTypeName_ShouldReturnEmptyString()
        {
            var packet = new BoolPacket();

            Assert.AreEqual(packet.RegisteredTypeName(), "");
        }
        #endregion

        #region #ValidateAsProtoMessageLite
        [Test]
        public void ValidateAsProtoMessageLite_ShouldReturnInvalidArgument_When_ValueIsBool()
        {
            var packet = new BoolPacket(true);

            Assert.AreEqual(packet.ValidateAsProtoMessageLite().Code, Status.StatusCode.InvalidArgument);
        }
        #endregion
    }
}
