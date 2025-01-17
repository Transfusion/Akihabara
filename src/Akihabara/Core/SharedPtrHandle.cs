// Copyright 2021 (c) homuler and The Vignette Authors
// Licensed under MIT
// See LICENSE for details

using System;

namespace Akihabara.Core
{
    public abstract class SharedPtrHandle : MpResourceHandle
    {
        public SharedPtrHandle(IntPtr ptr, bool isOwner = true) : base(ptr, isOwner) { }

        /// <summary>
        /// Get the owning pointer
        /// </summary>
        public abstract IntPtr Get();

        /// <summary>
        /// Release the owning pointer
        /// </summary>
        public abstract void Reset();
    }
}
