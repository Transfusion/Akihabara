// Copyright 2021 (c) homuler and The Vignette Authors
// Licensed under MIT
// See LICENSE for details

using System;
using Akihabara.Core;
using Akihabara.Framework.Port;
using Akihabara.Native;
using UnsafeNativeMethods = Akihabara.Native.Framework.UnsafeNativeMethods;

namespace Akihabara.Framework.Packet
{
    public abstract class Packet<T> : MpResourceHandle
    {
        public Packet() : base()
        {
            UnsafeNativeMethods.mp_Packet__(out var ptr);
            this.Ptr = ptr;
        }

        public Packet(IntPtr ptr, bool isOwner = true) : base(ptr, isOwner)
        {
        }

        public abstract T Get();

        public abstract StatusOr<T> Consume();

        public Packet<T> At(Timestamp timestamp)
        {
            UnsafeNativeMethods.mp_Packet__At__Rt(MpPtr, timestamp.MpPtr, out var packetPtr).Assert();

            GC.KeepAlive(timestamp);

            return (Packet<T>)Activator.CreateInstance(this.GetType(), packetPtr, true);
        }

        public Status ValidateAsProtoMessageLite()
        {
            UnsafeNativeMethods.mp_Packet__ValidateAsProtoMessageLite(MpPtr, out var statusPtr).Assert();

            GC.KeepAlive(this);
            return new Status(statusPtr);
        }

        public abstract Status ValidateAsType();

        public Timestamp Timestamp()
        {
            UnsafeNativeMethods.mp_Packet__Timestamp(MpPtr, out var timestampPtr).Assert();

            GC.KeepAlive(this);
            return new Timestamp(timestampPtr);
        }

        public string DebugString() => MarshalStringFromNative(UnsafeNativeMethods.mp_Packet__DebugString);

        public string RegisteredTypeName()
        {
            var typeName = MarshalStringFromNative(UnsafeNativeMethods.mp_Packet__RegisteredTypeName);

            return typeName ?? "";
        }

        public string DebugTypeName() => MarshalStringFromNative(UnsafeNativeMethods.mp_Packet__DebugTypeName);

        protected override void DeleteMpPtr()
        {
            UnsafeNativeMethods.mp_Packet__delete(Ptr);
        }
    }
}
