// Copyright 2021 (c) homuler and The Vignette Authors
// Licensed under MIT
// See LICENSE for details

using System;
using System.Runtime.InteropServices;

namespace Akihabara.Native.Gpu
{
    public partial class UnsafeNativeMethods : NativeMethods
    {
        #region GlContext

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern void mp_SharedGlContext__delete(IntPtr sharedGlContext);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern void mp_SharedGlContext__reset(IntPtr sharedGlContext);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_GlContext_GetCurrent(out IntPtr sharedGlContext);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_GlContext_Create__P_b([MarshalAs(UnmanagedType.I1)] bool createThread,
            out IntPtr statusOrSharedGlContext);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_GlContext_Create__Rgc_b(
            IntPtr shareContext, [MarshalAs(UnmanagedType.I1)] bool createThread, out IntPtr statusOrSharedGlContext);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_GlContext_Create__ui_b(
            UInt32 shareContext, [MarshalAs(UnmanagedType.I1)] bool createThread, out IntPtr statusOrSharedGlContext);


        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_GlContext_Create__Pes_b(
            IntPtr sharegroup, [MarshalAs(UnmanagedType.I1)] bool createThread, out IntPtr statusOrSharedGlContext);

        #endregion

        #region GlSyncToken

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern void mp_GlSyncToken__delete(IntPtr glSyncToken);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern void mp_GlSyncToken__reset(IntPtr glSyncToken);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_GlSyncPoint__Wait(IntPtr glSyncPoint);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_GlSyncPoint__WaitOnGpu(IntPtr glSyncPoint);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_GlSyncPoint__IsReady(IntPtr glSyncPoint, out bool value);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_GlSyncPoint__GetContext(IntPtr glSyncPoint, out IntPtr sharedGlContext);

        #endregion
    }
}
