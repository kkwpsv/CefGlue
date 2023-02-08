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
    internal unsafe struct cef_zip_reader_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _move_to_first_file;
        internal IntPtr _move_to_next_file;
        internal IntPtr _move_to_file;
        internal IntPtr _close;
        internal IntPtr _get_file_name;
        internal IntPtr _get_file_size;
        internal IntPtr _get_file_last_modified;
        internal IntPtr _open_file;
        internal IntPtr _close_file;
        internal IntPtr _read_file;
        internal IntPtr _tell;
        internal IntPtr _eof;
        
        // Create
        [DllImport(libcef.DllName, EntryPoint = "cef_zip_reader_create", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_zip_reader_t* create(cef_stream_reader_t* stream);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_zip_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_zip_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_zip_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_at_least_one_ref_delegate(cef_zip_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int move_to_first_file_delegate(cef_zip_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int move_to_next_file_delegate(cef_zip_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int move_to_file_delegate(cef_zip_reader_t* self, cef_string_t* fileName, int caseSensitive);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int close_delegate(cef_zip_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_file_name_delegate(cef_zip_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate long get_file_size_delegate(cef_zip_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefBaseTime get_file_last_modified_delegate(cef_zip_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int open_file_delegate(cef_zip_reader_t* self, cef_string_t* password);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int close_file_delegate(cef_zip_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int read_file_delegate(cef_zip_reader_t* self, void* buffer, UIntPtr bufferSize);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate long tell_delegate(cef_zip_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int eof_delegate(cef_zip_reader_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_zip_reader_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_zip_reader_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // HasOneRef
        private static IntPtr _p2;
        private static has_one_ref_delegate _d2;
        
        public static int has_one_ref(cef_zip_reader_t* self)
        {
            has_one_ref_delegate d;
            var p = self->_base._has_one_ref;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (has_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_one_ref_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // HasAtLeastOneRef
        private static IntPtr _p3;
        private static has_at_least_one_ref_delegate _d3;
        
        public static int has_at_least_one_ref(cef_zip_reader_t* self)
        {
            has_at_least_one_ref_delegate d;
            var p = self->_base._has_at_least_one_ref;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (has_at_least_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_at_least_one_ref_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // MoveToFirstFile
        private static IntPtr _p4;
        private static move_to_first_file_delegate _d4;
        
        public static int move_to_first_file(cef_zip_reader_t* self)
        {
            move_to_first_file_delegate d;
            var p = self->_move_to_first_file;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (move_to_first_file_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(move_to_first_file_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // MoveToNextFile
        private static IntPtr _p5;
        private static move_to_next_file_delegate _d5;
        
        public static int move_to_next_file(cef_zip_reader_t* self)
        {
            move_to_next_file_delegate d;
            var p = self->_move_to_next_file;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (move_to_next_file_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(move_to_next_file_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // MoveToFile
        private static IntPtr _p6;
        private static move_to_file_delegate _d6;
        
        public static int move_to_file(cef_zip_reader_t* self, cef_string_t* fileName, int caseSensitive)
        {
            move_to_file_delegate d;
            var p = self->_move_to_file;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (move_to_file_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(move_to_file_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self, fileName, caseSensitive);
        }
        
        // Close
        private static IntPtr _p7;
        private static close_delegate _d7;
        
        public static int close(cef_zip_reader_t* self)
        {
            close_delegate d;
            var p = self->_close;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (close_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(close_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self);
        }
        
        // GetFileName
        private static IntPtr _p8;
        private static get_file_name_delegate _d8;
        
        public static cef_string_userfree* get_file_name(cef_zip_reader_t* self)
        {
            get_file_name_delegate d;
            var p = self->_get_file_name;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (get_file_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_file_name_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            return d(self);
        }
        
        // GetFileSize
        private static IntPtr _p9;
        private static get_file_size_delegate _d9;
        
        public static long get_file_size(cef_zip_reader_t* self)
        {
            get_file_size_delegate d;
            var p = self->_get_file_size;
            if (p == _p9) { d = _d9; }
            else
            {
                d = (get_file_size_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_file_size_delegate));
                if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
            }
            return d(self);
        }
        
        // GetFileLastModified
        private static IntPtr _pa;
        private static get_file_last_modified_delegate _da;
        
        public static CefBaseTime get_file_last_modified(cef_zip_reader_t* self)
        {
            get_file_last_modified_delegate d;
            var p = self->_get_file_last_modified;
            if (p == _pa) { d = _da; }
            else
            {
                d = (get_file_last_modified_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_file_last_modified_delegate));
                if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
            }
            return d(self);
        }
        
        // OpenFile
        private static IntPtr _pb;
        private static open_file_delegate _db;
        
        public static int open_file(cef_zip_reader_t* self, cef_string_t* password)
        {
            open_file_delegate d;
            var p = self->_open_file;
            if (p == _pb) { d = _db; }
            else
            {
                d = (open_file_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(open_file_delegate));
                if (_pb == IntPtr.Zero) { _db = d; _pb = p; }
            }
            return d(self, password);
        }
        
        // CloseFile
        private static IntPtr _pc;
        private static close_file_delegate _dc;
        
        public static int close_file(cef_zip_reader_t* self)
        {
            close_file_delegate d;
            var p = self->_close_file;
            if (p == _pc) { d = _dc; }
            else
            {
                d = (close_file_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(close_file_delegate));
                if (_pc == IntPtr.Zero) { _dc = d; _pc = p; }
            }
            return d(self);
        }
        
        // ReadFile
        private static IntPtr _pd;
        private static read_file_delegate _dd;
        
        public static int read_file(cef_zip_reader_t* self, void* buffer, UIntPtr bufferSize)
        {
            read_file_delegate d;
            var p = self->_read_file;
            if (p == _pd) { d = _dd; }
            else
            {
                d = (read_file_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(read_file_delegate));
                if (_pd == IntPtr.Zero) { _dd = d; _pd = p; }
            }
            return d(self, buffer, bufferSize);
        }
        
        // Tell
        private static IntPtr _pe;
        private static tell_delegate _de;
        
        public static long tell(cef_zip_reader_t* self)
        {
            tell_delegate d;
            var p = self->_tell;
            if (p == _pe) { d = _de; }
            else
            {
                d = (tell_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(tell_delegate));
                if (_pe == IntPtr.Zero) { _de = d; _pe = p; }
            }
            return d(self);
        }
        
        // Eof
        private static IntPtr _pf;
        private static eof_delegate _df;
        
        public static int eof(cef_zip_reader_t* self)
        {
            eof_delegate d;
            var p = self->_eof;
            if (p == _pf) { d = _df; }
            else
            {
                d = (eof_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(eof_delegate));
                if (_pf == IntPtr.Zero) { _df = d; _pf = p; }
            }
            return d(self);
        }
        
    }
}
