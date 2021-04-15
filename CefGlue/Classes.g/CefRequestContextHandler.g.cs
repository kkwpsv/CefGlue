//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Threading;
    using Xilium.CefGlue.Interop;
    
    // Role: HANDLER
    public abstract unsafe partial class CefRequestContextHandler
    {
        private static Dictionary<IntPtr, CefRequestContextHandler> _roots = new Dictionary<IntPtr, CefRequestContextHandler>();
        
        private int _refct;
        private cef_request_context_handler_t* _self;
        
        internal static CefRequestContextHandler FromNativeOrNull(cef_request_context_handler_t* ptr)
        {
            CefRequestContextHandler value = null;
            bool found;
            lock (_roots)
            {
                found = _roots.TryGetValue((IntPtr)ptr, out value);
            }
            return found ? value : null;
        }
        
        internal static CefRequestContextHandler FromNative(cef_request_context_handler_t* ptr)
        {
            var value = FromNativeOrNull(ptr);
            if (value == null) throw ExceptionBuilder.ObjectNotFound();
            return value;
        }
        
        private cef_request_context_handler_t.add_ref_delegate _ds0;
        private cef_request_context_handler_t.release_delegate _ds1;
        private cef_request_context_handler_t.has_one_ref_delegate _ds2;
        private cef_request_context_handler_t.has_at_least_one_ref_delegate _ds3;
        private cef_request_context_handler_t.on_request_context_initialized_delegate _ds4;
        private cef_request_context_handler_t.on_before_plugin_load_delegate _ds5;
        private cef_request_context_handler_t.get_resource_request_handler_delegate _ds6;
        
        protected CefRequestContextHandler()
        {
            _self = cef_request_context_handler_t.Alloc();
        
            _ds0 = new cef_request_context_handler_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_request_context_handler_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_request_context_handler_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_request_context_handler_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_request_context_handler_t.on_request_context_initialized_delegate(on_request_context_initialized);
            _self->_on_request_context_initialized = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_request_context_handler_t.on_before_plugin_load_delegate(on_before_plugin_load);
            _self->_on_before_plugin_load = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_request_context_handler_t.get_resource_request_handler_delegate(get_resource_request_handler);
            _self->_get_resource_request_handler = Marshal.GetFunctionPointerForDelegate(_ds6);
        }
        
        ~CefRequestContextHandler()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_request_context_handler_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_request_context_handler_t* self)
        {
            if (Interlocked.Increment(ref _refct) == 1)
            {
                lock (_roots) { _roots.Add((IntPtr)_self, this); }
            }
        }
        
        private int release(cef_request_context_handler_t* self)
        {
            if (Interlocked.Decrement(ref _refct) == 0)
            {
                lock (_roots) { _roots.Remove((IntPtr)_self); }
                return 1;
            }
            return 0;
        }
        
        private int has_one_ref(cef_request_context_handler_t* self)
        {
            return _refct == 1 ? 1 : 0;
        }
        
        private int has_at_least_one_ref(cef_request_context_handler_t* self)
        {
            return _refct != 0 ? 1 : 0;
        }
        
        internal cef_request_context_handler_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_request_context_handler_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
