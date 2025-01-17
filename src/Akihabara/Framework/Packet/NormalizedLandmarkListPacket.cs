// Copyright 2021 (c) homuler and The Vignette Authors
// Licensed under MIT
// See LICENSE for details

using Akihabara.External;
using Akihabara.Framework.Port;
using Akihabara.Framework.Protobuf;
using Akihabara.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akihabara.Framework.Packet
{
    public class NormalizedLandmarkListPacket : Packet<NormalizedLandmarkList>
    {
        public NormalizedLandmarkListPacket() : base() { }
        public NormalizedLandmarkListPacket(IntPtr ptr, bool isOwner = true) : base(ptr, isOwner) { }

        public override NormalizedLandmarkList Get()
        {
            UnsafeNativeMethods.mp_Packet__GetNormalizedLandmarkList(MpPtr, out var serializedProtoPtr).Assert();
            GC.KeepAlive(this);

            var normalizedLandmarkList = External.Protobuf.DeserializeProto<NormalizedLandmarkList>(serializedProtoPtr, NormalizedLandmarkList.Parser);
            UnsafeNativeMethods.mp_api_SerializedProto__delete(serializedProtoPtr);

            return normalizedLandmarkList;
        }

        public override StatusOr<NormalizedLandmarkList> Consume()
        {
            throw new NotSupportedException();
        }

        public override Status ValidateAsType()
        {
            throw new NotSupportedException();
        }
    }
}
