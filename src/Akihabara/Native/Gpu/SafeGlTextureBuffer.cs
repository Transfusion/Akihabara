// Copyright 2021 (c) homuler and The Vignette Authors
// Licensed under MIT
// See LICENSE for details

using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using Akihabara.Gpu;

namespace Akihabara.Native.Gpu
{
    public partial class SafeNativeMethods : NativeMethods
    {
        #region GlTextureBuffer
        [Pure, DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern UInt32 mp_GlTextureBuffer__name(IntPtr glTextureBuffer);

        [Pure, DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern UInt32 mp_GlTextureBuffer__target(IntPtr glTextureBuffer);

        [Pure, DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern int mp_GlTextureBuffer__width(IntPtr glTextureBuffer);

        [Pure, DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern int mp_GlTextureBuffer__height(IntPtr glTextureBuffer);

        [Pure, DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern GpuBufferFormat mp_GlTextureBuffer__format(IntPtr glTextureBuffer);

        [Pure, DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern IntPtr mp_GlTextureBuffer__GetProducerContext(IntPtr glTextureBuffer);
        #endregion

        #region SharedGlTextureBuffer
        [Pure, DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern IntPtr mp_SharedGlTextureBuffer__get(IntPtr glTextureBuffer);
        #endregion        
    }
}
