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
    public class RectVectorPacket : Packet<List<Rect>>
    {
        public RectVectorPacket() : base() { }
        public RectVectorPacket(IntPtr ptr, bool isOwner = true) : base(ptr, isOwner) { }

        public override List<Rect> Get()
        {
            UnsafeNativeMethods.mp_Packet__GetRectVector(MpPtr, out var serializedProtoVectorPtr).Assert();
            GC.KeepAlive(this);

            var rects = External.Protobuf.DeserializeProtoVector<Rect>(serializedProtoVectorPtr, Rect.Parser);
            UnsafeNativeMethods.mp_api_SerializedProtoVector__delete(serializedProtoVectorPtr);

            return rects;
        }

        public override StatusOr<List<Rect>> Consume()
        {
            throw new NotSupportedException();
        }

        public override Status ValidateAsType()
        {
            throw new NotSupportedException();
        }
    }
}
