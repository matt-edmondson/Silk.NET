// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    public static class CLOverloads
    {
        public static unsafe nint CreateBufferWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateBufferWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateBufferWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateBufferWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, errcode_ret);
        }

        public static unsafe nint CreateBufferWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateBufferWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateBufferWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, image_format, image_desc, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, image_format, image_desc, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, image_format, image_desc, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, image_format, in image_desc.GetPinnableReference(), host_ptr, errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, image_format, in image_desc.GetPinnableReference(), host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, image_format, in image_desc.GetPinnableReference(), out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, image_format, in image_desc.GetPinnableReference(), out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, in image_format.GetPinnableReference(), image_desc, host_ptr, errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, in image_format.GetPinnableReference(), image_desc, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, in image_format.GetPinnableReference(), image_desc, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, in image_format.GetPinnableReference(), image_desc, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), host_ptr, errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, image_format, image_desc, host_ptr, errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, image_format, image_desc, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, image_format, image_desc, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, image_format, image_desc, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), host_ptr, errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, host_ptr, errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), host_ptr, errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImageWithProperties<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImageWithProperties(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe int SetContextDestructorCallback<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetContextDestructorCallback(context, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int SetProgramReleaseCallback<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetProgramReleaseCallback(program, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int SetProgramSpecializationConstant<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint spec_id, [Flow(FlowDirection.In)] nuint spec_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> spec_value) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetProgramSpecializationConstant(program, spec_id, spec_size, in spec_value.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithIL(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] void* il, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithIL(context, il, length, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithIL<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<T0> il, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateProgramWithIL(context, in il.GetPinnableReference(), length, errcode_ret);
        }

        public static unsafe nint CreateProgramWithIL<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<T0> il, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateProgramWithIL(context, in il.GetPinnableReference(), length, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, svm_pointers, sizes, flags, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, svm_pointers, sizes, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, svm_pointers, sizes, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, svm_pointers, in sizes.GetPinnableReference(), flags, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, svm_pointers, in sizes.GetPinnableReference(), flags, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, svm_pointers, in sizes.GetPinnableReference(), flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, svm_pointers, in sizes.GetPinnableReference(), flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, in svm_pointers, sizes, flags, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, in svm_pointers, sizes, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, in svm_pointers, sizes, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, in svm_pointers, in sizes.GetPinnableReference(), flags, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, in svm_pointers, in sizes.GetPinnableReference(), flags, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, in svm_pointers, in sizes.GetPinnableReference(), flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmigrateMem(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmigrateMem(command_queue, num_svm_pointers, in svm_pointers, in sizes.GetPinnableReference(), flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetDeviceAndHostTimer(this CL thisApi, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.Out)] ulong* device_timestamp, [Flow(FlowDirection.Out)] Span<ulong> host_timestamp)
        {
            // SpanOverloader
            return thisApi.GetDeviceAndHostTimer(device, device_timestamp, out host_timestamp.GetPinnableReference());
        }

        public static unsafe int GetDeviceAndHostTimer(this CL thisApi, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.Out)] Span<ulong> device_timestamp, [Flow(FlowDirection.Out)] ulong* host_timestamp)
        {
            // SpanOverloader
            return thisApi.GetDeviceAndHostTimer(device, out device_timestamp.GetPinnableReference(), host_timestamp);
        }

        public static unsafe int GetDeviceAndHostTimer(this CL thisApi, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.Out)] Span<ulong> device_timestamp, [Flow(FlowDirection.Out)] Span<ulong> host_timestamp)
        {
            // SpanOverloader
            return thisApi.GetDeviceAndHostTimer(device, out device_timestamp.GetPinnableReference(), out host_timestamp.GetPinnableReference());
        }

        public static unsafe int GetHostTimer(this CL thisApi, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.Out)] Span<ulong> host_timestamp)
        {
            // SpanOverloader
            return thisApi.GetHostTimer(device, out host_timestamp.GetPinnableReference());
        }

        public static unsafe int GetKernelSubGroupInfo(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, input_value, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, input_value, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, input_value, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, param_value, param_value_size_ret);
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelSubGroupInfo<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetKernelSubGroupInfo<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe nint OneKernel(this CL thisApi, [Flow(FlowDirection.In)] nint source_kernel, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.OneKernel(source_kernel, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateCommandQueueWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] QueueProperties* properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandQueueWithProperties(context, device, properties, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateCommandQueueWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ReadOnlySpan<QueueProperties> properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandQueueWithProperties(context, device, in properties.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateCommandQueueWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ReadOnlySpan<QueueProperties> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandQueueWithProperties(context, device, in properties.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreatePipe(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreatePipe(context, flags, pipe_packet_size, pipe_max_packets, properties, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreatePipe(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreatePipe(context, flags, pipe_packet_size, pipe_max_packets, in properties.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreatePipe(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreatePipe(context, flags, pipe_packet_size, pipe_max_packets, in properties.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateSamplerWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] SamplerProperties* sampler_properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateSamplerWithProperties(context, sampler_properties, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateSamplerWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<SamplerProperties> sampler_properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateSamplerWithProperties(context, in sampler_properties.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateSamplerWithProperties(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<SamplerProperties> sampler_properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateSamplerWithProperties(context, in sampler_properties.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmfree(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmfree<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmfree<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmfree<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, user_data, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmfree<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, user_data, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T1> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmfree<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T1> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T1> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmfree<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T1> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmap(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmap(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmap(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmap<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, out svm_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmap<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, out svm_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmap<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, out svm_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmap<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, out svm_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemcpy(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), src_ptr, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), src_ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), src_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), src_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmemcpy<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemcpy<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemFill(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), pattern, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), pattern, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmemFill<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemFill<T0, T1>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmunmap(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, svm_ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmunmap(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, svm_ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmunmap(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, svm_ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmunmap<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, out svm_ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmunmap<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, out svm_ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmunmap<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, out svm_ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmunmap<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, out svm_ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetPipeInfo(this CL thisApi, [Flow(FlowDirection.In)] nint pipe, [Flow(FlowDirection.In)] PipeInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetPipeInfo(pipe, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetPipeInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint pipe, [Flow(FlowDirection.In)] PipeInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPipeInfo(pipe, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetPipeInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint pipe, [Flow(FlowDirection.In)] PipeInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPipeInfo(pipe, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int SetKernelArgSvmpointer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] ReadOnlySpan<T0> arg_value) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetKernelArgSvmpointer(kernel, arg_index, in arg_value.GetPinnableReference());
        }

        public static unsafe int SetKernelExecInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] KernelExecInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> param_value) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetKernelExecInfo(kernel, param_name, param_value_size, in param_value.GetPinnableReference());
        }

        public static unsafe void Svmfree<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.Out)] Span<T0> svm_pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.Svmfree(context, out svm_pointer.GetPinnableReference());
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, in header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, options, num_input_headers, in input_headers.GetPinnableReference(), header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, options, num_input_headers, in input_headers.GetPinnableReference(), header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, options, num_input_headers, in input_headers.GetPinnableReference(), in header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, options, num_input_headers, in input_headers.GetPinnableReference(), in header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, in options.GetPinnableReference(), num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, in options.GetPinnableReference(), num_input_headers, input_headers, header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, in options.GetPinnableReference(), num_input_headers, input_headers, in header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, in options.GetPinnableReference(), num_input_headers, input_headers, in header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, in options.GetPinnableReference(), num_input_headers, in input_headers.GetPinnableReference(), header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, in options.GetPinnableReference(), num_input_headers, in input_headers.GetPinnableReference(), header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, in options.GetPinnableReference(), num_input_headers, in input_headers.GetPinnableReference(), in header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, in options.GetPinnableReference(), num_input_headers, in input_headers.GetPinnableReference(), in header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, in header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, options, num_input_headers, in input_headers.GetPinnableReference(), header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, options, num_input_headers, in input_headers.GetPinnableReference(), header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, options, num_input_headers, in input_headers.GetPinnableReference(), in header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, device_list, options, num_input_headers, in input_headers.GetPinnableReference(), in header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, input_headers, header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, input_headers, in header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, input_headers, in header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, in input_headers.GetPinnableReference(), header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, in input_headers.GetPinnableReference(), header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, in input_headers.GetPinnableReference(), in header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, in input_headers.GetPinnableReference(), in header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_headers, input_headers, header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_headers, input_headers, in header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_headers, input_headers, in header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_headers, in input_headers.GetPinnableReference(), header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_headers, in input_headers.GetPinnableReference(), header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_headers, in input_headers.GetPinnableReference(), in header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_headers, in input_headers.GetPinnableReference(), in header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, input_headers, header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, input_headers, in header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, input_headers, in header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, in input_headers.GetPinnableReference(), header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, in input_headers.GetPinnableReference(), header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int CompileProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, in input_headers.GetPinnableReference(), in header_include_names, pfn_notify, user_data);
        }

        public static unsafe int CompileProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CompileProgram(program, num_devices, in device_list.GetPinnableReference(), options, num_input_headers, in input_headers.GetPinnableReference(), in header_include_names, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe nint CreateImage(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, image_format, image_desc, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, image_format, image_desc, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, image_format, image_desc, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, image_format, in image_desc.GetPinnableReference(), host_ptr, errcode_ret);
        }

        public static unsafe nint CreateImage(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, image_format, in image_desc.GetPinnableReference(), host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, image_format, in image_desc.GetPinnableReference(), out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, image_format, in image_desc.GetPinnableReference(), out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, in image_format.GetPinnableReference(), image_desc, host_ptr, errcode_ret);
        }

        public static unsafe nint CreateImage(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, in image_format.GetPinnableReference(), image_desc, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, in image_format.GetPinnableReference(), image_desc, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, in image_format.GetPinnableReference(), image_desc, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), host_ptr, errcode_ret);
        }

        public static unsafe nint CreateImage(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage(context, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBuiltInKernel(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBuiltInKernel(context, num_devices, device_list, kernel_names, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBuiltInKernel(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBuiltInKernel(context, num_devices, device_list, in kernel_names.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateProgramWithBuiltInKernel(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBuiltInKernel(context, num_devices, device_list, in kernel_names.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBuiltInKernel(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBuiltInKernel(context, num_devices, device_list, kernel_names, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBuiltInKernel(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBuiltInKernel(context, num_devices, in device_list.GetPinnableReference(), kernel_names, errcode_ret);
        }

        public static unsafe nint CreateProgramWithBuiltInKernel(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBuiltInKernel(context, num_devices, in device_list.GetPinnableReference(), kernel_names, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBuiltInKernel(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBuiltInKernel(context, num_devices, in device_list.GetPinnableReference(), in kernel_names.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateProgramWithBuiltInKernel(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBuiltInKernel(context, num_devices, in device_list.GetPinnableReference(), in kernel_names.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBuiltInKernel(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBuiltInKernel(context, num_devices, in device_list.GetPinnableReference(), kernel_names, errcode_ret);
        }

        public static unsafe nint CreateProgramWithBuiltInKernel(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBuiltInKernel(context, num_devices, in device_list.GetPinnableReference(), kernel_names, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int CreateSubDevices(this CL thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices_ret)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, properties, num_devices, out_devices, out num_devices_ret.GetPinnableReference());
        }

        public static unsafe int CreateSubDevices(this CL thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] Span<nint> out_devices, [Flow(FlowDirection.Out)] uint* num_devices_ret)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, properties, num_devices, out out_devices.GetPinnableReference(), num_devices_ret);
        }

        public static unsafe int CreateSubDevices(this CL thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] Span<nint> out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices_ret)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, properties, num_devices, out out_devices.GetPinnableReference(), out num_devices_ret.GetPinnableReference());
        }

        public static unsafe int CreateSubDevices(this CL thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] uint* num_devices_ret)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_devices, out_devices, num_devices_ret);
        }

        public static unsafe int CreateSubDevices(this CL thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices_ret)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_devices, out_devices, out num_devices_ret.GetPinnableReference());
        }

        public static unsafe int CreateSubDevices(this CL thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] Span<nint> out_devices, [Flow(FlowDirection.Out)] uint* num_devices_ret)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_devices, out out_devices.GetPinnableReference(), num_devices_ret);
        }

        public static unsafe int CreateSubDevices(this CL thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] Span<nint> out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices_ret)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_devices, out out_devices.GetPinnableReference(), out num_devices_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueBarrierWithWaitList(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueBarrierWithWaitList(command_queue, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueBarrierWithWaitList(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueBarrierWithWaitList(command_queue, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueBarrierWithWaitList(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueBarrierWithWaitList(command_queue, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillBuffer(command_queue, buffer, pattern, pattern_size, offset, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillBuffer(command_queue, buffer, pattern, pattern_size, offset, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueFillBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillBuffer(command_queue, buffer, pattern, pattern_size, offset, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillBuffer(command_queue, buffer, in pattern.GetPinnableReference(), pattern_size, offset, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueFillBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillBuffer(command_queue, buffer, in pattern.GetPinnableReference(), pattern_size, offset, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillBuffer(command_queue, buffer, in pattern.GetPinnableReference(), pattern_size, offset, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueFillBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillBuffer(command_queue, buffer, in pattern.GetPinnableReference(), pattern_size, offset, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, origin, region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, origin, region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, origin, region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, origin, in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, origin, in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, origin, in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, origin, in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, in origin.GetPinnableReference(), region, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, in origin.GetPinnableReference(), region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, in origin.GetPinnableReference(), region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, in origin.GetPinnableReference(), region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, in origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, in origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, in origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueFillImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, fill_color, in origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), origin, region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), origin, region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), origin, region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), origin, in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), origin, in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), origin, in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), origin, in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), region, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueFillImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueFillImage(command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMarkerWithWaitList(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMarkerWithWaitList(command_queue, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMarkerWithWaitList(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMarkerWithWaitList(command_queue, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMarkerWithWaitList(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMarkerWithWaitList(command_queue, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMigrateMemObjects(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObjects(command_queue, num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMigrateMemObjects(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObjects(command_queue, num_mem_objects, mem_objects, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMigrateMemObjects(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObjects(command_queue, num_mem_objects, mem_objects, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMigrateMemObjects(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObjects(command_queue, num_mem_objects, in mem_objects.GetPinnableReference(), flags, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueMigrateMemObjects(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObjects(command_queue, num_mem_objects, in mem_objects.GetPinnableReference(), flags, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMigrateMemObjects(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObjects(command_queue, num_mem_objects, in mem_objects.GetPinnableReference(), flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMigrateMemObjects(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObjects(command_queue, num_mem_objects, in mem_objects.GetPinnableReference(), flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe void* GetExtensionFunctionAddressForPlatform(this CL thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] ReadOnlySpan<byte> func_name)
        {
            // SpanOverloader
            return thisApi.GetExtensionFunctionAddressForPlatform(platform, in func_name.GetPinnableReference());
        }

        public static unsafe int GetKernelArgInfo(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] KernelArgInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetKernelArgInfo(kernel, arg_index, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelArgInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] KernelArgInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelArgInfo(kernel, arg_index, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetKernelArgInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] KernelArgInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelArgInfo(kernel, arg_index, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, in options.GetPinnableReference(), num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, in options.GetPinnableReference(), num_input_programs, input_programs, pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, in options.GetPinnableReference(), num_input_programs, input_programs, pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, in options.GetPinnableReference(), num_input_programs, input_programs, pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, in options.GetPinnableReference(), num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, in options.GetPinnableReference(), num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, in options.GetPinnableReference(), num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, in options.GetPinnableReference(), num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, device_list, options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, input_programs, pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, input_programs, pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, input_programs, pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_programs, input_programs, pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_programs, input_programs, pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_programs, input_programs, pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, input_programs, pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, input_programs, pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, input_programs, pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint LinkProgram(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint LinkProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] ReadOnlySpan<nint> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LinkProgram(context, num_devices, in device_list.GetPinnableReference(), options, num_input_programs, in input_programs.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateSubBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] BufferCreateType buffer_create_type, [Flow(FlowDirection.In)] void* buffer_create_info, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateSubBuffer(buffer, flags, buffer_create_type, buffer_create_info, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateSubBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] BufferCreateType buffer_create_type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> buffer_create_info, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateSubBuffer(buffer, flags, buffer_create_type, in buffer_create_info.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateSubBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] BufferCreateType buffer_create_type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> buffer_create_info, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateSubBuffer(buffer, flags, buffer_create_type, in buffer_create_info.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateUserEvent(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateUserEvent(context, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBufferRect(command_queue, buffer, blocking_read, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin, in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), host_origin, in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBufferRect<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> buffer_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> host_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBufferRect(command_queue, buffer, blocking_write, in buffer_origin.GetPinnableReference(), in host_origin.GetPinnableReference(), in region.GetPinnableReference(), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int SetEventCallback<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] int command_exec_callback_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetEventCallback(@event, command_exec_callback_type, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int SetMemObjectDestructorCallback<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetMemObjectDestructorCallback(memobj, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int BuildProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BuildProgram(program, num_devices, device_list, options, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int BuildProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.BuildProgram(program, num_devices, device_list, in options.GetPinnableReference(), pfn_notify, user_data);
        }

        public static unsafe int BuildProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BuildProgram(program, num_devices, device_list, in options.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int BuildProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BuildProgram(program, num_devices, device_list, options, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int BuildProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.BuildProgram(program, num_devices, in device_list.GetPinnableReference(), options, pfn_notify, user_data);
        }

        public static unsafe int BuildProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BuildProgram(program, num_devices, in device_list.GetPinnableReference(), options, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int BuildProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.BuildProgram(program, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), pfn_notify, user_data);
        }

        public static unsafe int BuildProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<byte> options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BuildProgram(program, num_devices, in device_list.GetPinnableReference(), in options.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe int BuildProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            return thisApi.BuildProgram(program, num_devices, in device_list.GetPinnableReference(), options, pfn_notify, user_data);
        }

        public static unsafe int BuildProgram<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BuildProgram(program, num_devices, in device_list.GetPinnableReference(), options, pfn_notify, out user_data.GetPinnableReference());
        }

        public static unsafe nint CreateBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(context, flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBuffer(context, flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBuffer(context, flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateCommandQueue(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] CommandQueueProperties properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandQueue(context, device, properties, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateContext(this CL thisApi, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateContext(properties, num_devices, devices, pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateContext<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateContext(properties, num_devices, devices, pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateContext<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateContext(properties, num_devices, devices, pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateContext(this CL thisApi, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateContext(properties, num_devices, in devices.GetPinnableReference(), pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint CreateContext(this CL thisApi, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateContext(properties, num_devices, in devices.GetPinnableReference(), pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateContext<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateContext(properties, num_devices, in devices.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateContext<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateContext(properties, num_devices, in devices.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateContext(this CL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateContext(in properties.GetPinnableReference(), num_devices, devices, pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint CreateContext(this CL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateContext(in properties.GetPinnableReference(), num_devices, devices, pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateContext<T0>(this CL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateContext(in properties.GetPinnableReference(), num_devices, devices, pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateContext<T0>(this CL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateContext(in properties.GetPinnableReference(), num_devices, devices, pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateContext(this CL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateContext(in properties.GetPinnableReference(), num_devices, in devices.GetPinnableReference(), pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint CreateContext(this CL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateContext(in properties.GetPinnableReference(), num_devices, in devices.GetPinnableReference(), pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateContext<T0>(this CL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateContext(in properties.GetPinnableReference(), num_devices, in devices.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateContext<T0>(this CL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateContext(in properties.GetPinnableReference(), num_devices, in devices.GetPinnableReference(), pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateContextFromType(this CL thisApi, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] DeviceType device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateContextFromType(properties, device_type, pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateContextFromType<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] DeviceType device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateContextFromType(properties, device_type, pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateContextFromType<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] DeviceType device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateContextFromType(properties, device_type, pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateContextFromType(this CL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] DeviceType device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateContextFromType(in properties.GetPinnableReference(), device_type, pfn_notify, user_data, errcode_ret);
        }

        public static unsafe nint CreateContextFromType(this CL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] DeviceType device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateContextFromType(in properties.GetPinnableReference(), device_type, pfn_notify, user_data, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateContextFromType<T0>(this CL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] DeviceType device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateContextFromType(in properties.GetPinnableReference(), device_type, pfn_notify, out user_data.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateContextFromType<T0>(this CL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.In)] DeviceType device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateContextFromType(in properties.GetPinnableReference(), device_type, pfn_notify, out user_data.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage2D(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage2D<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImage2D<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage2D(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImage2D(context, flags, in image_format.GetPinnableReference(), image_width, image_height, image_row_pitch, host_ptr, errcode_ret);
        }

        public static unsafe nint CreateImage2D(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImage2D(context, flags, in image_format.GetPinnableReference(), image_width, image_height, image_row_pitch, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage2D<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage2D(context, flags, in image_format.GetPinnableReference(), image_width, image_height, image_row_pitch, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImage2D<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage2D(context, flags, in image_format.GetPinnableReference(), image_width, image_height, image_row_pitch, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage3D(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage3D<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImage3D<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage3D(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImage3D(context, flags, in image_format.GetPinnableReference(), image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);
        }

        public static unsafe nint CreateImage3D(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateImage3D(context, flags, in image_format.GetPinnableReference(), image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateImage3D<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage3D(context, flags, in image_format.GetPinnableReference(), image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateImage3D<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateImage3D(context, flags, in image_format.GetPinnableReference(), image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateKernel(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* kernel_name, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateKernel(program, kernel_name, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateKernel(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> kernel_name, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateKernel(program, in kernel_name.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateKernel(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> kernel_name, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateKernel(program, in kernel_name.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateKernel(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string kernel_name, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateKernel(program, kernel_name, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int CreateKernelsInProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] nint* kernels, [Flow(FlowDirection.Out)] Span<uint> num_kernels_ret)
        {
            // SpanOverloader
            return thisApi.CreateKernelsInProgram(program, num_kernels, kernels, out num_kernels_ret.GetPinnableReference());
        }

        public static unsafe int CreateKernelsInProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] Span<nint> kernels, [Flow(FlowDirection.Out)] uint* num_kernels_ret)
        {
            // SpanOverloader
            return thisApi.CreateKernelsInProgram(program, num_kernels, out kernels.GetPinnableReference(), num_kernels_ret);
        }

        public static unsafe int CreateKernelsInProgram(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] Span<nint> kernels, [Flow(FlowDirection.Out)] Span<uint> num_kernels_ret)
        {
            // SpanOverloader
            return thisApi.CreateKernelsInProgram(program, num_kernels, out kernels.GetPinnableReference(), out num_kernels_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, lengths, binaries, binary_status, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, lengths, binaries, out binary_status.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, lengths, binaries, out binary_status.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, lengths, in binaries, binary_status, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, lengths, in binaries, out binary_status.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, lengths, in binaries, out binary_status.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, in lengths.GetPinnableReference(), binaries, binary_status, errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, in lengths.GetPinnableReference(), binaries, binary_status, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, in lengths.GetPinnableReference(), binaries, out binary_status.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, in lengths.GetPinnableReference(), binaries, out binary_status.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, in lengths.GetPinnableReference(), in binaries, binary_status, errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, in lengths.GetPinnableReference(), in binaries, binary_status, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, in lengths.GetPinnableReference(), in binaries, out binary_status.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, device_list, in lengths.GetPinnableReference(), in binaries, out binary_status.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), lengths, binaries, binary_status, errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), lengths, binaries, binary_status, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), lengths, binaries, out binary_status.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), lengths, binaries, out binary_status.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), lengths, in binaries, binary_status, errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), lengths, in binaries, binary_status, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), lengths, in binaries, out binary_status.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), lengths, in binaries, out binary_status.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), in lengths.GetPinnableReference(), binaries, binary_status, errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), in lengths.GetPinnableReference(), binaries, binary_status, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), in lengths.GetPinnableReference(), binaries, out binary_status.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), in lengths.GetPinnableReference(), binaries, out binary_status.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), in lengths.GetPinnableReference(), in binaries, binary_status, errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), in lengths.GetPinnableReference(), in binaries, binary_status, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), in lengths.GetPinnableReference(), in binaries, out binary_status.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateProgramWithBinary(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] ReadOnlySpan<nint> device_list, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithBinary(context, num_devices, in device_list.GetPinnableReference(), in lengths.GetPinnableReference(), in binaries, out binary_status.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithSource(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] byte** strings, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithSource(context, count, strings, lengths, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithSource(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] byte** strings, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithSource(context, count, strings, in lengths.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateProgramWithSource(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] byte** strings, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithSource(context, count, strings, in lengths.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithSource(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in byte* strings, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithSource(context, count, in strings, lengths, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateProgramWithSource(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in byte* strings, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithSource(context, count, in strings, in lengths.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateProgramWithSource(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in byte* strings, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> lengths, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateProgramWithSource(context, count, in strings, in lengths.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateSampler(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] bool normalized_coords, [Flow(FlowDirection.In)] AddressingMode addressing_mode, [Flow(FlowDirection.In)] FilterMode filter_mode, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateSampler(context, normalized_coords, addressing_mode, filter_mode, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBuffer(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBuffer(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBuffer(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, dst_origin, in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, dst_origin, in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, dst_origin, in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, dst_origin, in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), region, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyBufferToImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, dst_origin, region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, dst_origin, region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, dst_origin, region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, dst_origin, in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, dst_origin, in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, dst_origin, in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, dst_origin, in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), region, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImage(command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, src_origin, in region.GetPinnableReference(), dst_offset, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, src_origin, in region.GetPinnableReference(), dst_offset, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, src_origin, in region.GetPinnableReference(), dst_offset, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, src_origin, in region.GetPinnableReference(), dst_offset, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), region, dst_offset, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), region, dst_offset, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), region, dst_offset, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), region, dst_offset, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), in region.GetPinnableReference(), dst_offset, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), in region.GetPinnableReference(), dst_offset, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), in region.GetPinnableReference(), dst_offset, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCopyImageToBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), in region.GetPinnableReference(), dst_offset, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapBuffer(command_queue, buffer, blocking_map, map_flags, offset, size, num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapBuffer(command_queue, buffer, blocking_map, map_flags, offset, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapBuffer(command_queue, buffer, blocking_map, map_flags, offset, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapBuffer(command_queue, buffer, blocking_map, map_flags, offset, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapBuffer(command_queue, buffer, blocking_map, map_flags, offset, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapBuffer(command_queue, buffer, blocking_map, map_flags, offset, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapBuffer(command_queue, buffer, blocking_map, map_flags, offset, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), region, out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), image_row_pitch, out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), image_slice_pitch, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), errcode_ret);
        }

        public static unsafe void* EnqueueMapImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags map_flags, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.Out)] Span<nuint> image_row_pitch, [Flow(FlowDirection.Out)] Span<nuint> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.EnqueueMapImage(command_queue, image, blocking_map, map_flags, in origin.GetPinnableReference(), in region.GetPinnableReference(), out image_row_pitch.GetPinnableReference(), out image_slice_pitch.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueMarker(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMarker(command_queue, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, mem_list, args_mem_loc, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, mem_list, args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, mem_list, args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, mem_list, in args_mem_loc, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, mem_list, in args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, mem_list, in args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, in mem_list.GetPinnableReference(), args_mem_loc, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, in mem_list.GetPinnableReference(), args_mem_loc, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, in mem_list.GetPinnableReference(), args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, in mem_list.GetPinnableReference(), args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, in mem_list.GetPinnableReference(), in args_mem_loc, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, in mem_list.GetPinnableReference(), in args_mem_loc, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, in mem_list.GetPinnableReference(), in args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNativeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, in mem_list.GetPinnableReference(), in args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, mem_list, args_mem_loc, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, mem_list, args_mem_loc, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, mem_list, args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, mem_list, args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, mem_list, in args_mem_loc, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, mem_list, in args_mem_loc, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, mem_list, in args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, mem_list, in args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, in mem_list.GetPinnableReference(), args_mem_loc, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, in mem_list.GetPinnableReference(), args_mem_loc, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, in mem_list.GetPinnableReference(), args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, in mem_list.GetPinnableReference(), args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, in mem_list.GetPinnableReference(), in args_mem_loc, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, in mem_list.GetPinnableReference(), in args_mem_loc, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, in mem_list.GetPinnableReference(), in args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNativeKernel<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueNativeKernel(command_queue, user_func, out args.GetPinnableReference(), cb_args, num_mem_objects, in mem_list.GetPinnableReference(), in args_mem_loc, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueNdrangeKernel(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueNdrangeKernel(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, region, row_pitch, slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, region, row_pitch, slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, region, row_pitch, slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, region, row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, region, row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, region, row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, region, row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, in region.GetPinnableReference(), row_pitch, slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, in region.GetPinnableReference(), row_pitch, slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, in region.GetPinnableReference(), row_pitch, slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, in region.GetPinnableReference(), row_pitch, slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, in region.GetPinnableReference(), row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, in region.GetPinnableReference(), row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, in region.GetPinnableReference(), row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, origin, in region.GetPinnableReference(), row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), region, row_pitch, slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), region, row_pitch, slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), region, row_pitch, slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), region, row_pitch, slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), region, row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), region, row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), region, row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), region, row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), in region.GetPinnableReference(), row_pitch, slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), in region.GetPinnableReference(), row_pitch, slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), in region.GetPinnableReference(), row_pitch, slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), in region.GetPinnableReference(), row_pitch, slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), in region.GetPinnableReference(), row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), in region.GetPinnableReference(), row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), in region.GetPinnableReference(), row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadImage(command_queue, image, blocking_read, in origin.GetPinnableReference(), in region.GetPinnableReference(), row_pitch, slice_pitch, out ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueTask(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueTask(command_queue, kernel, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueTask(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueTask(command_queue, kernel, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueTask(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueTask(command_queue, kernel, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueUnmapMemObject(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] void* mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueUnmapMemObject(command_queue, memobj, mapped_ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueUnmapMemObject(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] void* mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueUnmapMemObject(command_queue, memobj, mapped_ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueUnmapMemObject(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] void* mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueUnmapMemObject(command_queue, memobj, mapped_ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueUnmapMemObject<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] Span<T0> mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueUnmapMemObject(command_queue, memobj, out mapped_ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueUnmapMemObject<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] Span<T0> mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueUnmapMemObject(command_queue, memobj, out mapped_ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueUnmapMemObject<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] Span<T0> mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueUnmapMemObject(command_queue, memobj, out mapped_ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueUnmapMemObject<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] Span<T0> mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueUnmapMemObject(command_queue, memobj, out mapped_ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWaitForEvents(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_list)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitForEvents(command_queue, num_events, in event_list.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBuffer(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteBuffer<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, region, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, region, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, region, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, region, input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, region, input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, region, input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, region, input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, origin, in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), region, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), region, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), region, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), region, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), region, input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), region, input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), region, input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), region, input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteImage(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteImage<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteImage(command_queue, image, blocking_write, in origin.GetPinnableReference(), in region.GetPinnableReference(), input_row_pitch, input_slice_pitch, in ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetCommandQueueInfo(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] CommandQueueInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetCommandQueueInfo(command_queue, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetCommandQueueInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] CommandQueueInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetCommandQueueInfo(command_queue, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetCommandQueueInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] CommandQueueInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetCommandQueueInfo(command_queue, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetContextInfo(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ContextInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetContextInfo(context, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetContextInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ContextInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetContextInfo(context, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetContextInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ContextInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetContextInfo(context, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDs(this CL thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] DeviceType device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDs(platform, device_type, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDs(this CL thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] DeviceType device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDs(platform, device_type, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDs(this CL thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] DeviceType device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDs(platform, device_type, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceInfo(this CL thisApi, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] DeviceInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetDeviceInfo(device, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetDeviceInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] DeviceInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceInfo(device, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetDeviceInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] DeviceInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceInfo(device, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetEventInfo(this CL thisApi, [Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] EventInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetEventInfo(@event, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetEventInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] EventInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetEventInfo(@event, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetEventInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] EventInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetEventInfo(@event, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetEventProfilingInfo(this CL thisApi, [Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] ProfilingInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetEventProfilingInfo(@event, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetEventProfilingInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] ProfilingInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetEventProfilingInfo(@event, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetEventProfilingInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] ProfilingInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetEventProfilingInfo(@event, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe void* GetExtensionFunctionAddress(this CL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> func_name)
        {
            // SpanOverloader
            return thisApi.GetExtensionFunctionAddress(in func_name.GetPinnableReference());
        }

        public static unsafe int GetImageInfo(this CL thisApi, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ImageInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetImageInfo(image, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetImageInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ImageInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetImageInfo(image, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetImageInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ImageInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetImageInfo(image, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelInfo(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] KernelInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetKernelInfo(kernel, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] KernelInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelInfo(kernel, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetKernelInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] KernelInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelInfo(kernel, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelWorkGroupInfo(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] KernelWorkGroupInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelWorkGroupInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] KernelWorkGroupInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetKernelWorkGroupInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] KernelWorkGroupInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetMemObjectInfo(this CL thisApi, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In)] MemInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetMemObjectInfo(memobj, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetMemObjectInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In)] MemInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemObjectInfo(memobj, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetMemObjectInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In)] MemInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemObjectInfo(memobj, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetPlatformIDs(this CL thisApi, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* platforms, [Flow(FlowDirection.Out)] Span<uint> num_platforms)
        {
            // SpanOverloader
            return thisApi.GetPlatformIDs(num_entries, platforms, out num_platforms.GetPinnableReference());
        }

        public static unsafe int GetPlatformIDs(this CL thisApi, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> platforms, [Flow(FlowDirection.Out)] uint* num_platforms)
        {
            // SpanOverloader
            return thisApi.GetPlatformIDs(num_entries, out platforms.GetPinnableReference(), num_platforms);
        }

        public static unsafe int GetPlatformIDs(this CL thisApi, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> platforms, [Flow(FlowDirection.Out)] Span<uint> num_platforms)
        {
            // SpanOverloader
            return thisApi.GetPlatformIDs(num_entries, out platforms.GetPinnableReference(), out num_platforms.GetPinnableReference());
        }

        public static unsafe int GetPlatformInfo(this CL thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] PlatformInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetPlatformInfo(platform, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetPlatformInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] PlatformInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPlatformInfo(platform, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetPlatformInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] PlatformInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPlatformInfo(platform, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetProgramBuildInfo(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ProgramBuildInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetProgramBuildInfo(program, device, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetProgramBuildInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ProgramBuildInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetProgramBuildInfo(program, device, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetProgramBuildInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ProgramBuildInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetProgramBuildInfo(program, device, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetProgramInfo(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] ProgramInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetProgramInfo(program, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetProgramInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] ProgramInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetProgramInfo(program, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetProgramInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] ProgramInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetProgramInfo(program, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetSamplerInfo(this CL thisApi, [Flow(FlowDirection.In)] nint sampler, [Flow(FlowDirection.In)] SamplerInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetSamplerInfo(sampler, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetSamplerInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint sampler, [Flow(FlowDirection.In)] SamplerInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSamplerInfo(sampler, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetSamplerInfo<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint sampler, [Flow(FlowDirection.In)] SamplerInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSamplerInfo(sampler, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetSupportedImageFormats(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] ImageFormat* image_formats, [Flow(FlowDirection.Out)] Span<uint> num_image_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedImageFormats(context, flags, image_type, num_entries, image_formats, out num_image_formats.GetPinnableReference());
        }

        public static unsafe int GetSupportedImageFormats(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<ImageFormat> image_formats, [Flow(FlowDirection.Out)] uint* num_image_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedImageFormats(context, flags, image_type, num_entries, out image_formats.GetPinnableReference(), num_image_formats);
        }

        public static unsafe int GetSupportedImageFormats(this CL thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<ImageFormat> image_formats, [Flow(FlowDirection.Out)] Span<uint> num_image_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedImageFormats(context, flags, image_type, num_entries, out image_formats.GetPinnableReference(), out num_image_formats.GetPinnableReference());
        }

        public static unsafe int SetCommandQueueProperty(this CL thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] CommandQueueProperties properties, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.Out)] Span<CommandQueueProperties> old_properties)
        {
            // SpanOverloader
            return thisApi.SetCommandQueueProperty(command_queue, properties, enable, out old_properties.GetPinnableReference());
        }

        public static unsafe int SetKernelArg<T0>(this CL thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] nuint arg_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> arg_value) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetKernelArg(kernel, arg_index, arg_size, in arg_value.GetPinnableReference());
        }

        public static unsafe int WaitForEvents(this CL thisApi, [Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_list)
        {
            // SpanOverloader
            return thisApi.WaitForEvents(num_events, in event_list.GetPinnableReference());
        }

    }
}

