// Copyright 2021 (c) homuler and The Vignette Authors
// Licensed under MIT
// See LICENSE for details

using Akihabara.Gpu;
using NUnit.Framework;

namespace Tests
{
    public class GpuResourcesTest
    {
        #region Create
        [Test, GpuOnly]
        public void Create_ShouldReturnStatusOrGpuResources()
        {
            var statusOrGpuResources = GpuResources.Create();

            Assert.True(statusOrGpuResources.Ok);
        }
        #endregion

        #region IsDisposed
        [Test, GpuOnly]
        public void IsDisposed_ShouldReturnFalse_When_NotDisposedYet()
        {
            var gpuResources = GpuResources.Create().Value();

            Assert.False(gpuResources.IsDisposed);
        }

        [Test, GpuOnly]
        public void IsDisposed_ShouldReturnTrue_When_AlreadyDisposed()
        {
            var gpuResources = GpuResources.Create().Value();
            gpuResources.Dispose();

            Assert.True(gpuResources.IsDisposed);
        }
        #endregion
    }
}
