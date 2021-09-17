// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protofiles/framework/thread_pool_executor.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Akihabara.Framework.Protobuf
{

    /// <summary>Holder for reflection information generated from protofiles/framework/thread_pool_executor.proto</summary>
    public static partial class ThreadPoolExecutorReflection
    {

        #region Descriptor
        /// <summary>File descriptor for protofiles/framework/thread_pool_executor.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static ThreadPoolExecutorReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "Ci9wcm90b2ZpbGVzL2ZyYW1ld29yay90aHJlYWRfcG9vbF9leGVjdXRvci5w",
                  "cm90bxIcYWtpaGFiYXJhLmZyYW1ld29yay5wcm90b2J1ZhoscHJvdG9maWxl",
                  "cy9mcmFtZXdvcmsvbWVkaWFwaXBlX29wdGlvbnMucHJvdG8iogMKGVRocmVh",
                  "ZFBvb2xFeGVjdXRvck9wdGlvbnMSEwoLbnVtX3RocmVhZHMYASABKAUSEgoK",
                  "c3RhY2tfc2l6ZRgCIAEoBRIbChNuaWNlX3ByaW9yaXR5X2xldmVsGAMgASgF",
                  "EnMKHXJlcXVpcmVfcHJvY2Vzc29yX3BlcmZvcm1hbmNlGAQgASgOMkwuYWtp",
                  "aGFiYXJhLmZyYW1ld29yay5wcm90b2J1Zi5UaHJlYWRQb29sRXhlY3V0b3JP",
                  "cHRpb25zLlByb2Nlc3NvclBlcmZvcm1hbmNlEhoKEnRocmVhZF9uYW1lX3By",
                  "ZWZpeBgFIAEoCSI1ChRQcm9jZXNzb3JQZXJmb3JtYW5jZRIKCgZOT1JNQUwQ",
                  "ABIHCgNMT1cQARIICgRISUdIEAIydwoDZXh0Ei4uYWtpaGFiYXJhLmZyYW1l",
                  "d29yay5wcm90b2J1Zi5NZWRpYVBpcGVPcHRpb25zGJPT9UogASgLMjcuYWtp",
                  "aGFiYXJhLmZyYW1ld29yay5wcm90b2J1Zi5UaHJlYWRQb29sRXhlY3V0b3JP",
                  "cHRpb25z"));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { global::Akihabara.Framework.Protobuf.MediapipeOptionsReflection.Descriptor, },
                new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Akihabara.Framework.Protobuf.ThreadPoolExecutorOptions), global::Akihabara.Framework.Protobuf.ThreadPoolExecutorOptions.Parser, new[]{ "NumThreads", "StackSize", "NicePriorityLevel", "RequireProcessorPerformance", "ThreadNamePrefix" }, null, new[]{ typeof(global::Akihabara.Framework.Protobuf.ThreadPoolExecutorOptions.Types.ProcessorPerformance) }, new pb::Extension[] { global::Akihabara.Framework.Protobuf.ThreadPoolExecutorOptions.Extensions.Ext }, null)
                }));
        }
        #endregion

    }
    #region Messages
    public sealed partial class ThreadPoolExecutorOptions : pb::IMessage<ThreadPoolExecutorOptions>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
