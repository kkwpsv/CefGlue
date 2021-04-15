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
    public abstract unsafe partial class CefUserData
    {
        private static Dictionary<IntPtr, CefUserData> _roots = new Dictionary<IntPtr, CefUserData>();
        
        private int _refct;
        private cef_user_data_t* _self;
        
        internal static CefUserData FromNativeOrNull(cef_user_data_t* ptr)
        {
            CefUserData value = null;
            bool found;
            lock (_roots)
            {
                found = _roots.TryGetValue((IntPtr)ptr, out value);
            }
            return found ? value : null;
        }
        
        internal static CefUserData FromNative(cef_user_data_t* ptr)
        {
            var value = FromNativeOrNull(ptr);
            if (value == null) throw ExceptionBuilder.ObjectNotFound();
            return value;
        }
        
        private cef_user_data_t.add_ref_delegate _ds0;
        private cef_user_data_t.release_delegate _ds1;
        private cef_user_data_t.has_one_ref_delegate _ds2;
        private cef_user_data_t.has_at_least_one_ref_delegate _ds3;
        
        protected CefUserData()
        {
            _self = cef_user_data_t.Alloc();
        
            _ds0 = new cef_user_data_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_user_data_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_user_data_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_user_data_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
        }
        
        ~CefUserData()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_user_data_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_user_data_t* self)
        {
            if (Interlocked.Increment(ref _refct) == 1)
            {
                lock (_roots) { _roots.Add((IntPtr)_self, this); }
            }
        }
        
        private int release(cef_user_data_t* self)
        {
            if (Interlocked.Decrement(ref _refct) == 0)
            {
                lock (_roots) { _roots.Remove((IntPtr)_self); }
                return 1;
            }
            return 0;
        }
        
        private int has_one_ref(cef_user_data_t* self)
        {
            return _refct == 1 ? 1 : 0;
        }
        
        private int has_at_least_one_ref(cef_user_data_t* self)
        {
            return _refct != 0 ? 1 : 0;
        }
        
        internal cef_user_data_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_user_data_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
