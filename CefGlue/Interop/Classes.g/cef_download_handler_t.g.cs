//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_download_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _can_download;
        internal IntPtr _on_before_download;
        internal IntPtr _on_download_updated;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_download_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_download_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_download_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_download_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int can_download_delegate(cef_download_handler_t* self, cef_browser_t* browser, cef_string_t* url, cef_string_t* request_method);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_before_download_delegate(cef_download_handler_t* self, cef_browser_t* browser, cef_download_item_t* download_item, cef_string_t* suggested_name, cef_before_download_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_download_updated_delegate(cef_download_handler_t* self, cef_browser_t* browser, cef_download_item_t* download_item, cef_download_item_callback_t* callback);
        
        private static int _sizeof;
        
        static cef_download_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_download_handler_t));
        }
        
        internal static cef_download_handler_t* Alloc()
        {
            var ptr = (cef_download_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_download_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_download_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