#endif
    {
        private static readonly pb::MessageParser<ThreadPoolExecutorOptions> _parser = new pb::MessageParser<ThreadPoolExecutorOptions>(() => new ThreadPoolExecutorOptions());
        private pb::UnknownFieldSet _unknownFields;
        private int _hasBits0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<ThreadPoolExecutorOptions> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::Akihabara.Framework.Protobuf.ThreadPoolExecutorReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ThreadPoolExecutorOptions()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ThreadPoolExecutorOptions(ThreadPoolExecutorOptions other) : this()
        {
            _hasBits0 = other._hasBits0;
            numThreads_ = other.numThreads_;
            stackSize_ = other.stackSize_;
            nicePriorityLevel_ = other.nicePriorityLevel_;
            requireProcessorPerformance_ = other.requireProcessorPerformance_;
            threadNamePrefix_ = other.threadNamePrefix_;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ThreadPoolExecutorOptions Clone()
        {
            return new ThreadPoolExecutorOptions(this);
        }

        /// <summary>Field number for the "num_threads" field.</summary>
        public const int NumThreadsFieldNumber = 1;
        private readonly static int NumThreadsDefaultValue = 0;

        private int numThreads_;
        /// <summary>
        /// Number of threads for running calculators in multithreaded mode.
        ///
        /// When ThreadPoolExecutorOptions is used in the ExecutorOptions for the
        /// default executor with the executor type unspecified, the num_threads
        /// field is allowed to be -1 or 0.  If not specified or -1, the scheduler
        /// will pick an appropriate number of threads depending on the number of
        /// available processors.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int NumThreads
        {
            get { if ((_hasBits0 & 1) != 0) { return numThreads_; } else { return NumThreadsDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                numThreads_ = value;
            }
        }
        /// <summary>Gets whether the "num_threads" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasNumThreads
        {
            get { return (_hasBits0 & 1) != 0; }
        }
        /// <summary>Clears the value of the "num_threads" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearNumThreads()
        {
            _hasBits0 &= ~1;
        }

        /// <summary>Field number for the "stack_size" field.</summary>
        public const int StackSizeFieldNumber = 2;
        private readonly static int StackSizeDefaultValue = 0;

        private int stackSize_;
        /// <summary>
        /// Make all worker threads have the specified stack size (in bytes).
        /// NOTE: The stack_size option may not be implemented on some platforms.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int StackSize
        {
            get { if ((_hasBits0 & 2) != 0) { return stackSize_; } else { return StackSizeDefaultValue; } }
            set
            {
                _hasBits0 |= 2;
                stackSize_ = value;
            }
        }
        /// <summary>Gets whether the "stack_size" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasStackSize
        {
            get { return (_hasBits0 & 2) != 0; }
        }
        /// <summary>Clears the value of the "stack_size" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearStackSize()
        {
            _hasBits0 &= ~2;
        }

        /// <summary>Field number for the "nice_priority_level" field.</summary>
        public const int NicePriorityLevelFieldNumber = 3;
        private readonly static int NicePriorityLevelDefaultValue = 0;

        private int nicePriorityLevel_;
        /// <summary>
        /// The nice priority level of the worker threads.
        /// The nice priority level is 0 by default, and lower value means higher
        /// priority. The valid thread nice priority level value range varies by OS.
        /// Refer to system documentation for more details.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int NicePriorityLevel
        {
            get { if ((_hasBits0 & 4) != 0) { return nicePriorityLevel_; } else { return NicePriorityLevelDefaultValue; } }
            set
            {
                _hasBits0 |= 4;
                nicePriorityLevel_ = value;
            }
        }
        /// <summary>Gets whether the "nice_priority_level" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasNicePriorityLevel
        {
            get { return (_hasBits0 & 4) != 0; }
        }
        /// <summary>Clears the value of the "nice_priority_level" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearNicePriorityLevel()
        {
            _hasBits0 &= ~4;
        }

        /// <summary>Field number for the "require_processor_performance" field.</summary>
        public const int RequireProcessorPerformanceFieldNumber = 4;
        private readonly static global::Akihabara.Framework.Protobuf.ThreadPoolExecutorOptions.Types.ProcessorPerformance RequireProcessorPerformanceDefaultValue = global::Akihabara.Framework.Protobuf.ThreadPoolExecutorOptions.Types.ProcessorPerformance.Normal;

        private global::Akihabara.Framework.Protobuf.ThreadPoolExecutorOptions.Types.ProcessorPerformance requireProcessorPerformance_;
        /// <summary>
        /// The performance hint of the processor(s) that the threads will be bound to.
        /// Framework will make the best effort to run the threads on the specific
        /// processors based on the performance hint.
        /// The attempt may fail for various reasons. Success isn't guaranteed.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Akihabara.Framework.Protobuf.ThreadPoolExecutorOptions.Types.ProcessorPerformance RequireProcessorPerformance
        {
            get { if ((_hasBits0 & 8) != 0) { return requireProcessorPerformance_; } else { return RequireProcessorPerformanceDefaultValue; } }
            set
            {
                _hasBits0 |= 8;
                requireProcessorPerformance_ = value;
            }
        }
        /// <summary>Gets whether the "require_processor_performance" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasRequireProcessorPerformance
        {
            get { return (_hasBits0 & 8) != 0; }
        }
        /// <summary>Clears the value of the "require_processor_performance" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearRequireProcessorPerformance()
        {
            _hasBits0 &= ~8;
        }

        /// <summary>Field number for the "thread_name_prefix" field.</summary>
        public const int ThreadNamePrefixFieldNumber = 5;
        private readonly static string ThreadNamePrefixDefaultValue = "";

        private string threadNamePrefix_;
        /// <summary>
        /// Name prefix for worker threads, which can be useful for debugging
        /// multithreaded applications.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string ThreadNamePrefix
        {
            get { return threadNamePrefix_ ?? ThreadNamePrefixDefaultValue; }
            set
            {
                threadNamePrefix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }
        /// <summary>Gets whether the "thread_name_prefix" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasThreadNamePrefix
        {
            get { return threadNamePrefix_ != null; }
        }
        /// <summary>Clears the value of the "thread_name_prefix" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearThreadNamePrefix()
        {
            threadNamePrefix_ = null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other)
        {
            return Equals(other as ThreadPoolExecutorOptions);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(ThreadPoolExecutorOptions other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (NumThreads != other.NumThreads) return false;
            if (StackSize != other.StackSize) return false;
            if (NicePriorityLevel != other.NicePriorityLevel) return false;
            if (RequireProcessorPerformance != other.RequireProcessorPerformance) return false;
            if (ThreadNamePrefix != other.ThreadNamePrefix) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode()
        {
            int hash = 1;
            if (HasNumThreads) hash ^= NumThreads.GetHashCode();
            if (HasStackSize) hash ^= StackSize.GetHashCode();
            if (HasNicePriorityLevel) hash ^= NicePriorityLevel.GetHashCode();
            if (HasRequireProcessorPerformance) hash ^= RequireProcessorPerformance.GetHashCode();
            if (HasThreadNamePrefix) hash ^= ThreadNamePrefix.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (HasNumThreads) {
        output.WriteRawTag(8);
        output.WriteInt32(NumThreads);
      }
      if (HasStackSize) {
        output.WriteRawTag(16);
        output.WriteInt32(StackSize);
      }
      if (HasNicePriorityLevel) {
        output.WriteRawTag(24);
        output.WriteInt32(NicePriorityLevel);
      }
      if (HasRequireProcessorPerformance) {
        output.WriteRawTag(32);
        output.WriteEnum((int) RequireProcessorPerformance);
      }
      if (HasThreadNamePrefix) {
        output.WriteRawTag(42);
        output.WriteString(ThreadNamePrefix);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
        {
            if (HasNumThreads)
            {
                output.WriteRawTag(8);
                output.WriteInt32(NumThreads);
            }
            if (HasStackSize)
            {
                output.WriteRawTag(16);
                output.WriteInt32(StackSize);
            }
            if (HasNicePriorityLevel)
            {
                output.WriteRawTag(24);
                output.WriteInt32(NicePriorityLevel);
            }
            if (HasRequireProcessorPerformance)
            {
                output.WriteRawTag(32);
                output.WriteEnum((int)RequireProcessorPerformance);
            }
            if (HasThreadNamePrefix)
            {
                output.WriteRawTag(42);
                output.WriteString(ThreadNamePrefix);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(ref output);
            }
        }
#endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize()
        {
            int size = 0;
            if (HasNumThreads)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumThreads);
            }
            if (HasStackSize)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(StackSize);
            }
            if (HasNicePriorityLevel)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(NicePriorityLevel);
            }
            if (HasRequireProcessorPerformance)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)RequireProcessorPerformance);
            }
            if (HasThreadNamePrefix)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(ThreadNamePrefix);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(ThreadPoolExecutorOptions other)
        {
            if (other == null)
            {
                return;
            }
            if (other.HasNumThreads)
            {
                NumThreads = other.NumThreads;
            }
            if (other.HasStackSize)
            {
                StackSize = other.StackSize;
            }
            if (other.HasNicePriorityLevel)
            {
                NicePriorityLevel = other.NicePriorityLevel;
            }
            if (other.HasRequireProcessorPerformance)
            {
                RequireProcessorPerformance = other.RequireProcessorPerformance;
            }
            if (other.HasThreadNamePrefix)
            {
                ThreadNamePrefix = other.ThreadNamePrefix;
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            NumThreads = input.ReadInt32();
            break;
          }
          case 16: {
            StackSize = input.ReadInt32();
            break;
          }
          case 24: {
            NicePriorityLevel = input.ReadInt32();
            break;
          }
          case 32: {
            RequireProcessorPerformance = (global::Akihabara.Framework.Protobuf.ThreadPoolExecutorOptions.Types.ProcessorPerformance) input.ReadEnum();
            break;
          }
          case 42: {
            ThreadNamePrefix = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 8:
                        {
                            NumThreads = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            StackSize = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            NicePriorityLevel = input.ReadInt32();
                            break;
                        }
                    case 32:
                        {
                            RequireProcessorPerformance = (global::Akihabara.Framework.Protobuf.ThreadPoolExecutorOptions.Types.ProcessorPerformance)input.ReadEnum();
                            break;
                        }
                    case 42:
                        {
                            ThreadNamePrefix = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the ThreadPoolExecutorOptions message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Types
        {
            /// <summary>
            /// Processor performance enum.
            /// </summary>
            public enum ProcessorPerformance
            {
                [pbr::OriginalName("NORMAL")] Normal = 0,
                [pbr::OriginalName("LOW")] Low = 1,
                [pbr::OriginalName("HIGH")] High = 2,
            }

        }
        #endregion

        #region Extensions
        /// <summary>Container for extensions for other messages declared in the ThreadPoolExecutorOptions message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Extensions
        {
            public static readonly pb::Extension<global::Akihabara.Framework.Protobuf.MediaPipeOptions, global::Akihabara.Framework.Protobuf.ThreadPoolExecutorOptions> Ext =
              new pb::Extension<global::Akihabara.Framework.Protobuf.MediaPipeOptions, global::Akihabara.Framework.Protobuf.ThreadPoolExecutorOptions>(157116819, pb::FieldCodec.ForMessage(1256934554, global::Akihabara.Framework.Protobuf.ThreadPoolExecutorOptions.Parser));
        }
        #endregion

    }

    #endregion

}

#endregion Designer generated code