using System;
using System.Runtime.InteropServices;

namespace pjsip.Interop
{
    public partial class NativeConstants
    {

        /// __PJSUA_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSUA_H__ = "";

        /// __PJSIP_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_H__ = "";

        /// __PJSIP_SIP_TYPES_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_TYPES_H__ = "";

        /// __PJSIP_SIP_CONFIG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_CONFIG_H__ = "";

        /// __PJ_TYPES_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_TYPES_H__ = "";

        /// __PJ_CONFIG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_CONFIG_H__ = "";

        /// __PJ_COMPAT_CC_MSVC_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_COMPAT_CC_MSVC_H__ = "";

        /// PJ_CC_NAME -> "msvc"
        public const string PJ_CC_NAME = "msvc";

        /// PJ_CC_VER_1 -> (_MSC_VER/100)
        public const int PJ_CC_VER_1 = (NativeConstants._MSC_VER / 100);

        /// PJ_CC_VER_2 -> (_MSC_VER%100)
        public const int PJ_CC_VER_2 = (NativeConstants._MSC_VER % 100);

        /// PJ_CC_VER_3 -> 0
        public const int PJ_CC_VER_3 = 0;

        /// _CRT_SECURE_NO_DEPRECATE -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _CRT_SECURE_NO_DEPRECATE = "";

        /// _CRT_SECURE_NO_WARNINGS -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _CRT_SECURE_NO_WARNINGS = "";

        /// PJ_INLINE_SPECIFIER -> static __inline
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_INLINE_SPECIFIER = "static __inline";

        /// PJ_EXPORT_DECL_SPECIFIER -> __declspec(dllexport)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJ_EXPORT_DECL_SPECIFIER = "__declspec(dllexport)";

        /// PJ_EXPORT_DEF_SPECIFIER -> __declspec(dllexport)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJ_EXPORT_DEF_SPECIFIER = "__declspec(dllexport)";

        /// PJ_IMPORT_DECL_SPECIFIER -> __declspec(dllimport)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJ_IMPORT_DECL_SPECIFIER = "__declspec(dllimport)";

        /// PJ_THREAD_FUNC -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string PJ_THREAD_FUNC = "";

        /// PJ_NORETURN -> __declspec(noreturn)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJ_NORETURN = "__declspec(noreturn)";

        /// PJ_ATTR_NORETURN -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string PJ_ATTR_NORETURN = "";

        /// PJ_HAS_INT64 -> 1
        public const int PJ_HAS_INT64 = 1;

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_INT64 -> "(val) val##i64"
        public const string PJ_INT64 = "(val) val##i64";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_UINT64 -> "(val) val##ui64"
        public const string PJ_UINT64 = "(val) val##ui64";

        /// PJ_INT64_FMT -> "I64"
        public const string PJ_INT64_FMT = "I64";

        /// PJ_UNREACHED -> (x)
        /// Error generating expression: Value x is not resolved
        public const string PJ_UNREACHED = "(x)";

        /// PJ_WIN32 -> 1
        public const int PJ_WIN32 = 1;

        /// __PJ_COMPAT_OS_WIN32_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_COMPAT_OS_WIN32_H__ = "";

        /// PJ_OS_NAME -> "win32"
        public const string PJ_OS_NAME = "win32";

        /// WIN32_LEAN_AND_MEAN -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string WIN32_LEAN_AND_MEAN = "";

        /// PJ_WIN32_WINNT -> 0x0400
        public const int PJ_WIN32_WINNT = 1024;

        /// PJ_HAS_ARPA_INET_H -> 0
        public const int PJ_HAS_ARPA_INET_H = 0;

        /// PJ_HAS_ASSERT_H -> 1
        public const int PJ_HAS_ASSERT_H = 1;

        /// PJ_HAS_CTYPE_H -> 1
        public const int PJ_HAS_CTYPE_H = 1;

        /// PJ_HAS_ERRNO_H -> 0
        public const int PJ_HAS_ERRNO_H = 0;

        /// PJ_HAS_LINUX_SOCKET_H -> 0
        public const int PJ_HAS_LINUX_SOCKET_H = 0;

        /// PJ_HAS_MALLOC_H -> 1
        public const int PJ_HAS_MALLOC_H = 1;

        /// PJ_HAS_NETDB_H -> 0
        public const int PJ_HAS_NETDB_H = 0;

        /// PJ_HAS_NETINET_IN_H -> 0
        public const int PJ_HAS_NETINET_IN_H = 0;

        /// PJ_HAS_SETJMP_H -> 1
        public const int PJ_HAS_SETJMP_H = 1;

        /// PJ_HAS_STDARG_H -> 1
        public const int PJ_HAS_STDARG_H = 1;

        /// PJ_HAS_STDDEF_H -> 1
        public const int PJ_HAS_STDDEF_H = 1;

        /// PJ_HAS_STDIO_H -> 1
        public const int PJ_HAS_STDIO_H = 1;

        /// PJ_HAS_STDLIB_H -> 1
        public const int PJ_HAS_STDLIB_H = 1;

        /// PJ_HAS_STRING_H -> 1
        public const int PJ_HAS_STRING_H = 1;

        /// PJ_HAS_SYS_IOCTL_H -> 0
        public const int PJ_HAS_SYS_IOCTL_H = 0;

        /// PJ_HAS_SYS_SELECT_H -> 0
        public const int PJ_HAS_SYS_SELECT_H = 0;

        /// PJ_HAS_SYS_SOCKET_H -> 0
        public const int PJ_HAS_SYS_SOCKET_H = 0;

        /// PJ_HAS_SYS_TIME_H -> 0
        public const int PJ_HAS_SYS_TIME_H = 0;

        /// PJ_HAS_SYS_TIMEB_H -> 1
        public const int PJ_HAS_SYS_TIMEB_H = 1;

        /// PJ_HAS_SYS_TYPES_H -> 1
        public const int PJ_HAS_SYS_TYPES_H = 1;

        /// PJ_HAS_TIME_H -> 1
        public const int PJ_HAS_TIME_H = 1;

        /// PJ_HAS_UNISTD_H -> 0
        public const int PJ_HAS_UNISTD_H = 0;

        /// PJ_HAS_MSWSOCK_H -> 1
        public const int PJ_HAS_MSWSOCK_H = 1;

        /// PJ_HAS_WINSOCK_H -> 0
        public const int PJ_HAS_WINSOCK_H = 0;

        /// PJ_HAS_WINSOCK2_H -> 1
        public const int PJ_HAS_WINSOCK2_H = 1;

        /// PJ_HAS_WS2TCPIP_H -> 1
        public const int PJ_HAS_WS2TCPIP_H = 1;

        /// PJ_SOCK_HAS_INET_ATON -> 0
        public const int PJ_SOCK_HAS_INET_ATON = 0;

        /// PJ_SOCKADDR_HAS_LEN -> 0
        public const int PJ_SOCKADDR_HAS_LEN = 0;

        /// PJ_HAS_ERRNO_VAR -> 0
        public const int PJ_HAS_ERRNO_VAR = 0;

        /// PJ_HAS_SO_ERROR -> 1
        public const int PJ_HAS_SO_ERROR = 1;

        /// PJ_BLOCKING_ERROR_VAL -> WSAEWOULDBLOCK
        public const int PJ_BLOCKING_ERROR_VAL = NativeConstants.WSAEWOULDBLOCK;

        /// PJ_BLOCKING_CONNECT_ERROR_VAL -> WSAEWOULDBLOCK
        public const int PJ_BLOCKING_CONNECT_ERROR_VAL = NativeConstants.WSAEWOULDBLOCK;

        /// PJ_SELECT_NEEDS_NFDS -> 0
        public const int PJ_SELECT_NEEDS_NFDS = 0;

        /// PJ_HAS_THREADS -> (1)
        public const int PJ_HAS_THREADS = 1;

        /// PJ_HAS_HIGH_RES_TIMER -> 1
        public const int PJ_HAS_HIGH_RES_TIMER = 1;

        /// PJ_HAS_MALLOC -> 1
        public const int PJ_HAS_MALLOC = 1;

        /// PJ_OS_HAS_CHECK_STACK -> 0
        public const int PJ_OS_HAS_CHECK_STACK = 0;

        /// PJ_NATIVE_STRING_IS_UNICODE -> 0
        public const int PJ_NATIVE_STRING_IS_UNICODE = 0;

        /// PJ_ATOMIC_VALUE_TYPE -> long
        /// Error generating expression: Value long is not resolved
        public const string PJ_ATOMIC_VALUE_TYPE = "long";

        /// PJ_EMULATE_RWMUTEX -> 1
        public const int PJ_EMULATE_RWMUTEX = 1;

        /// PJ_THREAD_SET_STACK_SIZE -> 0
        public const int PJ_THREAD_SET_STACK_SIZE = 0;

        /// PJ_THREAD_ALLOCATE_STACK -> 0
        public const int PJ_THREAD_ALLOCATE_STACK = 0;

        /// PJ_M_I386 -> 1
        public const int PJ_M_I386 = 1;

        /// PJ_M_NAME -> "i386"
        public const string PJ_M_NAME = "i386";

        /// PJ_HAS_PENTIUM -> 1
        public const int PJ_HAS_PENTIUM = 1;

        /// PJ_IS_LITTLE_ENDIAN -> 1
        public const int PJ_IS_LITTLE_ENDIAN = 1;

        /// PJ_IS_BIG_ENDIAN -> 0
        public const int PJ_IS_BIG_ENDIAN = 0;

        /// __PJ_COMPAT_SIZE_T_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_COMPAT_SIZE_T_H__ = "";

        /// _INC_STDDEF -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _INC_STDDEF = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// offsetof -> "(s,m) (size_t)&(((s *)0)->m)"
        public const string offsetof = "(s,m) (size_t)&(((s *)0)->m)";

        /// PJ_EXPORT_SPECIFIER -> __declspec(dllexport)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJ_EXPORT_SPECIFIER = "__declspec(dllexport)";

        /// PJ_IMPORT_SPECIFIER -> __declspec(dllimport)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJ_IMPORT_SPECIFIER = "__declspec(dllimport)";

        /// PJ_CALLBACK -> __stdcall
        /// Error generating expression: Value __stdcall is not resolved
        public const string PJ_CALLBACK = "__stdcall";

        /// PJSIP_HAS_TLS_TRANSPORT -> 1
        public const int PJSIP_HAS_TLS_TRANSPORT = 1;

        /// PJMEDIA_HAS_SRTP -> 1
        public const int PJMEDIA_HAS_SRTP = 1;

        /// PJ_CONFIG_MAXIMUM_SPEED -> 1
        public const int PJ_CONFIG_MAXIMUM_SPEED = 1;

        /// PJ_SCANNER_USE_BITWISE -> 1
        public const int PJ_SCANNER_USE_BITWISE = 1;

        /// PJ_LOG_MAX_LEVEL -> 3
        public const int PJ_LOG_MAX_LEVEL = 3;

        /// PJ_ENABLE_EXTRA_CHECK -> 1
        public const int PJ_ENABLE_EXTRA_CHECK = 1;

        /// PJ_IOQUEUE_MAX_HANDLES -> 5000
        public const int PJ_IOQUEUE_MAX_HANDLES = 5000;

        /// PJSIP_MAX_TSX_COUNT -> ((640*1024)-1)
        public const int PJSIP_MAX_TSX_COUNT = ((640 * 1024)
                    - 1);

        /// PJSIP_MAX_DIALOG_COUNT -> ((640*1024)-1)
        public const int PJSIP_MAX_DIALOG_COUNT = ((640 * 1024)
                    - 1);

        /// PJSIP_UDP_SO_SNDBUF_SIZE -> (24*1024*1024)
        public const int PJSIP_UDP_SO_SNDBUF_SIZE = (24
                    * (1024 * 1024));

        /// PJSIP_UDP_SO_RCVBUF_SIZE -> (24*1024*1024)
        public const int PJSIP_UDP_SO_RCVBUF_SIZE = (24
                    * (1024 * 1024));

        /// PJ_DEBUG -> 1
        public const int PJ_DEBUG = 1;

        /// PJSIP_SAFE_MODULE -> 1
        public const int PJSIP_SAFE_MODULE = 1;

        /// PJ_HAS_STRICMP_ALNUM -> 0
        public const int PJ_HAS_STRICMP_ALNUM = 0;

        /// PJ_HASH_USE_OWN_TOLOWER -> 1
        public const int PJ_HASH_USE_OWN_TOLOWER = 1;

        /// PJSIP_UNESCAPE_IN_PLACE -> 1
        public const int PJSIP_UNESCAPE_IN_PLACE = 1;

        /// PJSIP_MAX_NET_EVENTS -> 10
        public const int PJSIP_MAX_NET_EVENTS = 10;

        /// PJSUA_MAX_CALLS -> 512
        public const int PJSUA_MAX_CALLS = 512;

        /// PJ_DEBUG_MUTEX -> 0
        public const int PJ_DEBUG_MUTEX = 0;

        /// PJ_FUNCTIONS_ARE_INLINED -> 0
        public const int PJ_FUNCTIONS_ARE_INLINED = 0;

        /// PJ_HAS_FLOATING_POINT -> 1
        public const int PJ_HAS_FLOATING_POINT = 1;

        /// PJ_LOG_MAX_SIZE -> 2000
        public const int PJ_LOG_MAX_SIZE = 2000;

        /// PJ_LOG_USE_STACK_BUFFER -> 1
        public const int PJ_LOG_USE_STACK_BUFFER = 1;

        /// PJ_TERM_HAS_COLOR -> 1
        public const int PJ_TERM_HAS_COLOR = 1;

        /// PJ_SAFE_POOL -> 0
        public const int PJ_SAFE_POOL = 0;

        /// PJ_POOL_DEBUG -> 0
        public const int PJ_POOL_DEBUG = 0;

        /// PJ_THREAD_DEFAULT_STACK_SIZE -> 8192
        public const int PJ_THREAD_DEFAULT_STACK_SIZE = 8192;

        /// PJ_HAS_POOL_ALT_API -> PJ_POOL_DEBUG
        public const int PJ_HAS_POOL_ALT_API = NativeConstants.PJ_POOL_DEBUG;

        /// PJ_HAS_TCP -> 1
        public const int PJ_HAS_TCP = 1;

        /// PJ_HAS_IPV6 -> 0
        public const int PJ_HAS_IPV6 = 0;

        /// PJ_MAX_HOSTNAME -> (128)
        public const int PJ_MAX_HOSTNAME = 128;

        /// PJ_IOQUEUE_HAS_SAFE_UNREG -> 1
        public const int PJ_IOQUEUE_HAS_SAFE_UNREG = 1;

        /// PJ_IOQUEUE_DEFAULT_ALLOW_CONCURRENCY -> 1
        public const int PJ_IOQUEUE_DEFAULT_ALLOW_CONCURRENCY = 1;

        /// PJ_IOQUEUE_KEY_FREE_DELAY -> 500
        public const int PJ_IOQUEUE_KEY_FREE_DELAY = 500;

        /// PJ_FD_SETSIZE_SETABLE -> 1
        public const int PJ_FD_SETSIZE_SETABLE = 1;

        /// PJ_IP_HELPER_IGNORE_LOOPBACK_IF -> 1
        public const int PJ_IP_HELPER_IGNORE_LOOPBACK_IF = 1;

        /// PJ_HAS_SEMAPHORE -> 1
        public const int PJ_HAS_SEMAPHORE = 1;

        /// PJ_HAS_EVENT_OBJ -> 1
        public const int PJ_HAS_EVENT_OBJ = 1;

        /// PJ_MAXPATH -> 260
        public const int PJ_MAXPATH = 260;

        /// PJ_HAS_EXCEPTION_NAMES -> 1
        public const int PJ_HAS_EXCEPTION_NAMES = 1;

        /// PJ_MAX_EXCEPTION_ID -> 16
        public const int PJ_MAX_EXCEPTION_ID = 16;

        /// PJ_EXCEPTION_USE_WIN32_SEH -> 0
        public const int PJ_EXCEPTION_USE_WIN32_SEH = 0;

        /// PJ_TIMESTAMP_USE_RDTSC -> 0
        public const int PJ_TIMESTAMP_USE_RDTSC = 0;

        /// PJ_NATIVE_ERR_POSITIVE -> 1
        public const int PJ_NATIVE_ERR_POSITIVE = 1;

        /// PJ_HAS_ERROR_STRING -> 1
        public const int PJ_HAS_ERROR_STRING = 1;

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_INLINE -> "(type) PJ_INLINE_SPECIFIER type"
        public const string PJ_INLINE = "(type) PJ_INLINE_SPECIFIER type";

        /// PJ_EXPORT_SYMBOL -> (x)
        /// Error generating expression: Value x is not resolved
        public const string PJ_EXPORT_SYMBOL = "(x)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DECL -> "(type) extern type"
        public const string PJ_DECL = "(type) extern type";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DEF -> "(type) type"
        public const string PJ_DEF = "(type) type";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DECL_NO_RETURN -> "(type) PJ_NORETURN PJ_DECL(type)"
        public const string PJ_DECL_NO_RETURN = "(type) PJ_NORETURN PJ_DECL(type)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_IDECL_NO_RETURN -> "(type) PJ_NORETURN PJ_INLINE(type)"
        public const string PJ_IDECL_NO_RETURN = "(type) PJ_NORETURN PJ_INLINE(type)";

        /// PJ_BEGIN_DECL -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string PJ_BEGIN_DECL = "";

        /// PJ_END_DECL -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string PJ_END_DECL = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DECL_DATA -> "(type) extern type"
        public const string PJ_DECL_DATA = "(type) extern type";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DEF_DATA -> "(type) type"
        public const string PJ_DEF_DATA = "(type) type";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_IDECL -> "(type) PJ_DECL(type)"
        public const string PJ_IDECL = "(type) PJ_DECL(type)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_IDEF -> "(type) PJ_DEF(type)"
        public const string PJ_IDEF = "(type) PJ_DEF(type)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_UNUSED_ARG -> "(arg) (void)arg"
        public const string PJ_UNUSED_ARG = "(arg) (void)arg";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_TODO -> "(id) TODO___##id:"
        public const string PJ_TODO = "(id) TODO___##id:";

        /// __pj_throw__ -> (x)
        /// Error generating expression: Value x is not resolved
        public const string @__pj_throw__ = "(x)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_T -> "(literal_str) literal_str"
        public const string PJ_T = "(literal_str) literal_str";

        /// PJ_SUCCESS -> 0
        public const int PJ_SUCCESS = 0;

        /// PJ_TRUE -> 1
        public const int PJ_TRUE = 1;

        /// PJ_FALSE -> 0
        public const int PJ_FALSE = 0;

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_ARRAY_SIZE -> "(a) (sizeof(a)/sizeof(a[0]))"
        public const string PJ_ARRAY_SIZE = "(a) (sizeof(a)/sizeof(a[0]))";

        /// PJ_MAXINT32 -> 0x7FFFFFFFL
        public const int PJ_MAXINT32 = 2147483647;

        /// PJ_MAX_OBJ_NAME -> 32
        public const int PJ_MAX_OBJ_NAME = 32;

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_TIME_VAL_MSEC -> "(t) ((t).sec * 1000 + (t).msec)"
        public const string PJ_TIME_VAL_MSEC = "(t) ((t).sec * 1000 + (t).msec)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_TIME_VAL_EQ -> "(t1,t2) ((t1).sec==(t2).sec && (t1).msec==(t2).msec)"
        public const string PJ_TIME_VAL_EQ = "(t1,t2) ((t1).sec==(t2).sec && (t1).msec==(t2).msec)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_TIME_VAL_GT -> "(t1,t2) ((t1).sec>(t2).sec || 
        ///                                ((t1).sec==(t2).sec && (t1).msec>(t2).msec))"
        public const string PJ_TIME_VAL_GT = "(t1,t2) ((t1).sec>(t2).sec || \r\n                                ((t1).sec==(t2).s" +
            "ec && (t1).msec>(t2).msec))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_TIME_VAL_GTE -> "(t1,t2) (PJ_TIME_VAL_GT(t1,t2) || 
        ///                                 PJ_TIME_VAL_EQ(t1,t2))"
        public const string PJ_TIME_VAL_GTE = "(t1,t2) (PJ_TIME_VAL_GT(t1,t2) || \r\n                                 PJ_TIME_VAL_" +
            "EQ(t1,t2))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_TIME_VAL_LT -> "(t1,t2) (!(PJ_TIME_VAL_GTE(t1,t2)))"
        public const string PJ_TIME_VAL_LT = "(t1,t2) (!(PJ_TIME_VAL_GTE(t1,t2)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_TIME_VAL_LTE -> "(t1,t2) (!PJ_TIME_VAL_GT(t1, t2))"
        public const string PJ_TIME_VAL_LTE = "(t1,t2) (!PJ_TIME_VAL_GT(t1, t2))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_TIME_VAL_ADD -> "(t1,t2) do {			    
        ///					(t1).sec += (t2).sec;	    
        ///					(t1).msec += (t2).msec;	    
        ///					pj_time_val_normalize(&(t1)); 
        ///				    } while (0)"
        public const string PJ_TIME_VAL_ADD = "(t1,t2) do {\t\t\t    \r\n\t\t\t\t\t(t1).sec += (t2).sec;\t    \r\n\t\t\t\t\t(t1).msec += (t2).msec" +
            ";\t    \r\n\t\t\t\t\tpj_time_val_normalize(&(t1)); \r\n\t\t\t\t    } while (0)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_TIME_VAL_SUB -> "(t1,t2) do {			    
        ///					(t1).sec -= (t2).sec;	    
        ///					(t1).msec -= (t2).msec;	    
        ///					pj_time_val_normalize(&(t1)); 
        ///				    } while (0)"
        public const string PJ_TIME_VAL_SUB = "(t1,t2) do {\t\t\t    \r\n\t\t\t\t\t(t1).sec -= (t2).sec;\t    \r\n\t\t\t\t\t(t1).msec -= (t2).msec" +
            ";\t    \r\n\t\t\t\t\tpj_time_val_normalize(&(t1)); \r\n\t\t\t\t    } while (0)";

        /// PJSIP_MAX_TRANSPORTS -> (PJ_IOQUEUE_MAX_HANDLES)
        public const int PJSIP_MAX_TRANSPORTS = NativeConstants.PJ_IOQUEUE_MAX_HANDLES;

        /// PJSIP_TPMGR_HTABLE_SIZE -> 31
        public const int PJSIP_TPMGR_HTABLE_SIZE = 31;

        /// PJSIP_MAX_URL_SIZE -> 256
        public const int PJSIP_MAX_URL_SIZE = 256;

        /// PJSIP_MAX_MODULE -> 16
        public const int PJSIP_MAX_MODULE = 16;

        /// PJSIP_MAX_PKT_LEN -> 2000
        public const int PJSIP_MAX_PKT_LEN = 2000;

        /// PJSIP_DONT_SWITCH_TO_TCP -> 0
        public const int PJSIP_DONT_SWITCH_TO_TCP = 0;

        /// PJSIP_UDP_SIZE_THRESHOLD -> 1300
        public const int PJSIP_UDP_SIZE_THRESHOLD = 1300;

        /// PJSIP_ENCODE_SHORT_HNAME -> 0
        public const int PJSIP_ENCODE_SHORT_HNAME = 0;

        /// PJSIP_INCLUDE_ALLOW_HDR_IN_DLG -> 1
        public const int PJSIP_INCLUDE_ALLOW_HDR_IN_DLG = 1;

        /// PJSIP_CHECK_VIA_SENT_BY -> 1
        public const int PJSIP_CHECK_VIA_SENT_BY = 1;

        /// PJSIP_MAX_TIMED_OUT_ENTRIES -> 10
        public const int PJSIP_MAX_TIMED_OUT_ENTRIES = 10;

        /// PJSIP_TRANSPORT_IDLE_TIME -> 600
        public const int PJSIP_TRANSPORT_IDLE_TIME = 600;

        /// PJSIP_MAX_TRANSPORT_USAGE -> ((unsigned)-1)
        /// Error generating expression: Value unsigned is not resolved
        public const string PJSIP_MAX_TRANSPORT_USAGE = "((unsigned)-1)";

        /// PJSIP_TCP_TRANSPORT_BACKLOG -> 5
        public const int PJSIP_TCP_TRANSPORT_BACKLOG = 5;

        /// PJSIP_TCP_KEEP_ALIVE_INTERVAL -> 90
        public const int PJSIP_TCP_KEEP_ALIVE_INTERVAL = 90;

        /// PJSIP_TCP_KEEP_ALIVE_DATA -> { "\r\n\r\n", 4 }
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJSIP_TCP_KEEP_ALIVE_DATA = "{ \"\\r\\n\\r\\n\", 4 }";

        /// PJSIP_TLS_KEEP_ALIVE_INTERVAL -> 90
        public const int PJSIP_TLS_KEEP_ALIVE_INTERVAL = 90;

        /// PJSIP_TLS_KEEP_ALIVE_DATA -> { "\r\n\r\n", 4 }
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJSIP_TLS_KEEP_ALIVE_DATA = "{ \"\\r\\n\\r\\n\", 4 }";

        /// PJSIP_HAS_RESOLVER -> 1
        public const int PJSIP_HAS_RESOLVER = 1;

        /// PJSIP_MAX_RESOLVED_ADDRESSES -> 8
        public const int PJSIP_MAX_RESOLVED_ADDRESSES = 8;

        /// PJSIP_TLS_TRANSPORT_BACKLOG -> 5
        public const int PJSIP_TLS_TRANSPORT_BACKLOG = 5;

        /// PJSIP_MAX_TIMER_COUNT -> (2*pjsip_cfg()->tsx.max_count + 					 2*PJSIP_MAX_DIALOG_COUNT)
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJSIP_MAX_TIMER_COUNT = "(2*pjsip_cfg()->tsx.max_count + \t\t\t\t\t 2*PJSIP_MAX_DIALOG_COUNT)";

        /// PJSIP_POOL_LEN_ENDPT -> (4000)
        public const int PJSIP_POOL_LEN_ENDPT = 4000;

        /// PJSIP_POOL_INC_ENDPT -> (4000)
        public const int PJSIP_POOL_INC_ENDPT = 4000;

        /// PJSIP_POOL_RDATA_LEN -> 4000
        public const int PJSIP_POOL_RDATA_LEN = 4000;

        /// PJSIP_POOL_RDATA_INC -> 4000
        public const int PJSIP_POOL_RDATA_INC = 4000;

        /// PJSIP_POOL_LEN_TRANSPORT -> 512
        public const int PJSIP_POOL_LEN_TRANSPORT = 512;

        /// PJSIP_POOL_INC_TRANSPORT -> 512
        public const int PJSIP_POOL_INC_TRANSPORT = 512;

        /// PJSIP_POOL_LEN_TDATA -> 4000
        public const int PJSIP_POOL_LEN_TDATA = 4000;

        /// PJSIP_POOL_INC_TDATA -> 4000
        public const int PJSIP_POOL_INC_TDATA = 4000;

        /// PJSIP_POOL_LEN_UA -> 512
        public const int PJSIP_POOL_LEN_UA = 512;

        /// PJSIP_POOL_INC_UA -> 512
        public const int PJSIP_POOL_INC_UA = 512;

        /// PJSIP_MAX_FORWARDS_VALUE -> 70
        public const int PJSIP_MAX_FORWARDS_VALUE = 70;

        /// PJSIP_RFC3261_BRANCH_ID -> "z9hG4bK"
        public const string PJSIP_RFC3261_BRANCH_ID = "z9hG4bK";

        /// PJSIP_RFC3261_BRANCH_LEN -> 7
        public const int PJSIP_RFC3261_BRANCH_LEN = 7;

        /// PJSIP_POOL_TSX_LAYER_LEN -> 512
        public const int PJSIP_POOL_TSX_LAYER_LEN = 512;

        /// PJSIP_POOL_TSX_LAYER_INC -> 512
        public const int PJSIP_POOL_TSX_LAYER_INC = 512;

        /// PJSIP_POOL_TSX_LEN -> 1536
        public const int PJSIP_POOL_TSX_LEN = 1536;

        /// PJSIP_POOL_TSX_INC -> 256
        public const int PJSIP_POOL_TSX_INC = 256;

        /// PJSIP_MAX_TSX_KEY_LEN -> (PJSIP_MAX_URL_SIZE*2)
        public const int PJSIP_MAX_TSX_KEY_LEN = (NativeConstants.PJSIP_MAX_URL_SIZE * 2);

        /// PJSIP_POOL_LEN_USER_AGENT -> 1024
        public const int PJSIP_POOL_LEN_USER_AGENT = 1024;

        /// PJSIP_POOL_INC_USER_AGENT -> 1024
        public const int PJSIP_POOL_INC_USER_AGENT = 1024;

        /// PJSIP_MAX_CALL_ID_LEN -> pj_GUID_STRING_LENGTH()
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJSIP_MAX_CALL_ID_LEN = "pj_GUID_STRING_LENGTH()";

        /// PJSIP_MAX_TAG_LEN -> pj_GUID_STRING_LENGTH()
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJSIP_MAX_TAG_LEN = "pj_GUID_STRING_LENGTH()";

        /// PJSIP_MAX_BRANCH_LEN -> (PJSIP_RFC3261_BRANCH_LEN + pj_GUID_STRING_LENGTH() + 2)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJSIP_MAX_BRANCH_LEN = "(PJSIP_RFC3261_BRANCH_LEN + pj_GUID_STRING_LENGTH() + 2)";

        /// PJSIP_MAX_HNAME_LEN -> 64
        public const int PJSIP_MAX_HNAME_LEN = 64;

        /// PJSIP_POOL_LEN_DIALOG -> 1200
        public const int PJSIP_POOL_LEN_DIALOG = 1200;

        /// PJSIP_POOL_INC_DIALOG -> 512
        public const int PJSIP_POOL_INC_DIALOG = 512;

        /// PJSIP_MAX_HEADER_TYPES -> 72
        public const int PJSIP_MAX_HEADER_TYPES = 72;

        /// PJSIP_MAX_URI_TYPES -> 4
        public const int PJSIP_MAX_URI_TYPES = 4;

        /// PJSIP_T1_TIMEOUT -> 500
        public const int PJSIP_T1_TIMEOUT = 500;

        /// PJSIP_T2_TIMEOUT -> 4000
        public const int PJSIP_T2_TIMEOUT = 4000;

        /// PJSIP_T4_TIMEOUT -> 5000
        public const int PJSIP_T4_TIMEOUT = 5000;

        /// PJSIP_TD_TIMEOUT -> 32000
        public const int PJSIP_TD_TIMEOUT = 32000;

        /// PJSIP_AUTH_HEADER_CACHING -> 0
        public const int PJSIP_AUTH_HEADER_CACHING = 0;

        /// PJSIP_AUTH_AUTO_SEND_NEXT -> 0
        public const int PJSIP_AUTH_AUTO_SEND_NEXT = 0;

        /// PJSIP_AUTH_QOP_SUPPORT -> 1
        public const int PJSIP_AUTH_QOP_SUPPORT = 1;

        /// PJSIP_MAX_STALE_COUNT -> 3
        public const int PJSIP_MAX_STALE_COUNT = 3;

        /// PJSIP_HAS_DIGEST_AKA_AUTH -> 0
        public const int PJSIP_HAS_DIGEST_AKA_AUTH = 0;

        /// PJSIP_REGISTER_CLIENT_DELAY_BEFORE_REFRESH -> 5
        public const int PJSIP_REGISTER_CLIENT_DELAY_BEFORE_REFRESH = 5;

        /// PJSIP_REGISTER_CLIENT_CHECK_CONTACT -> 1
        public const int PJSIP_REGISTER_CLIENT_CHECK_CONTACT = 1;

        /// PJSIP_REGISTER_CLIENT_ADD_XUID_PARAM -> 0
        public const int PJSIP_REGISTER_CLIENT_ADD_XUID_PARAM = 0;

        /// PJSIP_EVSUB_TIME_UAC_REFRESH -> 5
        public const int PJSIP_EVSUB_TIME_UAC_REFRESH = 5;

        /// PJSIP_PUBLISHC_DELAY_BEFORE_REFRESH -> 5
        public const int PJSIP_PUBLISHC_DELAY_BEFORE_REFRESH = 5;

        /// PJSIP_EVSUB_TIME_UAC_TERMINATE -> 5
        public const int PJSIP_EVSUB_TIME_UAC_TERMINATE = 5;

        /// PJSIP_EVSUB_TIME_UAC_WAIT_NOTIFY -> 5
        public const int PJSIP_EVSUB_TIME_UAC_WAIT_NOTIFY = 5;

        /// PJSIP_PRES_DEFAULT_EXPIRES -> 600
        public const int PJSIP_PRES_DEFAULT_EXPIRES = 600;

        /// PJSIP_PRES_PIDF_ADD_TIMESTAMP -> 1
        public const int PJSIP_PRES_PIDF_ADD_TIMESTAMP = 1;

        /// PJSIP_SESS_TIMER_DEF_SE -> 1800
        public const int PJSIP_SESS_TIMER_DEF_SE = 1800;

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_RETURN_EXCEPTION -> "() pjsip_exception_to_status(PJ_GET_EXCEPTION())"
        public const string PJSIP_RETURN_EXCEPTION = "() pjsip_exception_to_status(PJ_GET_EXCEPTION())";

        /// PJSIP_THROW_SPEC -> (list)
        /// Error generating expression: Value list is not resolved
        public const string PJSIP_THROW_SPEC = "(list)";

        /// __PJSIP_SIP_ERRNO_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_ERRNO_H__ = "";

        /// PJSIP_ERRNO_START -> (PJ_ERRNO_START_USER)
        /// Error generating expression: Value PJ_ERRNO_START_USER is not resolved
        public const string PJSIP_ERRNO_START = "(PJ_ERRNO_START_USER)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_ERRNO_FROM_SIP_STATUS -> "(code) (PJSIP_ERRNO_START+code)"
        public const string PJSIP_ERRNO_FROM_SIP_STATUS = "(code) (PJSIP_ERRNO_START+code)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_ERRNO_TO_SIP_STATUS -> "(status) ((status>=PJSIP_ERRNO_FROM_SIP_STATUS(100) &&  
        ///           status<PJSIP_ERRNO_FROM_SIP_STATUS(800)) ?   
        ///          status-PJSIP_ERRNO_FROM_SIP_STATUS(0) : 599)"
        public const string PJSIP_ERRNO_TO_SIP_STATUS = "(status) ((status>=PJSIP_ERRNO_FROM_SIP_STATUS(100) &&  \r\n           status<PJSIP" +
            "_ERRNO_FROM_SIP_STATUS(800)) ?   \r\n          status-PJSIP_ERRNO_FROM_SIP_STATUS(" +
            "0) : 599)";

        /// PJSIP_ERRNO_START_PJSIP -> (PJSIP_ERRNO_START + 1000)

        /// __PJSIP_SIP_URI_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_URI_H__ = "";

        /// __PJ_LIST_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_LIST_H__ = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DECL_LIST_MEMBER -> "(type) type *prev;          
        ///                                    
        ///                                   type *next"
        public const string PJ_DECL_LIST_MEMBER = "(type) type *prev;          \r\n                                    \r\n             " +
            "                      type *next";

        /// __PJ_SCANNER_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_SCANNER_H__ = "";

        /// __PJLIB_UTIL_TYPES_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_TYPES_H__ = "";

        /// __PJLIB_UTIL_CONFIG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_CONFIG_H__ = "";

        /// PJ_DNS_MAX_IP_IN_A_REC -> 8
        public const int PJ_DNS_MAX_IP_IN_A_REC = 8;

        /// PJ_DNS_SRV_MAX_ADDR -> 8
        public const int PJ_DNS_SRV_MAX_ADDR = 8;

        /// PJ_DNS_MAX_NAMES_IN_NAMETABLE -> 16
        public const int PJ_DNS_MAX_NAMES_IN_NAMETABLE = 16;

        /// PJ_DNS_RESOLVER_MAX_NS -> 16
        public const int PJ_DNS_RESOLVER_MAX_NS = 16;

        /// PJ_DNS_RESOLVER_QUERY_RETRANSMIT_DELAY -> 2000
        public const int PJ_DNS_RESOLVER_QUERY_RETRANSMIT_DELAY = 2000;

        /// PJ_DNS_RESOLVER_QUERY_RETRANSMIT_COUNT -> 5
        public const int PJ_DNS_RESOLVER_QUERY_RETRANSMIT_COUNT = 5;

        /// PJ_DNS_RESOLVER_MAX_TTL -> (5*60)
        public const int PJ_DNS_RESOLVER_MAX_TTL = (5 * 60);

        /// PJ_DNS_RESOLVER_INVALID_TTL -> 60
        public const int PJ_DNS_RESOLVER_INVALID_TTL = 60;

        /// PJ_DNS_RESOLVER_GOOD_NS_TTL -> (10*60)
        public const int PJ_DNS_RESOLVER_GOOD_NS_TTL = (10 * 60);

        /// PJ_DNS_RESOLVER_BAD_NS_TTL -> (1*60)
        public const int PJ_DNS_RESOLVER_BAD_NS_TTL = (1 * 60);

        /// PJ_DNS_RESOLVER_MAX_UDP_SIZE -> 512
        public const int PJ_DNS_RESOLVER_MAX_UDP_SIZE = 512;

        /// PJ_DNS_RESOLVER_RES_BUF_SIZE -> 512
        public const int PJ_DNS_RESOLVER_RES_BUF_SIZE = 512;

        /// PJ_DNS_RESOLVER_TMP_BUF_SIZE -> 4000
        public const int PJ_DNS_RESOLVER_TMP_BUF_SIZE = 4000;

        /// PJSTUN_MAX_ATTR -> 16
        public const int PJSTUN_MAX_ATTR = 16;

        /// PJ_STUN_MAX_ATTR -> 16
        public const int PJ_STUN_MAX_ATTR = 16;

        /// PJ_CRC32_HAS_TABLES -> 1
        public const int PJ_CRC32_HAS_TABLES = 1;

        /// __PJLIB_UTIL_SCANNER_CIS_BIT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_SCANNER_CIS_BIT_H__ = "";

        /// PJ_CIS_ELEM_TYPE -> pj_uint32_t
        /// Error generating expression: Value pj_uint32_t is not resolved
        public const string PJ_CIS_ELEM_TYPE = "pj_uint32_t";

        /// PJ_CIS_MAX_INDEX -> (sizeof(pj_cis_elem_t) << 3)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJ_CIS_MAX_INDEX = "(sizeof(pj_cis_elem_t) << 3)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_CIS_SET -> "(cis,c) ((cis)->cis_buf[(int)(c)] |= (1 << (cis)->cis_id))"
        public const string PJ_CIS_SET = "(cis,c) ((cis)->cis_buf[(int)(c)] |= (1 << (cis)->cis_id))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_CIS_CLR -> "(cis,c) ((cis)->cis_buf[(int)c] &= ~(1 << (cis)->cis_id))"
        public const string PJ_CIS_CLR = "(cis,c) ((cis)->cis_buf[(int)c] &= ~(1 << (cis)->cis_id))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_CIS_ISSET -> "(cis,c) ((cis)->cis_buf[(int)c] & (1 << (cis)->cis_id))"
        public const string PJ_CIS_ISSET = "(cis,c) ((cis)->cis_buf[(int)c] & (1 << (cis)->cis_id))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_URI_SCHEME_IS_SIP -> "(url) (pj_strnicmp2(pjsip_uri_get_scheme(url), "sip", 3)==0)"
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJSIP_URI_SCHEME_IS_SIP = "\"(url) (pj_strnicmp2(pjsip_uri_get_scheme(url), \"sip\", 3)==0)\"";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_URI_SCHEME_IS_SIPS -> "(url) (pj_strnicmp2(pjsip_uri_get_scheme(url), "sips", 4)==0)"
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJSIP_URI_SCHEME_IS_SIPS = "\"(url) (pj_strnicmp2(pjsip_uri_get_scheme(url), \"sips\", 4)==0)\"";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_URI_SCHEME_IS_TEL -> "(url) (pj_strnicmp2(pjsip_uri_get_scheme(url), "tel", 3)==0)"
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJSIP_URI_SCHEME_IS_TEL = "\"(url) (pj_strnicmp2(pjsip_uri_get_scheme(url), \"tel\", 3)==0)\"";

        /// __PJSIP_TEL_URI_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_TEL_URI_H__ = "";

        /// __PJSIP_SIP_MSG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_MSG_H__ = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_DECL_HDR_MEMBER -> "(hdr) PJ_DECL_LIST_MEMBER(hdr);	
        ///    		
        ///    pjsip_hdr_e	    type;	
        ///    		
        ///    pj_str_t	    name;	
        ///    	
        ///    pj_str_t	    sname;		
        ///    	
        ///    pjsip_hdr_vptr *vptr"
        public const string PJSIP_DECL_HDR_MEMBER = "(hdr) PJ_DECL_LIST_MEMBER(hdr);\t\r\n    \t\t\r\n    pjsip_hdr_e\t    type;\t\r\n    \t\t\r\n   " +
            " pj_str_t\t    name;\t\r\n    \t\r\n    pj_str_t\t    sname;\t\t\r\n    \t\r\n    pjsip_hdr_vpt" +
            "r *vptr";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_IS_STATUS_IN_CLASS -> "(status_code,code_class) (status_code/100 == code_class/100)"
        public const string PJSIP_IS_STATUS_IN_CLASS = "(status_code,code_class) (status_code/100 == code_class/100)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_MSG_CID_HDR -> "(msg) ((pjsip_cid_hdr*)pjsip_msg_find_hdr(msg, PJSIP_H_CALL_ID, NULL))"
        public const string PJSIP_MSG_CID_HDR = "(msg) ((pjsip_cid_hdr*)pjsip_msg_find_hdr(msg, PJSIP_H_CALL_ID, NULL))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_MSG_CSEQ_HDR -> "(msg) ((pjsip_cseq_hdr*)pjsip_msg_find_hdr(msg, PJSIP_H_CSEQ, NULL))"
        public const string PJSIP_MSG_CSEQ_HDR = "(msg) ((pjsip_cseq_hdr*)pjsip_msg_find_hdr(msg, PJSIP_H_CSEQ, NULL))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_MSG_FROM_HDR -> "(msg) ((pjsip_from_hdr*)pjsip_msg_find_hdr(msg, PJSIP_H_FROM, NULL))"
        public const string PJSIP_MSG_FROM_HDR = "(msg) ((pjsip_from_hdr*)pjsip_msg_find_hdr(msg, PJSIP_H_FROM, NULL))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_MSG_TO_HDR -> "(msg) ((pjsip_to_hdr*)pjsip_msg_find_hdr(msg, PJSIP_H_TO, NULL))"
        public const string PJSIP_MSG_TO_HDR = "(msg) ((pjsip_to_hdr*)pjsip_msg_find_hdr(msg, PJSIP_H_TO, NULL))";

        /// PJSIP_GENERIC_ARRAY_MAX_COUNT -> 32
        public const int PJSIP_GENERIC_ARRAY_MAX_COUNT = 32;

        /// PJSIP_MAX_ACCEPT_COUNT -> PJSIP_GENERIC_ARRAY_MAX_COUNT
        public const int PJSIP_MAX_ACCEPT_COUNT = NativeConstants.PJSIP_GENERIC_ARRAY_MAX_COUNT;

        /// pjsip_accept_encoding_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_accept_encoding_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_accept_lang_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_accept_lang_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_alert_info_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_alert_info_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_auth_info_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_auth_info_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_call_info_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_call_info_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_content_disposition_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_content_disposition_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_content_encoding_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_content_encoding_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_content_lang_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_content_lang_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_date_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_date_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_err_info_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_err_info_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_in_reply_to_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_in_reply_to_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_mime_version_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_mime_version_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_organization_hdr_create -> pjsip_genric_string_hdr_create
        /// Error generating expression: Value pjsip_genric_string_hdr_create is not resolved
        public const string pjsip_organization_hdr_create = "pjsip_genric_string_hdr_create";

        /// pjsip_priority_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_priority_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_reply_to_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_reply_to_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_server_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_server_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_subject_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_subject_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_timestamp_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_timestamp_hdr_create = "pjsip_generic_string_hdr_create";

        /// pjsip_user_agent_hdr_create -> pjsip_generic_string_hdr_create
        /// Error generating expression: Value pjsip_generic_string_hdr_create is not resolved
        public const string pjsip_user_agent_hdr_create = "pjsip_generic_string_hdr_create";

        /// __PJSIP_SIP_PARSER_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_PARSER_H__ = "";

        /// __PJSIP_SIP_EVENT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_EVENT_H__ = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_EVENT_INIT_TIMER -> "(event,pentry) do { 
        ///            (event).type = PJSIP_EVENT_TIMER;           
        ///            (event).body.timer.entry = pentry;          
        ///        } while (0)"
        public const string PJSIP_EVENT_INIT_TIMER = "(event,pentry) do { \r\n            (event).type = PJSIP_EVENT_TIMER;           \r\n " +
            "           (event).body.timer.entry = pentry;          \r\n        } while (0)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_EVENT_INIT_TSX_STATE -> "(event,ptsx,ptype,pdata,prev) do { 
        ///            (event).type = PJSIP_EVENT_TSX_STATE;           
        ///            (event).body.tsx_state.tsx = ptsx;		    
        ///            (event).body.tsx_state.type = ptype;            
        ///            (event).body.tsx_state.src.data = pdata;        
        ///	    (event).body.tsx_state.prev_state = prev;	    
        ///        } while (0)"
        public const string PJSIP_EVENT_INIT_TSX_STATE = @"(event,ptsx,ptype,pdata,prev) do { 
            (event).type = PJSIP_EVENT_TSX_STATE;           
            (event).body.tsx_state.tsx = ptsx;		    
            (event).body.tsx_state.type = ptype;            
            (event).body.tsx_state.src.data = pdata;        
	    (event).body.tsx_state.prev_state = prev;	    
        } while (0)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_EVENT_INIT_TX_MSG -> "(event,ptdata) do { 
        ///            (event).type = PJSIP_EVENT_TX_MSG;          
        ///            (event).body.tx_msg.tdata = ptdata;		
        ///        } while (0)"
        public const string PJSIP_EVENT_INIT_TX_MSG = "(event,ptdata) do { \r\n            (event).type = PJSIP_EVENT_TX_MSG;          \r\n " +
            "           (event).body.tx_msg.tdata = ptdata;\t\t\r\n        } while (0)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_EVENT_INIT_RX_MSG -> "(event,prdata) do { 
        ///            (event).type = PJSIP_EVENT_RX_MSG;		
        ///            (event).body.rx_msg.rdata = prdata;		
        ///        } while (0)"
        public const string PJSIP_EVENT_INIT_RX_MSG = "(event,prdata) do { \r\n            (event).type = PJSIP_EVENT_RX_MSG;\t\t\r\n         " +
            "   (event).body.rx_msg.rdata = prdata;\t\t\r\n        } while (0)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_EVENT_INIT_TRANSPORT_ERROR -> "(event,ptsx,ptdata) do { 
        ///            (event).type = PJSIP_EVENT_TRANSPORT_ERROR; 
        ///            (event).body.tx_error.tsx = ptsx;		
        ///            (event).body.tx_error.tdata = ptdata;	
        ///        } while (0)"
        public const string PJSIP_EVENT_INIT_TRANSPORT_ERROR = "(event,ptsx,ptdata) do { \r\n            (event).type = PJSIP_EVENT_TRANSPORT_ERROR" +
            "; \r\n            (event).body.tx_error.tsx = ptsx;\t\t\r\n            (event).body.tx" +
            "_error.tdata = ptdata;\t\r\n        } while (0)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_EVENT_INIT_USER -> "(event,u1,u2,u3,u4) do { 
        ///            (event).type = PJSIP_EVENT_USER;        
        ///            (event).body.user.user1 = (void*)u1;     
        ///            (event).body.user.user2 = (void*)u2;     
        ///            (event).body.user.user3 = (void*)u3;     
        ///            (event).body.user.user4 = (void*)u4;     
        ///        } while (0)"
        public const string PJSIP_EVENT_INIT_USER = @"(event,u1,u2,u3,u4) do { 
            (event).type = PJSIP_EVENT_USER;        
            (event).body.user.user1 = (void*)u1;     
            (event).body.user.user2 = (void*)u2;     
            (event).body.user.user3 = (void*)u3;     
            (event).body.user.user4 = (void*)u4;     
        } while (0)";

        /// __PJSIP_SIP_MODULE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_MODULE_H__ = "";

        /// __PJSIP_SIP_ENDPOINT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_ENDPOINT_H__ = "";

        /// __PJSIP_SIP_TRANSPORT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_TRANSPORT_H__ = "";

        /// __PJ_SOCK_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_SOCK_H__ = "";

        /// PJ_AF_LOCAL -> PJ_AF_UNIX;
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_AF_LOCAL = "PJ_AF_UNIX;";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_AF_UNSPEC -> "() PJ_AF_UNSPEC"
        public const string pj_AF_UNSPEC = "() PJ_AF_UNSPEC";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_AF_UNIX -> "() PJ_AF_UNIX"
        public const string pj_AF_UNIX = "() PJ_AF_UNIX";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_AF_INET -> "() PJ_AF_INET"
        public const string pj_AF_INET = "() PJ_AF_INET";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_AF_INET6 -> "() PJ_AF_INET6"
        public const string pj_AF_INET6 = "() PJ_AF_INET6";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_AF_PACKET -> "() PJ_AF_PACKET"
        public const string pj_AF_PACKET = "() PJ_AF_PACKET";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_AF_IRDA -> "() PJ_AF_IRDA"
        public const string pj_AF_IRDA = "() PJ_AF_IRDA";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_SOCK_STREAM -> "() PJ_SOCK_STREAM"
        public const string pj_SOCK_STREAM = "() PJ_SOCK_STREAM";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_SOCK_DGRAM -> "() PJ_SOCK_DGRAM"
        public const string pj_SOCK_DGRAM = "() PJ_SOCK_DGRAM";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_SOCK_RAW -> "() PJ_SOCK_RAW"
        public const string pj_SOCK_RAW = "() PJ_SOCK_RAW";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_SOCK_RDM -> "() PJ_SOCK_RDM"
        public const string pj_SOCK_RDM = "() PJ_SOCK_RDM";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_SOL_SOCKET -> "() PJ_SOL_SOCKET"
        public const string pj_SOL_SOCKET = "() PJ_SOL_SOCKET";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_SOL_IP -> "() PJ_SOL_IP"
        public const string pj_SOL_IP = "() PJ_SOL_IP";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_SOL_TCP -> "() PJ_SOL_TCP"
        public const string pj_SOL_TCP = "() PJ_SOL_TCP";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_SOL_UDP -> "() PJ_SOL_UDP"
        public const string pj_SOL_UDP = "() PJ_SOL_UDP";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_SOL_IPV6 -> "() PJ_SOL_IPV6"
        public const string pj_SOL_IPV6 = "() PJ_SOL_IPV6";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_IP_TOS -> "() PJ_IP_TOS"
        public const string pj_IP_TOS = "() PJ_IP_TOS";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_IPTOS_LOWDELAY -> "() PJ_IP_TOS_LOWDELAY"
        public const string pj_IPTOS_LOWDELAY = "() PJ_IP_TOS_LOWDELAY";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_IPTOS_THROUGHPUT -> "() PJ_IP_TOS_THROUGHPUT"
        public const string pj_IPTOS_THROUGHPUT = "() PJ_IP_TOS_THROUGHPUT";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_IPTOS_RELIABILITY -> "() PJ_IP_TOS_RELIABILITY"
        public const string pj_IPTOS_RELIABILITY = "() PJ_IP_TOS_RELIABILITY";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_IPTOS_MINCOST -> "() PJ_IP_TOS_MINCOST"
        public const string pj_IPTOS_MINCOST = "() PJ_IP_TOS_MINCOST";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_SO_TYPE -> "() PJ_SO_TYPE"
        public const string pj_SO_TYPE = "() PJ_SO_TYPE";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_SO_RCVBUF -> "() PJ_SO_RCVBUF"
        public const string pj_SO_RCVBUF = "() PJ_SO_RCVBUF";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_SO_SNDBUF -> "() PJ_SO_SNDBUF"
        public const string pj_SO_SNDBUF = "() PJ_SO_SNDBUF";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_IP_MULTICAST_IF -> "() PJ_IP_MULTICAST_IF"
        public const string pj_IP_MULTICAST_IF = "() PJ_IP_MULTICAST_IF";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_IP_MULTICAST_TTL -> "() PJ_IP_MULTICAST_TTL"
        public const string pj_IP_MULTICAST_TTL = "() PJ_IP_MULTICAST_TTL";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_IP_MULTICAST_LOOP -> "() PJ_IP_MULTICAST_LOOP"
        public const string pj_IP_MULTICAST_LOOP = "() PJ_IP_MULTICAST_LOOP";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_IP_ADD_MEMBERSHIP -> "() PJ_IP_ADD_MEMBERSHIP"
        public const string pj_IP_ADD_MEMBERSHIP = "() PJ_IP_ADD_MEMBERSHIP";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_IP_DROP_MEMBERSHIP -> "() PJ_IP_DROP_MEMBERSHIP"
        public const string pj_IP_DROP_MEMBERSHIP = "() PJ_IP_DROP_MEMBERSHIP";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_MSG_OOB -> "() PJ_MSG_OOB"
        public const string pj_MSG_OOB = "() PJ_MSG_OOB";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_MSG_PEEK -> "() PJ_MSG_PEEK"
        public const string pj_MSG_PEEK = "() PJ_MSG_PEEK";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_MSG_DONTROUTE -> "() PJ_MSG_DONTROUTE"
        public const string pj_MSG_DONTROUTE = "() PJ_MSG_DONTROUTE";

        /// PJ_INADDR_ANY -> ((pj_uint32_t)0)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string PJ_INADDR_ANY = "((pj_uint32_t)0)";

        /// PJ_INADDR_NONE -> ((pj_uint32_t)0xffffffff)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string PJ_INADDR_NONE = "((pj_uint32_t)0xffffffff)";

        /// PJ_INADDR_BROADCAST -> ((pj_uint32_t)0xffffffff)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string PJ_INADDR_BROADCAST = "((pj_uint32_t)0xffffffff)";

        /// PJ_SOMAXCONN -> 5
        public const int PJ_SOMAXCONN = 5;

        /// PJ_INVALID_SOCKET -> (-1)
        public const int PJ_INVALID_SOCKET = -1;

        /// PJ_INET_ADDRSTRLEN -> 16
        public const int PJ_INET_ADDRSTRLEN = 16;

        /// PJ_INET6_ADDRSTRLEN -> 46
        public const int PJ_INET6_ADDRSTRLEN = 46;

        /// PJ_IN6ADDR_ANY_INIT -> { { { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } } }
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_IN6ADDR_ANY_INIT = "{ { { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } } }";

        /// PJ_IN6ADDR_LOOPBACK_INIT -> { { { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 } } }
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_IN6ADDR_LOOPBACK_INIT = "{ { { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 } } }";

        /// __PJ_IOQUEUE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_IOQUEUE_H__ = "";

        /// PJ_IOQUEUE_MAX_EVENTS_IN_SINGLE_POLL -> (16)
        public const int PJ_IOQUEUE_MAX_EVENTS_IN_SINGLE_POLL = 16;

        /// PJ_IOQUEUE_ALWAYS_ASYNC -> ((pj_uint32_t)1 << (pj_uint32_t)31)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string PJ_IOQUEUE_ALWAYS_ASYNC = "((pj_uint32_t)1 << (pj_uint32_t)31)";

        /// __PJ_TIMER_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_TIMER_H__ = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_TRANSPORT_IS_RELIABLE -> "(tp) ((tp)->flag & PJSIP_TRANSPORT_RELIABLE)"
        public const string PJSIP_TRANSPORT_IS_RELIABLE = "(tp) ((tp)->flag & PJSIP_TRANSPORT_RELIABLE)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_TRANSPORT_IS_SECURE -> "(tp) ((tp)->flag & PJSIP_TRANSPORT_SECURE)"
        public const string PJSIP_TRANSPORT_IS_SECURE = "(tp) ((tp)->flag & PJSIP_TRANSPORT_SECURE)";

        /// __PJSIP_SIP_RESOLVE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_RESOLVE_H__ = "";

        /// __PJLIB_UTIL_RESOLVER_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_RESOLVER_H__ = "";

        /// __PJLIB_UTIL_DNS_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_DNS_H__ = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_SET_RCODE -> "(c) ((pj_uint16_t)((c) & 0x0F))"
        public const string PJ_DNS_SET_RCODE = "(c) ((pj_uint16_t)((c) & 0x0F))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_SET_RA -> "(on) ((pj_uint16_t)((on) << 7))"
        public const string PJ_DNS_SET_RA = "(on) ((pj_uint16_t)((on) << 7))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_SET_RD -> "(on) ((pj_uint16_t)((on) << 8))"
        public const string PJ_DNS_SET_RD = "(on) ((pj_uint16_t)((on) << 8))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_SET_TC -> "(on) ((pj_uint16_t)((on) << 9))"
        public const string PJ_DNS_SET_TC = "(on) ((pj_uint16_t)((on) << 9))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_SET_AA -> "(on) ((pj_uint16_t)((on) << 10))"
        public const string PJ_DNS_SET_AA = "(on) ((pj_uint16_t)((on) << 10))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_SET_OPCODE -> "(o) ((pj_uint16_t)((o)  << 11))"
        public const string PJ_DNS_SET_OPCODE = "(o) ((pj_uint16_t)((o)  << 11))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_SET_QR -> "(on) ((pj_uint16_t)((on) << 15))"
        public const string PJ_DNS_SET_QR = "(on) ((pj_uint16_t)((on) << 15))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_GET_RCODE -> "(val) (((val) & PJ_DNS_SET_RCODE(0x0F)) >> 0)"
        public const string PJ_DNS_GET_RCODE = "(val) (((val) & PJ_DNS_SET_RCODE(0x0F)) >> 0)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_GET_RA -> "(val) (((val) & PJ_DNS_SET_RA(1)) >> 7)"
        public const string PJ_DNS_GET_RA = "(val) (((val) & PJ_DNS_SET_RA(1)) >> 7)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_GET_RD -> "(val) (((val) & PJ_DNS_SET_RD(1)) >> 8)"
        public const string PJ_DNS_GET_RD = "(val) (((val) & PJ_DNS_SET_RD(1)) >> 8)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_GET_TC -> "(val) (((val) & PJ_DNS_SET_TC(1)) >> 9)"
        public const string PJ_DNS_GET_TC = "(val) (((val) & PJ_DNS_SET_TC(1)) >> 9)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_GET_AA -> "(val) (((val) & PJ_DNS_SET_AA(1)) >> 10)"
        public const string PJ_DNS_GET_AA = "(val) (((val) & PJ_DNS_SET_AA(1)) >> 10)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_GET_OPCODE -> "(val) (((val) & PJ_DNS_SET_OPCODE(0x0F)) >> 11)"
        public const string PJ_DNS_GET_OPCODE = "(val) (((val) & PJ_DNS_SET_OPCODE(0x0F)) >> 11)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_DNS_GET_QR -> "(val) (((val) & PJ_DNS_SET_QR(1)) >> 15)"
        public const string PJ_DNS_GET_QR = "(val) (((val) & PJ_DNS_SET_QR(1)) >> 15)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_ENDPT_LOG_ERROR -> "(expr) pjsip_endpt_log_error expr"
        public const string PJSIP_ENDPT_LOG_ERROR = "(expr) pjsip_endpt_log_error expr";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJSIP_ENDPT_TRACE -> "(tracing,expr) do {                        
        ///                if ((tracing))          
        ///                    PJ_LOG(4,expr);     
        ///            } while (0)"
        public const string PJSIP_ENDPT_TRACE = "(tracing,expr) do {                        \r\n                if ((tracing))      " +
            "    \r\n                    PJ_LOG(4,expr);     \r\n            } while (0)";

        /// __PJSIP_SIP_MISC_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_MISC_H__ = "";

        /// __PJSIP_TRANSPORT_UDP_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_TRANSPORT_UDP_H__ = "";

        /// __PJSIP_TRANSPORT_LOOP_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_TRANSPORT_LOOP_H__ = "";

        /// __PJSIP_TRANSPORT_TCP_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_TRANSPORT_TCP_H__ = "";

        /// __PJSIP_TRANSPORT_TLS_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_TRANSPORT_TLS_H__ = "";

        /// __PJ_STRING_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_STRING_H__ = "";

        /// __PJ_COMPAT_STRING_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_COMPAT_STRING_H__ = "";

        /// _INC_STDIO -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _INC_STDIO = "";

        /// BUFSIZ -> 512
        public const int BUFSIZ = 512;

        /// _NFILE -> _NSTREAM_
        public const int _NFILE = NativeConstants._NSTREAM_;

        /// _NSTREAM_ -> 512
        public const int _NSTREAM_ = 512;

        /// _IOB_ENTRIES -> 20
        public const int _IOB_ENTRIES = 20;

        /// EOF -> (-1)
        public const int EOF = -1;

        /// _FILE_DEFINED -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _FILE_DEFINED = "";

        /// _P_tmpdir -> "\\"
        public const string _P_tmpdir = "\\\\";

        /// _wP_tmpdir -> L"\\"
        public const string _wP_tmpdir = "\\\\";

        /// L_tmpnam -> (sizeof(_P_tmpdir) + 12)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string L_tmpnam = "(sizeof(_P_tmpdir) + 12)";

        /// L_tmpnam_s -> (sizeof(_P_tmpdir) + 16)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string L_tmpnam_s = "(sizeof(_P_tmpdir) + 16)";

        /// FILENAME_MAX -> 260
        public const int FILENAME_MAX = 260;

        /// FOPEN_MAX -> 20
        public const int FOPEN_MAX = 20;

        /// _SYS_OPEN -> 20
        public const int _SYS_OPEN = 20;

        /// TMP_MAX -> 32767
        public const int TMP_MAX = 32767;

        /// _TMP_MAX_S -> 2147483647
        public const int _TMP_MAX_S = 2147483647;

        /// Warning: Generation of Method Macros is not supported at this time
        /// _FPOSOFF -> "(fp) ((long)(fp))"
        public const string _FPOSOFF = "(fp) ((long)(fp))";

        /// _FPOS_T_DEFINED -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _FPOS_T_DEFINED = "";

        /// stdin -> (&__iob_func()[0])
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string stdin = "(&__iob_func()[0])";

        /// stdout -> (&__iob_func()[1])
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string stdout = "(&__iob_func()[1])";

        /// stderr -> (&__iob_func()[2])
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string stderr = "(&__iob_func()[2])";

        /// _STDSTREAM_DEFINED -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _STDSTREAM_DEFINED = "";

        /// _IOREAD -> 0x0001
        public const int _IOREAD = 1;

        /// _IOWRT -> 0x0002
        public const int _IOWRT = 2;

        /// _IOFBF -> 0x0000
        public const int _IOFBF = 0;

        /// _IOLBF -> 0x0040
        public const int _IOLBF = 64;

        /// _IONBF -> 0x0004
        public const int _IONBF = 4;

        /// _IOMYBUF -> 0x0008
        public const int _IOMYBUF = 8;

        /// _IOEOF -> 0x0010
        public const int _IOEOF = 16;

        /// _IOERR -> 0x0020
        public const int _IOERR = 32;

        /// _IOSTRG -> 0x0040
        public const int _IOSTRG = 64;

        /// _IORW -> 0x0080
        public const int _IORW = 128;

        /// _TWO_DIGIT_EXPONENT -> 0x1
        public const int _TWO_DIGIT_EXPONENT = 1;

        /// _CRT_DIRECTORY_DEFINED -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _CRT_DIRECTORY_DEFINED = "";

        /// _SWPRINTFS_DEPRECATED -> _CRT_DEPRECATE_TEXT("swprintf has been changed to conform with the ISO C standard, adding an extra character count parameter. To use traditional Microsoft swprintf, set _CRT_NON_CONFORMING_SWPRINTFS.")
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string _SWPRINTFS_DEPRECATED = "_CRT_DEPRECATE_TEXT(\"swprintf has been changed to conform with the ISO C standard" +
            ", adding an extra character count parameter. To use traditional Microsoft swprin" +
            "tf, set _CRT_NON_CONFORMING_SWPRINTFS.\")";

        /// _INC_SWPRINTF_INL_ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _INC_SWPRINTF_INL_ = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// getwchar -> "() fgetwc(stdin)"
        public const string getwchar = "() fgetwc(stdin)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// putwchar -> "(_c) fputwc((_c),stdout)"
        public const string putwchar = "(_c) fputwc((_c),stdout)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// getwc -> "(_stm) fgetwc(_stm)"
        public const string getwc = "(_stm) fgetwc(_stm)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// putwc -> "(_c,_stm) fputwc(_c,_stm)"
        public const string putwc = "(_c,_stm) fputwc(_c,_stm)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _putwc_nolock -> "(_c,_stm) _fputwc_nolock(_c,_stm)"
        public const string _putwc_nolock = "(_c,_stm) _fputwc_nolock(_c,_stm)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _getwc_nolock -> "(_stm) _fgetwc_nolock(_stm)"
        public const string _getwc_nolock = "(_stm) _fgetwc_nolock(_stm)";

        /// _WSTDIO_DEFINED -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _WSTDIO_DEFINED = "";

        /// _STDIO_DEFINED -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _STDIO_DEFINED = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _fgetc_nolock -> "(_stream) (--(_stream)->_cnt >= 0 ? 0xff & *(_stream)->_ptr++ : _filbuf(_stream))"
        public const string _fgetc_nolock = "(_stream) (--(_stream)->_cnt >= 0 ? 0xff & *(_stream)->_ptr++ : _filbuf(_stream))" +
            "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _fputc_nolock -> "(_c,_stream) (--(_stream)->_cnt >= 0 ? 0xff & (*(_stream)->_ptr++ = (char)(_c)) :  _flsbuf((_c),(_stream)))"
        public const string _fputc_nolock = "(_c,_stream) (--(_stream)->_cnt >= 0 ? 0xff & (*(_stream)->_ptr++ = (char)(_c)) :" +
            "  _flsbuf((_c),(_stream)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _getc_nolock -> "(_stream) _fgetc_nolock(_stream)"
        public const string _getc_nolock = "(_stream) _fgetc_nolock(_stream)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _putc_nolock -> "(_c,_stream) _fputc_nolock(_c, _stream)"
        public const string _putc_nolock = "(_c,_stream) _fputc_nolock(_c, _stream)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _getchar_nolock -> "() _getc_nolock(stdin)"
        public const string _getchar_nolock = "() _getc_nolock(stdin)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _putchar_nolock -> "(_c) _putc_nolock((_c),stdout)"
        public const string _putchar_nolock = "(_c) _putc_nolock((_c),stdout)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _getwchar_nolock -> "() _getwc_nolock(stdin)"
        public const string _getwchar_nolock = "() _getwc_nolock(stdin)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _putwchar_nolock -> "(_c) _putwc_nolock((_c),stdout)"
        public const string _putwchar_nolock = "(_c) _putwc_nolock((_c),stdout)";

        /// _lock_file -> (c)
        /// Error generating expression: Value c is not resolved
        public const string _lock_file = "(c)";

        /// _unlock_file -> (c)
        /// Error generating expression: Value c is not resolved
        public const string _unlock_file = "(c)";

        /// strcasecmp -> _stricmp
        /// Error generating expression: Value _stricmp is not resolved
        public const string strcasecmp = "_stricmp";

        /// strncasecmp -> _strnicmp
        /// Error generating expression: Value _strnicmp is not resolved
        public const string strncasecmp = "_strnicmp";

        /// snprintf -> _snprintf
        /// Error generating expression: Value _snprintf is not resolved
        public const string snprintf = "_snprintf";

        /// vsnprintf -> _vsnprintf
        /// Error generating expression: Value _vsnprintf is not resolved
        public const string vsnprintf = "_vsnprintf";

        /// snwprintf -> _snwprintf
        /// Error generating expression: Value _snwprintf is not resolved
        public const string snwprintf = "_snwprintf";

        /// wcsicmp -> _wcsicmp
        /// Error generating expression: Value _wcsicmp is not resolved
        public const string wcsicmp = "_wcsicmp";

        /// wcsnicmp -> _wcsnicmp
        /// Error generating expression: Value _wcsnicmp is not resolved
        public const string wcsnicmp = "_wcsnicmp";

        /// pj_ansi_strcmp -> strcmp
        /// Error generating expression: Value strcmp is not resolved
        public const string pj_ansi_strcmp = "strcmp";

        /// pj_ansi_strncmp -> strncmp
        /// Error generating expression: Value strncmp is not resolved
        public const string pj_ansi_strncmp = "strncmp";

        /// pj_ansi_strlen -> strlen
        /// Error generating expression: Value strlen is not resolved
        public const string pj_ansi_strlen = "strlen";

        /// pj_ansi_strcpy -> strcpy
        /// Error generating expression: Value strcpy is not resolved
        public const string pj_ansi_strcpy = "strcpy";

        /// pj_ansi_strncpy -> strncpy
        /// Error generating expression: Value strncpy is not resolved
        public const string pj_ansi_strncpy = "strncpy";

        /// pj_ansi_strcat -> strcat
        /// Error generating expression: Value strcat is not resolved
        public const string pj_ansi_strcat = "strcat";

        /// pj_ansi_strstr -> strstr
        /// Error generating expression: Value strstr is not resolved
        public const string pj_ansi_strstr = "strstr";

        /// pj_ansi_strchr -> strchr
        /// Error generating expression: Value strchr is not resolved
        public const string pj_ansi_strchr = "strchr";

        /// pj_unicode_strcmp -> wcscmp
        /// Error generating expression: Value wcscmp is not resolved
        public const string pj_unicode_strcmp = "wcscmp";

        /// pj_unicode_strncmp -> wcsncmp
        /// Error generating expression: Value wcsncmp is not resolved
        public const string pj_unicode_strncmp = "wcsncmp";

        /// pj_unicode_strlen -> wcslen
        /// Error generating expression: Value wcslen is not resolved
        public const string pj_unicode_strlen = "wcslen";

        /// pj_unicode_strcpy -> wcscpy
        /// Error generating expression: Value wcscpy is not resolved
        public const string pj_unicode_strcpy = "wcscpy";

        /// pj_unicode_strncpy -> wcsncpy
        /// Error generating expression: Value wcsncpy is not resolved
        public const string pj_unicode_strncpy = "wcsncpy";

        /// pj_unicode_strcat -> wcscat
        /// Error generating expression: Value wcscat is not resolved
        public const string pj_unicode_strcat = "wcscat";

        /// pj_unicode_strstr -> wcsstr
        /// Error generating expression: Value wcsstr is not resolved
        public const string pj_unicode_strstr = "wcsstr";

        /// pj_unicode_strchr -> wcschr
        /// Error generating expression: Value wcschr is not resolved
        public const string pj_unicode_strchr = "wcschr";


        /// pj_stricmp_alnum -> pj_stricmp
        /// Error generating expression: Value pj_stricmp is not resolved
        public const string pj_stricmp_alnum = "pj_stricmp";

        /// PJSIP_SSL_DEFAULT_METHOD -> PJSIP_TLSV1_METHOD
        public const pjsip_ssl_method PJSIP_SSL_DEFAULT_METHOD = pjsip_ssl_method.PJSIP_TLSV1_METHOD;

        /// __PJSIP_AUTH_SIP_AUTH_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_AUTH_SIP_AUTH_H__ = "";

        /// __PJSIP_AUTH_SIP_AUTH_MSG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_AUTH_SIP_AUTH_MSG_H__ = "";

        /// PJSIP_MD5STRLEN -> 32
        public const int PJSIP_MD5STRLEN = 32;

        /// PJSIP_AUTH_SRV_IS_PROXY -> 1
        public const int PJSIP_AUTH_SRV_IS_PROXY = 1;

        /// __PJSIP_AUTH_SIP_AUTH_AKA_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_AUTH_SIP_AUTH_AKA_H__ = "";

        /// PJSIP_AKA_AKLEN -> 6
        public const int PJSIP_AKA_AKLEN = 6;

        /// PJSIP_AKA_AMFLEN -> 2
        public const int PJSIP_AKA_AMFLEN = 2;

        /// PJSIP_AKA_AUTNLEN -> 16
        public const int PJSIP_AKA_AUTNLEN = 16;

        /// PJSIP_AKA_CKLEN -> 16
        public const int PJSIP_AKA_CKLEN = 16;

        /// PJSIP_AKA_IKLEN -> 16
        public const int PJSIP_AKA_IKLEN = 16;

        /// PJSIP_AKA_KLEN -> 16
        public const int PJSIP_AKA_KLEN = 16;

        /// PJSIP_AKA_MACLEN -> 8
        public const int PJSIP_AKA_MACLEN = 8;

        /// PJSIP_AKA_OPLEN -> 16
        public const int PJSIP_AKA_OPLEN = 16;

        /// PJSIP_AKA_RANDLEN -> 16
        public const int PJSIP_AKA_RANDLEN = 16;

        /// PJSIP_AKA_RESLEN -> 8
        public const int PJSIP_AKA_RESLEN = 8;

        /// PJSIP_AKA_SQNLEN -> 6
        public const int PJSIP_AKA_SQNLEN = 6;

        /// __PJSIP_SIP_TRANSACTION_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_TRANSACTION_H__ = "";

        /// __PJSIP_SIP_UA_LAYER_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_UA_LAYER_H__ = "";

        /// __PJSIP_SIP_DIALOG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_DIALOG_H__ = "";

        /// __PJ_ASSERT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_ASSERT_H__ = "";

        /// __PJ_COMPAT_ASSERT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_COMPAT_ASSERT_H__ = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// assert -> "(_Expression) (void)( (!!(_Expression)) || (_wassert(_CRT_WIDE(#_Expression), _CRT_WIDE(__FILE__), __LINE__), 0) )"
        public const string assert = "(_Expression) (void)( (!!(_Expression)) || (_wassert(_CRT_WIDE(#_Expression), _CR" +
            "T_WIDE(__FILE__), __LINE__), 0) )";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_assert -> "(expr) assert(expr)"
        public const string pj_assert = "(expr) assert(expr)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_ASSERT_RETURN -> "(expr,retval) do { 
        ///		if (!(expr)) { pj_assert(expr); return retval; } 
        ///	    } while (0)"
        public const string PJ_ASSERT_RETURN = "(expr,retval) do { \r\n\t\tif (!(expr)) { pj_assert(expr); return retval; } \r\n\t    } " +
            "while (0)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_ASSERT_ON_FAIL -> "(expr,exec_on_fail) do { 
        ///		pj_assert(expr); 
        ///		if (!(expr)) exec_on_fail; 
        ///	    } while (0)"
        public const string PJ_ASSERT_ON_FAIL = "(expr,exec_on_fail) do { \r\n\t\tpj_assert(expr); \r\n\t\tif (!(expr)) exec_on_fail; \r\n\t " +
            "   } while (0)";

        /// __PJMEDIA_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_H__ = "";

        /// __PJMEDIA_TYPES_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_TYPES_H__ = "";

        /// __PJMEDIA_CONFIG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CONFIG_H__ = "";

        /// PJMEDIA_CONF_USE_SWITCH_BOARD -> 0
        public const int PJMEDIA_CONF_USE_SWITCH_BOARD = 0;

        /// PJMEDIA_HAS_LEGACY_SOUND_API -> 1
        public const int PJMEDIA_HAS_LEGACY_SOUND_API = 1;

        /// PJMEDIA_SND_DEFAULT_REC_LATENCY -> 100
        public const int PJMEDIA_SND_DEFAULT_REC_LATENCY = 100;

        /// PJMEDIA_SND_DEFAULT_PLAY_LATENCY -> 100
        public const int PJMEDIA_SND_DEFAULT_PLAY_LATENCY = 100;

        /// PJMEDIA_WSOLA_IMP_NULL -> 0
        public const int PJMEDIA_WSOLA_IMP_NULL = 0;

        /// PJMEDIA_WSOLA_IMP_WSOLA -> 1
        public const int PJMEDIA_WSOLA_IMP_WSOLA = 1;

        /// PJMEDIA_WSOLA_IMP_WSOLA_LITE -> 2
        public const int PJMEDIA_WSOLA_IMP_WSOLA_LITE = 2;

        /// PJMEDIA_WSOLA_IMP -> PJMEDIA_WSOLA_IMP_WSOLA
        public const int PJMEDIA_WSOLA_IMP = NativeConstants.PJMEDIA_WSOLA_IMP_WSOLA;

        /// PJMEDIA_WSOLA_MAX_EXPAND_MSEC -> 80
        public const int PJMEDIA_WSOLA_MAX_EXPAND_MSEC = 80;

        /// PJMEDIA_WSOLA_TEMPLATE_LENGTH_MSEC -> 5
        public const int PJMEDIA_WSOLA_TEMPLATE_LENGTH_MSEC = 5;

        /// PJMEDIA_WSOLA_DELAY_MSEC -> 5
        public const int PJMEDIA_WSOLA_DELAY_MSEC = 5;

        /// PJMEDIA_WSOLA_PLC_NO_FADING -> 0
        public const int PJMEDIA_WSOLA_PLC_NO_FADING = 0;

        /// PJMEDIA_SOUND_BUFFER_COUNT -> 6
        public const int PJMEDIA_SOUND_BUFFER_COUNT = 6;

        /// PJMEDIA_HAS_ALAW_ULAW_TABLE -> 1
        public const int PJMEDIA_HAS_ALAW_ULAW_TABLE = 1;

        /// PJMEDIA_HAS_G711_CODEC -> 1
        public const int PJMEDIA_HAS_G711_CODEC = 1;

        /// PJMEDIA_RESAMPLE_NONE -> 1
        public const int PJMEDIA_RESAMPLE_NONE = 1;

        /// PJMEDIA_RESAMPLE_LIBRESAMPLE -> 2
        public const int PJMEDIA_RESAMPLE_LIBRESAMPLE = 2;

        /// PJMEDIA_RESAMPLE_SPEEX -> 3
        public const int PJMEDIA_RESAMPLE_SPEEX = 3;

        /// PJMEDIA_RESAMPLE_LIBSAMPLERATE -> 4
        public const int PJMEDIA_RESAMPLE_LIBSAMPLERATE = 4;

        /// PJMEDIA_RESAMPLE_IMP -> PJMEDIA_RESAMPLE_LIBRESAMPLE
        public const int PJMEDIA_RESAMPLE_IMP = NativeConstants.PJMEDIA_RESAMPLE_LIBRESAMPLE;

        /// PJMEDIA_FILE_PORT_BUFSIZE -> 4000
        public const int PJMEDIA_FILE_PORT_BUFSIZE = 4000;

        /// PJMEDIA_MAX_FRAME_DURATION_MS -> 200
        public const int PJMEDIA_MAX_FRAME_DURATION_MS = 200;

        /// PJMEDIA_MAX_MTU -> 1500
        public const int PJMEDIA_MAX_MTU = 1500;

        /// PJMEDIA_DTMF_DURATION -> 1600
        public const int PJMEDIA_DTMF_DURATION = 1600;

        /// PJMEDIA_RTP_NAT_PROBATION_CNT -> 10
        public const int PJMEDIA_RTP_NAT_PROBATION_CNT = 10;

        /// PJMEDIA_ADVERTISE_RTCP -> 1
        public const int PJMEDIA_ADVERTISE_RTCP = 1;

        /// PJMEDIA_RTCP_INTERVAL -> 5000
        public const int PJMEDIA_RTCP_INTERVAL = 5000;

        /// PJMEDIA_RTCP_IGNORE_FIRST_PACKETS -> 25
        public const int PJMEDIA_RTCP_IGNORE_FIRST_PACKETS = 25;

        /// PJMEDIA_HAS_RTCP_XR -> 0
        public const int PJMEDIA_HAS_RTCP_XR = 0;

        /// PJMEDIA_STREAM_ENABLE_XR -> 0
        public const int PJMEDIA_STREAM_ENABLE_XR = 0;

        /// PJMEDIA_STREAM_VAD_SUSPEND_MSEC -> 600
        public const int PJMEDIA_STREAM_VAD_SUSPEND_MSEC = 600;

        /// PJMEDIA_CODEC_MAX_SILENCE_PERIOD -> 5000
        public const int PJMEDIA_CODEC_MAX_SILENCE_PERIOD = 5000;

        /// PJMEDIA_SILENCE_DET_THRESHOLD -> 4
        public const int PJMEDIA_SILENCE_DET_THRESHOLD = 4;

        /// PJMEDIA_SILENCE_DET_MAX_THRESHOLD -> 0x10000
        public const int PJMEDIA_SILENCE_DET_MAX_THRESHOLD = 65536;

        /// PJMEDIA_HAS_SPEEX_AEC -> 1
        public const int PJMEDIA_HAS_SPEEX_AEC = 1;

        /// PJMEDIA_SDP_NEG_PREFER_REMOTE_CODEC_ORDER -> 1
        public const int PJMEDIA_SDP_NEG_PREFER_REMOTE_CODEC_ORDER = 1;

        /// PJMEDIA_HAS_RTCP_IN_SDP -> (PJMEDIA_ADVERTISE_RTCP)
        public const int PJMEDIA_HAS_RTCP_IN_SDP = NativeConstants.PJMEDIA_ADVERTISE_RTCP;

        /// PJMEDIA_ADD_RTPMAP_FOR_STATIC_PT -> 1
        public const int PJMEDIA_ADD_RTPMAP_FOR_STATIC_PT = 1;

        /// PJMEDIA_RTP_PT_TELEPHONE_EVENTS -> 101
        public const int PJMEDIA_RTP_PT_TELEPHONE_EVENTS = 101;

        /// PJMEDIA_RTP_PT_TELEPHONE_EVENTS_STR -> "101"
        public const string PJMEDIA_RTP_PT_TELEPHONE_EVENTS_STR = "101";

        /// PJMEDIA_TONEGEN_MAX_DIGITS -> 32
        public const int PJMEDIA_TONEGEN_MAX_DIGITS = 32;

        /// PJMEDIA_TONEGEN_SINE -> 1
        public const int PJMEDIA_TONEGEN_SINE = 1;

        /// PJMEDIA_TONEGEN_FLOATING_POINT -> 2
        public const int PJMEDIA_TONEGEN_FLOATING_POINT = 2;

        /// PJMEDIA_TONEGEN_FIXED_POINT_CORDIC -> 3
        public const int PJMEDIA_TONEGEN_FIXED_POINT_CORDIC = 3;

        /// PJMEDIA_TONEGEN_FAST_FIXED_POINT -> 4
        public const int PJMEDIA_TONEGEN_FAST_FIXED_POINT = 4;

        /// PJMEDIA_TONEGEN_ALG -> PJMEDIA_TONEGEN_FLOATING_POINT
        public const int PJMEDIA_TONEGEN_ALG = NativeConstants.PJMEDIA_TONEGEN_FLOATING_POINT;

        /// PJMEDIA_TONEGEN_FIXED_POINT_CORDIC_LOOP -> 10
        public const int PJMEDIA_TONEGEN_FIXED_POINT_CORDIC_LOOP = 10;

        /// PJMEDIA_TONEGEN_FADE_IN_TIME -> 1
        public const int PJMEDIA_TONEGEN_FADE_IN_TIME = 1;

        /// PJMEDIA_TONEGEN_FADE_OUT_TIME -> 2
        public const int PJMEDIA_TONEGEN_FADE_OUT_TIME = 2;

        /// PJMEDIA_TONEGEN_VOLUME -> 12288
        public const int PJMEDIA_TONEGEN_VOLUME = 12288;

        /// PJMEDIA_HANDLE_G722_MPEG_BUG -> 1
        public const int PJMEDIA_HANDLE_G722_MPEG_BUG = 1;

        /// PJMEDIA_TRANSPORT_SPECIFIC_INFO_MAXCNT -> 4
        public const int PJMEDIA_TRANSPORT_SPECIFIC_INFO_MAXCNT = 4;

        /// PJMEDIA_TRANSPORT_SPECIFIC_INFO_MAXSIZE -> (16*sizeof(long))
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJMEDIA_TRANSPORT_SPECIFIC_INFO_MAXSIZE = "(16*sizeof(long))";

        /// PJMEDIA_STREAM_KA_EMPTY_RTP -> 1
        public const int PJMEDIA_STREAM_KA_EMPTY_RTP = 1;

        /// PJMEDIA_STREAM_KA_USER -> 2
        public const int PJMEDIA_STREAM_KA_USER = 2;

        /// PJMEDIA_STREAM_KA_USER_PKT -> { "\r\n", 2 }
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJMEDIA_STREAM_KA_USER_PKT = "{ \"\\r\\n\", 2 }";

        /// PJMEDIA_STREAM_ENABLE_KA -> 0
        public const int PJMEDIA_STREAM_ENABLE_KA = 0;

        /// PJMEDIA_STREAM_KA_INTERVAL -> 5
        public const int PJMEDIA_STREAM_KA_INTERVAL = 5;

        /// PJMEDIA_DIR_CAPTURE -> PJMEDIA_DIR_ENCODING
        public const pjmedia_dir PJMEDIA_DIR_CAPTURE = pjmedia_dir.PJMEDIA_DIR_ENCODING;

        /// PJMEDIA_DIR_PLAYBACK -> PJMEDIA_DIR_DECODING
        public const pjmedia_dir PJMEDIA_DIR_PLAYBACK = pjmedia_dir.PJMEDIA_DIR_DECODING;

        /// PJMEDIA_DIR_CAPTURE_PLAYBACK -> PJMEDIA_DIR_ENCODING_DECODING
        public const pjmedia_dir PJMEDIA_DIR_CAPTURE_PLAYBACK = pjmedia_dir.PJMEDIA_DIR_ENCODING_DECODING;

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJMEDIA_PORT_SIGNATURE -> "(a,b,c,d) (a<<24 | b<<16 | c<<8 | d)"
        public const string PJMEDIA_PORT_SIGNATURE = "(a,b,c,d) (a<<24 | b<<16 | c<<8 | d)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJMEDIA_FORMAT_PACK -> "(C1,C2,C3,C4) ( C4<<24 | C3<<16 | C2<<8 | C1 )"
        public const string PJMEDIA_FORMAT_PACK = "(C1,C2,C3,C4) ( C4<<24 | C3<<16 | C2<<8 | C1 )";

        /// __PJMEDIA_ALAW_ULAW_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_ALAW_ULAW_H__ = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pjmedia_linear2alaw -> "(pcm_val) pjmedia_linear2alaw_tab[(((pj_int16_t)pcm_val) >> 2) & 0x3fff]"
        public const string pjmedia_linear2alaw = "(pcm_val) pjmedia_linear2alaw_tab[(((pj_int16_t)pcm_val) >> 2) & 0x3fff]";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pjmedia_alaw2linear -> "(chara_val) pjmedia_alaw2linear_tab[chara_val]"
        public const string pjmedia_alaw2linear = "(chara_val) pjmedia_alaw2linear_tab[chara_val]";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pjmedia_linear2ulaw -> "(pcm_val) pjmedia_linear2ulaw_tab[(((pj_int16_t)pcm_val) >> 2) & 0x3fff]"
        public const string pjmedia_linear2ulaw = "(pcm_val) pjmedia_linear2ulaw_tab[(((pj_int16_t)pcm_val) >> 2) & 0x3fff]";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pjmedia_ulaw2linear -> "(u_val) pjmedia_ulaw2linear_tab[u_val]"
        public const string pjmedia_ulaw2linear = "(u_val) pjmedia_ulaw2linear_tab[u_val]";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pjmedia_alaw2ulaw -> "(aval) pjmedia_linear2ulaw(pjmedia_alaw2linear(aval))"
        public const string pjmedia_alaw2ulaw = "(aval) pjmedia_linear2ulaw(pjmedia_alaw2linear(aval))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pjmedia_ulaw2alaw -> "(uval) pjmedia_linear2alaw(pjmedia_ulaw2linear(uval))"
        public const string pjmedia_ulaw2alaw = "(uval) pjmedia_linear2alaw(pjmedia_ulaw2linear(uval))";

        /// __PJMEDIA_BIDIRECTIONAL_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_BIDIRECTIONAL_H__ = "";

        /// __PJMEDIA_PORT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_PORT_H__ = "";

        /// __PJ_OS_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_OS_H__ = "";

        /// PJ_THREAD_DESC_SIZE -> (64)
        public const int PJ_THREAD_DESC_SIZE = 64;

        /// PJ_CHECK_STACK -> ()
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_CHECK_STACK = "()";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_thread_get_stack_max_usage -> "(thread) 0"
        public const string pj_thread_get_stack_max_usage = "(thread) 0";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_thread_get_stack_info -> "(thread,f,l) (*(f)="",*(l)=0)"
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string pj_thread_get_stack_info = "\"(thread,f,l) (*(f)=\"\",*(l)=0)\"";

        /// __PJMEDIA_CIRC_BUF_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CIRC_BUF_H__ = "";

        /// __PJ_POOL_ALT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_POOL_ALT_H__ = "";

        /// __PJ_POOL_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_POOL_H__ = "";

        /// PJ_POOL_SIZE -> (sizeof(struct pj_pool_t))
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_POOL_SIZE = "(sizeof(struct pj_pool_t))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_pool_create -> "(fc,nm,init,inc,cb) pj_pool_create_imp(__FILE__, __LINE__, fc, nm, init, inc, cb)"
        public const string pj_pool_create = "(fc,nm,init,inc,cb) pj_pool_create_imp(__FILE__, __LINE__, fc, nm, init, inc, cb)" +
            "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_pool_release -> "(pool) pj_pool_release_imp(pool)"
        public const string pj_pool_release = "(pool) pj_pool_release_imp(pool)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_pool_getobjname -> "(pool) pj_pool_getobjname_imp(pool)"
        public const string pj_pool_getobjname = "(pool) pj_pool_getobjname_imp(pool)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_pool_reset -> "(pool) pj_pool_reset_imp(pool)"
        public const string pj_pool_reset = "(pool) pj_pool_reset_imp(pool)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_pool_get_capacity -> "(pool) pj_pool_get_capacity_imp(pool)"
        public const string pj_pool_get_capacity = "(pool) pj_pool_get_capacity_imp(pool)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_pool_get_used_size -> "(pool) pj_pool_get_used_size_imp(pool)"
        public const string pj_pool_get_used_size = "(pool) pj_pool_get_used_size_imp(pool)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_pool_alloc -> "(pool,sz) pj_pool_alloc_imp(__FILE__, __LINE__, pool, sz)"
        public const string pj_pool_alloc = "(pool,sz) pj_pool_alloc_imp(__FILE__, __LINE__, pool, sz)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_pool_calloc -> "(pool,cnt,elem) pj_pool_calloc_imp(__FILE__, __LINE__, pool, cnt, elem)"
        public const string pj_pool_calloc = "(pool,cnt,elem) pj_pool_calloc_imp(__FILE__, __LINE__, pool, cnt, elem)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_pool_zalloc -> "(pool,sz) pj_pool_zalloc_imp(__FILE__, __LINE__, pool, sz)"
        public const string pj_pool_zalloc = "(pool,sz) pj_pool_zalloc_imp(__FILE__, __LINE__, pool, sz)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_POOL_ZALLOC_T -> "(pool,type) ((type*)pj_pool_zalloc(pool, sizeof(type)))"
        public const string PJ_POOL_ZALLOC_T = "(pool,type) ((type*)pj_pool_zalloc(pool, sizeof(type)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_POOL_ALLOC_T -> "(pool,type) ((type*)pj_pool_alloc(pool, sizeof(type)))"
        public const string PJ_POOL_ALLOC_T = "(pool,type) ((type*)pj_pool_alloc(pool, sizeof(type)))";

        /// PJ_POOL_ALIGNMENT -> 4
        public const int PJ_POOL_ALIGNMENT = 4;

        /// pj_caching_pool_init -> ( cp, pol, mac)
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string pj_caching_pool_init = "( cp, pol, mac)";

        /// pj_caching_pool_destroy -> (cp)
        /// Error generating expression: Value cp is not resolved
        public const string pj_caching_pool_destroy = "(cp)";

        /// pj_pool_factory_dump -> (pf, detail)
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string pj_pool_factory_dump = "(pf, detail)";

        /// PJMEDIA_CIRC_BUF_CHECK -> (x)
        /// Error generating expression: Value x is not resolved
        public const string PJMEDIA_CIRC_BUF_CHECK = "(x)";

        /// __PJMEDIA_CLOCK_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CLOCK_H__ = "";

        /// __PJMEDIA_CODEC_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CODEC_H__ = "";

        /// PJMEDIA_CODEC_MAX_FMTP_CNT -> 8
        public const int PJMEDIA_CODEC_MAX_FMTP_CNT = 8;

        /// PJMEDIA_CODEC_MGR_MAX_CODECS -> 32
        public const int PJMEDIA_CODEC_MGR_MAX_CODECS = 32;

        /// __PJMEDIA_CONF_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CONF_H__ = "";

        /// PJMEDIA_CONF_BRIDGE_SIGNATURE -> PJMEDIA_PORT_SIGNATURE('C', 'O', 'N', 'F')
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJMEDIA_CONF_BRIDGE_SIGNATURE = "PJMEDIA_PORT_SIGNATURE(\'C\', \'O\', \'N\', \'F\')";

        /// PJMEDIA_CONF_SWITCH_SIGNATURE -> PJMEDIA_PORT_SIGNATURE('A', 'S', 'W', 'I')
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJMEDIA_CONF_SWITCH_SIGNATURE = "PJMEDIA_PORT_SIGNATURE(\'A\', \'S\', \'W\', \'I\')";

        /// __PJMEDIA_DELAYBUF_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_DELAYBUF_H__ = "";

        /// __PJMEDIA_ECHO_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_ECHO_H__ = "";

        /// __PJMEDIA_AEC_PORT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_AEC_PORT_H__ = "";

        /// __PJMEDIA_MEDIAMGR_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_MEDIAMGR_H__ = "";

        /// __PJMEDIA_SDP_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_SDP_H__ = "";

        /// PJMEDIA_MAX_SDP_FMT -> 32
        public const int PJMEDIA_MAX_SDP_FMT = 32;

        /// PJMEDIA_MAX_SDP_ATTR -> (PJMEDIA_MAX_SDP_FMT*2 + 4)
        public const int PJMEDIA_MAX_SDP_ATTR = (NativeConstants.PJMEDIA_MAX_SDP_FMT
                    * (2 + 4));

        /// PJMEDIA_MAX_SDP_MEDIA -> 16
        public const int PJMEDIA_MAX_SDP_MEDIA = 16;

        /// __PJMEDIA_G711_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_G711_H__ = "";

        /// __PJMEDIA_CODEC_TYPES_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CODEC_TYPES_H__ = "";

        /// __PJMEDIA_CODEC_CONFIG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CODEC_CONFIG_H__ = "";

        /// PJMEDIA_HAS_L16_CODEC -> 1
        public const int PJMEDIA_HAS_L16_CODEC = 1;

        /// PJMEDIA_HAS_GSM_CODEC -> 1
        public const int PJMEDIA_HAS_GSM_CODEC = 1;

        /// PJMEDIA_HAS_SPEEX_CODEC -> 1
        public const int PJMEDIA_HAS_SPEEX_CODEC = 1;

        /// PJMEDIA_CODEC_SPEEX_DEFAULT_COMPLEXITY -> 2
        public const int PJMEDIA_CODEC_SPEEX_DEFAULT_COMPLEXITY = 2;

        /// PJMEDIA_CODEC_SPEEX_DEFAULT_QUALITY -> 8
        public const int PJMEDIA_CODEC_SPEEX_DEFAULT_QUALITY = 8;

        /// PJMEDIA_HAS_ILBC_CODEC -> 1
        public const int PJMEDIA_HAS_ILBC_CODEC = 1;

        /// PJMEDIA_HAS_G722_CODEC -> 1
        public const int PJMEDIA_HAS_G722_CODEC = 1;

        /// PJMEDIA_HAS_INTEL_IPP -> 0
        public const int PJMEDIA_HAS_INTEL_IPP = 0;

        /// PJMEDIA_AUTO_LINK_IPP_LIBS -> 1
        public const int PJMEDIA_AUTO_LINK_IPP_LIBS = 1;

        /// PJMEDIA_HAS_INTEL_IPP_CODEC_AMR -> 1
        public const int PJMEDIA_HAS_INTEL_IPP_CODEC_AMR = 1;

        /// PJMEDIA_HAS_INTEL_IPP_CODEC_AMRWB -> 1
        public const int PJMEDIA_HAS_INTEL_IPP_CODEC_AMRWB = 1;

        /// PJMEDIA_HAS_INTEL_IPP_CODEC_G729 -> 1
        public const int PJMEDIA_HAS_INTEL_IPP_CODEC_G729 = 1;

        /// PJMEDIA_HAS_INTEL_IPP_CODEC_G723_1 -> 1
        public const int PJMEDIA_HAS_INTEL_IPP_CODEC_G723_1 = 1;

        /// PJMEDIA_HAS_INTEL_IPP_CODEC_G726 -> 1
        public const int PJMEDIA_HAS_INTEL_IPP_CODEC_G726 = 1;

        /// PJMEDIA_HAS_INTEL_IPP_CODEC_G728 -> 1
        public const int PJMEDIA_HAS_INTEL_IPP_CODEC_G728 = 1;

        /// PJMEDIA_HAS_INTEL_IPP_CODEC_G722_1 -> 1
        public const int PJMEDIA_HAS_INTEL_IPP_CODEC_G722_1 = 1;

        /// PJMEDIA_HAS_PASSTHROUGH_CODECS -> 0
        public const int PJMEDIA_HAS_PASSTHROUGH_CODECS = 0;

        /// PJMEDIA_HAS_PASSTHROUGH_CODEC_AMR -> 1
        public const int PJMEDIA_HAS_PASSTHROUGH_CODEC_AMR = 1;

        /// PJMEDIA_HAS_PASSTHROUGH_CODEC_G729 -> 1
        public const int PJMEDIA_HAS_PASSTHROUGH_CODEC_G729 = 1;

        /// PJMEDIA_HAS_PASSTHROUGH_CODEC_ILBC -> 1
        public const int PJMEDIA_HAS_PASSTHROUGH_CODEC_ILBC = 1;

        /// PJMEDIA_HAS_PASSTHROUGH_CODEC_PCMU -> 1
        public const int PJMEDIA_HAS_PASSTHROUGH_CODEC_PCMU = 1;

        /// PJMEDIA_HAS_PASSTHROUGH_CODEC_PCMA -> 1
        public const int PJMEDIA_HAS_PASSTHROUGH_CODEC_PCMA = 1;

        /// PJMEDIA_HAS_G7221_CODEC -> 0
        public const int PJMEDIA_HAS_G7221_CODEC = 0;

        /// PJMEDIA_G7221_DEFAULT_PCM_SHIFT -> 1
        public const int PJMEDIA_G7221_DEFAULT_PCM_SHIFT = 1;

        /// __PJMEDIA_JBUF_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_JBUF_H__ = "";

        /// PJMEDIA_JB_DEFAULT_INIT_DELAY -> 15
        public const int PJMEDIA_JB_DEFAULT_INIT_DELAY = 15;

        /// __PJMEDIA_MASTER_PORT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_MASTER_PORT_H__ = "";

        /// __PJMEDIA_MEM_PORT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_MEM_PORT_H__ = "";

        /// __PJMEDIA_NULL_PORT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_NULL_PORT_H__ = "";

        /// __PJMEDIA_PLC_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_PLC_H__ = "";

        /// __PJMEDIA_RESAMPLE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_RESAMPLE_H__ = "";

        /// __PJMEDIA_RTCP_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_RTCP_H__ = "";

        /// __PJMEDIA_RTCP_XR_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_RTCP_XR_H__ = "";

        /// __PJ_MATH_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_MATH_H__ = "";

        /// __PJ_COMPAT_HIGH_PRECISION_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_COMPAT_HIGH_PRECISION_H__ = "";

        /// _INC_MATH -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _INC_MATH = "";

        /// _EXCEPTION_DEFINED -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _EXCEPTION_DEFINED = "";

        /// _COMPLEX_DEFINED -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _COMPLEX_DEFINED = "";

        /// _DOMAIN -> 1
        public const int _DOMAIN = 1;

        /// _SING -> 2
        public const int _SING = 2;

        /// _OVERFLOW -> 3
        public const int _OVERFLOW = 3;

        /// _UNDERFLOW -> 4
        public const int _UNDERFLOW = 4;

        /// _TLOSS -> 5
        public const int _TLOSS = 5;

        /// _PLOSS -> 6
        public const int _PLOSS = 6;

        /// EDOM -> 33
        public const int EDOM = 33;

        /// ERANGE -> 34
        public const int ERANGE = 34;

        /// HUGE_VAL -> _HUGE
        /// Error generating expression: Value _HUGE is not resolved
        public const string HUGE_VAL = "_HUGE";

        /// _SIGN_DEFINED -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _SIGN_DEFINED = "";

        /// _CRT_MATHERR_DEFINED -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _CRT_MATHERR_DEFINED = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// acosl -> "(x) ((long double)acos((double)(x)))"
        public const string acosl = "(x) ((long double)acos((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// asinl -> "(x) ((long double)asin((double)(x)))"
        public const string asinl = "(x) ((long double)asin((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// atanl -> "(x) ((long double)atan((double)(x)))"
        public const string atanl = "(x) ((long double)atan((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// atan2l -> "(x,y) ((long double)atan2((double)(x), (double)(y)))"
        public const string atan2l = "(x,y) ((long double)atan2((double)(x), (double)(y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// ceill -> "(x) ((long double)ceil((double)(x)))"
        public const string ceill = "(x) ((long double)ceil((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// cosl -> "(x) ((long double)cos((double)(x)))"
        public const string cosl = "(x) ((long double)cos((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// coshl -> "(x) ((long double)cosh((double)(x)))"
        public const string coshl = "(x) ((long double)cosh((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// expl -> "(x) ((long double)exp((double)(x)))"
        public const string expl = "(x) ((long double)exp((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// fabsl -> "(x) ((long double)fabs((double)(x)))"
        public const string fabsl = "(x) ((long double)fabs((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// floorl -> "(x) ((long double)floor((double)(x)))"
        public const string floorl = "(x) ((long double)floor((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// fmodl -> "(x,y) ((long double)fmod((double)(x), (double)(y)))"
        public const string fmodl = "(x,y) ((long double)fmod((double)(x), (double)(y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// frexpl -> "(x,y) ((long double)frexp((double)(x), (y)))"
        public const string frexpl = "(x,y) ((long double)frexp((double)(x), (y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _hypotl -> "(x,y) ((long double)_hypot((double)(x), (double)(y)))"
        public const string _hypotl = "(x,y) ((long double)_hypot((double)(x), (double)(y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// ldexpl -> "(x,y) ((long double)ldexp((double)(x), (y)))"
        public const string ldexpl = "(x,y) ((long double)ldexp((double)(x), (y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// logl -> "(x) ((long double)log((double)(x)))"
        public const string logl = "(x) ((long double)log((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// log10l -> "(x) ((long double)log10((double)(x)))"
        public const string log10l = "(x) ((long double)log10((double)(x)))";

        /// _matherrl -> _matherr
        /// Error generating expression: Value _matherr is not resolved
        public const string _matherrl = "_matherr";

        /// Warning: Generation of Method Macros is not supported at this time
        /// modfl -> "(x,y) ((long double)modf((double)(x), (double *)(y)))"
        public const string modfl = "(x,y) ((long double)modf((double)(x), (double *)(y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// powl -> "(x,y) ((long double)pow((double)(x), (double)(y)))"
        public const string powl = "(x,y) ((long double)pow((double)(x), (double)(y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// sinl -> "(x) ((long double)sin((double)(x)))"
        public const string sinl = "(x) ((long double)sin((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// sinhl -> "(x) ((long double)sinh((double)(x)))"
        public const string sinhl = "(x) ((long double)sinh((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// sqrtl -> "(x) ((long double)sqrt((double)(x)))"
        public const string sqrtl = "(x) ((long double)sqrt((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// tanl -> "(x) ((long double)tan((double)(x)))"
        public const string tanl = "(x) ((long double)tan((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// tanhl -> "(x) ((long double)tanh((double)(x)))"
        public const string tanhl = "(x) ((long double)tanh((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _chgsignl -> "(x) ((long double)_chgsign((double)(x)))"
        public const string _chgsignl = "(x) ((long double)_chgsign((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _copysignl -> "(x,y) ((long double)_copysign((double)(x), (double)(y)))"
        public const string _copysignl = "(x,y) ((long double)_copysign((double)(x), (double)(y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// frexpf -> "(x,y) ((float)frexp((double)(x),(y)))"
        public const string frexpf = "(x,y) ((float)frexp((double)(x),(y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// fabsf -> "(x) ((float)fabs((double)(x)))"
        public const string fabsf = "(x) ((float)fabs((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// ldexpf -> "(x,y) ((float)ldexp((double)(x),(y)))"
        public const string ldexpf = "(x,y) ((float)ldexp((double)(x),(y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// acosf -> "(x) ((float)acos((double)(x)))"
        public const string acosf = "(x) ((float)acos((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// asinf -> "(x) ((float)asin((double)(x)))"
        public const string asinf = "(x) ((float)asin((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// atanf -> "(x) ((float)atan((double)(x)))"
        public const string atanf = "(x) ((float)atan((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// atan2f -> "(x,y) ((float)atan2((double)(x), (double)(y)))"
        public const string atan2f = "(x,y) ((float)atan2((double)(x), (double)(y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// ceilf -> "(x) ((float)ceil((double)(x)))"
        public const string ceilf = "(x) ((float)ceil((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// cosf -> "(x) ((float)cos((double)(x)))"
        public const string cosf = "(x) ((float)cos((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// coshf -> "(x) ((float)cosh((double)(x)))"
        public const string coshf = "(x) ((float)cosh((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// expf -> "(x) ((float)exp((double)(x)))"
        public const string expf = "(x) ((float)exp((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// floorf -> "(x) ((float)floor((double)(x)))"
        public const string floorf = "(x) ((float)floor((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// fmodf -> "(x,y) ((float)fmod((double)(x), (double)(y)))"
        public const string fmodf = "(x,y) ((float)fmod((double)(x), (double)(y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// logf -> "(x) ((float)log((double)(x)));"
        public const string logf = "(x) ((float)log((double)(x)));";

        /// Warning: Generation of Method Macros is not supported at this time
        /// log10f -> "(x) ((float)log10((double)(x)))"
        public const string log10f = "(x) ((float)log10((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// modff -> "(x,y) ((float)modf((double)(x), (double *)(y)))"
        public const string modff = "(x,y) ((float)modf((double)(x), (double *)(y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// powf -> "(x,y) ((float)pow((double)(x), (double)(y)))"
        public const string powf = "(x,y) ((float)pow((double)(x), (double)(y)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// sinf -> "(x) ((float)sin((double)(x)))"
        public const string sinf = "(x) ((float)sin((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// sinhf -> "(x) ((float)sinh((double)(x)))"
        public const string sinhf = "(x) ((float)sinh((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// sqrtf -> "(x) ((float)sqrt((double)(x)))"
        public const string sqrtf = "(x) ((float)sqrt((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// tanf -> "(x) ((float)tan((double)(x)))"
        public const string tanf = "(x) ((float)tan((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// tanhf -> "(x) ((float)tanh((double)(x)))"
        public const string tanhf = "(x) ((float)tanh((double)(x)))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_HIGHPREC_VALUE_IS_ZERO -> "(a) (a==0)"
        public const string PJ_HIGHPREC_VALUE_IS_ZERO = "(a) (a==0)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_highprec_mod -> "(a,b) (a=fmod(a,b))"
        public const string pj_highprec_mod = "(a,b) (a=fmod(a,b))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_highprec_mul -> "(a1,a2) (a1 = a1 * a2)"
        public const string pj_highprec_mul = "(a1,a2) (a1 = a1 * a2)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_highprec_div -> "(a1,a2) (a1 = a1 / a2)"
        public const string pj_highprec_div = "(a1,a2) (a1 = a1 / a2)";

        /// PJ_PI -> 3.14159265358979323846
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_PI = "3.14159265358979323846";

        /// PJ_1_PI -> 0.318309886183790671538
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_1_PI = "0.318309886183790671538";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_ABS -> "(x) ((x) >  0 ? (x) : -(x))"
        public const string PJ_ABS = "(x) ((x) >  0 ? (x) : -(x))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_MAX -> "(x,y) ((x) > (y)? (x) : (y))"
        public const string PJ_MAX = "(x,y) ((x) > (y)? (x) : (y))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_MIN -> "(x,y) ((x) < (y)? (x) : (y))"
        public const string PJ_MIN = "(x,y) ((x) < (y)? (x) : (y))";

        /// __PJMEDIA_RTP_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_RTP_H__ = "";

        /// __PJMEDIA_SDP_NEG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_SDP_NEG_H__ = "";

        /// __PJMEDIA_SESSION_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_SESSION_H__ = "";

        /// __PJMEDIA_STREAM_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_STREAM_H__ = "";

        /// __PJMEDIA_TRANSPORT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_TRANSPORT_H__ = "";

        /// __PJMEDIA_SILENCE_DET_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_SILENCE_DET_H__ = "";

        /// __PJMEDIA_SOUND_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_SOUND_H__ = "";

        /// __PJMEDIA_AUDIODEV_AUDIODEV_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_AUDIODEV_AUDIODEV_H__ = "";

        /// __PJMEDIA_AUDIODEV_CONFIG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_AUDIODEV_CONFIG_H__ = "";

        /// PJMEDIA_AUDIO_DEV_HAS_PORTAUDIO -> 1
        public const int PJMEDIA_AUDIO_DEV_HAS_PORTAUDIO = 1;

        /// PJMEDIA_AUDIO_DEV_HAS_WMME -> 1
        public const int PJMEDIA_AUDIO_DEV_HAS_WMME = 1;

        /// PJMEDIA_AUDIO_DEV_HAS_SYMB_APS -> 0
        public const int PJMEDIA_AUDIO_DEV_HAS_SYMB_APS = 0;

        /// PJMEDIA_AUDIO_DEV_HAS_SYMB_VAS -> 0
        public const int PJMEDIA_AUDIO_DEV_HAS_SYMB_VAS = 0;

        /// PJMEDIA_AUDIO_DEV_SYMB_VAS_VERSION -> 1
        public const int PJMEDIA_AUDIO_DEV_SYMB_VAS_VERSION = 1;

        /// PJMEDIA_AUDIO_DEV_HAS_SYMB_MDA -> PJ_SYMBIAN
        /// Error generating expression: Value PJ_SYMBIAN is not resolved
        public const string PJMEDIA_AUDIO_DEV_HAS_SYMB_MDA = "PJ_SYMBIAN";

        /// PJMEDIA_AUDIO_DEV_HAS_LEGACY_DEVICE -> 0
        public const int PJMEDIA_AUDIO_DEV_HAS_LEGACY_DEVICE = 0;

        /// __PJMEDIA_SOUND_PORT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_SOUND_PORT_H__ = "";

        /// __PJMEDIA_SPLITCOMB_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_SPLITCOMB_H__ = "";

        /// __PJMEDIA_STEREO_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_STEREO_H__ = "";

        /// PJMEDIA_STEREO_MIX -> PJ_TRUE
        public const int PJMEDIA_STEREO_MIX = NativeConstants.PJ_TRUE;

        /// __PJMEDIA_TONEGEN_PORT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_TONEGEN_PORT_H__ = "";

        /// __PJMEDIA_TRANSPORT_ADAPTER_SAMPLE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_TRANSPORT_ADAPTER_SAMPLE_H__ = "";

        /// __PJMEDIA_TRANSPORT_ICE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_TRANSPORT_ICE_H__ = "";

        /// __PJNATH_ICE_STRANS_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJNATH_ICE_STRANS_H__ = "";

        /// __PJNATH_ICE_SESSION_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJNATH_ICE_SESSION_H__ = "";

        /// __PJNATH_TYPES_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJNATH_TYPES_H__ = "";

        /// __PJNATH_CONFIG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJNATH_CONFIG_H__ = "";

        /// PJNATH_ERROR_LEVEL -> 1
        public const int PJNATH_ERROR_LEVEL = 1;

        /// PJ_STUN_RTO_VALUE -> 100
        public const int PJ_STUN_RTO_VALUE = 100;

        /// PJ_STUN_TIMEOUT_VALUE -> (16 * PJ_STUN_RTO_VALUE)
        public const int PJ_STUN_TIMEOUT_VALUE = (16 * NativeConstants.PJ_STUN_RTO_VALUE);

        /// PJ_STUN_MAX_TRANSMIT_COUNT -> 7
        public const int PJ_STUN_MAX_TRANSMIT_COUNT = 7;

        /// PJ_STUN_RES_CACHE_DURATION -> 10000
        public const int PJ_STUN_RES_CACHE_DURATION = 10000;

        /// PJ_STUN_MAX_PKT_LEN -> 800
        public const int PJ_STUN_MAX_PKT_LEN = 800;

        /// PJ_STUN_PORT -> 3478
        public const int PJ_STUN_PORT = 3478;

        /// PJ_STUN_STRING_ATTR_PAD_CHR -> 0
        public const int PJ_STUN_STRING_ATTR_PAD_CHR = 0;

        /// PJ_STUN_OLD_STYLE_MI_FINGERPRINT -> 0
        public const int PJ_STUN_OLD_STYLE_MI_FINGERPRINT = 0;

        /// PJ_STUN_SOCK_PKT_LEN -> 2000
        public const int PJ_STUN_SOCK_PKT_LEN = 2000;

        /// PJ_STUN_KEEP_ALIVE_SEC -> 15
        public const int PJ_STUN_KEEP_ALIVE_SEC = 15;

        /// PJ_TURN_MAX_DNS_SRV_CNT -> 4
        public const int PJ_TURN_MAX_DNS_SRV_CNT = 4;

        /// PJ_TURN_MAX_PKT_LEN -> 3000
        public const int PJ_TURN_MAX_PKT_LEN = 3000;

        /// PJ_TURN_PERM_TIMEOUT -> 300
        public const int PJ_TURN_PERM_TIMEOUT = 300;

        /// PJ_TURN_CHANNEL_TIMEOUT -> 600
        public const int PJ_TURN_CHANNEL_TIMEOUT = 600;

        /// PJ_TURN_REFRESH_SEC_BEFORE -> 60
        public const int PJ_TURN_REFRESH_SEC_BEFORE = 60;

        /// PJ_TURN_KEEP_ALIVE_SEC -> 15
        public const int PJ_TURN_KEEP_ALIVE_SEC = 15;

        /// PJ_ICE_MAX_CAND -> 16
        public const int PJ_ICE_MAX_CAND = 16;

        /// PJ_ICE_ST_MAX_CAND -> 8
        public const int PJ_ICE_ST_MAX_CAND = 8;

        /// PJ_ICE_COMP_BITS -> 3
        public const int PJ_ICE_COMP_BITS = 3;

        /// PJ_ICE_MAX_COMP -> (2<<PJ_ICE_COMP_BITS)
        public const int PJ_ICE_MAX_COMP = (2) << (NativeConstants.PJ_ICE_COMP_BITS);

        /// PJNATH_ICE_PRIO_STD -> 1
        public const int PJNATH_ICE_PRIO_STD = 1;

        /// PJ_ICE_CAND_TYPE_PREF_BITS -> 8
        public const int PJ_ICE_CAND_TYPE_PREF_BITS = 8;

        /// PJ_ICE_LOCAL_PREF_BITS -> 0
        public const int PJ_ICE_LOCAL_PREF_BITS = 0;

        /// PJ_ICE_MAX_CHECKS -> 32
        public const int PJ_ICE_MAX_CHECKS = 32;

        /// PJ_ICE_TA_VAL -> 20
        public const int PJ_ICE_TA_VAL = 20;

        /// PJ_ICE_CANCEL_ALL -> 1
        public const int PJ_ICE_CANCEL_ALL = 1;

        /// ICE_CONTROLLED_AGENT_WAIT_NOMINATION_TIMEOUT -> 10000
        public const int ICE_CONTROLLED_AGENT_WAIT_NOMINATION_TIMEOUT = 10000;

        /// PJ_ICE_NOMINATED_CHECK_DELAY -> (4*PJ_STUN_RTO_VALUE)
        public const int PJ_ICE_NOMINATED_CHECK_DELAY = (4 * NativeConstants.PJ_STUN_RTO_VALUE);

        /// PJ_ICE_SESS_KEEP_ALIVE_MIN -> 20
        public const int PJ_ICE_SESS_KEEP_ALIVE_MIN = 20;

        /// PJ_ICE_SESS_KEEP_ALIVE_MAX_RAND -> 5
        public const int PJ_ICE_SESS_KEEP_ALIVE_MAX_RAND = 5;

        /// PJ_ICE_UFRAG_LEN -> 8
        public const int PJ_ICE_UFRAG_LEN = 8;

        /// PJNATH_POOL_LEN_ICE_SESS -> 512
        public const int PJNATH_POOL_LEN_ICE_SESS = 512;

        /// PJNATH_POOL_INC_ICE_SESS -> 512
        public const int PJNATH_POOL_INC_ICE_SESS = 512;

        /// PJNATH_POOL_LEN_ICE_STRANS -> 1000
        public const int PJNATH_POOL_LEN_ICE_STRANS = 1000;

        /// PJNATH_POOL_INC_ICE_STRANS -> 512
        public const int PJNATH_POOL_INC_ICE_STRANS = 512;

        /// PJNATH_POOL_LEN_NATCK -> 512
        public const int PJNATH_POOL_LEN_NATCK = 512;

        /// PJNATH_POOL_INC_NATCK -> 512
        public const int PJNATH_POOL_INC_NATCK = 512;

        /// PJNATH_POOL_LEN_STUN_SESS -> 1000
        public const int PJNATH_POOL_LEN_STUN_SESS = 1000;

        /// PJNATH_POOL_INC_STUN_SESS -> 1000
        public const int PJNATH_POOL_INC_STUN_SESS = 1000;

        /// PJNATH_POOL_LEN_STUN_TDATA -> 1000
        public const int PJNATH_POOL_LEN_STUN_TDATA = 1000;

        /// PJNATH_POOL_INC_STUN_TDATA -> 1000
        public const int PJNATH_POOL_INC_STUN_TDATA = 1000;

        /// PJ_TURN_INVALID_CHANNEL -> 0xFFFF
        public const int PJ_TURN_INVALID_CHANNEL = 65535;

        /// __PJNATH_STUN_SESSION_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJNATH_STUN_SESSION_H__ = "";

        /// __PJNATH_STUN_MSG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJNATH_STUN_MSG_H__ = "";

        /// PJ_STUN_MAGIC -> 0x2112A442
        public const int PJ_STUN_MAGIC = 554869826;

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_STUN_GET_METHOD -> "(msg_type) ((msg_type) & 0xFEEF)"
        public const string PJ_STUN_GET_METHOD = "(msg_type) ((msg_type) & 0xFEEF)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_STUN_IS_REQUEST -> "(msg_type) (((msg_type) & 0x0110) == 0x0000)"
        public const string PJ_STUN_IS_REQUEST = "(msg_type) (((msg_type) & 0x0110) == 0x0000)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_STUN_IS_SUCCESS_RESPONSE -> "(msg_type) (((msg_type) & 0x0110) == 0x0100)"
        public const string PJ_STUN_IS_SUCCESS_RESPONSE = "(msg_type) (((msg_type) & 0x0110) == 0x0100)";

        /// PJ_STUN_SUCCESS_RESPONSE_BIT -> (0x0100)
        public const int PJ_STUN_SUCCESS_RESPONSE_BIT = 256;

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_STUN_IS_ERROR_RESPONSE -> "(msg_type) (((msg_type) & 0x0110) == 0x0110)"
        public const string PJ_STUN_IS_ERROR_RESPONSE = "(msg_type) (((msg_type) & 0x0110) == 0x0110)";

        /// PJ_STUN_ERROR_RESPONSE_BIT -> (0x0110)
        public const int PJ_STUN_ERROR_RESPONSE_BIT = 272;

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_STUN_IS_RESPONSE -> "(msg_type) (((msg_type) & 0x0100) == 0x0100)"
        public const string PJ_STUN_IS_RESPONSE = "(msg_type) (((msg_type) & 0x0100) == 0x0100)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_STUN_IS_INDICATION -> "(msg_type) (((msg_type) & 0x0110) == 0x0010)"
        public const string PJ_STUN_IS_INDICATION = "(msg_type) (((msg_type) & 0x0110) == 0x0010)";

        /// PJ_STUN_INDICATION_BIT -> (0x0010)
        public const int PJ_STUN_INDICATION_BIT = 16;

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_STUN_GET_CH_NB -> "(u32) ((pj_uint16_t)(u32>>16))"
        public const string PJ_STUN_GET_CH_NB = "(u32) ((pj_uint16_t)(u32>>16))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_STUN_SET_CH_NB -> "(chnum) (((pj_uint32_t)chnum) << 16)"
        public const string PJ_STUN_SET_CH_NB = "(chnum) (((pj_uint32_t)chnum) << 16)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_STUN_GET_RT_PROTO -> "(u32) (u32 >> 24)"
        public const string PJ_STUN_GET_RT_PROTO = "(u32) (u32 >> 24)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_STUN_SET_RT_PROTO -> "(proto) (((pj_uint32_t)(proto)) << 24)"
        public const string PJ_STUN_SET_RT_PROTO = "(proto) (((pj_uint32_t)(proto)) << 24)";

        /// __PJNATH_STUN_AUTH_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJNATH_STUN_AUTH_H__ = "";

        /// __PJNATH_STUN_CONFIG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJNATH_STUN_CONFIG_H__ = "";

        /// __PJNATH_STUN_TRANSACTION_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJNATH_STUN_TRANSACTION_H__ = "";

        /// __PJNATH_STUN_SOCK_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJNATH_STUN_SOCK_H__ = "";

        /// __PJNATH_TURN_SOCK_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJNATH_TURN_SOCK_H__ = "";

        /// __PJNATH_TURN_SESSION_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJNATH_TURN_SESSION_H__ = "";

        /// __PJMEDIA_TRANSPORT_LOOP_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_TRANSPORT_LOOP_H__ = "";

        /// __PJMEDIA_TRANSPORT_SRTP_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_TRANSPORT_SRTP_H__ = "";

        /// __PJMEDIA_TRANSPORT_UDP_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_TRANSPORT_UDP_H__ = "";

        /// __PJMEDIA_WAV_PLAYLIST_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_WAV_PLAYLIST_H__ = "";

        /// __PJMEDIA_WAV_PORT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_WAV_PORT_H__ = "";

        /// __PJMEDIA_WAVE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_WAVE_H__ = "";


        /// PJMEDIA_WAVE_NORMALIZE_SUBCHUNK -> (ch)
        /// Error generating expression: Value ch is not resolved
        public const string PJMEDIA_WAVE_NORMALIZE_SUBCHUNK = "(ch)";

        /// __PJMEDIA_WSOLA_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_WSOLA_H__ = "";

        /// __PJMEDIA_CODEC_PJMEDIA_CODEC_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CODEC_PJMEDIA_CODEC_H__ = "";

        /// __PJMEDIA_CODEC_L16_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CODEC_L16_H__ = "";

        /// __PJMEDIA_CODEC_GSM_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CODEC_GSM_H__ = "";

        /// __PJMEDIA_CODEC_SPEEX_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CODEC_SPEEX_H__ = "";

        /// __PJMEDIA_CODEC_ILBC_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CODEC_ILBC_H__ = "";

        /// __PJMEDIA_CODEC_G722_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CODEC_G722_H__ = "";

        /// __PJMEDIA_CODECS_G7221_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CODECS_G7221_H__ = "";

        /// __PJMEDIA_CODECS_IPP_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CODECS_IPP_H__ = "";

        /// __PJMEDIA_CODECS_PASSTHROUGH_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJMEDIA_CODECS_PASSTHROUGH_H__ = "";

        /// __PJSIP_UA_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_UA_H__ = "";

        /// __SIP_INVITE_SESSION_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__SIP_INVITE_SESSION_H__ = "";

        /// __PJSIP_SIP_REG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIP_REG_H__ = "";

        /// PJSIP_REGC_MAX_CONTACT -> 10
        public const int PJSIP_REGC_MAX_CONTACT = 10;

        /// PJSIP_REGC_EXPIRATION_NOT_SPECIFIED -> ((pj_uint32_t)0xFFFFFFFFUL)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string PJSIP_REGC_EXPIRATION_NOT_SPECIFIED = "((pj_uint32_t)0xFFFFFFFFUL)";

        /// PJSIP_REGC_CONTACT_BUF_SIZE -> 512
        public const int PJSIP_REGC_CONTACT_BUF_SIZE = 512;

        /// __PJSIP_REPLACES_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_REPLACES_H__ = "";

        /// __PJSIP_XFER_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_XFER_H__ = "";

        /// __PJSIP_SIMPLE_EVSUB_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIMPLE_EVSUB_H__ = "";

        /// __PJSIP_SIMPLE_TYPES_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIMPLE_TYPES_H__ = "";

        /// PJSIP_EVSUB_POOL_LEN -> 4000
        public const int PJSIP_EVSUB_POOL_LEN = 4000;

        /// PJSIP_EVSUB_POOL_INC -> 4000
        public const int PJSIP_EVSUB_POOL_INC = 4000;

        /// __SIP_100REL_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__SIP_100REL_H__ = "";

        /// __PJSIP_TIMER_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_TIMER_H__ = "";

        /// __PJSIP_SIMPLE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIMPLE_H__ = "";

        /// __PJSIP_SIMPLE_ISCOMPOSING_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIMPLE_ISCOMPOSING_H__ = "";

        /// __PJ_XML_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_XML_H__ = "";

        /// __PJSIP_SIMPLE_PRESENCE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIMPLE_PRESENCE_H__ = "";

        /// __PJSIP_SIMPLE_PIDF_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIMPLE_PIDF_H__ = "";

        /// __PJSIP_SIMPLE_XPIDF_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIMPLE_XPIDF_H__ = "";

        /// __PJSIP_SIMPLE_RPID_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIMPLE_RPID_H__ = "";

        /// PJSIP_PRES_STATUS_MAX_INFO -> 8
        public const int PJSIP_PRES_STATUS_MAX_INFO = 8;

        /// __PJSIP_SIMPLE_PUBLISH_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSIP_SIMPLE_PUBLISH_H__ = "";

        /// PJSIP_PUBC_EXPIRATION_NOT_SPECIFIED -> ((pj_uint32_t)0xFFFFFFFFUL)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string PJSIP_PUBC_EXPIRATION_NOT_SPECIFIED = "((pj_uint32_t)0xFFFFFFFFUL)";

        /// __PJNATH_NAT_DETECT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJNATH_NAT_DETECT_H__ = "";

        /// __PJLIB_UTIL_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_H__ = "";

        /// __PJ_GETOPT_H__ -> 1
        public const int @__PJ_GETOPT_H__ = 1;

        /// no_argument -> 0
        public const int no_argument = 0;

        /// required_argument -> 1
        public const int required_argument = 1;

        /// optional_argument -> 2
        public const int optional_argument = 2;

        /// __PJLIB_UTIL_BASE64_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_BASE64_H__ = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_BASE256_TO_BASE64_LEN -> "(len) (len * 4 / 3 + 3)"
        public const string PJ_BASE256_TO_BASE64_LEN = "(len) (len * 4 / 3 + 3)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_BASE64_TO_BASE256_LEN -> "(len) (len * 3 / 4)"
        public const string PJ_BASE64_TO_BASE256_LEN = "(len) (len * 3 / 4)";

        /// __PJLIB_UTIL_CRC32_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_CRC32_H__ = "";

        /// __PJLIB_UTIL_HMAC_MD5_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_HMAC_MD5_H__ = "";

        /// __PJLIB_UTIL_MD5_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_MD5_H__ = "";

        /// __PJLIB_UTIL_HMAC_SHA1_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_HMAC_SHA1_H__ = "";

        /// __PJLIB_UTIL_SHA1_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_SHA1_H__ = "";

        /// PJ_SHA1_DIGEST_SIZE -> 20
        public const int PJ_SHA1_DIGEST_SIZE = 20;

        /// __PJLIB_UTIL_SRV_RESOLVER_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_SRV_RESOLVER_H__ = "";

        /// __PJLIB_UTIL_DNS_SERVER_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_DNS_SERVER_H__ = "";

        /// __PJSTUN_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJSTUN_H__ = "";

        /// __PJLIB_UTIL_PCAP_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_UTIL_PCAP_H__ = "";

        /// __PJLIB_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJLIB_H__ = "";

        /// __PJ_ASYNCSOCK_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_ASYNCSOCK_H__ = "";

        /// __PJ_ADDR_RESOLV_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_ADDR_RESOLV_H__ = "";

        /// __PJ_ARRAY_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_ARRAY_H__ = "";

        /// __PJ_CTYPE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_CTYPE_H__ = "";

        /// __PJ_COMPAT_CTYPE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_COMPAT_CTYPE_H__ = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// isblank -> "(c) (c==' ' || c=='\t')"
        public const string isblank = "(c) (c==\' \' || c==\'\\t\')";

        /// pj_hex_digits -> "0123456789abcdef"
        public const string pj_hex_digits = "0123456789abcdef";

        /// __PJ_EXCEPTION_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_EXCEPTION_H__ = "";

        /// __PJ_COMPAT_SETJMP_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_COMPAT_SETJMP_H__ = "";

        /// _INC_SETJMP -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _INC_SETJMP = "";

        /// _JMP_BUF_DEFINED -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string _JMP_BUF_DEFINED = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_setjmp -> "(buf) setjmp(buf)"
        public const string pj_setjmp = "(buf) setjmp(buf)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_longjmp -> "(buf,d) longjmp(buf,d)"
        public const string pj_longjmp = "(buf,d) longjmp(buf,d)";

        /// __PJ_LOG_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_LOG_H__ = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_LOG -> "(level,arg) do { 
        ///				    if (level <= pj_log_get_level()) 
        ///					pj_log_wrapper_##level(arg); 
        ///				} while (0)"
        public const string PJ_LOG = "(level,arg) do { \r\n\t\t\t\t    if (level <= pj_log_get_level()) \r\n\t\t\t\t\tpj_log_wrapper" +
            "_##level(arg); \r\n\t\t\t\t} while (0)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_log_wrapper_1 -> "(arg) pj_log_1 arg"
        public const string pj_log_wrapper_1 = "(arg) pj_log_1 arg";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_log_wrapper_2 -> "(arg) pj_log_2 arg"
        public const string pj_log_wrapper_2 = "(arg) pj_log_2 arg";

        /// Warning: Generation of Method Macros is not supported at this time
        /// pj_log_wrapper_3 -> "(arg) pj_log_3 arg"
        public const string pj_log_wrapper_3 = "(arg) pj_log_3 arg";

        /// pj_log_wrapper_4 -> (arg)
        /// Error generating expression: Value arg is not resolved
        public const string pj_log_wrapper_4 = "(arg)";

        /// pj_log_wrapper_5 -> (arg)
        /// Error generating expression: Value arg is not resolved
        public const string pj_log_wrapper_5 = "(arg)";

        /// pj_log_wrapper_6 -> (arg)
        /// Error generating expression: Value arg is not resolved
        public const string pj_log_wrapper_6 = "(arg)";

        /// PJ_USE_EXCEPTION -> struct pj_exception_state_t pj_x_except__; int pj_x_code__
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_USE_EXCEPTION = "struct pj_exception_state_t pj_x_except__; int pj_x_code__";

        /// PJ_TRY -> if (1) { 				pj_push_exception_handler_(&pj_x_except__); 				pj_x_code__ = pj_setjmp(pj_x_except__.state); 				if (pj_x_code__ == 0)
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_TRY = "if (1) { \t\t\t\tpj_push_exception_handler_(&pj_x_except__); \t\t\t\tpj_x_code__ = pj_set" +
            "jmp(pj_x_except__.state); \t\t\t\tif (pj_x_code__ == 0)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_CATCH -> "(id) else if (pj_x_code__ == (id))"
        public const string PJ_CATCH = "(id) else if (pj_x_code__ == (id))";

        /// PJ_CATCH_ANY -> else
        /// Error generating expression: Value else is not resolved
        public const string PJ_CATCH_ANY = "else";

        /// PJ_END -> pj_pop_exception_handler_(&pj_x_except__); 			    } else {}
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_END = "pj_pop_exception_handler_(&pj_x_except__); \t\t\t    } else {}";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_THROW -> "(exception_id) pj_throw_exception_(exception_id)"
        public const string PJ_THROW = "(exception_id) pj_throw_exception_(exception_id)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_GET_EXCEPTION -> "() (pj_x_code__)"
        public const string PJ_GET_EXCEPTION = "() (pj_x_code__)";

        /// __PJ_FIFOBUF_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_FIFOBUF_H__ = "";

        /// __PJ_FILE_ACCESS_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_FILE_ACCESS_H__ = "";

        /// __PJ_FILE_IO_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_FILE_IO_H__ = "";

        /// __PJ_GUID_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_GUID_H__ = "";

        /// PJ_GUID_MAX_LENGTH -> 36
        public const int PJ_GUID_MAX_LENGTH = 36;

        /// __PJ_HASH_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_HASH_H__ = "";

        /// PJ_HASH_KEY_STRING -> ((unsigned)-1)
        /// Error generating expression: Value unsigned is not resolved
        public const string PJ_HASH_KEY_STRING = "((unsigned)-1)";

        /// PJ_HASH_ENTRY_BUF_SIZE -> (3*sizeof(void*) + 2*sizeof(pj_uint32_t))
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_HASH_ENTRY_BUF_SIZE = "(3*sizeof(void*) + 2*sizeof(pj_uint32_t))";

        /// __PJ_IP_ROUTE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_IP_ROUTE_H__ = "";

        /// __PJ_LOCK_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_LOCK_H__ = "";

        /// __POOL_STACK_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__POOL_STACK_H__ = "";

        /// __PJ_RAND_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_RAND_H__ = "";

        /// __PJ_RBTREE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_RBTREE_H__ = "";

        /// PJ_RBTREE_NODE_SIZE -> (sizeof(pj_rbtree_node))
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJ_RBTREE_NODE_SIZE = "(sizeof(pj_rbtree_node))";

        /// PJ_RBTREE_SIZE -> (sizeof(pj_rbtree))
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PJ_RBTREE_SIZE = "(sizeof(pj_rbtree))";

        /// __PJ_SELECT_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_SELECT_H__ = "";

        /// __PJ_UNICODE_H__ -> 
        /// Error generating expression: Значение не может быть неопределенным.
        ///Имя параметра: node
        public const string @__PJ_UNICODE_H__ = "";

        /// PJ_DECL_UNICODE_TEMP_BUF -> (var,size)
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_DECL_UNICODE_TEMP_BUF = "(var,size)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_STRING_TO_NATIVE -> "(s,buf,max) ((char*)s)"
        public const string PJ_STRING_TO_NATIVE = "(s,buf,max) ((char*)s)";

        /// PJ_DECL_ANSI_TEMP_BUF -> (buf,size)
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string PJ_DECL_ANSI_TEMP_BUF = "(buf,size)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PJ_NATIVE_TO_STRING -> "(cs,buf,max) ((char*)(const char*)cs)"
        public const string PJ_NATIVE_TO_STRING = "(cs,buf,max) ((char*)(const char*)cs)";

        /// PJSUA_INVALID_ID -> (-1)
        public const int PJSUA_INVALID_ID = -1;

        /// PJSUA_ACC_MAX_PROXIES -> 8
        public const int PJSUA_ACC_MAX_PROXIES = 8;

        /// PJSUA_DEFAULT_USE_SRTP -> PJMEDIA_SRTP_DISABLED
        public const pjmedia_srtp_use PJSUA_DEFAULT_USE_SRTP = pjmedia_srtp_use.PJMEDIA_SRTP_DISABLED;

        /// PJSUA_DEFAULT_SRTP_SECURE_SIGNALING -> 1
        public const int PJSUA_DEFAULT_SRTP_SECURE_SIGNALING = 1;

        /// pjsip_cred_dup -> pjsip_cred_info_dup
        /// Error generating expression: Value pjsip_cred_info_dup is not resolved
        public const string pjsip_cred_dup = "pjsip_cred_info_dup";

        /// PJSUA_MAX_ACC -> 8
        public const int PJSUA_MAX_ACC = 8;

        /// PJSUA_REG_INTERVAL -> 300
        public const int PJSUA_REG_INTERVAL = 300;

        /// PJSUA_DEFAULT_ACC_PRIORITY -> 0
        public const int PJSUA_DEFAULT_ACC_PRIORITY = 0;

        /// PJSUA_SECURE_SCHEME -> "sip"
        public const string PJSUA_SECURE_SCHEME = "sip";

        /// PJSUA_XFER_NO_REQUIRE_REPLACES -> 1
        public const int PJSUA_XFER_NO_REQUIRE_REPLACES = 1;

        /// PJSUA_MAX_BUDDIES -> 256
        public const int PJSUA_MAX_BUDDIES = 256;

        /// PJSUA_PRES_TIMER -> 300
        public const int PJSUA_PRES_TIMER = 300;

        /// PJSUA_MAX_CONF_PORTS -> 254
        public const int PJSUA_MAX_CONF_PORTS = 254;

        /// PJSUA_DEFAULT_CLOCK_RATE -> 16000
        public const int PJSUA_DEFAULT_CLOCK_RATE = 16000;

        /// PJSUA_DEFAULT_AUDIO_FRAME_PTIME -> 20
        public const int PJSUA_DEFAULT_AUDIO_FRAME_PTIME = 20;

        /// PJSUA_DEFAULT_CODEC_QUALITY -> 8
        public const int PJSUA_DEFAULT_CODEC_QUALITY = 8;

        /// PJSUA_DEFAULT_ILBC_MODE -> 30
        public const int PJSUA_DEFAULT_ILBC_MODE = 30;

        /// PJSUA_DEFAULT_EC_TAIL_LEN -> 200
        public const int PJSUA_DEFAULT_EC_TAIL_LEN = 200;

        /// PJSUA_MAX_PLAYERS -> 32
        public const int PJSUA_MAX_PLAYERS = 32;

        /// PJSUA_MAX_RECORDERS -> 32
        public const int PJSUA_MAX_RECORDERS = 32;

        /// _MSC_VER -> 9999
        public const int _MSC_VER = 9999;

        /// WSAEWOULDBLOCK -> 10035L
        public const int WSAEWOULDBLOCK = 10035;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct pj_str_t
    {

        /// char*
        public IntPtr ptr;

        /// pj_ssize_t->int
        public int slen;

        public pj_str_t(string source)
        {
            ptr = string.IsNullOrEmpty(source) ? IntPtr.Zero : Marshal.StringToHGlobalAnsi(source);
            slen = string.IsNullOrEmpty(source) ? 0 : source.Length;
        }

        public static implicit operator string(pj_str_t @string)
        {
            return @string.slen == 0 ? string.Empty : Marshal.PtrToStringAnsi(@string.ptr, @string.slen);
        }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public struct pj_timestamp
    {

        /// Anonymous_8f76ed83_b773_414d_aab1_99764d2712ae
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_8f76ed83_b773_414d_aab1_99764d2712ae u32;

        /// pj_uint64_t->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong u64;
    }

    /// Return Type: void
    public delegate void pj_exit_callback();

    [StructLayout(LayoutKind.Sequential)]
    public struct pj_time_val
    {
        /// int
        public int sec;

        /// int
        public int msec;

        public static implicit operator TimeSpan(pj_time_val time)
        {
            return TimeSpan.FromMilliseconds(time.msec).Add(TimeSpan.FromSeconds(time.sec));
        }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_parsed_time
    {

        /// int
        public int wday;

        /// int
        public int day;

        /// int
        public int mon;

        /// int
        public int year;

        /// int
        public int sec;

        /// int
        public int min;

        /// int
        public int hour;

        /// int
        public int msec;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_cfg_t
    {

        /// Anonymous_086cca6e_5828_482b_8f5b_27304685ff89
        public Anonymous_086cca6e_5828_482b_8f5b_27304685ff89 tsx;

        /// Anonymous_c441d546_e170_46ac_93c6_11da47055c8f
        public Anonymous_c441d546_e170_46ac_93c6_11da47055c8f regc;
    }

    public enum pjsip_transport_type_e
    {

        PJSIP_TRANSPORT_UNSPECIFIED,

        PJSIP_TRANSPORT_UDP,

        PJSIP_TRANSPORT_TCP,

        PJSIP_TRANSPORT_TLS,

        PJSIP_TRANSPORT_SCTP,

        PJSIP_TRANSPORT_LOOP,

        PJSIP_TRANSPORT_LOOP_DGRAM,

        PJSIP_TRANSPORT_START_OTHER,

        /// PJSIP_TRANSPORT_IPV6 -> 128
        PJSIP_TRANSPORT_IPV6 = 128,

        /// PJSIP_TRANSPORT_UDP6 -> PJSIP_TRANSPORT_UDP+PJSIP_TRANSPORT_IPV6
        PJSIP_TRANSPORT_UDP6 = (pjsip_transport_type_e.PJSIP_TRANSPORT_UDP + pjsip_transport_type_e.PJSIP_TRANSPORT_IPV6),

        /// PJSIP_TRANSPORT_TCP6 -> PJSIP_TRANSPORT_TCP+PJSIP_TRANSPORT_IPV6
        PJSIP_TRANSPORT_TCP6 = (pjsip_transport_type_e.PJSIP_TRANSPORT_TCP + pjsip_transport_type_e.PJSIP_TRANSPORT_IPV6),
    }

    public enum pjsip_role_e
    {

        PJSIP_ROLE_UAC,

        PJSIP_ROLE_UAS,

        /// PJSIP_UAC_ROLE -> PJSIP_ROLE_UAC
        PJSIP_UAC_ROLE = pjsip_role_e.PJSIP_ROLE_UAC,

        /// PJSIP_UAS_ROLE -> PJSIP_ROLE_UAS
        PJSIP_UAS_ROLE = pjsip_role_e.PJSIP_ROLE_UAS,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_buffer
    {

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string start;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string cur;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string end;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_host_port
    {

        /// pj_str_t
        public pj_str_t host;

        /// int
        public int port;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_host_info
    {

        /// unsigned int
        public uint flag;

        /// pjsip_transport_type_e
        public pjsip_transport_type_e type;

        /// pjsip_host_port
        public pjsip_host_port addr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_list
    {

        /// void*
        public System.IntPtr prev;

        /// void*
        public System.IntPtr next;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_cis_buf_t
    {

        /// pj_cis_elem_t[256]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U4)]
        public uint[] cis_buf;

        /// pj_cis_elem_t->pj_uint32_t->unsigned int
        public uint use_mask;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_cis_t
    {

        /// pj_cis_elem_t*
        public System.IntPtr cis_buf;

        /// int
        public int cis_id;
    }

    /// Return Type: void
    ///scanner: pj_scanner*
    public delegate void pj_syn_err_func_ptr(ref pj_scanner scanner);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_scanner
    {

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string begin;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string end;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string curptr;

        /// int
        public int line;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string start_line;

        /// int
        public int skip_ws;

        /// pj_syn_err_func_ptr
        public pj_syn_err_func_ptr callback;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_scan_state
    {

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string curptr;

        /// int
        public int line;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string start_line;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_param
    {

        /// pjsip_param*
        public System.IntPtr prev;

        /// pjsip_param*
        public System.IntPtr next;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t value;
    }

    public enum pjsip_uri_context_e
    {

        PJSIP_URI_IN_REQ_URI,

        PJSIP_URI_IN_FROMTO_HDR,

        PJSIP_URI_IN_CONTACT_HDR,

        PJSIP_URI_IN_ROUTING_HDR,

        PJSIP_URI_IN_OTHER,
    }

    /// Return Type: pj_str_t*
    ///uri: void*
    public delegate System.IntPtr pjsip_uri_vptr_p_get_scheme(System.IntPtr uri);

    /// Return Type: void*
    ///uri: void*
    public delegate System.IntPtr pjsip_uri_vptr_p_get_uri(System.IntPtr uri);

    /// Return Type: pj_ssize_t->int
    ///context: pjsip_uri_context_e
    ///uri: void*
    ///buf: char*
    ///size: pj_size_t->size_t->unsigned int
    public delegate int pjsip_uri_vptr_p_print(pjsip_uri_context_e context, System.IntPtr uri, System.IntPtr buf, System.IntPtr size);

    /// Return Type: pj_status_t->int
    ///context: pjsip_uri_context_e
    ///uri1: void*
    ///uri2: void*
    public delegate int pjsip_uri_vptr_p_compare(pjsip_uri_context_e context, System.IntPtr uri1, System.IntPtr uri2);

    /// Return Type: void*
    ///pool: pj_pool_t*
    ///uri: void*
    public delegate System.IntPtr pjsip_uri_vptr_p_clone(ref pj_pool_t pool, System.IntPtr uri);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_uri_vptr
    {

        /// pjsip_uri_vptr_p_get_scheme
        public pjsip_uri_vptr_p_get_scheme AnonymousMember1;

        /// pjsip_uri_vptr_p_get_uri
        public pjsip_uri_vptr_p_get_uri AnonymousMember2;

        /// pjsip_uri_vptr_p_print
        public pjsip_uri_vptr_p_print AnonymousMember3;

        /// pjsip_uri_vptr_p_compare
        public pjsip_uri_vptr_p_compare AnonymousMember4;

        /// pjsip_uri_vptr_p_clone
        public pjsip_uri_vptr_p_clone AnonymousMember5;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_uri
    {

        /// pjsip_uri_vptr*
        public System.IntPtr vptr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_sip_uri
    {

        /// pjsip_uri_vptr*
        public System.IntPtr vptr;

        /// pj_str_t
        public pj_str_t user;

        /// pj_str_t
        public pj_str_t passwd;

        /// pj_str_t
        public pj_str_t host;

        /// int
        public int port;

        /// pj_str_t
        public pj_str_t user_param;

        /// pj_str_t
        public pj_str_t method_param;

        /// pj_str_t
        public pj_str_t transport_param;

        /// int
        public int ttl_param;

        /// int
        public int lr_param;

        /// pj_str_t
        public pj_str_t maddr_param;

        /// pjsip_param
        public pjsip_param other_param;

        /// pjsip_param
        public pjsip_param header_param;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_name_addr
    {

        /// pjsip_uri_vptr*
        public System.IntPtr vptr;

        /// pj_str_t
        public pj_str_t display;

        /// pjsip_uri*
        public System.IntPtr uri;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_other_uri
    {

        /// pjsip_uri_vptr*
        public System.IntPtr vptr;

        /// pj_str_t
        public pj_str_t scheme;

        /// pj_str_t
        public pj_str_t content;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_tel_uri
    {

        /// pjsip_uri_vptr*
        public System.IntPtr vptr;

        /// pj_str_t
        public pj_str_t number;

        /// pj_str_t
        public pj_str_t context;

        /// pj_str_t
        public pj_str_t ext_param;

        /// pj_str_t
        public pj_str_t isub_param;

        /// pjsip_param
        public pjsip_param other_param;
    }

    public enum pjsip_method_e
    {

        PJSIP_INVITE_METHOD,

        PJSIP_CANCEL_METHOD,

        PJSIP_ACK_METHOD,

        PJSIP_BYE_METHOD,

        PJSIP_REGISTER_METHOD,

        PJSIP_OPTIONS_METHOD,

        PJSIP_OTHER_METHOD,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_method
    {

        /// pjsip_method_e
        public pjsip_method_e id;

        /// pj_str_t
        public pj_str_t name;
    }

    public enum pjsip_hdr_e
    {

        PJSIP_H_ACCEPT,

        PJSIP_H_ACCEPT_ENCODING_UNIMP,

        PJSIP_H_ACCEPT_LANGUAGE_UNIMP,

        PJSIP_H_ALERT_INFO_UNIMP,

        PJSIP_H_ALLOW,

        PJSIP_H_AUTHENTICATION_INFO_UNIMP,

        PJSIP_H_AUTHORIZATION,

        PJSIP_H_CALL_ID,

        PJSIP_H_CALL_INFO_UNIMP,

        PJSIP_H_CONTACT,

        PJSIP_H_CONTENT_DISPOSITION_UNIMP,

        PJSIP_H_CONTENT_ENCODING_UNIMP,

        PJSIP_H_CONTENT_LANGUAGE_UNIMP,

        PJSIP_H_CONTENT_LENGTH,

        PJSIP_H_CONTENT_TYPE,

        PJSIP_H_CSEQ,

        PJSIP_H_DATE_UNIMP,

        PJSIP_H_ERROR_INFO_UNIMP,

        PJSIP_H_EXPIRES,

        PJSIP_H_FROM,

        PJSIP_H_IN_REPLY_TO_UNIMP,

        PJSIP_H_MAX_FORWARDS,

        PJSIP_H_MIME_VERSION_UNIMP,

        PJSIP_H_MIN_EXPIRES,

        PJSIP_H_ORGANIZATION_UNIMP,

        PJSIP_H_PRIORITY_UNIMP,

        PJSIP_H_PROXY_AUTHENTICATE,

        PJSIP_H_PROXY_AUTHORIZATION,

        PJSIP_H_PROXY_REQUIRE_UNIMP,

        PJSIP_H_RECORD_ROUTE,

        PJSIP_H_REPLY_TO_UNIMP,

        PJSIP_H_REQUIRE,

        PJSIP_H_RETRY_AFTER,

        PJSIP_H_ROUTE,

        PJSIP_H_SERVER_UNIMP,

        PJSIP_H_SUBJECT_UNIMP,

        PJSIP_H_SUPPORTED,

        PJSIP_H_TIMESTAMP_UNIMP,

        PJSIP_H_TO,

        PJSIP_H_UNSUPPORTED,

        PJSIP_H_USER_AGENT_UNIMP,

        PJSIP_H_VIA,

        PJSIP_H_WARNING_UNIMP,

        PJSIP_H_WWW_AUTHENTICATE,

        PJSIP_H_OTHER,
    }

    /// Return Type: void*
    ///pool: pj_pool_t*
    ///hdr: void*
    public delegate System.IntPtr pjsip_hdr_vptr_clone(ref pj_pool_t pool, System.IntPtr hdr);

    /// Return Type: void*
    ///pool: pj_pool_t*
    ///hdr: void*
    public delegate System.IntPtr pjsip_hdr_vptr_shallow_clone(ref pj_pool_t pool, System.IntPtr hdr);

    /// Return Type: int
    ///hdr: void*
    ///buf: char*
    ///len: pj_size_t->size_t->unsigned int
    public delegate int pjsip_hdr_vptr_print_on(System.IntPtr hdr, System.IntPtr buf, System.IntPtr len);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_hdr_vptr
    {

        /// pjsip_hdr_vptr_clone
        public pjsip_hdr_vptr_clone AnonymousMember1;

        /// pjsip_hdr_vptr_shallow_clone
        public pjsip_hdr_vptr_shallow_clone AnonymousMember2;

        /// pjsip_hdr_vptr_print_on
        public pjsip_hdr_vptr_print_on AnonymousMember3;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_hdr
    {

        /// pjsip_hdr*
        public System.IntPtr prev;

        /// pjsip_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_request_line
    {

        /// pjsip_method
        public pjsip_method method;

        /// pjsip_uri*
        public System.IntPtr uri;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_status_line
    {

        /// int
        public int code;

        /// pj_str_t
        public pj_str_t reason;
    }

    public enum pjsip_status_code
    {

        /// PJSIP_SC_TRYING -> 100
        PJSIP_SC_TRYING = 100,

        /// PJSIP_SC_RINGING -> 180
        PJSIP_SC_RINGING = 180,

        /// PJSIP_SC_CALL_BEING_FORWARDED -> 181
        PJSIP_SC_CALL_BEING_FORWARDED = 181,

        /// PJSIP_SC_QUEUED -> 182
        PJSIP_SC_QUEUED = 182,

        /// PJSIP_SC_PROGRESS -> 183
        PJSIP_SC_PROGRESS = 183,

        /// PJSIP_SC_OK -> 200
        PJSIP_SC_OK = 200,

        /// PJSIP_SC_ACCEPTED -> 202
        PJSIP_SC_ACCEPTED = 202,

        /// PJSIP_SC_MULTIPLE_CHOICES -> 300
        PJSIP_SC_MULTIPLE_CHOICES = 300,

        /// PJSIP_SC_MOVED_PERMANENTLY -> 301
        PJSIP_SC_MOVED_PERMANENTLY = 301,

        /// PJSIP_SC_MOVED_TEMPORARILY -> 302
        PJSIP_SC_MOVED_TEMPORARILY = 302,

        /// PJSIP_SC_USE_PROXY -> 305
        PJSIP_SC_USE_PROXY = 305,

        /// PJSIP_SC_ALTERNATIVE_SERVICE -> 380
        PJSIP_SC_ALTERNATIVE_SERVICE = 380,

        /// PJSIP_SC_BAD_REQUEST -> 400
        PJSIP_SC_BAD_REQUEST = 400,

        /// PJSIP_SC_UNAUTHORIZED -> 401
        PJSIP_SC_UNAUTHORIZED = 401,

        /// PJSIP_SC_PAYMENT_REQUIRED -> 402
        PJSIP_SC_PAYMENT_REQUIRED = 402,

        /// PJSIP_SC_FORBIDDEN -> 403
        PJSIP_SC_FORBIDDEN = 403,

        /// PJSIP_SC_NOT_FOUND -> 404
        PJSIP_SC_NOT_FOUND = 404,

        /// PJSIP_SC_METHOD_NOT_ALLOWED -> 405
        PJSIP_SC_METHOD_NOT_ALLOWED = 405,

        /// PJSIP_SC_NOT_ACCEPTABLE -> 406
        PJSIP_SC_NOT_ACCEPTABLE = 406,

        /// PJSIP_SC_PROXY_AUTHENTICATION_REQUIRED -> 407
        PJSIP_SC_PROXY_AUTHENTICATION_REQUIRED = 407,

        /// PJSIP_SC_REQUEST_TIMEOUT -> 408
        PJSIP_SC_REQUEST_TIMEOUT = 408,

        /// PJSIP_SC_GONE -> 410
        PJSIP_SC_GONE = 410,

        /// PJSIP_SC_REQUEST_ENTITY_TOO_LARGE -> 413
        PJSIP_SC_REQUEST_ENTITY_TOO_LARGE = 413,

        /// PJSIP_SC_REQUEST_URI_TOO_LONG -> 414
        PJSIP_SC_REQUEST_URI_TOO_LONG = 414,

        /// PJSIP_SC_UNSUPPORTED_MEDIA_TYPE -> 415
        PJSIP_SC_UNSUPPORTED_MEDIA_TYPE = 415,

        /// PJSIP_SC_UNSUPPORTED_URI_SCHEME -> 416
        PJSIP_SC_UNSUPPORTED_URI_SCHEME = 416,

        /// PJSIP_SC_BAD_EXTENSION -> 420
        PJSIP_SC_BAD_EXTENSION = 420,

        /// PJSIP_SC_EXTENSION_REQUIRED -> 421
        PJSIP_SC_EXTENSION_REQUIRED = 421,

        /// PJSIP_SC_SESSION_TIMER_TOO_SMALL -> 422
        PJSIP_SC_SESSION_TIMER_TOO_SMALL = 422,

        /// PJSIP_SC_INTERVAL_TOO_BRIEF -> 423
        PJSIP_SC_INTERVAL_TOO_BRIEF = 423,

        /// PJSIP_SC_TEMPORARILY_UNAVAILABLE -> 480
        PJSIP_SC_TEMPORARILY_UNAVAILABLE = 480,

        /// PJSIP_SC_CALL_TSX_DOES_NOT_EXIST -> 481
        PJSIP_SC_CALL_TSX_DOES_NOT_EXIST = 481,

        /// PJSIP_SC_LOOP_DETECTED -> 482
        PJSIP_SC_LOOP_DETECTED = 482,

        /// PJSIP_SC_TOO_MANY_HOPS -> 483
        PJSIP_SC_TOO_MANY_HOPS = 483,

        /// PJSIP_SC_ADDRESS_INCOMPLETE -> 484
        PJSIP_SC_ADDRESS_INCOMPLETE = 484,

        /// PJSIP_AC_AMBIGUOUS -> 485
        PJSIP_AC_AMBIGUOUS = 485,

        /// PJSIP_SC_BUSY_HERE -> 486
        PJSIP_SC_BUSY_HERE = 486,

        /// PJSIP_SC_REQUEST_TERMINATED -> 487
        PJSIP_SC_REQUEST_TERMINATED = 487,

        /// PJSIP_SC_NOT_ACCEPTABLE_HERE -> 488
        PJSIP_SC_NOT_ACCEPTABLE_HERE = 488,

        /// PJSIP_SC_BAD_EVENT -> 489
        PJSIP_SC_BAD_EVENT = 489,

        /// PJSIP_SC_REQUEST_UPDATED -> 490
        PJSIP_SC_REQUEST_UPDATED = 490,

        /// PJSIP_SC_REQUEST_PENDING -> 491
        PJSIP_SC_REQUEST_PENDING = 491,

        /// PJSIP_SC_UNDECIPHERABLE -> 493
        PJSIP_SC_UNDECIPHERABLE = 493,

        /// PJSIP_SC_INTERNAL_SERVER_ERROR -> 500
        PJSIP_SC_INTERNAL_SERVER_ERROR = 500,

        /// PJSIP_SC_NOT_IMPLEMENTED -> 501
        PJSIP_SC_NOT_IMPLEMENTED = 501,

        /// PJSIP_SC_BAD_GATEWAY -> 502
        PJSIP_SC_BAD_GATEWAY = 502,

        /// PJSIP_SC_SERVICE_UNAVAILABLE -> 503
        PJSIP_SC_SERVICE_UNAVAILABLE = 503,

        /// PJSIP_SC_SERVER_TIMEOUT -> 504
        PJSIP_SC_SERVER_TIMEOUT = 504,

        /// PJSIP_SC_VERSION_NOT_SUPPORTED -> 505
        PJSIP_SC_VERSION_NOT_SUPPORTED = 505,

        /// PJSIP_SC_MESSAGE_TOO_LARGE -> 513
        PJSIP_SC_MESSAGE_TOO_LARGE = 513,

        /// PJSIP_SC_PRECONDITION_FAILURE -> 580
        PJSIP_SC_PRECONDITION_FAILURE = 580,

        /// PJSIP_SC_BUSY_EVERYWHERE -> 600
        PJSIP_SC_BUSY_EVERYWHERE = 600,

        /// PJSIP_SC_DECLINE -> 603
        PJSIP_SC_DECLINE = 603,

        /// PJSIP_SC_DOES_NOT_EXIST_ANYWHERE -> 604
        PJSIP_SC_DOES_NOT_EXIST_ANYWHERE = 604,

        /// PJSIP_SC_NOT_ACCEPTABLE_ANYWHERE -> 606
        PJSIP_SC_NOT_ACCEPTABLE_ANYWHERE = 606,

        /// PJSIP_SC_TSX_TIMEOUT -> PJSIP_SC_REQUEST_TIMEOUT
        PJSIP_SC_TSX_TIMEOUT = pjsip_status_code.PJSIP_SC_REQUEST_TIMEOUT,

        /// PJSIP_SC_TSX_TRANSPORT_ERROR -> PJSIP_SC_SERVICE_UNAVAILABLE
        PJSIP_SC_TSX_TRANSPORT_ERROR = pjsip_status_code.PJSIP_SC_SERVICE_UNAVAILABLE,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_media_type
    {

        /// pj_str_t
        public pj_str_t type;

        /// pj_str_t
        public pj_str_t subtype;

        /// pj_str_t
        public pj_str_t param;
    }

    /// Return Type: int
    ///msg_body: pjsip_msg_body*
    ///buf: char*
    ///size: pj_size_t->size_t->unsigned int
    public delegate int pjsip_msg_body_print_body(ref pjsip_msg_body msg_body, System.IntPtr buf, System.IntPtr size);

    /// Return Type: void*
    ///pool: pj_pool_t*
    ///data: void*
    ///len: unsigned int
    public delegate System.IntPtr pjsip_msg_body_clone_data(ref pj_pool_t pool, System.IntPtr data, uint len);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_msg_body
    {

        /// pjsip_media_type
        public pjsip_media_type content_type;

        /// void*
        public System.IntPtr data;

        /// unsigned int
        public uint len;

        /// pjsip_msg_body_print_body
        public pjsip_msg_body_print_body AnonymousMember1;

        /// pjsip_msg_body_clone_data
        public pjsip_msg_body_clone_data AnonymousMember2;
    }

    public enum pjsip_msg_type_e
    {

        PJSIP_REQUEST_MSG,

        PJSIP_RESPONSE_MSG,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_msg
    {

        /// pjsip_msg_type_e
        public pjsip_msg_type_e type;

        /// Anonymous_92f5cbce_6875_485c_99be_45295d0617d1
        public Anonymous_92f5cbce_6875_485c_99be_45295d0617d1 line;

        /// pjsip_hdr
        public pjsip_hdr hdr;

        /// pjsip_msg_body*
        public System.IntPtr body;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_generic_string_hdr
    {

        /// pjsip_generic_string_hdr*
        public System.IntPtr prev;

        /// pjsip_generic_string_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// pj_str_t
        public pj_str_t hvalue;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_generic_int_hdr
    {

        /// pjsip_generic_int_hdr*
        public System.IntPtr prev;

        /// pjsip_generic_int_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// pj_int32_t->int
        public int ivalue;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_generic_array_hdr
    {

        /// pjsip_generic_array_hdr*
        public System.IntPtr prev;

        /// pjsip_generic_array_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// unsigned int
        public uint count;

        /// pj_str_t[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public pj_str_t[] values;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_cid_hdr
    {

        /// pjsip_cid_hdr*
        public System.IntPtr prev;

        /// pjsip_cid_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// pj_str_t
        public pj_str_t id;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_clen_hdr
    {

        /// pjsip_clen_hdr*
        public System.IntPtr prev;

        /// pjsip_clen_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// int
        public int len;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_cseq_hdr
    {

        /// pjsip_cseq_hdr*
        public System.IntPtr prev;

        /// pjsip_cseq_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// pj_int32_t->int
        public int cseq;

        /// pjsip_method
        public pjsip_method method;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_contact_hdr
    {

        /// pjsip_contact_hdr*
        public System.IntPtr prev;

        /// pjsip_contact_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// int
        public int star;

        /// pjsip_uri*
        public System.IntPtr uri;

        /// int
        public int q1000;

        /// pj_int32_t->int
        public int expires;

        /// pjsip_param
        public pjsip_param other_param;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_ctype_hdr
    {

        /// pjsip_ctype_hdr*
        public System.IntPtr prev;

        /// pjsip_ctype_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// pjsip_media_type
        public pjsip_media_type media;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_fromto_hdr
    {

        /// pjsip_fromto_hdr*
        public System.IntPtr prev;

        /// pjsip_fromto_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// pjsip_uri*
        public System.IntPtr uri;

        /// pj_str_t
        public pj_str_t tag;

        /// pjsip_param
        public pjsip_param other_param;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_routing_hdr
    {

        /// pjsip_routing_hdr*
        public System.IntPtr prev;

        /// pjsip_routing_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// pjsip_name_addr
        public pjsip_name_addr name_addr;

        /// pjsip_param
        public pjsip_param other_param;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_retry_after_hdr
    {

        /// pjsip_retry_after_hdr*
        public System.IntPtr prev;

        /// pjsip_retry_after_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// pj_int32_t->int
        public int ivalue;

        /// pjsip_param
        public pjsip_param param;

        /// pj_str_t
        public pj_str_t comment;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_via_hdr
    {

        /// pjsip_via_hdr*
        public System.IntPtr prev;

        /// pjsip_via_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// pj_str_t
        public pj_str_t transport;

        /// pjsip_host_port
        public pjsip_host_port sent_by;

        /// int
        public int ttl_param;

        /// int
        public int rport_param;

        /// pj_str_t
        public pj_str_t maddr_param;

        /// pj_str_t
        public pj_str_t recvd_param;

        /// pj_str_t
        public pj_str_t branch_param;

        /// pjsip_param
        public pjsip_param other_param;

        /// pj_str_t
        public pj_str_t comment;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_parser_err_report
    {

        /// pjsip_parser_err_report*
        public System.IntPtr prev;

        /// pjsip_parser_err_report*
        public System.IntPtr next;

        /// int
        public int except_code;

        /// int
        public int line;

        /// int
        public int col;

        /// pj_str_t
        public pj_str_t hname;
    }

    /// Return Type: void*
    ///scanner: pj_scanner*
    ///pool: pj_pool_t*
    ///parse_params: pj_bool_t->int
    public delegate System.IntPtr pjsip_parse_uri_func(ref pj_scanner scanner, ref pj_pool_t pool, int parse_params);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_parser_const_t
    {

        /// pj_str_t
        public pj_str_t pjsip_USER_STR;

        /// pj_str_t
        public pj_str_t pjsip_METHOD_STR;

        /// pj_str_t
        public pj_str_t pjsip_TRANSPORT_STR;

        /// pj_str_t
        public pj_str_t pjsip_MADDR_STR;

        /// pj_str_t
        public pj_str_t pjsip_LR_STR;

        /// pj_str_t
        public pj_str_t pjsip_SIP_STR;

        /// pj_str_t
        public pj_str_t pjsip_SIPS_STR;

        /// pj_str_t
        public pj_str_t pjsip_TEL_STR;

        /// pj_str_t
        public pj_str_t pjsip_BRANCH_STR;

        /// pj_str_t
        public pj_str_t pjsip_TTL_STR;

        /// pj_str_t
        public pj_str_t pjsip_RECEIVED_STR;

        /// pj_str_t
        public pj_str_t pjsip_Q_STR;

        /// pj_str_t
        public pj_str_t pjsip_EXPIRES_STR;

        /// pj_str_t
        public pj_str_t pjsip_TAG_STR;

        /// pj_str_t
        public pj_str_t pjsip_RPORT_STR;

        /// pj_cis_t
        public pj_cis_t pjsip_HOST_SPEC;

        /// pj_cis_t
        public pj_cis_t pjsip_DIGIT_SPEC;

        /// pj_cis_t
        public pj_cis_t pjsip_ALPHA_SPEC;

        /// pj_cis_t
        public pj_cis_t pjsip_ALNUM_SPEC;

        /// pj_cis_t
        public pj_cis_t pjsip_TOKEN_SPEC;

        /// pj_cis_t
        public pj_cis_t pjsip_TOKEN_SPEC_ESC;

        /// pj_cis_t
        public pj_cis_t pjsip_VIA_PARAM_SPEC;

        /// pj_cis_t
        public pj_cis_t pjsip_VIA_PARAM_SPEC_ESC;

        /// pj_cis_t
        public pj_cis_t pjsip_HEX_SPEC;

        /// pj_cis_t
        public pj_cis_t pjsip_PARAM_CHAR_SPEC;

        /// pj_cis_t
        public pj_cis_t pjsip_PARAM_CHAR_SPEC_ESC;

        /// pj_cis_t
        public pj_cis_t pjsip_HDR_CHAR_SPEC;

        /// pj_cis_t
        public pj_cis_t pjsip_HDR_CHAR_SPEC_ESC;

        /// pj_cis_t
        public pj_cis_t pjsip_PROBE_USER_HOST_SPEC;

        /// pj_cis_t
        public pj_cis_t pjsip_PASSWD_SPEC;

        /// pj_cis_t
        public pj_cis_t pjsip_PASSWD_SPEC_ESC;

        /// pj_cis_t
        public pj_cis_t pjsip_USER_SPEC;

        /// pj_cis_t
        public pj_cis_t pjsip_USER_SPEC_ESC;

        /// pj_cis_t
        public pj_cis_t pjsip_USER_SPEC_LENIENT;

        /// pj_cis_t
        public pj_cis_t pjsip_USER_SPEC_LENIENT_ESC;

        /// pj_cis_t
        public pj_cis_t pjsip_NOT_NEWLINE;

        /// pj_cis_t
        public pj_cis_t pjsip_NOT_COMMA_OR_NEWLINE;

        /// pj_cis_t
        public pj_cis_t pjsip_DISPLAY_SPEC;

        /// pj_cis_t
        public pj_cis_t pjsip_OTHER_URI_CONTENT;
    }

    public enum pjsip_event_id_e
    {

        PJSIP_EVENT_UNKNOWN,

        PJSIP_EVENT_TIMER,

        PJSIP_EVENT_TX_MSG,

        PJSIP_EVENT_RX_MSG,

        PJSIP_EVENT_TRANSPORT_ERROR,

        PJSIP_EVENT_TSX_STATE,

        PJSIP_EVENT_USER,
    }

    /// Return Type: pj_status_t->int
    public delegate int pjsip_module_start();

    /// Return Type: pj_status_t->int
    public delegate int pjsip_module_stop();

    /// Return Type: pj_status_t->int
    public delegate int pjsip_module_unload();

    public enum pjsip_module_priority
    {

        /// PJSIP_MOD_PRIORITY_TRANSPORT_LAYER -> 8
        PJSIP_MOD_PRIORITY_TRANSPORT_LAYER = 8,

        /// PJSIP_MOD_PRIORITY_TSX_LAYER -> 16
        PJSIP_MOD_PRIORITY_TSX_LAYER = 16,

        /// PJSIP_MOD_PRIORITY_UA_PROXY_LAYER -> 32
        PJSIP_MOD_PRIORITY_UA_PROXY_LAYER = 32,

        /// PJSIP_MOD_PRIORITY_DIALOG_USAGE -> 48
        PJSIP_MOD_PRIORITY_DIALOG_USAGE = 48,

        /// PJSIP_MOD_PRIORITY_APPLICATION -> 64
        PJSIP_MOD_PRIORITY_APPLICATION = 64,
    }

    public enum pj_socket_sd_type
    {

        /// PJ_SD_RECEIVE -> 0
        PJ_SD_RECEIVE = 0,

        /// PJ_SHUT_RD -> 0
        PJ_SHUT_RD = 0,

        /// PJ_SD_SEND -> 1
        PJ_SD_SEND = 1,

        /// PJ_SHUT_WR -> 1
        PJ_SHUT_WR = 1,

        /// PJ_SD_BOTH -> 2
        PJ_SD_BOTH = 2,

        /// PJ_SHUT_RDWR -> 2
        PJ_SHUT_RDWR = 2,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_in_addr
    {

        /// pj_uint32_t->unsigned int
        public uint s_addr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pj_sockaddr_in
    {

        /// pj_uint16_t->unsigned short
        public ushort sin_family;

        /// pj_uint16_t->unsigned short
        public ushort sin_port;

        /// pj_in_addr
        public pj_in_addr sin_addr;

        /// char[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 8)]
        public string sin_zero;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public struct pj_in6_addr
    {

        /// pj_uint8_t[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public byte[] s6_addr;

        /// pj_uint32_t[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U4)]
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint[] u6_addr32;

        /// pj_int64_t[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I8)]
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public long[] u6_addr64;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_sockaddr_in6
    {

        /// pj_uint16_t->unsigned short
        public ushort sin6_family;

        /// pj_uint16_t->unsigned short
        public ushort sin6_port;

        /// pj_uint32_t->unsigned int
        public uint sin6_flowinfo;

        /// pj_in6_addr
        public pj_in6_addr sin6_addr;

        /// pj_uint32_t->unsigned int
        public uint sin6_scope_id;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_addr_hdr
    {

        /// pj_uint16_t->unsigned short
        public ushort sa_family;
    }

    //[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public struct pj_sockaddr
    {

        /// pj_addr_hdr
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pj_addr_hdr addr;

        /// pj_sockaddr_in
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        //public pj_sockaddr_in ipv4;

        ///// pj_sockaddr_in6
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        //public pj_sockaddr_in6 ipv6;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_ip_mreq
    {

        /// pj_in_addr
        public pj_in_addr imr_multiaddr;

        /// pj_in_addr
        public pj_in_addr imr_interface;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_ioqueue_op_key_t
    {

        /// void*[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = System.Runtime.InteropServices.UnmanagedType.SysUInt)]
        public System.IntPtr[] internal__;

        /// void*
        public System.IntPtr activesock_data;

        /// void*
        public System.IntPtr user_data;
    }

    public enum pj_ioqueue_operation_e
    {

        /// PJ_IOQUEUE_OP_NONE -> 0
        PJ_IOQUEUE_OP_NONE = 0,

        /// PJ_IOQUEUE_OP_READ -> 1
        PJ_IOQUEUE_OP_READ = 1,

        /// PJ_IOQUEUE_OP_RECV -> 2
        PJ_IOQUEUE_OP_RECV = 2,

        /// PJ_IOQUEUE_OP_RECV_FROM -> 4
        PJ_IOQUEUE_OP_RECV_FROM = 4,

        /// PJ_IOQUEUE_OP_WRITE -> 8
        PJ_IOQUEUE_OP_WRITE = 8,

        /// PJ_IOQUEUE_OP_SEND -> 16
        PJ_IOQUEUE_OP_SEND = 16,

        /// PJ_IOQUEUE_OP_SEND_TO -> 32
        PJ_IOQUEUE_OP_SEND_TO = 32,

        /// PJ_IOQUEUE_OP_ACCEPT -> 64
        PJ_IOQUEUE_OP_ACCEPT = 64,

        /// PJ_IOQUEUE_OP_CONNECT -> 128
        PJ_IOQUEUE_OP_CONNECT = 128,
    }

    public enum pjsip_transport_flags_e
    {

        /// PJSIP_TRANSPORT_RELIABLE -> 1
        PJSIP_TRANSPORT_RELIABLE = 1,

        /// PJSIP_TRANSPORT_SECURE -> 2
        PJSIP_TRANSPORT_SECURE = 2,

        /// PJSIP_TRANSPORT_DATAGRAM -> 4
        PJSIP_TRANSPORT_DATAGRAM = 4,
    }

    public enum pjsip_tpselector_type
    {

        PJSIP_TPSELECTOR_NONE,

        PJSIP_TPSELECTOR_TRANSPORT,

        PJSIP_TPSELECTOR_LISTENER,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_transport_key
    {

        /// int
        public int type;

        /// pj_sockaddr
        public pj_sockaddr rem_addr;
    }

    public enum pj_dns_type
    {

        /// PJ_DNS_TYPE_A -> 1
        PJ_DNS_TYPE_A = 1,

        /// PJ_DNS_TYPE_NS -> 2
        PJ_DNS_TYPE_NS = 2,

        /// PJ_DNS_TYPE_MD -> 3
        PJ_DNS_TYPE_MD = 3,

        /// PJ_DNS_TYPE_MF -> 4
        PJ_DNS_TYPE_MF = 4,

        /// PJ_DNS_TYPE_CNAME -> 5
        PJ_DNS_TYPE_CNAME = 5,

        /// PJ_DNS_TYPE_SOA -> 6
        PJ_DNS_TYPE_SOA = 6,

        /// PJ_DNS_TYPE_MB -> 7
        PJ_DNS_TYPE_MB = 7,

        /// PJ_DNS_TYPE_MG -> 8
        PJ_DNS_TYPE_MG = 8,

        /// PJ_DNS_TYPE_MR -> 9
        PJ_DNS_TYPE_MR = 9,

        /// PJ_DNS_TYPE_NULL -> 10
        PJ_DNS_TYPE_NULL = 10,

        /// PJ_DNS_TYPE_WKS -> 11
        PJ_DNS_TYPE_WKS = 11,

        /// PJ_DNS_TYPE_PTR -> 12
        PJ_DNS_TYPE_PTR = 12,

        /// PJ_DNS_TYPE_HINFO -> 13
        PJ_DNS_TYPE_HINFO = 13,

        /// PJ_DNS_TYPE_MINFO -> 14
        PJ_DNS_TYPE_MINFO = 14,

        /// PJ_DNS_TYPE_MX -> 15
        PJ_DNS_TYPE_MX = 15,

        /// PJ_DNS_TYPE_TXT -> 16
        PJ_DNS_TYPE_TXT = 16,

        /// PJ_DNS_TYPE_RP -> 17
        PJ_DNS_TYPE_RP = 17,

        /// PJ_DNS_TYPE_AFSB -> 18
        PJ_DNS_TYPE_AFSB = 18,

        /// PJ_DNS_TYPE_X25 -> 19
        PJ_DNS_TYPE_X25 = 19,

        /// PJ_DNS_TYPE_ISDN -> 20
        PJ_DNS_TYPE_ISDN = 20,

        /// PJ_DNS_TYPE_RT -> 21
        PJ_DNS_TYPE_RT = 21,

        /// PJ_DNS_TYPE_NSAP -> 22
        PJ_DNS_TYPE_NSAP = 22,

        /// PJ_DNS_TYPE_NSAP_PTR -> 23
        PJ_DNS_TYPE_NSAP_PTR = 23,

        /// PJ_DNS_TYPE_SIG -> 24
        PJ_DNS_TYPE_SIG = 24,

        /// PJ_DNS_TYPE_KEY -> 25
        PJ_DNS_TYPE_KEY = 25,

        /// PJ_DNS_TYPE_PX -> 26
        PJ_DNS_TYPE_PX = 26,

        /// PJ_DNS_TYPE_GPOS -> 27
        PJ_DNS_TYPE_GPOS = 27,

        /// PJ_DNS_TYPE_AAAA -> 28
        PJ_DNS_TYPE_AAAA = 28,

        /// PJ_DNS_TYPE_LOC -> 29
        PJ_DNS_TYPE_LOC = 29,

        /// PJ_DNS_TYPE_NXT -> 30
        PJ_DNS_TYPE_NXT = 30,

        /// PJ_DNS_TYPE_EID -> 31
        PJ_DNS_TYPE_EID = 31,

        /// PJ_DNS_TYPE_NIMLOC -> 32
        PJ_DNS_TYPE_NIMLOC = 32,

        /// PJ_DNS_TYPE_SRV -> 33
        PJ_DNS_TYPE_SRV = 33,

        /// PJ_DNS_TYPE_ATMA -> 34
        PJ_DNS_TYPE_ATMA = 34,

        /// PJ_DNS_TYPE_NAPTR -> 35
        PJ_DNS_TYPE_NAPTR = 35,

        /// PJ_DNS_TYPE_KX -> 36
        PJ_DNS_TYPE_KX = 36,

        /// PJ_DNS_TYPE_CERT -> 37
        PJ_DNS_TYPE_CERT = 37,

        /// PJ_DNS_TYPE_A6 -> 38
        PJ_DNS_TYPE_A6 = 38,

        /// PJ_DNS_TYPE_DNAME -> 39
        PJ_DNS_TYPE_DNAME = 39,

        /// PJ_DNS_TYPE_OPT -> 41
        PJ_DNS_TYPE_OPT = 41,

        /// PJ_DNS_TYPE_APL -> 42
        PJ_DNS_TYPE_APL = 42,

        /// PJ_DNS_TYPE_DS -> 43
        PJ_DNS_TYPE_DS = 43,

        /// PJ_DNS_TYPE_SSHFP -> 44
        PJ_DNS_TYPE_SSHFP = 44,

        /// PJ_DNS_TYPE_IPSECKEY -> 45
        PJ_DNS_TYPE_IPSECKEY = 45,

        /// PJ_DNS_TYPE_RRSIG -> 46
        PJ_DNS_TYPE_RRSIG = 46,

        /// PJ_DNS_TYPE_NSEC -> 47
        PJ_DNS_TYPE_NSEC = 47,

        /// PJ_DNS_TYPE_DNSKEY -> 48
        PJ_DNS_TYPE_DNSKEY = 48,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_dns_hdr
    {

        /// pj_uint16_t->unsigned short
        public ushort id;

        /// pj_uint16_t->unsigned short
        public ushort flags;

        /// pj_uint16_t->unsigned short
        public ushort qdcount;

        /// pj_uint16_t->unsigned short
        public ushort anscount;

        /// pj_uint16_t->unsigned short
        public ushort nscount;

        /// pj_uint16_t->unsigned short
        public ushort arcount;
    }

    public enum pj_dns_rcode
    {

        /// PJ_DNS_RCODE_FORMERR -> 1
        PJ_DNS_RCODE_FORMERR = 1,

        /// PJ_DNS_RCODE_SERVFAIL -> 2
        PJ_DNS_RCODE_SERVFAIL = 2,

        /// PJ_DNS_RCODE_NXDOMAIN -> 3
        PJ_DNS_RCODE_NXDOMAIN = 3,

        /// PJ_DNS_RCODE_NOTIMPL -> 4
        PJ_DNS_RCODE_NOTIMPL = 4,

        /// PJ_DNS_RCODE_REFUSED -> 5
        PJ_DNS_RCODE_REFUSED = 5,

        /// PJ_DNS_RCODE_YXDOMAIN -> 6
        PJ_DNS_RCODE_YXDOMAIN = 6,

        /// PJ_DNS_RCODE_YXRRSET -> 7
        PJ_DNS_RCODE_YXRRSET = 7,

        /// PJ_DNS_RCODE_NXRRSET -> 8
        PJ_DNS_RCODE_NXRRSET = 8,

        /// PJ_DNS_RCODE_NOTAUTH -> 9
        PJ_DNS_RCODE_NOTAUTH = 9,

        /// PJ_DNS_RCODE_NOTZONE -> 10
        PJ_DNS_RCODE_NOTZONE = 10,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_dns_parsed_query
    {

        /// pj_str_t
        public pj_str_t name;

        /// pj_uint16_t->unsigned short
        public ushort type;

        /// pj_uint16_t->unsigned short
        public ushort dnsclass;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_dns_parsed_rr_rdata_srv
    {

        /// pj_uint16_t->unsigned short
        public ushort prio;

        /// pj_uint16_t->unsigned short
        public ushort weight;

        /// pj_uint16_t->unsigned short
        public ushort port;

        /// pj_str_t
        public pj_str_t target;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_dns_parsed_rr_rdata_cname
    {

        /// pj_str_t
        public pj_str_t name;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_dns_parsed_rr_rdata_ns
    {

        /// pj_str_t
        public pj_str_t name;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_dns_parsed_rr_rdata_ptr
    {

        /// pj_str_t
        public pj_str_t name;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_dns_parsed_rr_rdata_a
    {

        /// pj_in_addr
        public pj_in_addr ip_addr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_dns_parsed_rr_rdata_aaaa
    {

        /// pj_in6_addr
        public pj_in6_addr ip_addr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public struct pj_dns_parsed_rr_rdata
    {

        /// pj_dns_parsed_rr_rdata_srv
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pj_dns_parsed_rr_rdata_srv Struct1;

        /// pj_dns_parsed_rr_rdata_cname
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pj_dns_parsed_rr_rdata_cname Struct2;

        /// pj_dns_parsed_rr_rdata_ns
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pj_dns_parsed_rr_rdata_ns Struct3;

        /// pj_dns_parsed_rr_rdata_ptr
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pj_dns_parsed_rr_rdata_ptr Struct4;

        /// pj_dns_parsed_rr_rdata_a
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pj_dns_parsed_rr_rdata_a Struct5;

        /// pj_dns_parsed_rr_rdata_aaaa
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pj_dns_parsed_rr_rdata_aaaa Struct6;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_dns_parsed_rr
    {

        /// pj_str_t
        public pj_str_t name;

        /// pj_uint16_t->unsigned short
        public ushort type;

        /// pj_uint16_t->unsigned short
        public ushort dnsclass;

        /// pj_uint32_t->unsigned int
        public uint ttl;

        /// pj_uint16_t->unsigned short
        public ushort rdlength;

        /// void*
        public System.IntPtr data;

        /// pj_dns_parsed_rr_rdata
        public pj_dns_parsed_rr_rdata Union1;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_dns_parsed_packet
    {

        /// pj_dns_hdr
        public pj_dns_hdr hdr;

        /// pj_dns_parsed_query*
        public System.IntPtr q;

        /// pj_dns_parsed_rr*
        public System.IntPtr ans;

        /// pj_dns_parsed_rr*
        public System.IntPtr ns;

        /// pj_dns_parsed_rr*
        public System.IntPtr arr;
    }

    public enum pj_dns_dup_options
    {

        /// PJ_DNS_NO_QD -> 1
        PJ_DNS_NO_QD = 1,

        /// PJ_DNS_NO_ANS -> 2
        PJ_DNS_NO_ANS = 2,

        /// PJ_DNS_NO_NS -> 4
        PJ_DNS_NO_NS = 4,

        /// PJ_DNS_NO_AR -> 8
        PJ_DNS_NO_AR = 8,
    }

    /// Return Type: void
    ///user_data: void*
    ///status: pj_status_t->int
    ///response: pj_dns_parsed_packet*
    public delegate void pj_dns_callback(System.IntPtr user_data, int status, ref pj_dns_parsed_packet response);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_dns_settings
    {

        /// unsigned int
        public uint options;

        /// unsigned int
        public uint qretr_delay;

        /// unsigned int
        public uint qretr_count;

        /// unsigned int
        public uint cache_max_ttl;

        /// unsigned int
        public uint good_ns_ttl;

        /// unsigned int
        public uint bad_ns_ttl;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pj_dns_a_record
    {

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t alias;

        /// unsigned int
        public uint addr_count;

        /// pj_in_addr[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public pj_in_addr[] addr;

        /// char[128]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
        public string buf_;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_server_addresses
    {

        /// unsigned int
        public uint count;

        /// Anonymous_117b0241_67c2_4345_8937_776cc4b07c57[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public Anonymous_117b0241_67c2_4345_8937_776cc4b07c57[] entry;
    }

    /// Return Type: void
    ///status: pj_status_t->int
    ///token: void*
    ///addr: pjsip_server_addresses*
    public delegate void pjsip_resolver_callback(int status, System.IntPtr token, ref pjsip_server_addresses addr);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_target
    {

        /// pjsip_target*
        public System.IntPtr prev;

        /// pjsip_target*
        public System.IntPtr next;

        /// pjsip_uri*
        public System.IntPtr uri;

        /// int
        public int q1000;

        /// pjsip_status_code
        public pjsip_status_code code;

        /// pj_str_t
        public pj_str_t reason;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_target_set
    {

        /// pjsip_target
        public pjsip_target head;

        /// pjsip_target*
        public System.IntPtr current;
    }

    public enum pjsip_redirect_op
    {

        PJSIP_REDIRECT_REJECT,

        PJSIP_REDIRECT_ACCEPT,

        PJSIP_REDIRECT_PENDING,

        PJSIP_REDIRECT_STOP,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct FILE
    {

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string _ptr;

        /// int
        public int _cnt;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string _base;

        /// int
        public int _flag;

        /// int
        public int _file;

        /// int
        public int _charbuf;

        /// int
        public int _bufsiz;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string _tmpfname;
    }

    public enum pjsip_ssl_method
    {

        /// PJSIP_SSL_UNSPECIFIED_METHOD -> 0
        PJSIP_SSL_UNSPECIFIED_METHOD = 0,

        /// PJSIP_TLSV1_METHOD -> 31
        PJSIP_TLSV1_METHOD = 31,

        /// PJSIP_SSLV2_METHOD -> 20
        PJSIP_SSLV2_METHOD = 20,

        /// PJSIP_SSLV3_METHOD -> 30
        PJSIP_SSLV3_METHOD = 30,

        /// PJSIP_SSLV23_METHOD -> 23
        PJSIP_SSLV23_METHOD = 23,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public class pjsip_tls_setting
    {

        /// pj_str_t
        public pj_str_t ca_list_file;

        /// pj_str_t
        public pj_str_t cert_file;

        /// pj_str_t
        public pj_str_t privkey_file;

        /// pj_str_t
        public pj_str_t password;

        /// int
        public int method;

        /// pj_str_t
        public pj_str_t ciphers;

        /// pj_str_t
        public pj_str_t server_name;

        /// pj_bool_t->int
        public int verify_server;

        /// pj_bool_t->int
        public int verify_client;

        /// pj_bool_t->int
        public int require_client_cert;

        /// pj_time_val
        public pj_time_val timeout;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_common_credential
    {

        /// pj_str_t
        public pj_str_t realm;

        /// pjsip_param
        public pjsip_param other_param;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_digest_credential
    {

        /// pj_str_t
        public pj_str_t realm;

        /// pjsip_param
        public pjsip_param other_param;

        /// pj_str_t
        public pj_str_t username;

        /// pj_str_t
        public pj_str_t nonce;

        /// pj_str_t
        public pj_str_t uri;

        /// pj_str_t
        public pj_str_t response;

        /// pj_str_t
        public pj_str_t algorithm;

        /// pj_str_t
        public pj_str_t cnonce;

        /// pj_str_t
        public pj_str_t opaque;

        /// pj_str_t
        public pj_str_t qop;

        /// pj_str_t
        public pj_str_t nc;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_pgp_credential
    {

        /// pj_str_t
        public pj_str_t realm;

        /// pjsip_param
        public pjsip_param other_param;

        /// pj_str_t
        public pj_str_t version;

        /// pj_str_t
        public pj_str_t signature;

        /// pj_str_t
        public pj_str_t signed_by;

        /// pj_str_t
        public pj_str_t nonce;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_authorization_hdr
    {

        /// pjsip_authorization_hdr*
        public System.IntPtr prev;

        /// pjsip_authorization_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// pj_str_t
        public pj_str_t scheme;

        /// Anonymous_e77ed7d9_8eae_4efc_bdaf_ea578a55b094
        public Anonymous_e77ed7d9_8eae_4efc_bdaf_ea578a55b094 credential;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_common_challenge
    {

        /// pj_str_t
        public pj_str_t realm;

        /// pjsip_param
        public pjsip_param other_param;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_digest_challenge
    {

        /// pj_str_t
        public pj_str_t realm;

        /// pjsip_param
        public pjsip_param other_param;

        /// pj_str_t
        public pj_str_t domain;

        /// pj_str_t
        public pj_str_t nonce;

        /// pj_str_t
        public pj_str_t opaque;

        /// int
        public int stale;

        /// pj_str_t
        public pj_str_t algorithm;

        /// pj_str_t
        public pj_str_t qop;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_pgp_challenge
    {

        /// pj_str_t
        public pj_str_t realm;

        /// pjsip_param
        public pjsip_param other_param;

        /// pj_str_t
        public pj_str_t version;

        /// pj_str_t
        public pj_str_t micalgorithm;

        /// pj_str_t
        public pj_str_t pubalgorithm;

        /// pj_str_t
        public pj_str_t nonce;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_www_authenticate_hdr
    {

        /// pjsip_www_authenticate_hdr*
        public System.IntPtr prev;

        /// pjsip_www_authenticate_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// pj_str_t
        public pj_str_t scheme;

        /// Anonymous_e3727455_c116_4081_998c_73e2457c5923
        public Anonymous_e3727455_c116_4081_998c_73e2457c5923 challenge;
    }

    public enum pjsip_cred_data_type
    {

        /// PJSIP_CRED_DATA_PLAIN_PASSWD -> 0
        PJSIP_CRED_DATA_PLAIN_PASSWD = 0,

        /// PJSIP_CRED_DATA_DIGEST -> 1
        PJSIP_CRED_DATA_DIGEST = 1,

        /// PJSIP_CRED_DATA_EXT_AKA -> 16
        PJSIP_CRED_DATA_EXT_AKA = 16,
    }

    public enum pjsip_auth_qop_type
    {

        PJSIP_AUTH_QOP_NONE,

        PJSIP_AUTH_QOP_AUTH,

        PJSIP_AUTH_QOP_AUTH_INT,

        PJSIP_AUTH_QOP_UNKNOWN,
    }

    /// Return Type: pj_status_t->int
    ///pool: pj_pool_t*
    ///chal: pjsip_digest_challenge*
    ///cred: pjsip_cred_info*
    ///method: pj_str_t*
    ///auth: pjsip_digest_credential*
    public delegate int pjsip_cred_cb(ref pj_pool_t pool, ref pjsip_digest_challenge chal, ref pjsip_cred_info cred, ref pj_str_t method, ref pjsip_digest_credential auth);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_cred_info
    {

        /// pj_str_t
        public pj_str_t realm;

        /// pj_str_t
        public pj_str_t scheme;

        /// pj_str_t
        public pj_str_t username;

        /// int
        public int data_type;

        /// pj_str_t
        public pj_str_t data;

        /// Anonymous_3eeaa12c_ae9a_4f9d_9e09_5cfc2bf23da5
        public Anonymous_3eeaa12c_ae9a_4f9d_9e09_5cfc2bf23da5 ext;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_cached_auth_hdr
    {

        /// pjsip_cached_auth_hdr*
        public System.IntPtr prev;

        /// pjsip_cached_auth_hdr*
        public System.IntPtr next;

        /// pjsip_method
        public pjsip_method method;

        /// pjsip_authorization_hdr*
        public System.IntPtr hdr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_cached_auth
    {

        /// pjsip_cached_auth*
        public System.IntPtr prev;

        /// pjsip_cached_auth*
        public System.IntPtr next;

        /// pj_str_t
        public pj_str_t realm;

        /// pj_bool_t->int
        public int is_proxy;

        /// pjsip_auth_qop_type
        public pjsip_auth_qop_type qop_value;

        /// unsigned int
        public uint stale_cnt;

        /// pj_uint32_t->unsigned int
        public uint nc;

        /// pj_str_t
        public pj_str_t cnonce;

        /// pjsip_www_authenticate_hdr*
        public System.IntPtr last_chal;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_auth_clt_pref
    {

        /// pj_bool_t->int
        public int initial_auth;

        /// pj_str_t
        public pj_str_t algorithm;
    }

    /// Return Type: pj_status_t->int
    ///pool: pj_pool_t*
    ///realm: pj_str_t*
    ///acc_name: pj_str_t*
    ///cred_info: pjsip_cred_info*
    public delegate int pjsip_auth_lookup_cred(ref pj_pool_t pool, ref pj_str_t realm, ref pj_str_t acc_name, ref pjsip_cred_info cred_info);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_auth_srv
    {

        /// pj_str_t
        public pj_str_t realm;

        /// pj_bool_t->int
        public int is_proxy;

        /// pjsip_auth_lookup_cred*
        public System.IntPtr lookup;
    }

    public enum pjsip_tsx_state_e
    {

        PJSIP_TSX_STATE_NULL,

        PJSIP_TSX_STATE_CALLING,

        PJSIP_TSX_STATE_TRYING,

        PJSIP_TSX_STATE_PROCEEDING,

        PJSIP_TSX_STATE_COMPLETED,

        PJSIP_TSX_STATE_CONFIRMED,

        PJSIP_TSX_STATE_TERMINATED,

        PJSIP_TSX_STATE_DESTROYED,

        PJSIP_TSX_STATE_MAX,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_dlg_party
    {

        /// pjsip_fromto_hdr*
        public System.IntPtr info;

        /// pj_str_t
        public pj_str_t info_str;

        /// pj_uint32_t->unsigned int
        public uint tag_hval;

        /// pjsip_contact_hdr*
        public System.IntPtr contact;

        /// pj_int32_t->int
        public int first_cseq;

        /// pj_int32_t->int
        public int cseq;
    }

    public enum pjsip_dialog_state
    {

        PJSIP_DIALOG_STATE_NULL,

        PJSIP_DIALOG_STATE_ESTABLISHED,
    }

    public enum pjmedia_type
    {

        /// PJMEDIA_TYPE_NONE -> 0
        PJMEDIA_TYPE_NONE = 0,

        /// PJMEDIA_TYPE_AUDIO -> 1
        PJMEDIA_TYPE_AUDIO = 1,

        /// PJMEDIA_TYPE_VIDEO -> 2
        PJMEDIA_TYPE_VIDEO = 2,

        /// PJMEDIA_TYPE_UNKNOWN -> 3
        PJMEDIA_TYPE_UNKNOWN = 3,

        /// PJMEDIA_TYPE_APPLICATION -> 4
        PJMEDIA_TYPE_APPLICATION = 4,
    }

    public enum pjmedia_tp_proto
    {

        /// PJMEDIA_TP_PROTO_NONE -> 0
        PJMEDIA_TP_PROTO_NONE = 0,

        PJMEDIA_TP_PROTO_RTP_AVP,

        PJMEDIA_TP_PROTO_RTP_SAVP,

        PJMEDIA_TP_PROTO_UNKNOWN,
    }

    public enum pjmedia_dir
    {

        /// PJMEDIA_DIR_NONE -> 0
        PJMEDIA_DIR_NONE = 0,

        /// PJMEDIA_DIR_ENCODING -> 1
        PJMEDIA_DIR_ENCODING = 1,

        /// PJMEDIA_DIR_DECODING -> 2
        PJMEDIA_DIR_DECODING = 2,

        /// PJMEDIA_DIR_ENCODING_DECODING -> 3
        PJMEDIA_DIR_ENCODING_DECODING = 3,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_sock_info
    {

        /// pj_sock_t->int
        public int rtp_sock;

        /// pj_sockaddr
        public pj_sockaddr rtp_addr_name;

        /// pj_sock_t->int
        public int rtcp_sock;

        /// pj_sockaddr
        public pj_sockaddr rtcp_addr_name;
    }

    public enum pjmedia_format_id
    {

        /// PJMEDIA_FORMAT_L16 -> 0
        PJMEDIA_FORMAT_L16 = 0,

        /// PJMEDIA_FORMAT_PCM -> PJMEDIA_FORMAT_L16
        PJMEDIA_FORMAT_PCM = pjmedia_format_id.PJMEDIA_FORMAT_L16,

        /// PJMEDIA_FORMAT_PCMA -> ('W'<<24|'A'<<16|'L'<<8|'A')
        PJMEDIA_FORMAT_PCMA = ('W') << ((24 | ('A') << ((16 | ('L') << ((8 | 'A')))))),

        /// PJMEDIA_FORMAT_ALAW -> PJMEDIA_FORMAT_PCMA
        PJMEDIA_FORMAT_ALAW = pjmedia_format_id.PJMEDIA_FORMAT_PCMA,

        /// PJMEDIA_FORMAT_PCMU -> ('W'<<24|'A'<<16|'L'<<8|'u')
        PJMEDIA_FORMAT_PCMU = ('W') << ((24 | ('A') << ((16 | ('L') << ((8 | 'u')))))),

        /// PJMEDIA_FORMAT_ULAW -> PJMEDIA_FORMAT_PCMU
        PJMEDIA_FORMAT_ULAW = pjmedia_format_id.PJMEDIA_FORMAT_PCMU,

        /// PJMEDIA_FORMAT_AMR -> ('R'<<24|'M'<<16|'A'<<8|' ')
        PJMEDIA_FORMAT_AMR = ('R') << ((24 | ('M') << ((16 | ('A') << ((8 | ' ')))))),

        /// PJMEDIA_FORMAT_G729 -> ('9'<<24|'2'<<16|'7'<<8|'G')
        PJMEDIA_FORMAT_G729 = ('9') << ((24 | ('2') << ((16 | ('7') << ((8 | 'G')))))),

        /// PJMEDIA_FORMAT_ILBC -> ('C'<<24|'B'<<16|'L'<<8|'I')
        PJMEDIA_FORMAT_ILBC = ('C') << ((24 | ('B') << ((16 | ('L') << ((8 | 'I')))))),
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_format
    {

        /// pjmedia_format_id
        public pjmedia_format_id id;

        /// pj_uint32_t->unsigned int
        public uint bitrate;

        /// pj_bool_t->int
        public int vad;
    }

    public enum pjmedia_frame_type
    {

        PJMEDIA_FRAME_TYPE_NONE,

        PJMEDIA_FRAME_TYPE_AUDIO,

        PJMEDIA_FRAME_TYPE_EXTENDED,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_frame
    {

        /// pjmedia_frame_type
        public pjmedia_frame_type type;

        /// void*
        public System.IntPtr buf;

        /// pj_size_t->size_t->unsigned int
        public uint size;

        /// pj_timestamp
        public pj_timestamp timestamp;

        /// pj_uint32_t->unsigned int
        public uint bit_info;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_frame_ext
    {

        /// pjmedia_frame
        public pjmedia_frame @base;

        /// pj_uint16_t->unsigned short
        public ushort samples_cnt;

        /// pj_uint16_t->unsigned short
        public ushort subframe_cnt;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pjmedia_frame_ext_subframe
    {

        /// pj_uint16_t->unsigned short
        public ushort bitlen;

        /// pj_uint8_t[1]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 1)]
        public string data;
    }

    public enum pj_thread_create_flags
    {

        /// PJ_THREAD_SUSPENDED -> 1
        PJ_THREAD_SUSPENDED = 1,
    }

    /// Return Type: int
    ///param0: void*
    public delegate int pj_thread_proc(System.IntPtr param0);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_symbianos_params
    {

        /// void*
        public System.IntPtr rsocketserv;

        /// void*
        public System.IntPtr rconnection;

        /// void*
        public System.IntPtr rhostresolver;

        /// void*
        public System.IntPtr rhostresolver6;
    }

    public enum pj_mutex_type_e
    {

        PJ_MUTEX_DEFAULT,

        PJ_MUTEX_SIMPLE,

        PJ_MUTEX_RECURSE,
    }

    public enum pjmedia_port_op
    {

        PJMEDIA_PORT_NO_CHANGE,

        PJMEDIA_PORT_DISABLE,

        PJMEDIA_PORT_MUTE,

        PJMEDIA_PORT_ENABLE,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_port_info
    {

        /// pj_str_t
        public pj_str_t name;

        /// pj_uint32_t->unsigned int
        public uint signature;

        /// pjmedia_type
        public pjmedia_type type;

        /// pj_bool_t->int
        public int has_info;

        /// pj_bool_t->int
        public int need_info;

        /// unsigned int
        public uint pt;

        /// pjmedia_format
        public pjmedia_format format;

        /// pj_str_t
        public pj_str_t encoding_name;

        /// unsigned int
        public uint clock_rate;

        /// unsigned int
        public uint channel_count;

        /// unsigned int
        public uint bits_per_sample;

        /// unsigned int
        public uint samples_per_frame;

        /// unsigned int
        public uint bytes_per_frame;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_port_port_data
    {

        /// void*
        public System.IntPtr pdata;

        /// int
        public int ldata;
    }

    /// Return Type: pj_status_t->int
    ///this_port: pjmedia_port*
    ///frame: pjmedia_frame*
    public delegate int pjmedia_port_put_frame(ref pjmedia_port this_port, ref pjmedia_frame frame);

    /// Return Type: pj_status_t->int
    ///this_port: pjmedia_port*
    ///frame: pjmedia_frame*
    public delegate int pjmedia_port_get_frame(ref pjmedia_port this_port, ref pjmedia_frame frame);

    /// Return Type: pj_status_t->int
    ///this_port: pjmedia_port*
    public delegate int pjmedia_port_on_destroy(ref pjmedia_port this_port);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_port
    {

        /// pjmedia_port_info
        public pjmedia_port_info info;

        /// pjmedia_port_port_data
        public pjmedia_port_port_data Struct1;

        /// pjmedia_port_put_frame
        public pjmedia_port_put_frame AnonymousMember2;

        /// pjmedia_port_get_frame
        public pjmedia_port_get_frame AnonymousMember3;

        /// pjmedia_port_on_destroy
        public pjmedia_port_on_destroy AnonymousMember4;
    }

    /// Return Type: void
    ///pool: pj_pool_t*
    ///size: pj_size_t->size_t->unsigned int
    public delegate void pj_pool_callback(ref pj_pool_t pool, System.IntPtr size);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_pool_mem
    {

        /// pj_pool_mem*
        public System.IntPtr next;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pj_pool_t
    {

        /// pj_pool_mem*
        public System.IntPtr first_mem;

        /// pj_pool_factory*
        public System.IntPtr factory;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string obj_name;

        /// pj_size_t->size_t->unsigned int
        public uint used_size;

        /// pj_pool_callback*
        public System.IntPtr cb;
    }

    /// Return Type: void*
    ///factory: pj_pool_factory*
    ///size: pj_size_t->size_t->unsigned int
    public delegate System.IntPtr pj_pool_factory_policy_block_alloc(ref pj_pool_factory factory, System.IntPtr size);

    /// Return Type: void
    ///factory: pj_pool_factory*
    ///mem: void*
    ///size: pj_size_t->size_t->unsigned int
    public delegate void pj_pool_factory_policy_block_free(ref pj_pool_factory factory, System.IntPtr mem, System.IntPtr size);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_pool_factory_policy
    {

        /// pj_pool_factory_policy_block_alloc
        public pj_pool_factory_policy_block_alloc AnonymousMember1;

        /// pj_pool_factory_policy_block_free
        public pj_pool_factory_policy_block_free AnonymousMember2;

        /// pj_pool_callback*
        public System.IntPtr callback;

        /// unsigned int
        public uint flags;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_pool_factory
    {

        /// pj_pool_factory_policy
        public pj_pool_factory_policy policy;

        /// int
        public int dummy;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_caching_pool
    {

        /// pj_pool_factory
        public pj_pool_factory factory;

        /// unsigned int
        public uint used_count;

        /// unsigned int
        public uint used_size;

        /// unsigned int
        public uint peak_used_size;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_pool_block
    {

        /// int
        public int dummy;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_circ_buf
    {

        /// pj_int16_t*
        public System.IntPtr buf;

        /// unsigned int
        public uint capacity;

        /// pj_int16_t*
        public System.IntPtr start;

        /// unsigned int
        public uint len;
    }

    public enum pjmedia_clock_options
    {

        /// PJMEDIA_CLOCK_NO_ASYNC -> 1
        PJMEDIA_CLOCK_NO_ASYNC = 1,

        /// PJMEDIA_CLOCK_NO_HIGHEST_PRIO -> 2
        PJMEDIA_CLOCK_NO_HIGHEST_PRIO = 2,
    }

    /// Return Type: void
    ///ts: pj_timestamp*
    ///user_data: void*
    public delegate void pjmedia_clock_callback(ref pj_timestamp ts, System.IntPtr user_data);

    public enum pjmedia_rtp_pt
    {

        /// PJMEDIA_RTP_PT_PCMU -> 0
        PJMEDIA_RTP_PT_PCMU = 0,

        /// PJMEDIA_RTP_PT_G726_32 -> 2
        PJMEDIA_RTP_PT_G726_32 = 2,

        /// PJMEDIA_RTP_PT_GSM -> 3
        PJMEDIA_RTP_PT_GSM = 3,

        /// PJMEDIA_RTP_PT_G723 -> 4
        PJMEDIA_RTP_PT_G723 = 4,

        /// PJMEDIA_RTP_PT_DVI4_8K -> 5
        PJMEDIA_RTP_PT_DVI4_8K = 5,

        /// PJMEDIA_RTP_PT_DVI4_16K -> 6
        PJMEDIA_RTP_PT_DVI4_16K = 6,

        /// PJMEDIA_RTP_PT_LPC -> 7
        PJMEDIA_RTP_PT_LPC = 7,

        /// PJMEDIA_RTP_PT_PCMA -> 8
        PJMEDIA_RTP_PT_PCMA = 8,

        /// PJMEDIA_RTP_PT_G722 -> 9
        PJMEDIA_RTP_PT_G722 = 9,

        /// PJMEDIA_RTP_PT_L16_2 -> 10
        PJMEDIA_RTP_PT_L16_2 = 10,

        /// PJMEDIA_RTP_PT_L16_1 -> 11
        PJMEDIA_RTP_PT_L16_1 = 11,

        /// PJMEDIA_RTP_PT_QCELP -> 12
        PJMEDIA_RTP_PT_QCELP = 12,

        /// PJMEDIA_RTP_PT_CN -> 13
        PJMEDIA_RTP_PT_CN = 13,

        /// PJMEDIA_RTP_PT_MPA -> 14
        PJMEDIA_RTP_PT_MPA = 14,

        /// PJMEDIA_RTP_PT_G728 -> 15
        PJMEDIA_RTP_PT_G728 = 15,

        /// PJMEDIA_RTP_PT_DVI4_11K -> 16
        PJMEDIA_RTP_PT_DVI4_11K = 16,

        /// PJMEDIA_RTP_PT_DVI4_22K -> 17
        PJMEDIA_RTP_PT_DVI4_22K = 17,

        /// PJMEDIA_RTP_PT_G729 -> 18
        PJMEDIA_RTP_PT_G729 = 18,

        /// PJMEDIA_RTP_PT_CELB -> 25
        PJMEDIA_RTP_PT_CELB = 25,

        /// PJMEDIA_RTP_PT_JPEG -> 26
        PJMEDIA_RTP_PT_JPEG = 26,

        /// PJMEDIA_RTP_PT_NV -> 28
        PJMEDIA_RTP_PT_NV = 28,

        /// PJMEDIA_RTP_PT_H261 -> 31
        PJMEDIA_RTP_PT_H261 = 31,

        /// PJMEDIA_RTP_PT_MPV -> 32
        PJMEDIA_RTP_PT_MPV = 32,

        /// PJMEDIA_RTP_PT_MP2T -> 33
        PJMEDIA_RTP_PT_MP2T = 33,

        /// PJMEDIA_RTP_PT_H263 -> 34
        PJMEDIA_RTP_PT_H263 = 34,

        /// PJMEDIA_RTP_PT_DYNAMIC -> 96
        PJMEDIA_RTP_PT_DYNAMIC = 96,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_codec_info
    {

        /// pjmedia_type
        public pjmedia_type type;

        /// unsigned int
        public uint pt;

        /// pj_str_t
        public pj_str_t encoding_name;

        /// unsigned int
        public uint clock_rate;

        /// unsigned int
        public uint channel_cnt;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_codec_fmtp_param
    {

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t val;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_codec_fmtp
    {

        /// pj_uint8_t->unsigned char
        public byte cnt;

        /// pjmedia_codec_fmtp_param
        public pjmedia_codec_fmtp_param Struct1;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_codec_param
    {

        /// Anonymous_5f5fdd64_f5a8_4714_9bc5_3704040cd03c
        public Anonymous_5f5fdd64_f5a8_4714_9bc5_3704040cd03c info;

        /// Anonymous_a1ebca6a_52b2_431a_9440_f4bd2e622211
        public Anonymous_a1ebca6a_52b2_431a_9440_f4bd2e622211 setting;
    }

    /// Return Type: pj_status_t->int
    ///codec: pjmedia_codec*
    ///pool: pj_pool_t*
    public delegate int pjmedia_codec_op_init(ref pjmedia_codec codec, ref pj_pool_t pool);

    /// Return Type: pj_status_t->int
    ///codec: pjmedia_codec*
    ///param: pjmedia_codec_param*
    public delegate int pjmedia_codec_op_open(ref pjmedia_codec codec, ref pjmedia_codec_param param);

    /// Return Type: pj_status_t->int
    ///codec: pjmedia_codec*
    public delegate int pjmedia_codec_op_close(ref pjmedia_codec codec);

    /// Return Type: pj_status_t->int
    ///codec: pjmedia_codec*
    ///param: pjmedia_codec_param*
    public delegate int pjmedia_codec_op_modify(ref pjmedia_codec codec, ref pjmedia_codec_param param);

    /// Return Type: pj_status_t->int
    ///codec: pjmedia_codec*
    ///pkt: void*
    ///pkt_size: pj_size_t->size_t->unsigned int
    ///timestamp: pj_timestamp*
    ///frame_cnt: unsigned int*
    ///frames: pjmedia_frame*
    public delegate int pjmedia_codec_op_parse(ref pjmedia_codec codec, System.IntPtr pkt, System.IntPtr pkt_size, ref pj_timestamp timestamp, ref uint frame_cnt, ref pjmedia_frame frames);

    /// Return Type: pj_status_t->int
    ///codec: pjmedia_codec*
    ///input: pjmedia_frame*
    ///out_size: unsigned int
    ///output: pjmedia_frame*
    public delegate int pjmedia_codec_op_encode(ref pjmedia_codec codec, ref pjmedia_frame input, uint out_size, ref pjmedia_frame output);

    /// Return Type: pj_status_t->int
    ///codec: pjmedia_codec*
    ///input: pjmedia_frame*
    ///out_size: unsigned int
    ///output: pjmedia_frame*
    public delegate int pjmedia_codec_op_decode(ref pjmedia_codec codec, ref pjmedia_frame input, uint out_size, ref pjmedia_frame output);

    /// Return Type: pj_status_t->int
    ///codec: pjmedia_codec*
    ///out_size: unsigned int
    ///output: pjmedia_frame*
    public delegate int pjmedia_codec_op_recover(ref pjmedia_codec codec, uint out_size, ref pjmedia_frame output);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_codec_op
    {

        /// pjmedia_codec_op_init
        public pjmedia_codec_op_init AnonymousMember1;

        /// pjmedia_codec_op_open
        public pjmedia_codec_op_open AnonymousMember2;

        /// pjmedia_codec_op_close
        public pjmedia_codec_op_close AnonymousMember3;

        /// pjmedia_codec_op_modify
        public pjmedia_codec_op_modify AnonymousMember4;

        /// pjmedia_codec_op_parse
        public pjmedia_codec_op_parse AnonymousMember5;

        /// pjmedia_codec_op_encode
        public pjmedia_codec_op_encode AnonymousMember6;

        /// pjmedia_codec_op_decode
        public pjmedia_codec_op_decode AnonymousMember7;

        /// pjmedia_codec_op_recover
        public pjmedia_codec_op_recover AnonymousMember8;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_codec
    {

        /// pjmedia_codec*
        public System.IntPtr prev;

        /// pjmedia_codec*
        public System.IntPtr next;

        /// void*
        public System.IntPtr codec_data;

        /// pjmedia_codec_factory*
        public System.IntPtr factory;

        /// pjmedia_codec_op*
        public System.IntPtr op;
    }

    /// Return Type: pj_status_t->int
    ///factory: pjmedia_codec_factory*
    ///info: pjmedia_codec_info*
    public delegate int pjmedia_codec_factory_op_test_alloc(ref pjmedia_codec_factory factory, ref pjmedia_codec_info info);

    /// Return Type: pj_status_t->int
    ///factory: pjmedia_codec_factory*
    ///info: pjmedia_codec_info*
    ///attr: pjmedia_codec_param*
    public delegate int pjmedia_codec_factory_op_default_attr(ref pjmedia_codec_factory factory, ref pjmedia_codec_info info, ref pjmedia_codec_param attr);

    /// Return Type: pj_status_t->int
    ///factory: pjmedia_codec_factory*
    ///count: unsigned int*
    ///codecs: pjmedia_codec_info*
    public delegate int pjmedia_codec_factory_op_enum_info(ref pjmedia_codec_factory factory, ref uint count, ref pjmedia_codec_info codecs);

    /// Return Type: pj_status_t->int
    ///factory: pjmedia_codec_factory*
    ///info: pjmedia_codec_info*
    ///p_codec: pjmedia_codec**
    public delegate int pjmedia_codec_factory_op_alloc_codec(ref pjmedia_codec_factory factory, ref pjmedia_codec_info info, ref System.IntPtr p_codec);

    /// Return Type: pj_status_t->int
    ///factory: pjmedia_codec_factory*
    ///codec: pjmedia_codec*
    public delegate int pjmedia_codec_factory_op_dealloc_codec(ref pjmedia_codec_factory factory, ref pjmedia_codec codec);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_codec_factory_op
    {

        /// pjmedia_codec_factory_op_test_alloc
        public pjmedia_codec_factory_op_test_alloc AnonymousMember1;

        /// pjmedia_codec_factory_op_default_attr
        public pjmedia_codec_factory_op_default_attr AnonymousMember2;

        /// pjmedia_codec_factory_op_enum_info
        public pjmedia_codec_factory_op_enum_info AnonymousMember3;

        /// pjmedia_codec_factory_op_alloc_codec
        public pjmedia_codec_factory_op_alloc_codec AnonymousMember4;

        /// pjmedia_codec_factory_op_dealloc_codec
        public pjmedia_codec_factory_op_dealloc_codec AnonymousMember5;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_codec_factory
    {

        /// pjmedia_codec_factory*
        public System.IntPtr prev;

        /// pjmedia_codec_factory*
        public System.IntPtr next;

        /// void*
        public System.IntPtr factory_data;

        /// pjmedia_codec_factory_op*
        public System.IntPtr op;
    }

    public enum pjmedia_codec_priority
    {

        /// PJMEDIA_CODEC_PRIO_HIGHEST -> 255
        PJMEDIA_CODEC_PRIO_HIGHEST = 255,

        /// PJMEDIA_CODEC_PRIO_NEXT_HIGHER -> 254
        PJMEDIA_CODEC_PRIO_NEXT_HIGHER = 254,

        /// PJMEDIA_CODEC_PRIO_NORMAL -> 128
        PJMEDIA_CODEC_PRIO_NORMAL = 128,

        /// PJMEDIA_CODEC_PRIO_LOWEST -> 1
        PJMEDIA_CODEC_PRIO_LOWEST = 1,

        /// PJMEDIA_CODEC_PRIO_DISABLED -> 0
        PJMEDIA_CODEC_PRIO_DISABLED = 0,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pjmedia_codec_desc
    {

        /// pjmedia_codec_info
        public pjmedia_codec_info info;

        /// pjmedia_codec_id->char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string id;

        /// pjmedia_codec_priority
        public pjmedia_codec_priority prio;

        /// pjmedia_codec_factory*
        public System.IntPtr factory;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_codec_mgr
    {

        /// pjmedia_codec_factory
        public pjmedia_codec_factory factory_list;

        /// unsigned int
        public uint codec_cnt;

        /// pjmedia_codec_desc[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public pjmedia_codec_desc[] codec_desc;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_conf_port_info
    {

        /// unsigned int
        public uint slot;

        /// pj_str_t
        public pj_str_t name;

        /// pjmedia_format
        public pjmedia_format format;

        /// pjmedia_port_op
        public pjmedia_port_op tx_setting;

        /// pjmedia_port_op
        public pjmedia_port_op rx_setting;

        /// unsigned int
        public uint listener_cnt;

        /// unsigned int*
        public System.IntPtr listener_slots;

        /// unsigned int
        public uint transmitter_cnt;

        /// unsigned int
        public uint clock_rate;

        /// unsigned int
        public uint channel_count;

        /// unsigned int
        public uint samples_per_frame;

        /// unsigned int
        public uint bits_per_sample;

        /// int
        public int tx_adj_level;

        /// int
        public int rx_adj_level;
    }

    public enum pjmedia_conf_option
    {

        /// PJMEDIA_CONF_NO_MIC -> 1
        PJMEDIA_CONF_NO_MIC = 1,

        /// PJMEDIA_CONF_NO_DEVICE -> 2
        PJMEDIA_CONF_NO_DEVICE = 2,

        /// PJMEDIA_CONF_SMALL_FILTER -> 4
        PJMEDIA_CONF_SMALL_FILTER = 4,

        /// PJMEDIA_CONF_USE_LINEAR -> 8
        PJMEDIA_CONF_USE_LINEAR = 8,
    }

    public enum pjmedia_echo_flag
    {

        /// PJMEDIA_ECHO_DEFAULT -> 0
        PJMEDIA_ECHO_DEFAULT = 0,

        /// PJMEDIA_ECHO_SPEEX -> 1
        PJMEDIA_ECHO_SPEEX = 1,

        /// PJMEDIA_ECHO_SIMPLE -> 2
        PJMEDIA_ECHO_SIMPLE = 2,

        /// PJMEDIA_ECHO_ALGO_MASK -> 15
        PJMEDIA_ECHO_ALGO_MASK = 15,

        /// PJMEDIA_ECHO_NO_LOCK -> 16
        PJMEDIA_ECHO_NO_LOCK = 16,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_sdp_attr
    {

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t value;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_sdp_rtpmap
    {

        /// pj_str_t
        public pj_str_t pt;

        /// pj_str_t
        public pj_str_t enc_name;

        /// unsigned int
        public uint clock_rate;

        /// pj_str_t
        public pj_str_t param;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_sdp_fmtp
    {

        /// pj_str_t
        public pj_str_t fmt;

        /// pj_str_t
        public pj_str_t fmt_param;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_sdp_rtcp_attr
    {

        /// unsigned int
        public uint port;

        /// pj_str_t
        public pj_str_t net_type;

        /// pj_str_t
        public pj_str_t addr_type;

        /// pj_str_t
        public pj_str_t addr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_sdp_conn
    {

        /// pj_str_t
        public pj_str_t net_type;

        /// pj_str_t
        public pj_str_t addr_type;

        /// pj_str_t
        public pj_str_t addr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_sdp_media
    {

        /// Anonymous_5785ac56_567e_49cd_a064_a19fece4f976
        public Anonymous_5785ac56_567e_49cd_a064_a19fece4f976 desc;

        /// pjmedia_sdp_conn*
        public System.IntPtr conn;

        /// unsigned int
        public uint attr_count;

        /// pjmedia_sdp_attr*[]
        public System.IntPtr[] attr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_sdp_session
    {

        /// Anonymous_317d2398_97dd_4de7_b964_c7e28dbf3420
        public Anonymous_317d2398_97dd_4de7_b964_c7e28dbf3420 origin;

        /// pj_str_t
        public pj_str_t name;

        /// pjmedia_sdp_conn*
        public System.IntPtr conn;

        /// Anonymous_4de5b558_55e9_4df5_a932_74cef35a8e4b
        public Anonymous_4de5b558_55e9_4df5_a932_74cef35a8e4b time;

        /// unsigned int
        public uint attr_count;

        /// pjmedia_sdp_attr*[]
        public System.IntPtr[] attr;

        /// unsigned int
        public uint media_count;

        /// pjmedia_sdp_media*[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = System.Runtime.InteropServices.UnmanagedType.SysUInt)]
        public System.IntPtr[] media;
    }

    public enum pjmedia_jb_frame_type
    {

        /// PJMEDIA_JB_MISSING_FRAME -> 0
        PJMEDIA_JB_MISSING_FRAME = 0,

        /// PJMEDIA_JB_NORMAL_FRAME -> 1
        PJMEDIA_JB_NORMAL_FRAME = 1,

        /// PJMEDIA_JB_ZERO_PREFETCH_FRAME -> 2
        PJMEDIA_JB_ZERO_PREFETCH_FRAME = 2,

        /// PJMEDIA_JB_ZERO_EMPTY_FRAME -> 3
        PJMEDIA_JB_ZERO_EMPTY_FRAME = 3,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_jb_state
    {

        /// unsigned int
        public uint frame_size;

        /// unsigned int
        public uint min_prefetch;

        /// unsigned int
        public uint max_prefetch;

        /// unsigned int
        public uint prefetch;

        /// unsigned int
        public uint size;

        /// unsigned int
        public uint avg_delay;

        /// unsigned int
        public uint min_delay;

        /// unsigned int
        public uint max_delay;

        /// unsigned int
        public uint dev_delay;

        /// unsigned int
        public uint avg_burst;

        /// unsigned int
        public uint lost;

        /// unsigned int
        public uint discard;

        /// unsigned int
        public uint empty;
    }

    public enum pjmedia_mem_player_option
    {

        /// PJMEDIA_MEM_NO_LOOP -> 1
        PJMEDIA_MEM_NO_LOOP = 1,
    }

    public enum pjmedia_resample_port_options
    {

        /// PJMEDIA_RESAMPLE_USE_LINEAR -> 1
        PJMEDIA_RESAMPLE_USE_LINEAR = 1,

        /// PJMEDIA_RESAMPLE_USE_SMALL_FILTER -> 2
        PJMEDIA_RESAMPLE_USE_SMALL_FILTER = 2,

        /// PJMEDIA_RESAMPLE_DONT_DESTROY_DN -> 4
        PJMEDIA_RESAMPLE_DONT_DESTROY_DN = 4,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct _exception
    {

        /// int
        public int type;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string name;

        /// double
        public double arg1;

        /// double
        public double arg2;

        /// double
        public double retval;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct _complex
    {

        /// double
        public double x;

        /// double
        public double y;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_math_stat
    {

        /// int
        public int n;

        /// int
        public int max;

        /// int
        public int min;

        /// int
        public int last;

        /// int
        public int mean;

        /// float
        public float fmean_;

        /// pj_highprec_t->double
        public double m2_;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_xr_rb_header
    {

        /// pj_uint8_t->unsigned char
        public byte bt;

        /// pj_uint8_t->unsigned char
        public byte specific;

        /// pj_uint16_t->unsigned short
        public ushort length;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_xr_rb_rr_time
    {

        /// pjmedia_rtcp_xr_rb_header
        public pjmedia_rtcp_xr_rb_header header;

        /// pj_uint32_t->unsigned int
        public uint ntp_sec;

        /// pj_uint32_t->unsigned int
        public uint ntp_frac;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_xr_rb_dlrr_item
    {

        /// pj_uint32_t->unsigned int
        public uint ssrc;

        /// pj_uint32_t->unsigned int
        public uint lrr;

        /// pj_uint32_t->unsigned int
        public uint dlrr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_xr_rb_dlrr
    {

        /// pjmedia_rtcp_xr_rb_header
        public pjmedia_rtcp_xr_rb_header header;

        /// pjmedia_rtcp_xr_rb_dlrr_item
        public pjmedia_rtcp_xr_rb_dlrr_item item;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_xr_rb_stats
    {

        /// pjmedia_rtcp_xr_rb_header
        public pjmedia_rtcp_xr_rb_header header;

        /// pj_uint32_t->unsigned int
        public uint ssrc;

        /// pj_uint16_t->unsigned short
        public ushort begin_seq;

        /// pj_uint16_t->unsigned short
        public ushort end_seq;

        /// pj_uint32_t->unsigned int
        public uint lost;

        /// pj_uint32_t->unsigned int
        public uint dup;

        /// pj_uint32_t->unsigned int
        public uint jitter_min;

        /// pj_uint32_t->unsigned int
        public uint jitter_max;

        /// pj_uint32_t->unsigned int
        public uint jitter_mean;

        /// pj_uint32_t->unsigned int
        public uint jitter_dev;

        /// toh_min : 8
        ///toh_max : 8
        ///toh_mean : 8
        ///toh_dev : 8
        public uint bitvector1;

        public uint toh_min
        {
            get
            {
                return ((uint)((this.bitvector1 & 255u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint toh_max
        {
            get
            {
                return ((uint)(((this.bitvector1 & 65280u)
                            / 256)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 256)
                            | this.bitvector1)));
            }
        }

        public uint toh_mean
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16711680u)
                            / 65536)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 65536)
                            | this.bitvector1)));
            }
        }

        public uint toh_dev
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4278190080u)
                            / 16777216)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16777216)
                            | this.bitvector1)));
            }
        }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_xr_rb_voip_mtc
    {

        /// pjmedia_rtcp_xr_rb_header
        public pjmedia_rtcp_xr_rb_header header;

        /// pj_uint32_t->unsigned int
        public uint ssrc;

        /// pj_uint8_t->unsigned char
        public byte loss_rate;

        /// pj_uint8_t->unsigned char
        public byte discard_rate;

        /// pj_uint8_t->unsigned char
        public byte burst_den;

        /// pj_uint8_t->unsigned char
        public byte gap_den;

        /// pj_uint16_t->unsigned short
        public ushort burst_dur;

        /// pj_uint16_t->unsigned short
        public ushort gap_dur;

        /// pj_uint16_t->unsigned short
        public ushort rnd_trip_delay;

        /// pj_uint16_t->unsigned short
        public ushort end_sys_delay;

        /// pj_uint8_t->unsigned char
        public byte signal_lvl;

        /// pj_uint8_t->unsigned char
        public byte noise_lvl;

        /// pj_uint8_t->unsigned char
        public byte rerl;

        /// pj_uint8_t->unsigned char
        public byte gmin;

        /// pj_uint8_t->unsigned char
        public byte r_factor;

        /// pj_uint8_t->unsigned char
        public byte ext_r_factor;

        /// pj_uint8_t->unsigned char
        public byte mos_lq;

        /// pj_uint8_t->unsigned char
        public byte mos_cq;

        /// pj_uint8_t->unsigned char
        public byte rx_config;

        /// pj_uint8_t->unsigned char
        public byte reserved2;

        /// pj_uint16_t->unsigned short
        public ushort jb_nom;

        /// pj_uint16_t->unsigned short
        public ushort jb_max;

        /// pj_uint16_t->unsigned short
        public ushort jb_abs_max;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pjmedia_rtcp_xr_pkt
    {

        /// Anonymous_a14448ec_b859_47e9_8724_6af5eedbde17
        public Anonymous_a14448ec_b859_47e9_8724_6af5eedbde17 common;

        /// pj_int8_t[1500]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 1500)]
        public string buf;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_xr_stream_stat
    {

        /// Anonymous_aa0c1455_526f_4abe_bc41_ef74ed856d68
        public Anonymous_aa0c1455_526f_4abe_bc41_ef74ed856d68 stat_sum;

        /// Anonymous_c4f986d4_7d01_41ea_8724_a1d054cb26c0
        public Anonymous_c4f986d4_7d01_41ea_8724_a1d054cb26c0 voip_mtc;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_xr_stat
    {

        /// pjmedia_rtcp_xr_stream_stat
        public pjmedia_rtcp_xr_stream_stat rx;

        /// pjmedia_rtcp_xr_stream_stat
        public pjmedia_rtcp_xr_stream_stat tx;

        /// pj_math_stat
        public pj_math_stat rtt;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_xr_session
    {

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string name;

        /// pjmedia_rtcp_xr_pkt
        public pjmedia_rtcp_xr_pkt pkt;

        /// pj_uint32_t->unsigned int
        public uint rx_lrr;

        /// pj_timestamp
        public pj_timestamp rx_lrr_time;

        /// pj_uint32_t->unsigned int
        public uint rx_last_rr;

        /// pjmedia_rtcp_xr_stat
        public pjmedia_rtcp_xr_stat stat;

        /// pj_uint32_t->unsigned int
        public uint src_ref_seq;

        /// pj_bool_t->int
        public int uninitialized_src_ref_seq;

        /// Anonymous_50c755a7_59e7_44a9_8789_96eeb30d4164
        public Anonymous_50c755a7_59e7_44a9_8789_96eeb30d4164 voip_mtc_stat;

        /// unsigned int
        public uint ptime;

        /// unsigned int
        public uint frames_per_packet;

        /// pjmedia_rtcp_session*
        public System.IntPtr rtcp_session;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtp_hdr
    {

        /// cc : 4
        ///x : 1
        ///p : 1
        ///v : 2
        ///pt : 7
        ///m : 1
        public uint bitvector1;

        /// pj_uint16_t->unsigned short
        public ushort seq;

        /// pj_uint32_t->unsigned int
        public uint ts;

        /// pj_uint32_t->unsigned int
        public uint ssrc;

        public uint cc
        {
            get
            {
                return ((uint)((this.bitvector1 & 15u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint x
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16u)
                            / 16)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16)
                            | this.bitvector1)));
            }
        }

        public uint p
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32u)
                            / 32)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32)
                            | this.bitvector1)));
            }
        }

        public uint v
        {
            get
            {
                return ((uint)(((this.bitvector1 & 192u)
                            / 64)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 64)
                            | this.bitvector1)));
            }
        }

        public uint pt
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32512u)
                            / 256)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 256)
                            | this.bitvector1)));
            }
        }

        public uint m
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32768u)
                            / 32768)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32768)
                            | this.bitvector1)));
            }
        }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtp_ext_hdr
    {

        /// pj_uint16_t->unsigned short
        public ushort profile_data;

        /// pj_uint16_t->unsigned short
        public ushort length;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtp_dtmf_event
    {

        /// pj_uint8_t->unsigned char
        public byte @event;

        /// pj_uint8_t->unsigned char
        public byte e_vol;

        /// pj_uint16_t->unsigned short
        public ushort duration;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtp_seq_session
    {

        /// pj_uint16_t->unsigned short
        public ushort max_seq;

        /// pj_uint32_t->unsigned int
        public uint cycles;

        /// pj_uint32_t->unsigned int
        public uint base_seq;

        /// pj_uint32_t->unsigned int
        public uint bad_seq;

        /// pj_uint32_t->unsigned int
        public uint probation;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtp_session
    {

        /// pjmedia_rtp_hdr
        public pjmedia_rtp_hdr out_hdr;

        /// pjmedia_rtp_seq_session
        public pjmedia_rtp_seq_session seq_ctrl;

        /// pj_uint16_t->unsigned short
        public ushort out_pt;

        /// pj_uint32_t->unsigned int
        public uint out_extseq;

        /// pj_uint32_t->unsigned int
        public uint peer_ssrc;

        /// pj_uint32_t->unsigned int
        public uint received;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct flag
    {

        /// bad : 1
        ///badpt : 1
        ///badssrc : 1
        ///dup : 1
        ///outorder : 1
        ///probation : 1
        ///restart : 1
        public uint bitvector1;

        public uint bad
        {
            get
            {
                return ((uint)((this.bitvector1 & 1u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint badpt
        {
            get
            {
                return ((uint)(((this.bitvector1 & 2u)
                            / 2)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 2)
                            | this.bitvector1)));
            }
        }

        public uint badssrc
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4u)
                            / 4)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 4)
                            | this.bitvector1)));
            }
        }

        public uint dup
        {
            get
            {
                return ((uint)(((this.bitvector1 & 8u)
                            / 8)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 8)
                            | this.bitvector1)));
            }
        }

        public uint outorder
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16u)
                            / 16)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16)
                            | this.bitvector1)));
            }
        }

        public uint probation
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32u)
                            / 32)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32)
                            | this.bitvector1)));
            }
        }

        public uint restart
        {
            get
            {
                return ((uint)(((this.bitvector1 & 64u)
                            / 64)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 64)
                            | this.bitvector1)));
            }
        }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtp_status
    {

        /// Anonymous_f82179d2_ca4d_4982_bfb2_c571f88a474c
        public Anonymous_f82179d2_ca4d_4982_bfb2_c571f88a474c status;

        /// pj_uint16_t->unsigned short
        public ushort diff;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtp_session_setting
    {

        /// pj_uint8_t->unsigned char
        public byte flags;

        /// int
        public int default_pt;

        /// pj_uint32_t->unsigned int
        public uint sender_ssrc;

        /// pj_uint16_t->unsigned short
        public ushort seq;

        /// pj_uint32_t->unsigned int
        public uint ts;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_sr
    {

        /// pj_uint32_t->unsigned int
        public uint ntp_sec;

        /// pj_uint32_t->unsigned int
        public uint ntp_frac;

        /// pj_uint32_t->unsigned int
        public uint rtp_ts;

        /// pj_uint32_t->unsigned int
        public uint sender_pcount;

        /// pj_uint32_t->unsigned int
        public uint sender_bcount;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_rr
    {

        /// pj_uint32_t->unsigned int
        public uint ssrc;

        /// fract_lost : 8
        ///total_lost_2 : 8
        ///total_lost_1 : 8
        ///total_lost_0 : 8
        public uint bitvector1;

        /// pj_uint32_t->unsigned int
        public uint last_seq;

        /// pj_uint32_t->unsigned int
        public uint jitter;

        /// pj_uint32_t->unsigned int
        public uint lsr;

        /// pj_uint32_t->unsigned int
        public uint dlsr;

        public uint fract_lost
        {
            get
            {
                return ((uint)((this.bitvector1 & 255u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint total_lost_2
        {
            get
            {
                return ((uint)(((this.bitvector1 & 65280u)
                            / 256)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 256)
                            | this.bitvector1)));
            }
        }

        public uint total_lost_1
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16711680u)
                            / 65536)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 65536)
                            | this.bitvector1)));
            }
        }

        public uint total_lost_0
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4278190080u)
                            / 16777216)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16777216)
                            | this.bitvector1)));
            }
        }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_common
    {

        /// count : 5
        ///p : 1
        ///version : 2
        ///pt : 8
        ///length : 16
        public uint bitvector1;

        /// pj_uint32_t->unsigned int
        public uint ssrc;

        public uint count
        {
            get
            {
                return ((uint)((this.bitvector1 & 31u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint p
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32u)
                            / 32)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32)
                            | this.bitvector1)));
            }
        }

        public uint version
        {
            get
            {
                return ((uint)(((this.bitvector1 & 192u)
                            / 64)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 64)
                            | this.bitvector1)));
            }
        }

        public uint pt
        {
            get
            {
                return ((uint)(((this.bitvector1 & 65280u)
                            / 256)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 256)
                            | this.bitvector1)));
            }
        }

        public uint length
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4294901760u)
                            / 65536)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 65536)
                            | this.bitvector1)));
            }
        }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_sr_pkt
    {

        /// pjmedia_rtcp_common
        public pjmedia_rtcp_common common;

        /// pjmedia_rtcp_sr
        public pjmedia_rtcp_sr sr;

        /// pjmedia_rtcp_rr
        public pjmedia_rtcp_rr rr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_rr_pkt
    {

        /// pjmedia_rtcp_common
        public pjmedia_rtcp_common common;

        /// pjmedia_rtcp_rr
        public pjmedia_rtcp_rr rr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_ntp_rec
    {

        /// pj_uint32_t->unsigned int
        public uint hi;

        /// pj_uint32_t->unsigned int
        public uint lo;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_stream_stat
    {

        /// pj_time_val
        public pj_time_val update;

        /// unsigned int
        public uint update_cnt;

        /// pj_uint32_t->unsigned int
        public uint pkt;

        /// pj_uint32_t->unsigned int
        public uint bytes;

        /// unsigned int
        public uint discard;

        /// unsigned int
        public uint loss;

        /// unsigned int
        public uint reorder;

        /// unsigned int
        public uint dup;

        /// pj_math_stat
        public pj_math_stat loss_period;

        /// Anonymous_4d61a905_b963_46ef_8547_2aaa9774cf85
        public Anonymous_4d61a905_b963_46ef_8547_2aaa9774cf85 loss_type;

        /// pj_math_stat
        public pj_math_stat jitter;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_stat
    {

        /// pj_time_val
        public pj_time_val start;

        /// pjmedia_rtcp_stream_stat
        public pjmedia_rtcp_stream_stat tx;

        /// pjmedia_rtcp_stream_stat
        public pjmedia_rtcp_stream_stat rx;

        /// pj_math_stat
        public pj_math_stat rtt;

        /// pj_uint32_t->unsigned int
        public uint rtp_tx_last_ts;

        /// pj_uint16_t->unsigned short
        public ushort rtp_tx_last_seq;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_rtcp_session
    {

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string name;

        /// pjmedia_rtcp_sr_pkt
        public pjmedia_rtcp_sr_pkt rtcp_sr_pkt;

        /// pjmedia_rtcp_rr_pkt
        public pjmedia_rtcp_rr_pkt rtcp_rr_pkt;

        /// pjmedia_rtp_seq_session
        public pjmedia_rtp_seq_session seq_ctrl;

        /// unsigned int
        public uint rtp_last_ts;

        /// unsigned int
        public uint clock_rate;

        /// unsigned int
        public uint pkt_size;

        /// pj_uint32_t->unsigned int
        public uint received;

        /// pj_uint32_t->unsigned int
        public uint exp_prior;

        /// pj_uint32_t->unsigned int
        public uint rx_prior;

        /// pj_int32_t->int
        public int transit;

        /// pj_uint32_t->unsigned int
        public uint jitter;

        /// pj_time_val
        public pj_time_val tv_base;

        /// pj_timestamp
        public pj_timestamp ts_base;

        /// pj_timestamp
        public pj_timestamp ts_freq;

        /// pj_uint32_t->unsigned int
        public uint rx_lsr;

        /// pj_timestamp
        public pj_timestamp rx_lsr_time;

        /// pj_uint32_t->unsigned int
        public uint peer_ssrc;

        /// pjmedia_rtcp_stat
        public pjmedia_rtcp_stat stat;
    }

    public enum pjmedia_sdp_neg_state
    {

        PJMEDIA_SDP_NEG_STATE_NULL,

        PJMEDIA_SDP_NEG_STATE_LOCAL_OFFER,

        PJMEDIA_SDP_NEG_STATE_REMOTE_OFFER,

        PJMEDIA_SDP_NEG_STATE_WAIT_NEGO,

        PJMEDIA_SDP_NEG_STATE_DONE,
    }

    public enum pjmedia_tranport_media_option
    {

        /// PJMEDIA_TPMED_NO_TRANSPORT_CHECKING -> 1
        PJMEDIA_TPMED_NO_TRANSPORT_CHECKING = 1,
    }

    /// Return Type: pj_status_t->int
    ///tp: pjmedia_transport*
    ///info: pjmedia_transport_info*
    public delegate int pjmedia_transport_op_get_info(ref pjmedia_transport tp, ref pjmedia_transport_info info);

    /// Return Type: pj_status_t->int
    ///tp: pjmedia_transport*
    ///user_data: void*
    ///rem_addr: pj_sockaddr_t*
    ///rem_rtcp: pj_sockaddr_t*
    ///addr_len: unsigned int
    ///rtp_cb: Anonymous_85d742b6_eba5_4080_a5b4_07d19b35439c
    ///rtcp_cb: Anonymous_5be1ad26_db76_4044_9249_95d1d7418205
    public delegate int pjmedia_transport_op_attach(ref pjmedia_transport tp, System.IntPtr user_data, System.IntPtr rem_addr, System.IntPtr rem_rtcp, uint addr_len, Anonymous_85d742b6_eba5_4080_a5b4_07d19b35439c rtp_cb, Anonymous_5be1ad26_db76_4044_9249_95d1d7418205 rtcp_cb);

    /// Return Type: void
    ///tp: pjmedia_transport*
    ///user_data: void*
    public delegate void pjmedia_transport_op_detach(ref pjmedia_transport tp, System.IntPtr user_data);

    /// Return Type: pj_status_t->int
    ///tp: pjmedia_transport*
    ///pkt: void*
    ///size: pj_size_t->size_t->unsigned int
    public delegate int pjmedia_transport_op_send_rtp(ref pjmedia_transport tp, System.IntPtr pkt, System.IntPtr size);

    /// Return Type: pj_status_t->int
    ///tp: pjmedia_transport*
    ///pkt: void*
    ///size: pj_size_t->size_t->unsigned int
    public delegate int pjmedia_transport_op_send_rtcp(ref pjmedia_transport tp, System.IntPtr pkt, System.IntPtr size);

    /// Return Type: pj_status_t->int
    ///tp: pjmedia_transport*
    ///addr: pj_sockaddr_t*
    ///addr_len: unsigned int
    ///pkt: void*
    ///size: pj_size_t->size_t->unsigned int
    public delegate int pjmedia_transport_op_send_rtcp2(ref pjmedia_transport tp, System.IntPtr addr, uint addr_len, System.IntPtr pkt, System.IntPtr size);

    /// Return Type: pj_status_t->int
    ///tp: pjmedia_transport*
    ///sdp_pool: pj_pool_t*
    ///options: unsigned int
    ///remote_sdp: pjmedia_sdp_session*
    ///media_index: unsigned int
    public delegate int pjmedia_transport_op_media_create(ref pjmedia_transport tp, ref pj_pool_t sdp_pool, uint options, ref pjmedia_sdp_session remote_sdp, uint media_index);

    /// Return Type: pj_status_t->int
    ///tp: pjmedia_transport*
    ///sdp_pool: pj_pool_t*
    ///sdp_local: pjmedia_sdp_session*
    ///rem_sdp: pjmedia_sdp_session*
    ///media_index: unsigned int
    public delegate int pjmedia_transport_op_encode_sdp(ref pjmedia_transport tp, ref pj_pool_t sdp_pool, ref pjmedia_sdp_session sdp_local, ref pjmedia_sdp_session rem_sdp, uint media_index);

    /// Return Type: pj_status_t->int
    ///tp: pjmedia_transport*
    ///tmp_pool: pj_pool_t*
    ///sdp_local: pjmedia_sdp_session*
    ///sdp_remote: pjmedia_sdp_session*
    ///media_index: unsigned int
    public delegate int pjmedia_transport_op_media_start(ref pjmedia_transport tp, ref pj_pool_t tmp_pool, ref pjmedia_sdp_session sdp_local, ref pjmedia_sdp_session sdp_remote, uint media_index);

    /// Return Type: pj_status_t->int
    ///tp: pjmedia_transport*
    public delegate int pjmedia_transport_op_media_stop(ref pjmedia_transport tp);

    /// Return Type: pj_status_t->int
    ///tp: pjmedia_transport*
    ///dir: pjmedia_dir
    ///pct_lost: unsigned int
    public delegate int pjmedia_transport_op_simulate_lost(ref pjmedia_transport tp, pjmedia_dir dir, uint pct_lost);

    /// Return Type: pj_status_t->int
    ///tp: pjmedia_transport*
    public delegate int pjmedia_transport_op_destroy(ref pjmedia_transport tp);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_transport_op
    {

        /// pjmedia_transport_op_get_info
        public pjmedia_transport_op_get_info AnonymousMember1;

        /// pjmedia_transport_op_attach
        public pjmedia_transport_op_attach AnonymousMember2;

        /// pjmedia_transport_op_detach
        public pjmedia_transport_op_detach AnonymousMember3;

        /// pjmedia_transport_op_send_rtp
        public pjmedia_transport_op_send_rtp AnonymousMember4;

        /// pjmedia_transport_op_send_rtcp
        public pjmedia_transport_op_send_rtcp AnonymousMember5;

        /// pjmedia_transport_op_send_rtcp2
        public pjmedia_transport_op_send_rtcp2 AnonymousMember6;

        /// pjmedia_transport_op_media_create
        public pjmedia_transport_op_media_create AnonymousMember7;

        /// pjmedia_transport_op_encode_sdp
        public pjmedia_transport_op_encode_sdp AnonymousMember8;

        /// pjmedia_transport_op_media_start
        public pjmedia_transport_op_media_start AnonymousMember9;

        /// pjmedia_transport_op_media_stop
        public pjmedia_transport_op_media_stop AnonymousMember10;

        /// pjmedia_transport_op_simulate_lost
        public pjmedia_transport_op_simulate_lost AnonymousMember11;

        /// pjmedia_transport_op_destroy
        public pjmedia_transport_op_destroy AnonymousMember12;
    }

    public enum pjmedia_transport_type
    {

        PJMEDIA_TRANSPORT_TYPE_UDP,

        PJMEDIA_TRANSPORT_TYPE_ICE,

        PJMEDIA_TRANSPORT_TYPE_SRTP,

        PJMEDIA_TRANSPORT_TYPE_USER,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pjmedia_transport
    {

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string name;

        /// pjmedia_transport_type
        public pjmedia_transport_type type;

        /// pjmedia_transport_op*
        public System.IntPtr op;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pjmedia_transport_specific_info
    {

        /// pjmedia_transport_type
        public pjmedia_transport_type type;

        /// int
        public int cbsize;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
        public string buffer;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_transport_info
    {

        /// pjmedia_sock_info
        public pjmedia_sock_info sock_info;

        /// pj_sockaddr
        public pj_sockaddr src_rtp_name;

        /// pj_sockaddr
        public pj_sockaddr src_rtcp_name;

        /// int
        public int specific_info_cnt;

        /// pjmedia_transport_specific_info[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public pjmedia_transport_specific_info[] spc_info;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_stream_info
    {

        /// pjmedia_type
        public pjmedia_type type;

        /// pjmedia_tp_proto
        public pjmedia_tp_proto proto;

        /// pjmedia_dir
        public pjmedia_dir dir;

        /// pj_sockaddr
        public pj_sockaddr rem_addr;

        /// pj_sockaddr
        public pj_sockaddr rem_rtcp;

        /// pjmedia_codec_info
        public pjmedia_codec_info fmt;

        /// pjmedia_codec_param*
        public System.IntPtr param;

        /// unsigned int
        public uint tx_pt;

        /// unsigned int
        public uint tx_maxptime;

        /// int
        public int tx_event_pt;

        /// int
        public int rx_event_pt;

        /// pj_uint32_t->unsigned int
        public uint ssrc;

        /// pj_uint32_t->unsigned int
        public uint rtp_ts;

        /// pj_uint16_t->unsigned short
        public ushort rtp_seq;

        /// pj_uint8_t->unsigned char
        public byte rtp_seq_ts_set;

        /// int
        public int jb_init;

        /// int
        public int jb_min_pre;

        /// int
        public int jb_max_pre;

        /// int
        public int jb_max;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_session_info
    {

        /// unsigned int
        public uint stream_cnt;

        /// pjmedia_stream_info[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public pjmedia_stream_info[] stream_info;
    }

    public enum pjmedia_aud_dev_cap
    {

        /// PJMEDIA_AUD_DEV_CAP_EXT_FORMAT -> 1
        PJMEDIA_AUD_DEV_CAP_EXT_FORMAT = 1,

        /// PJMEDIA_AUD_DEV_CAP_INPUT_LATENCY -> 2
        PJMEDIA_AUD_DEV_CAP_INPUT_LATENCY = 2,

        /// PJMEDIA_AUD_DEV_CAP_OUTPUT_LATENCY -> 4
        PJMEDIA_AUD_DEV_CAP_OUTPUT_LATENCY = 4,

        /// PJMEDIA_AUD_DEV_CAP_INPUT_VOLUME_SETTING -> 8
        PJMEDIA_AUD_DEV_CAP_INPUT_VOLUME_SETTING = 8,

        /// PJMEDIA_AUD_DEV_CAP_OUTPUT_VOLUME_SETTING -> 16
        PJMEDIA_AUD_DEV_CAP_OUTPUT_VOLUME_SETTING = 16,

        /// PJMEDIA_AUD_DEV_CAP_INPUT_SIGNAL_METER -> 32
        PJMEDIA_AUD_DEV_CAP_INPUT_SIGNAL_METER = 32,

        /// PJMEDIA_AUD_DEV_CAP_OUTPUT_SIGNAL_METER -> 64
        PJMEDIA_AUD_DEV_CAP_OUTPUT_SIGNAL_METER = 64,

        /// PJMEDIA_AUD_DEV_CAP_INPUT_ROUTE -> 128
        PJMEDIA_AUD_DEV_CAP_INPUT_ROUTE = 128,

        /// PJMEDIA_AUD_DEV_CAP_OUTPUT_ROUTE -> 256
        PJMEDIA_AUD_DEV_CAP_OUTPUT_ROUTE = 256,

        /// PJMEDIA_AUD_DEV_CAP_EC -> 512
        PJMEDIA_AUD_DEV_CAP_EC = 512,

        /// PJMEDIA_AUD_DEV_CAP_EC_TAIL -> 1024
        PJMEDIA_AUD_DEV_CAP_EC_TAIL = 1024,

        /// PJMEDIA_AUD_DEV_CAP_VAD -> 2048
        PJMEDIA_AUD_DEV_CAP_VAD = 2048,

        /// PJMEDIA_AUD_DEV_CAP_CNG -> 4096
        PJMEDIA_AUD_DEV_CAP_CNG = 4096,

        /// PJMEDIA_AUD_DEV_CAP_PLC -> 8192
        PJMEDIA_AUD_DEV_CAP_PLC = 8192,

        /// PJMEDIA_AUD_DEV_CAP_MAX -> 16384
        PJMEDIA_AUD_DEV_CAP_MAX = 16384,
    }

    public enum pjmedia_aud_dev_route
    {

        /// PJMEDIA_AUD_DEV_ROUTE_DEFAULT -> 0
        PJMEDIA_AUD_DEV_ROUTE_DEFAULT = 0,

        /// PJMEDIA_AUD_DEV_ROUTE_LOUDSPEAKER -> 1
        PJMEDIA_AUD_DEV_ROUTE_LOUDSPEAKER = 1,

        /// PJMEDIA_AUD_DEV_ROUTE_EARPIECE -> 2
        PJMEDIA_AUD_DEV_ROUTE_EARPIECE = 2,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pjmedia_aud_dev_info
    {

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string name;

        /// unsigned int
        public uint input_count;

        /// unsigned int
        public uint output_count;

        /// unsigned int
        public uint default_samples_per_sec;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string driver;

        /// unsigned int
        public uint caps;

        /// unsigned int
        public uint routes;

        /// unsigned int
        public uint ext_fmt_cnt;

        /// pjmedia_format[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public pjmedia_format[] ext_fmt;
    }

    /// Return Type: pj_status_t->int
    ///user_data: void*
    ///frame: pjmedia_frame*
    public delegate int pjmedia_aud_play_cb(System.IntPtr user_data, ref pjmedia_frame frame);

    /// Return Type: pj_status_t->int
    ///user_data: void*
    ///frame: pjmedia_frame*
    public delegate int pjmedia_aud_rec_cb(System.IntPtr user_data, ref pjmedia_frame frame);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_aud_param
    {

        /// pjmedia_dir
        public pjmedia_dir dir;

        /// pjmedia_aud_dev_index->pj_int32_t->int
        public int rec_id;

        /// pjmedia_aud_dev_index->pj_int32_t->int
        public int play_id;

        /// unsigned int
        public uint clock_rate;

        /// unsigned int
        public uint channel_count;

        /// unsigned int
        public uint samples_per_frame;

        /// unsigned int
        public uint bits_per_sample;

        /// unsigned int
        public uint flags;

        /// pjmedia_format
        public pjmedia_format ext_fmt;

        /// unsigned int
        public uint input_latency_ms;

        /// unsigned int
        public uint output_latency_ms;

        /// unsigned int
        public uint input_vol;

        /// unsigned int
        public uint output_vol;

        /// pjmedia_aud_dev_route
        public pjmedia_aud_dev_route input_route;

        /// pjmedia_aud_dev_route
        public pjmedia_aud_dev_route output_route;

        /// pj_bool_t->int
        public int ec_enabled;

        /// unsigned int
        public uint ec_tail_ms;

        /// pj_bool_t->int
        public int plc_enabled;

        /// pj_bool_t->int
        public int cng_enabled;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pjmedia_snd_dev_info
    {

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string name;

        /// unsigned int
        public uint input_count;

        /// unsigned int
        public uint output_count;

        /// unsigned int
        public uint default_samples_per_sec;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_snd_stream_info
    {

        /// pjmedia_dir
        public pjmedia_dir dir;

        /// int
        public int play_id;

        /// int
        public int rec_id;

        /// unsigned int
        public uint clock_rate;

        /// unsigned int
        public uint channel_count;

        /// unsigned int
        public uint samples_per_frame;

        /// unsigned int
        public uint bits_per_sample;

        /// unsigned int
        public uint rec_latency;

        /// unsigned int
        public uint play_latency;
    }

    /// Return Type: pj_status_t->int
    ///user_data: void*
    ///timestamp: pj_uint32_t->unsigned int
    ///output: void*
    ///size: unsigned int
    public delegate int pjmedia_snd_play_cb(System.IntPtr user_data, uint timestamp, System.IntPtr output, uint size);

    /// Return Type: pj_status_t->int
    ///user_data: void*
    ///timestamp: pj_uint32_t->unsigned int
    ///input: void*
    ///size: unsigned int
    public delegate int pjmedia_snd_rec_cb(System.IntPtr user_data, uint timestamp, System.IntPtr input, uint size);

    public enum pjmedia_stereo_port_options
    {

        /// PJMEDIA_STEREO_DONT_DESTROY_DN -> 4
        PJMEDIA_STEREO_DONT_DESTROY_DN = 4,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_tone_desc
    {

        /// short
        public short freq1;

        /// short
        public short freq2;

        /// short
        public short on_msec;

        /// short
        public short off_msec;

        /// short
        public short volume;

        /// short
        public short flags;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_tone_digit
    {

        /// char
        public byte digit;

        /// short
        public short on_msec;

        /// short
        public short off_msec;

        /// short
        public short volume;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_tone_digit_map
    {

        /// unsigned int
        public uint count;

        /// Anonymous_027e9f14_4c2d_429d_87f8_af0dc61b7581[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public Anonymous_027e9f14_4c2d_429d_87f8_af0dc61b7581[] digits;
    }

    public enum pj_stun_method_e
    {

        /// PJ_STUN_BINDING_METHOD -> 1
        PJ_STUN_BINDING_METHOD = 1,

        /// PJ_STUN_SHARED_SECRET_METHOD -> 2
        PJ_STUN_SHARED_SECRET_METHOD = 2,

        /// PJ_STUN_ALLOCATE_METHOD -> 3
        PJ_STUN_ALLOCATE_METHOD = 3,

        /// PJ_STUN_REFRESH_METHOD -> 4
        PJ_STUN_REFRESH_METHOD = 4,

        /// PJ_STUN_SEND_METHOD -> 6
        PJ_STUN_SEND_METHOD = 6,

        /// PJ_STUN_DATA_METHOD -> 7
        PJ_STUN_DATA_METHOD = 7,

        /// PJ_STUN_CREATE_PERM_METHOD -> 8
        PJ_STUN_CREATE_PERM_METHOD = 8,

        /// PJ_STUN_CHANNEL_BIND_METHOD -> 9
        PJ_STUN_CHANNEL_BIND_METHOD = 9,

        PJ_STUN_METHOD_MAX,
    }

    public enum pj_stun_msg_class_e
    {

        /// PJ_STUN_REQUEST_CLASS -> 0
        PJ_STUN_REQUEST_CLASS = 0,

        /// PJ_STUN_INDICATION_CLASS -> 1
        PJ_STUN_INDICATION_CLASS = 1,

        /// PJ_STUN_SUCCESS_CLASS -> 2
        PJ_STUN_SUCCESS_CLASS = 2,

        /// PJ_STUN_ERROR_CLASS -> 3
        PJ_STUN_ERROR_CLASS = 3,
    }

    public enum pj_stun_msg_type
    {

        /// PJ_STUN_BINDING_REQUEST -> 0x0001
        PJ_STUN_BINDING_REQUEST = 1,

        /// PJ_STUN_BINDING_RESPONSE -> 0x0101
        PJ_STUN_BINDING_RESPONSE = 257,

        /// PJ_STUN_BINDING_ERROR_RESPONSE -> 0x0111
        PJ_STUN_BINDING_ERROR_RESPONSE = 273,

        /// PJ_STUN_BINDING_INDICATION -> 0x0011
        PJ_STUN_BINDING_INDICATION = 17,

        /// PJ_STUN_SHARED_SECRET_REQUEST -> 0x0002
        PJ_STUN_SHARED_SECRET_REQUEST = 2,

        /// PJ_STUN_SHARED_SECRET_RESPONSE -> 0x0102
        PJ_STUN_SHARED_SECRET_RESPONSE = 258,

        /// PJ_STUN_SHARED_SECRET_ERROR_RESPONSE -> 0x0112
        PJ_STUN_SHARED_SECRET_ERROR_RESPONSE = 274,

        /// PJ_STUN_ALLOCATE_REQUEST -> 0x0003
        PJ_STUN_ALLOCATE_REQUEST = 3,

        /// PJ_STUN_ALLOCATE_RESPONSE -> 0x0103
        PJ_STUN_ALLOCATE_RESPONSE = 259,

        /// PJ_STUN_ALLOCATE_ERROR_RESPONSE -> 0x0113
        PJ_STUN_ALLOCATE_ERROR_RESPONSE = 275,

        /// PJ_STUN_REFRESH_REQUEST -> 0x0004
        PJ_STUN_REFRESH_REQUEST = 4,

        /// PJ_STUN_REFRESH_RESPONSE -> 0x0104
        PJ_STUN_REFRESH_RESPONSE = 260,

        /// PJ_STUN_REFRESH_ERROR_RESPONSE -> 0x0114
        PJ_STUN_REFRESH_ERROR_RESPONSE = 276,

        /// PJ_STUN_SEND_INDICATION -> 0x0016
        PJ_STUN_SEND_INDICATION = 22,

        /// PJ_STUN_DATA_INDICATION -> 0x0017
        PJ_STUN_DATA_INDICATION = 23,

        /// PJ_STUN_CREATE_PERM_REQUEST -> 0x0008
        PJ_STUN_CREATE_PERM_REQUEST = 8,

        /// PJ_STUN_CREATE_PERM_RESPONSE -> 0x0108
        PJ_STUN_CREATE_PERM_RESPONSE = 264,

        /// PJ_STUN_CREATE_PERM_ERROR_RESPONSE -> 0x0118
        PJ_STUN_CREATE_PERM_ERROR_RESPONSE = 280,

        /// PJ_STUN_CHANNEL_BIND_REQUEST -> 0x0009
        PJ_STUN_CHANNEL_BIND_REQUEST = 9,

        /// PJ_STUN_CHANNEL_BIND_RESPONSE -> 0x0109
        PJ_STUN_CHANNEL_BIND_RESPONSE = 265,

        /// PJ_STUN_CHANNEL_BIND_ERROR_RESPONSE -> 0x0119
        PJ_STUN_CHANNEL_BIND_ERROR_RESPONSE = 281,
    }

    public enum pj_stun_attr_type
    {

        /// PJ_STUN_ATTR_MAPPED_ADDR -> 0x0001
        PJ_STUN_ATTR_MAPPED_ADDR = 1,

        /// PJ_STUN_ATTR_RESPONSE_ADDR -> 0x0002
        PJ_STUN_ATTR_RESPONSE_ADDR = 2,

        /// PJ_STUN_ATTR_CHANGE_REQUEST -> 0x0003
        PJ_STUN_ATTR_CHANGE_REQUEST = 3,

        /// PJ_STUN_ATTR_SOURCE_ADDR -> 0x0004
        PJ_STUN_ATTR_SOURCE_ADDR = 4,

        /// PJ_STUN_ATTR_CHANGED_ADDR -> 0x0005
        PJ_STUN_ATTR_CHANGED_ADDR = 5,

        /// PJ_STUN_ATTR_USERNAME -> 0x0006
        PJ_STUN_ATTR_USERNAME = 6,

        /// PJ_STUN_ATTR_PASSWORD -> 0x0007
        PJ_STUN_ATTR_PASSWORD = 7,

        /// PJ_STUN_ATTR_MESSAGE_INTEGRITY -> 0x0008
        PJ_STUN_ATTR_MESSAGE_INTEGRITY = 8,

        /// PJ_STUN_ATTR_ERROR_CODE -> 0x0009
        PJ_STUN_ATTR_ERROR_CODE = 9,

        /// PJ_STUN_ATTR_UNKNOWN_ATTRIBUTES -> 0x000A
        PJ_STUN_ATTR_UNKNOWN_ATTRIBUTES = 10,

        /// PJ_STUN_ATTR_REFLECTED_FROM -> 0x000B
        PJ_STUN_ATTR_REFLECTED_FROM = 11,

        /// PJ_STUN_ATTR_CHANNEL_NUMBER -> 0x000C
        PJ_STUN_ATTR_CHANNEL_NUMBER = 12,

        /// PJ_STUN_ATTR_LIFETIME -> 0x000D
        PJ_STUN_ATTR_LIFETIME = 13,

        /// PJ_STUN_ATTR_MAGIC_COOKIE -> 0x000F
        PJ_STUN_ATTR_MAGIC_COOKIE = 15,

        /// PJ_STUN_ATTR_BANDWIDTH -> 0x0010
        PJ_STUN_ATTR_BANDWIDTH = 16,

        /// PJ_STUN_ATTR_XOR_PEER_ADDR -> 0x0012
        PJ_STUN_ATTR_XOR_PEER_ADDR = 18,

        /// PJ_STUN_ATTR_DATA -> 0x0013
        PJ_STUN_ATTR_DATA = 19,

        /// PJ_STUN_ATTR_REALM -> 0x0014
        PJ_STUN_ATTR_REALM = 20,

        /// PJ_STUN_ATTR_NONCE -> 0x0015
        PJ_STUN_ATTR_NONCE = 21,

        /// PJ_STUN_ATTR_XOR_RELAYED_ADDR -> 0x0016
        PJ_STUN_ATTR_XOR_RELAYED_ADDR = 22,

        /// PJ_STUN_ATTR_REQ_ADDR_TYPE -> 0x0017
        PJ_STUN_ATTR_REQ_ADDR_TYPE = 23,

        /// PJ_STUN_ATTR_EVEN_PORT -> 0x0018
        PJ_STUN_ATTR_EVEN_PORT = 24,

        /// PJ_STUN_ATTR_REQ_TRANSPORT -> 0x0019
        PJ_STUN_ATTR_REQ_TRANSPORT = 25,

        /// PJ_STUN_ATTR_DONT_FRAGMENT -> 0x001A
        PJ_STUN_ATTR_DONT_FRAGMENT = 26,

        /// PJ_STUN_ATTR_XOR_MAPPED_ADDR -> 0x0020
        PJ_STUN_ATTR_XOR_MAPPED_ADDR = 32,

        /// PJ_STUN_ATTR_TIMER_VAL -> 0x0021
        PJ_STUN_ATTR_TIMER_VAL = 33,

        /// PJ_STUN_ATTR_RESERVATION_TOKEN -> 0x0022
        PJ_STUN_ATTR_RESERVATION_TOKEN = 34,

        /// PJ_STUN_ATTR_XOR_REFLECTED_FROM -> 0x0023
        PJ_STUN_ATTR_XOR_REFLECTED_FROM = 35,

        /// PJ_STUN_ATTR_PRIORITY -> 0x0024
        PJ_STUN_ATTR_PRIORITY = 36,

        /// PJ_STUN_ATTR_USE_CANDIDATE -> 0x0025
        PJ_STUN_ATTR_USE_CANDIDATE = 37,

        /// PJ_STUN_ATTR_ICMP -> 0x0030
        PJ_STUN_ATTR_ICMP = 48,

        PJ_STUN_ATTR_END_MANDATORY_ATTR,

        /// PJ_STUN_ATTR_START_EXTENDED_ATTR -> 0x8021
        PJ_STUN_ATTR_START_EXTENDED_ATTR = 32801,

        /// PJ_STUN_ATTR_SOFTWARE -> 0x8022
        PJ_STUN_ATTR_SOFTWARE = 32802,

        /// PJ_STUN_ATTR_ALTERNATE_SERVER -> 0x8023
        PJ_STUN_ATTR_ALTERNATE_SERVER = 32803,

        /// PJ_STUN_ATTR_REFRESH_INTERVAL -> 0x8024
        PJ_STUN_ATTR_REFRESH_INTERVAL = 32804,

        /// PJ_STUN_ATTR_FINGERPRINT -> 0x8028
        PJ_STUN_ATTR_FINGERPRINT = 32808,

        /// PJ_STUN_ATTR_ICE_CONTROLLED -> 0x8029
        PJ_STUN_ATTR_ICE_CONTROLLED = 32809,

        /// PJ_STUN_ATTR_ICE_CONTROLLING -> 0x802a
        PJ_STUN_ATTR_ICE_CONTROLLING = 32810,

        PJ_STUN_ATTR_END_EXTENDED_ATTR,
    }

    public enum pj_stun_status
    {

        /// PJ_STUN_SC_TRY_ALTERNATE -> 300
        PJ_STUN_SC_TRY_ALTERNATE = 300,

        /// PJ_STUN_SC_BAD_REQUEST -> 400
        PJ_STUN_SC_BAD_REQUEST = 400,

        /// PJ_STUN_SC_UNAUTHORIZED -> 401
        PJ_STUN_SC_UNAUTHORIZED = 401,

        /// PJ_STUN_SC_FORBIDDEN -> 403
        PJ_STUN_SC_FORBIDDEN = 403,

        /// PJ_STUN_SC_UNKNOWN_ATTRIBUTE -> 420
        PJ_STUN_SC_UNKNOWN_ATTRIBUTE = 420,

        /// PJ_STUN_SC_ALLOCATION_MISMATCH -> 437
        PJ_STUN_SC_ALLOCATION_MISMATCH = 437,

        /// PJ_STUN_SC_STALE_NONCE -> 438
        PJ_STUN_SC_STALE_NONCE = 438,

        /// PJ_STUN_SC_TRANSITIONING -> 439
        PJ_STUN_SC_TRANSITIONING = 439,

        /// PJ_STUN_SC_WRONG_CREDENTIALS -> 441
        PJ_STUN_SC_WRONG_CREDENTIALS = 441,

        /// PJ_STUN_SC_UNSUPP_TRANSPORT_PROTO -> 442
        PJ_STUN_SC_UNSUPP_TRANSPORT_PROTO = 442,

        /// PJ_STUN_SC_OPER_TCP_ONLY -> 445
        PJ_STUN_SC_OPER_TCP_ONLY = 445,

        /// PJ_STUN_SC_CONNECTION_FAILURE -> 446
        PJ_STUN_SC_CONNECTION_FAILURE = 446,

        /// PJ_STUN_SC_CONNECTION_TIMEOUT -> 447
        PJ_STUN_SC_CONNECTION_TIMEOUT = 447,

        /// PJ_STUN_SC_ALLOCATION_QUOTA_REACHED -> 486
        PJ_STUN_SC_ALLOCATION_QUOTA_REACHED = 486,

        /// PJ_STUN_SC_ROLE_CONFLICT -> 487
        PJ_STUN_SC_ROLE_CONFLICT = 487,

        /// PJ_STUN_SC_SERVER_ERROR -> 500
        PJ_STUN_SC_SERVER_ERROR = 500,

        /// PJ_STUN_SC_INSUFFICIENT_CAPACITY -> 508
        PJ_STUN_SC_INSUFFICIENT_CAPACITY = 508,

        /// PJ_STUN_SC_GLOBAL_FAILURE -> 600
        PJ_STUN_SC_GLOBAL_FAILURE = 600,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pj_stun_msg_hdr
    {

        /// pj_uint16_t->unsigned short
        public ushort type;

        /// pj_uint16_t->unsigned short
        public ushort length;

        /// pj_uint32_t->unsigned int
        public uint magic;

        /// pj_uint8_t[12]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 12)]
        public string tsx_id;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_attr_hdr
    {

        /// pj_uint16_t->unsigned short
        public ushort type;

        /// pj_uint16_t->unsigned short
        public ushort length;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_sockaddr_attr
    {

        /// pj_stun_attr_hdr
        public pj_stun_attr_hdr hdr;

        /// pj_bool_t->int
        public int xor_ed;

        /// pj_sockaddr
        public pj_sockaddr sockaddr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_empty_attr
    {

        /// pj_stun_attr_hdr
        public pj_stun_attr_hdr hdr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_string_attr
    {

        /// pj_stun_attr_hdr
        public pj_stun_attr_hdr hdr;

        /// pj_str_t
        public pj_str_t value;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_uint_attr
    {

        /// pj_stun_attr_hdr
        public pj_stun_attr_hdr hdr;

        /// pj_uint32_t->unsigned int
        public uint value;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_uint64_attr
    {

        /// pj_stun_attr_hdr
        public pj_stun_attr_hdr hdr;

        /// pj_timestamp
        public pj_timestamp value;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_binary_attr
    {

        /// pj_stun_attr_hdr
        public pj_stun_attr_hdr hdr;

        /// pj_uint32_t->unsigned int
        public uint magic;

        /// unsigned int
        public uint length;

        /// pj_uint8_t*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string data;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pj_stun_msgint_attr
    {

        /// pj_stun_attr_hdr
        public pj_stun_attr_hdr hdr;

        /// pj_uint8_t[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
        public string hmac;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_errcode_attr
    {

        /// pj_stun_attr_hdr
        public pj_stun_attr_hdr hdr;

        /// int
        public int err_code;

        /// pj_str_t
        public pj_str_t reason;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_unknown_attr
    {

        /// pj_stun_attr_hdr
        public pj_stun_attr_hdr hdr;

        /// unsigned int
        public uint attr_count;

        /// pj_uint16_t[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] attrs;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_msg
    {

        /// pj_stun_msg_hdr
        public pj_stun_msg_hdr hdr;

        /// unsigned int
        public uint attr_count;

        /// pj_stun_attr_hdr*[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = System.Runtime.InteropServices.UnmanagedType.SysUInt)]
        public System.IntPtr[] attr;
    }

    public enum pj_stun_decode_options
    {

        /// PJ_STUN_IS_DATAGRAM -> 1
        PJ_STUN_IS_DATAGRAM = 1,

        /// PJ_STUN_CHECK_PACKET -> 2
        PJ_STUN_CHECK_PACKET = 2,

        /// PJ_STUN_NO_AUTHENTICATE -> 4
        PJ_STUN_NO_AUTHENTICATE = 4,

        /// PJ_STUN_NO_FINGERPRINT_CHECK -> 8
        PJ_STUN_NO_FINGERPRINT_CHECK = 8,
    }

    public enum pj_stun_auth_type
    {

        /// PJ_STUN_AUTH_NONE -> 0
        PJ_STUN_AUTH_NONE = 0,

        /// PJ_STUN_AUTH_SHORT_TERM -> 1
        PJ_STUN_AUTH_SHORT_TERM = 1,

        /// PJ_STUN_AUTH_LONG_TERM -> 2
        PJ_STUN_AUTH_LONG_TERM = 2,
    }

    public enum pj_stun_auth_cred_type
    {

        PJ_STUN_AUTH_CRED_STATIC,

        PJ_STUN_AUTH_CRED_DYNAMIC,
    }

    public enum pj_stun_passwd_type
    {

        /// PJ_STUN_PASSWD_PLAIN -> 0
        PJ_STUN_PASSWD_PLAIN = 0,

        /// PJ_STUN_PASSWD_HASHED -> 1
        PJ_STUN_PASSWD_HASHED = 1,
    }

    /// Return Type: pj_status_t->int
    ///user_data: void*
    ///pool: pj_pool_t*
    ///realm: pj_str_t*
    ///nonce: pj_str_t*
    public delegate int _get_auth(System.IntPtr user_data, ref pj_pool_t pool, ref pj_str_t realm, ref pj_str_t nonce);

    /// Return Type: pj_status_t->int
    ///msg: pj_stun_msg*
    ///user_data: void*
    ///pool: pj_pool_t*
    ///realm: pj_str_t*
    ///username: pj_str_t*
    ///nonce: pj_str_t*
    ///data_type: pj_stun_passwd_type*
    ///data: pj_str_t*
    public delegate int _get_cred(ref pj_stun_msg msg, System.IntPtr user_data, ref pj_pool_t pool, ref pj_str_t realm, ref pj_str_t username, ref pj_str_t nonce, ref pj_stun_passwd_type data_type, ref pj_str_t data);

    /// Return Type: pj_status_t->int
    ///msg: pj_stun_msg*
    ///user_data: void*
    ///realm: pj_str_t*
    ///username: pj_str_t*
    ///pool: pj_pool_t*
    ///data_type: pj_stun_passwd_type*
    ///data: pj_str_t*
    public delegate int _get_password(ref pj_stun_msg msg, System.IntPtr user_data, ref pj_str_t realm, ref pj_str_t username, ref pj_pool_t pool, ref pj_stun_passwd_type data_type, ref pj_str_t data);

    /// Return Type: pj_bool_t->int
    ///msg: pj_stun_msg*
    ///user_data: void*
    ///realm: pj_str_t*
    ///username: pj_str_t*
    ///nonce: pj_str_t*
    public delegate int _verify_nonce(ref pj_stun_msg msg, System.IntPtr user_data, ref pj_str_t realm, ref pj_str_t username, ref pj_str_t nonce);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_auth_cred
    {

        /// pj_stun_auth_cred_type
        public pj_stun_auth_cred_type type;

        /// Anonymous_5d329b9d_5b05_4095_9710_1f4fa75f6b7a
        public Anonymous_5d329b9d_5b05_4095_9710_1f4fa75f6b7a data;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_req_cred_info
    {

        /// pj_str_t
        public pj_str_t realm;

        /// pj_str_t
        public pj_str_t username;

        /// pj_str_t
        public pj_str_t nonce;

        /// pj_str_t
        public pj_str_t auth_key;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_rx_data
    {

        /// pj_stun_msg*
        public System.IntPtr msg;

        /// pj_stun_req_cred_info
        public pj_stun_req_cred_info info;
    }

    public enum pj_stun_sess_msg_log_flag
    {

        /// PJ_STUN_SESS_LOG_TX_REQ -> 1
        PJ_STUN_SESS_LOG_TX_REQ = 1,

        /// PJ_STUN_SESS_LOG_TX_RES -> 2
        PJ_STUN_SESS_LOG_TX_RES = 2,

        /// PJ_STUN_SESS_LOG_TX_IND -> 4
        PJ_STUN_SESS_LOG_TX_IND = 4,

        /// PJ_STUN_SESS_LOG_RX_REQ -> 8
        PJ_STUN_SESS_LOG_RX_REQ = 8,

        /// PJ_STUN_SESS_LOG_RX_RES -> 16
        PJ_STUN_SESS_LOG_RX_RES = 16,

        /// PJ_STUN_SESS_LOG_RX_IND -> 32
        PJ_STUN_SESS_LOG_RX_IND = 32,
    }

    public enum pj_ice_cand_type
    {

        PJ_ICE_CAND_TYPE_HOST,

        PJ_ICE_CAND_TYPE_SRFLX,

        PJ_ICE_CAND_TYPE_PRFLX,

        PJ_ICE_CAND_TYPE_RELAYED,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_ice_sess_cand
    {

        /// pj_ice_cand_type
        public pj_ice_cand_type type;

        /// pj_status_t->int
        public int status;

        /// pj_uint8_t->unsigned char
        public byte comp_id;

        /// pj_uint8_t->unsigned char
        public byte transport_id;

        /// pj_uint16_t->unsigned short
        public ushort local_pref;

        /// pj_str_t
        public pj_str_t foundation;

        /// pj_uint32_t->unsigned int
        public uint prio;

        /// pj_sockaddr
        public pj_sockaddr addr;

        /// pj_sockaddr
        public pj_sockaddr base_addr;

        /// pj_sockaddr
        public pj_sockaddr rel_addr;
    }

    public enum pj_ice_sess_check_state
    {

        PJ_ICE_SESS_CHECK_STATE_FROZEN,

        PJ_ICE_SESS_CHECK_STATE_WAITING,

        PJ_ICE_SESS_CHECK_STATE_IN_PROGRESS,

        PJ_ICE_SESS_CHECK_STATE_SUCCEEDED,

        PJ_ICE_SESS_CHECK_STATE_FAILED,
    }

    public enum pj_ice_sess_checklist_state
    {

        PJ_ICE_SESS_CHECKLIST_ST_IDLE,

        PJ_ICE_SESS_CHECKLIST_ST_RUNNING,

        PJ_ICE_SESS_CHECKLIST_ST_COMPLETED,
    }

    public enum pj_ice_sess_role
    {

        PJ_ICE_SESS_ROLE_UNKNOWN,

        PJ_ICE_SESS_ROLE_CONTROLLED,

        PJ_ICE_SESS_ROLE_CONTROLLING,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_ice_rx_check
    {

        /// pj_ice_rx_check*
        public System.IntPtr prev;

        /// pj_ice_rx_check*
        public System.IntPtr next;

        /// unsigned int
        public uint comp_id;

        /// unsigned int
        public uint transport_id;

        /// pj_sockaddr
        public pj_sockaddr src_addr;

        /// unsigned int
        public uint src_addr_len;

        /// pj_bool_t->int
        public int use_candidate;

        /// pj_uint32_t->unsigned int
        public uint priority;

        /// pj_stun_uint64_attr*
        public System.IntPtr role_attr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_ice_sess_options
    {

        /// pj_bool_t->int
        public int aggressive;

        /// unsigned int
        public uint nominated_check_delay;

        /// int
        public int controlled_agent_want_nom_timeout;
    }

    public enum pj_stun_sock_op
    {

        /// PJ_STUN_SOCK_DNS_OP -> 1
        PJ_STUN_SOCK_DNS_OP = 1,

        PJ_STUN_SOCK_BINDING_OP,

        PJ_STUN_SOCK_KEEP_ALIVE_OP,

        PJ_STUN_SOCK_MAPPED_ADDR_CHANGE,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_sock_info
    {

        /// pj_sockaddr
        public pj_sockaddr bound_addr;

        /// pj_sockaddr
        public pj_sockaddr srv_addr;

        /// pj_sockaddr
        public pj_sockaddr mapped_addr;

        /// unsigned int
        public uint alias_cnt;

        /// pj_sockaddr[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public pj_sockaddr[] aliases;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_sock_cfg
    {

        /// unsigned int
        public uint max_pkt_size;

        /// unsigned int
        public uint async_cnt;

        /// pj_sockaddr
        public pj_sockaddr bound_addr;

        /// int
        public int ka_interval;
    }

    public enum pj_turn_tp_type
    {

        /// PJ_TURN_TP_UDP -> 17
        PJ_TURN_TP_UDP = 17,

        /// PJ_TURN_TP_TCP -> 6
        PJ_TURN_TP_TCP = 6,

        /// PJ_TURN_TP_TLS -> 255
        PJ_TURN_TP_TLS = 255,
    }

    public enum pj_turn_state_t
    {

        PJ_TURN_STATE_NULL,

        PJ_TURN_STATE_RESOLVING,

        PJ_TURN_STATE_RESOLVED,

        PJ_TURN_STATE_ALLOCATING,

        PJ_TURN_STATE_READY,

        PJ_TURN_STATE_DEALLOCATING,

        PJ_TURN_STATE_DEALLOCATED,

        PJ_TURN_STATE_DESTROYING,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_turn_channel_data
    {

        /// pj_uint16_t->unsigned short
        public ushort ch_number;

        /// pj_uint16_t->unsigned short
        public ushort length;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_turn_alloc_param
    {

        /// int
        public int bandwidth;

        /// int
        public int lifetime;

        /// int
        public int ka_interval;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_turn_session_info
    {

        /// pj_turn_state_t
        public pj_turn_state_t state;

        /// pj_status_t->int
        public int last_status;

        /// pj_turn_tp_type
        public pj_turn_tp_type conn_type;

        /// pj_sockaddr
        public pj_sockaddr server;

        /// pj_sockaddr
        public pj_sockaddr mapped_addr;

        /// pj_sockaddr
        public pj_sockaddr relay_addr;

        /// int
        public int lifetime;
    }

    public enum pj_ice_strans_op
    {

        PJ_ICE_STRANS_OP_INIT,

        PJ_ICE_STRANS_OP_NEGOTIATION,
    }

    /// Return Type: void
    ///tp: pjmedia_transport*
    ///op: pj_ice_strans_op
    ///status: pj_status_t->int
    public delegate void pjmedia_ice_cb_on_ice_complete(ref pjmedia_transport tp, pj_ice_strans_op op, int status);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_ice_cb
    {

        /// pjmedia_ice_cb_on_ice_complete
        public pjmedia_ice_cb_on_ice_complete AnonymousMember1;
    }

    public enum pjmedia_transport_ice_options
    {

        /// PJMEDIA_ICE_NO_SRC_ADDR_CHECKING -> 1
        PJMEDIA_ICE_NO_SRC_ADDR_CHECKING = 1,
    }

    public enum pjmedia_srtp_crypto_option
    {

        /// PJMEDIA_SRTP_NO_ENCRYPTION -> 1
        PJMEDIA_SRTP_NO_ENCRYPTION = 1,

        /// PJMEDIA_SRTP_NO_AUTHENTICATION -> 2
        PJMEDIA_SRTP_NO_AUTHENTICATION = 2,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_srtp_crypto
    {

        /// pj_str_t
        public pj_str_t key;

        /// pj_str_t
        public pj_str_t name;

        /// unsigned int
        public uint flags;
    }

    public enum pjmedia_srtp_use
    {

        PJMEDIA_SRTP_DISABLED,

        PJMEDIA_SRTP_OPTIONAL,

        PJMEDIA_SRTP_MANDATORY,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_srtp_setting
    {

        /// pjmedia_srtp_use
        public pjmedia_srtp_use use;

        /// pj_bool_t->int
        public int close_member_tp;

        /// unsigned int
        public uint crypto_count;

        /// pjmedia_srtp_crypto[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public pjmedia_srtp_crypto[] crypto;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_srtp_info
    {

        /// pj_bool_t->int
        public int active;

        /// pjmedia_srtp_crypto
        public pjmedia_srtp_crypto rx_policy;

        /// pjmedia_srtp_crypto
        public pjmedia_srtp_crypto tx_policy;

        /// pjmedia_srtp_use
        public pjmedia_srtp_use use;

        /// pjmedia_srtp_use
        public pjmedia_srtp_use peer_use;
    }

    public enum pjmedia_transport_udp_options
    {

        /// PJMEDIA_UDP_NO_SRC_ADDR_CHECKING -> 1
        PJMEDIA_UDP_NO_SRC_ADDR_CHECKING = 1,
    }

    public enum pjmedia_file_player_option
    {

        /// PJMEDIA_FILE_NO_LOOP -> 1
        PJMEDIA_FILE_NO_LOOP = 1,
    }

    public enum pjmedia_file_writer_option
    {

        /// PJMEDIA_FILE_WRITE_PCM -> 0
        PJMEDIA_FILE_WRITE_PCM = 0,

        /// PJMEDIA_FILE_WRITE_ALAW -> 1
        PJMEDIA_FILE_WRITE_ALAW = 1,

        /// PJMEDIA_FILE_WRITE_ULAW -> 2
        PJMEDIA_FILE_WRITE_ULAW = 2,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_wave_hdr
    {

        /// Anonymous_493f2a2f_2df7_4488_b2c6_b0e054f612ae
        public Anonymous_493f2a2f_2df7_4488_b2c6_b0e054f612ae riff_hdr;

        /// Anonymous_4e0909fa_74e9_480d_9958_95f6e147a9dc
        public Anonymous_4e0909fa_74e9_480d_9958_95f6e147a9dc fmt_hdr;

        /// Anonymous_d58ae436_ef8c_4ebd_ae68_4e047c684d40
        public Anonymous_d58ae436_ef8c_4ebd_ae68_4e047c684d40 data_hdr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_wave_subchunk
    {

        /// pj_uint32_t->unsigned int
        public uint id;

        /// pj_uint32_t->unsigned int
        public uint len;
    }

    public enum pjmedia_wsola_option
    {

        /// PJMEDIA_WSOLA_NO_HANNING -> 1
        PJMEDIA_WSOLA_NO_HANNING = 1,

        /// PJMEDIA_WSOLA_NO_PLC -> 2
        PJMEDIA_WSOLA_NO_PLC = 2,

        /// PJMEDIA_WSOLA_NO_DISCARD -> 4
        PJMEDIA_WSOLA_NO_DISCARD = 4,

        /// PJMEDIA_WSOLA_NO_FADING -> 8
        PJMEDIA_WSOLA_NO_FADING = 8,
    }

    public enum pjmedia_speex_options
    {

        /// PJMEDIA_SPEEX_NO_NB -> 1
        PJMEDIA_SPEEX_NO_NB = 1,

        /// PJMEDIA_SPEEX_NO_WB -> 2
        PJMEDIA_SPEEX_NO_WB = 2,

        /// PJMEDIA_SPEEX_NO_UWB -> 4
        PJMEDIA_SPEEX_NO_UWB = 4,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjmedia_codec_passthrough_setting
    {

        /// unsigned int
        public uint fmt_cnt;

        /// pjmedia_format*
        public System.IntPtr fmts;

        /// unsigned int
        public uint ilbc_mode;
    }

    public enum pjsip_inv_state
    {

        PJSIP_INV_STATE_NULL,

        PJSIP_INV_STATE_CALLING,

        PJSIP_INV_STATE_INCOMING,

        PJSIP_INV_STATE_EARLY,

        PJSIP_INV_STATE_CONNECTING,

        PJSIP_INV_STATE_CONFIRMED,

        PJSIP_INV_STATE_DISCONNECTED,
    }

    public enum pjsip_inv_option
    {

        /// PJSIP_INV_SUPPORT_100REL -> 1
        PJSIP_INV_SUPPORT_100REL = 1,

        /// PJSIP_INV_SUPPORT_TIMER -> 2
        PJSIP_INV_SUPPORT_TIMER = 2,

        /// PJSIP_INV_SUPPORT_UPDATE -> 4
        PJSIP_INV_SUPPORT_UPDATE = 4,

        /// PJSIP_INV_REQUIRE_100REL -> 32
        PJSIP_INV_REQUIRE_100REL = 32,

        /// PJSIP_INV_REQUIRE_TIMER -> 64
        PJSIP_INV_REQUIRE_TIMER = 64,

        /// PJSIP_INV_ALWAYS_USE_TIMER -> 128
        PJSIP_INV_ALWAYS_USE_TIMER = 128,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_regc_info
    {

        /// pj_str_t
        public pj_str_t server_uri;

        /// pj_str_t
        public pj_str_t client_uri;

        /// pj_bool_t->int
        public int is_busy;

        /// pj_bool_t->int
        public int auto_reg;

        /// int
        public int interval;

        /// int
        public int next_reg;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_replaces_hdr
    {

        /// pjsip_replaces_hdr*
        public System.IntPtr prev;

        /// pjsip_replaces_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// pj_str_t
        public pj_str_t call_id;

        /// pj_str_t
        public pj_str_t to_tag;

        /// pj_str_t
        public pj_str_t from_tag;

        /// pj_bool_t->int
        public int early_only;

        /// pjsip_param
        public pjsip_param other_param;
    }

    public enum pjsip_evsub_state
    {

        PJSIP_EVSUB_STATE_NULL,

        PJSIP_EVSUB_STATE_SENT,

        PJSIP_EVSUB_STATE_ACCEPTED,

        PJSIP_EVSUB_STATE_PENDING,

        PJSIP_EVSUB_STATE_ACTIVE,

        PJSIP_EVSUB_STATE_TERMINATED,

        PJSIP_EVSUB_STATE_UNKNOWN,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_timer_setting
    {

        /// unsigned int
        public uint min_se;

        /// unsigned int
        public uint sess_expires;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_sess_expires_hdr
    {

        /// pjsip_sess_expires_hdr*
        public System.IntPtr prev;

        /// pjsip_sess_expires_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// unsigned int
        public uint sess_expires;

        /// pj_str_t
        public pj_str_t refresher;

        /// pjsip_param
        public pjsip_param other_param;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_min_se_hdr
    {

        /// pjsip_min_se_hdr*
        public System.IntPtr prev;

        /// pjsip_min_se_hdr*
        public System.IntPtr next;

        /// pjsip_hdr_e
        public pjsip_hdr_e type;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t sname;

        /// pjsip_hdr_vptr*
        public System.IntPtr vptr;

        /// unsigned int
        public uint min_se;

        /// pjsip_param
        public pjsip_param other_param;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_xml_attr
    {

        /// pj_xml_attr*
        public System.IntPtr prev;

        /// pj_xml_attr*
        public System.IntPtr next;

        /// pj_str_t
        public pj_str_t name;

        /// pj_str_t
        public pj_str_t value;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_xml_node_head
    {

        /// pj_xml_node*
        public System.IntPtr prev;

        /// pj_xml_node*
        public System.IntPtr next;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_xml_node
    {

        /// pj_xml_node*
        public System.IntPtr prev;

        /// pj_xml_node*
        public System.IntPtr next;

        /// pj_str_t
        public pj_str_t name;

        /// pj_xml_attr
        public pj_xml_attr attr_head;

        /// pj_xml_node_head
        public pj_xml_node_head node_head;

        /// pj_str_t
        public pj_str_t content;
    }

    /// Return Type: void
    ///param0: pj_pool_t*
    ///param1: pjpidf_status*
    public delegate void pjpidf_status_op_construct(ref pj_pool_t param0, ref pj_xml_node param1);

    /// Return Type: pj_bool_t->int
    ///param0: pjpidf_status*
    public delegate int pjpidf_status_op_is_basic_open(ref pj_xml_node param0);

    /// Return Type: void
    ///param0: pjpidf_status*
    ///param1: pj_bool_t->int
    public delegate void pjpidf_status_op_set_basic_open(ref pj_xml_node param0, int param1);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjpidf_status_op
    {

        /// pjpidf_status_op_construct
        public pjpidf_status_op_construct AnonymousMember1;

        /// pjpidf_status_op_is_basic_open
        public pjpidf_status_op_is_basic_open AnonymousMember2;

        /// pjpidf_status_op_set_basic_open
        public pjpidf_status_op_set_basic_open AnonymousMember3;
    }

    /// Return Type: void
    ///param0: pj_pool_t*
    ///param1: pjpidf_tuple*
    ///param2: pj_str_t*
    public delegate void pjpidf_tuple_op_construct(ref pj_pool_t param0, ref pj_xml_node param1, ref pj_str_t param2);

    /// Return Type: pj_str_t*
    ///param0: pjpidf_tuple*
    public delegate System.IntPtr pjpidf_tuple_op_get_id(ref pj_xml_node param0);

    /// Return Type: void
    ///param0: pj_pool_t*
    ///param1: pjpidf_tuple*
    ///param2: pj_str_t*
    public delegate void pjpidf_tuple_op_set_id(ref pj_pool_t param0, ref pj_xml_node param1, ref pj_str_t param2);

    /// Return Type: pjpidf_status*
    ///param0: pjpidf_tuple*
    public delegate System.IntPtr pjpidf_tuple_op_get_status(ref pj_xml_node param0);

    /// Return Type: pj_str_t*
    ///param0: pjpidf_tuple*
    public delegate System.IntPtr pjpidf_tuple_op_get_contact(ref pj_xml_node param0);

    /// Return Type: void
    ///param0: pj_pool_t*
    ///param1: pjpidf_tuple*
    ///param2: pj_str_t*
    public delegate void pjpidf_tuple_op_set_contact(ref pj_pool_t param0, ref pj_xml_node param1, ref pj_str_t param2);

    /// Return Type: void
    ///param0: pj_pool_t*
    ///param1: pjpidf_tuple*
    ///param2: pj_str_t*
    public delegate void pjpidf_tuple_op_set_contact_prio(ref pj_pool_t param0, ref pj_xml_node param1, ref pj_str_t param2);

    /// Return Type: pj_str_t*
    ///param0: pjpidf_tuple*
    public delegate System.IntPtr pjpidf_tuple_op_get_contact_prio(ref pj_xml_node param0);

    /// Return Type: pjpidf_note*
    ///param0: pj_pool_t*
    ///param1: pjpidf_tuple*
    ///param2: pj_str_t*
    public delegate System.IntPtr pjpidf_tuple_op_add_note(ref pj_pool_t param0, ref pj_xml_node param1, ref pj_str_t param2);

    /// Return Type: pjpidf_note*
    ///param0: pjpidf_tuple*
    public delegate System.IntPtr pjpidf_tuple_op_get_first_note(ref pj_xml_node param0);

    /// Return Type: pjpidf_note*
    ///param0: pjpidf_tuple*
    ///param1: pjpidf_note*
    public delegate System.IntPtr pjpidf_tuple_op_get_next_note(ref pj_xml_node param0, ref pj_xml_node param1);

    /// Return Type: pj_str_t*
    ///param0: pjpidf_tuple*
    public delegate System.IntPtr pjpidf_tuple_op_get_timestamp(ref pj_xml_node param0);

    /// Return Type: void
    ///param0: pj_pool_t*
    ///param1: pjpidf_tuple*
    ///param2: pj_str_t*
    public delegate void pjpidf_tuple_op_set_timestamp(ref pj_pool_t param0, ref pj_xml_node param1, ref pj_str_t param2);

    /// Return Type: void
    ///param0: pj_pool_t*
    ///param1: pjpidf_tuple*
    ///param2: pj_str_t*
    public delegate void pjpidf_tuple_op_set_timestamp_np(ref pj_pool_t param0, ref pj_xml_node param1, ref pj_str_t param2);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjpidf_tuple_op
    {

        /// pjpidf_tuple_op_construct
        public pjpidf_tuple_op_construct AnonymousMember1;

        /// pjpidf_tuple_op_get_id
        public pjpidf_tuple_op_get_id AnonymousMember2;

        /// pjpidf_tuple_op_set_id
        public pjpidf_tuple_op_set_id AnonymousMember3;

        /// pjpidf_tuple_op_get_status
        public pjpidf_tuple_op_get_status AnonymousMember4;

        /// pjpidf_tuple_op_get_contact
        public pjpidf_tuple_op_get_contact AnonymousMember5;

        /// pjpidf_tuple_op_set_contact
        public pjpidf_tuple_op_set_contact AnonymousMember6;

        /// pjpidf_tuple_op_set_contact_prio
        public pjpidf_tuple_op_set_contact_prio AnonymousMember7;

        /// pjpidf_tuple_op_get_contact_prio
        public pjpidf_tuple_op_get_contact_prio AnonymousMember8;

        /// pjpidf_tuple_op_add_note
        public pjpidf_tuple_op_add_note AnonymousMember9;

        /// pjpidf_tuple_op_get_first_note
        public pjpidf_tuple_op_get_first_note AnonymousMember10;

        /// pjpidf_tuple_op_get_next_note
        public pjpidf_tuple_op_get_next_note AnonymousMember11;

        /// pjpidf_tuple_op_get_timestamp
        public pjpidf_tuple_op_get_timestamp AnonymousMember12;

        /// pjpidf_tuple_op_set_timestamp
        public pjpidf_tuple_op_set_timestamp AnonymousMember13;

        /// pjpidf_tuple_op_set_timestamp_np
        public pjpidf_tuple_op_set_timestamp_np AnonymousMember14;
    }

    /// Return Type: void
    ///param0: pj_pool_t*
    ///param1: pjpidf_pres*
    ///param2: pj_str_t*
    public delegate void pjpidf_pres_op_construct(ref pj_pool_t param0, ref pj_xml_node param1, ref pj_str_t param2);

    /// Return Type: pjpidf_tuple*
    ///param0: pj_pool_t*
    ///param1: pjpidf_pres*
    ///param2: pj_str_t*
    public delegate System.IntPtr pjpidf_pres_op_add_tuple(ref pj_pool_t param0, ref pj_xml_node param1, ref pj_str_t param2);

    /// Return Type: pjpidf_tuple*
    ///param0: pjpidf_pres*
    public delegate System.IntPtr pjpidf_pres_op_get_first_tuple(ref pj_xml_node param0);

    /// Return Type: pjpidf_tuple*
    ///param0: pjpidf_pres*
    ///param1: pjpidf_tuple*
    public delegate System.IntPtr pjpidf_pres_op_get_next_tuple(ref pj_xml_node param0, ref pj_xml_node param1);

    /// Return Type: pjpidf_tuple*
    ///param0: pjpidf_pres*
    ///param1: pj_str_t*
    public delegate System.IntPtr pjpidf_pres_op_find_tuple(ref pj_xml_node param0, ref pj_str_t param1);

    /// Return Type: void
    ///param0: pjpidf_pres*
    ///param1: pjpidf_tuple*
    public delegate void pjpidf_pres_op_remove_tuple(ref pj_xml_node param0, ref pj_xml_node param1);

    /// Return Type: pjpidf_note*
    ///param0: pj_pool_t*
    ///param1: pjpidf_pres*
    ///param2: pj_str_t*
    public delegate System.IntPtr pjpidf_pres_op_add_note(ref pj_pool_t param0, ref pj_xml_node param1, ref pj_str_t param2);

    /// Return Type: pjpidf_note*
    ///param0: pjpidf_pres*
    public delegate System.IntPtr pjpidf_pres_op_get_first_note(ref pj_xml_node param0);

    /// Return Type: pjpidf_note*
    ///param0: pjpidf_pres*
    ///param1: pjpidf_note*
    public delegate System.IntPtr pjpidf_pres_op_get_next_note(ref pj_xml_node param0, ref pj_xml_node param1);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjpidf_pres_op
    {

        /// pjpidf_pres_op_construct
        public pjpidf_pres_op_construct AnonymousMember1;

        /// pjpidf_pres_op_add_tuple
        public pjpidf_pres_op_add_tuple AnonymousMember2;

        /// pjpidf_pres_op_get_first_tuple
        public pjpidf_pres_op_get_first_tuple AnonymousMember3;

        /// pjpidf_pres_op_get_next_tuple
        public pjpidf_pres_op_get_next_tuple AnonymousMember4;

        /// pjpidf_pres_op_find_tuple
        public pjpidf_pres_op_find_tuple AnonymousMember5;

        /// pjpidf_pres_op_remove_tuple
        public pjpidf_pres_op_remove_tuple AnonymousMember6;

        /// pjpidf_pres_op_add_note
        public pjpidf_pres_op_add_note AnonymousMember7;

        /// pjpidf_pres_op_get_first_note
        public pjpidf_pres_op_get_first_note AnonymousMember8;

        /// pjpidf_pres_op_get_next_note
        public pjpidf_pres_op_get_next_note AnonymousMember9;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjpidf_op_desc
    {

        /// pjpidf_pres_op
        public pjpidf_pres_op pres;

        /// pjpidf_tuple_op
        public pjpidf_tuple_op tuple;

        /// pjpidf_status_op
        public pjpidf_status_op status;
    }

    public enum pjrpid_activity
    {

        PJRPID_ACTIVITY_UNKNOWN,

        PJRPID_ACTIVITY_AWAY,

        PJRPID_ACTIVITY_BUSY,
    }

    public enum pjrpid_element_type
    {

        PJRPID_ELEMENT_TYPE_PERSON,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjrpid_element
    {

        /// pjrpid_element_type
        public pjrpid_element_type type;

        /// pj_str_t
        public pj_str_t id;

        /// pjrpid_activity
        public pjrpid_activity activity;

        /// pj_str_t
        public pj_str_t note;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsip_pres_status
    {

        /// unsigned int
        public uint info_cnt;

        /// Anonymous_3f860102_f882_4a29_98fd_fe70f9d7a321[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public Anonymous_3f860102_f882_4a29_98fd_fe70f9d7a321[] info;

        /// pj_bool_t->int
        public int _is_valid;
    }

    public enum pj_stun_nat_type
    {

        PJ_STUN_NAT_TYPE_UNKNOWN,

        PJ_STUN_NAT_TYPE_ERR_UNKNOWN,

        PJ_STUN_NAT_TYPE_OPEN,

        PJ_STUN_NAT_TYPE_BLOCKED,

        PJ_STUN_NAT_TYPE_SYMMETRIC_UDP,

        PJ_STUN_NAT_TYPE_FULL_CONE,

        PJ_STUN_NAT_TYPE_SYMMETRIC,

        PJ_STUN_NAT_TYPE_RESTRICTED,

        PJ_STUN_NAT_TYPE_PORT_RESTRICTED,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_nat_detect_result
    {

        /// pj_status_t->int
        public int status;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string status_text;

        /// pj_stun_nat_type
        public pj_stun_nat_type nat_type;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string nat_type_name;
    }

    /// Return Type: void
    ///user_data: void*
    ///res: pj_stun_nat_detect_result*
    public delegate void pj_stun_nat_detect_cb(System.IntPtr user_data, ref pj_stun_nat_detect_result res);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_getopt_option
    {

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string name;

        /// int
        public int has_arg;

        /// int*
        public System.IntPtr flag;

        /// int
        public int val;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_crc32_context
    {

        /// pj_uint32_t->unsigned int
        public uint crc_state;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pj_md5_context
    {

        /// pj_uint32_t[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U4)]
        public uint[] buf;

        /// pj_uint32_t[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U4)]
        public uint[] bits;

        /// pj_uint8_t[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string @in;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pj_hmac_md5_context
    {

        /// pj_md5_context
        public pj_md5_context context;

        /// pj_uint8_t[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string k_opad;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pj_sha1_context
    {

        /// pj_uint32_t[5]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U4)]
        public uint[] state;

        /// pj_uint32_t[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U4)]
        public uint[] count;

        /// pj_uint8_t[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string buffer;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pj_hmac_sha1_context
    {

        /// pj_sha1_context
        public pj_sha1_context context;

        /// pj_uint8_t[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string k_opad;
    }

    public enum pj_dns_srv_option
    {

        /// PJ_DNS_SRV_FALLBACK_A -> 1
        PJ_DNS_SRV_FALLBACK_A = 1,

        /// PJ_DNS_SRV_FALLBACK_AAAA -> 2
        PJ_DNS_SRV_FALLBACK_AAAA = 2,

        /// PJ_DNS_SRV_RESOLVE_AAAA -> 4
        PJ_DNS_SRV_RESOLVE_AAAA = 4,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_dns_srv_record
    {

        /// unsigned int
        public uint count;

        /// Anonymous_30c1cc4f_b70b_42fe_91de_97b5a067b9cc[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public Anonymous_30c1cc4f_b70b_42fe_91de_97b5a067b9cc[] entry;
    }

    /// Return Type: void
    ///user_data: void*
    ///status: pj_status_t->int
    ///rec: pj_dns_srv_record*
    public delegate void pj_dns_srv_resolver_cb(System.IntPtr user_data, int status, ref pj_dns_srv_record rec);

    public enum pjstun_msg_type
    {

        /// PJSTUN_BINDING_REQUEST -> 0x0001
        PJSTUN_BINDING_REQUEST = 1,

        /// PJSTUN_BINDING_RESPONSE -> 0x0101
        PJSTUN_BINDING_RESPONSE = 257,

        /// PJSTUN_BINDING_ERROR_RESPONSE -> 0x0111
        PJSTUN_BINDING_ERROR_RESPONSE = 273,

        /// PJSTUN_SHARED_SECRET_REQUEST -> 0x0002
        PJSTUN_SHARED_SECRET_REQUEST = 2,

        /// PJSTUN_SHARED_SECRET_RESPONSE -> 0x0102
        PJSTUN_SHARED_SECRET_RESPONSE = 258,

        /// PJSTUN_SHARED_SECRET_ERROR_RESPONSE -> 0x0112
        PJSTUN_SHARED_SECRET_ERROR_RESPONSE = 274,
    }

    public enum pjstun_attr_type
    {

        /// PJSTUN_ATTR_MAPPED_ADDR -> 1
        PJSTUN_ATTR_MAPPED_ADDR = 1,

        PJSTUN_ATTR_RESPONSE_ADDR,

        PJSTUN_ATTR_CHANGE_REQUEST,

        PJSTUN_ATTR_SOURCE_ADDR,

        PJSTUN_ATTR_CHANGED_ADDR,

        PJSTUN_ATTR_USERNAME,

        PJSTUN_ATTR_PASSWORD,

        PJSTUN_ATTR_MESSAGE_INTEGRITY,

        PJSTUN_ATTR_ERROR_CODE,

        PJSTUN_ATTR_UNKNOWN_ATTRIBUTES,

        PJSTUN_ATTR_REFLECTED_FORM,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjstun_msg_hdr
    {

        /// pj_uint16_t->unsigned short
        public ushort type;

        /// pj_uint16_t->unsigned short
        public ushort length;

        /// pj_uint32_t[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U4)]
        public uint[] tsx;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjstun_attr_hdr
    {

        /// pj_uint16_t->unsigned short
        public ushort type;

        /// pj_uint16_t->unsigned short
        public ushort length;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjstun_mapped_addr_attr
    {

        /// pjstun_attr_hdr
        public pjstun_attr_hdr hdr;

        /// pj_uint8_t->unsigned char
        public byte ignored;

        /// pj_uint8_t->unsigned char
        public byte family;

        /// pj_uint16_t->unsigned short
        public ushort port;

        /// pj_uint32_t->unsigned int
        public uint addr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjstun_change_request_attr
    {

        /// pjstun_attr_hdr
        public pjstun_attr_hdr hdr;

        /// pj_uint32_t->unsigned int
        public uint value;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjstun_username_attr
    {

        /// pjstun_attr_hdr
        public pjstun_attr_hdr hdr;

        /// pj_uint32_t[1]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U4)]
        public uint[] value;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pjstun_error_code_attr
    {

        /// pjstun_attr_hdr
        public pjstun_attr_hdr hdr;

        /// pj_uint16_t->unsigned short
        public ushort ignored;

        /// pj_uint8_t->unsigned char
        public byte err_class;

        /// pj_uint8_t->unsigned char
        public byte number;

        /// char[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string reason;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjstun_msg
    {

        /// pjstun_msg_hdr*
        public System.IntPtr hdr;

        /// int
        public int attr_count;

        /// pjstun_attr_hdr*[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = System.Runtime.InteropServices.UnmanagedType.SysUInt)]
        public System.IntPtr[] attr;
    }

    public enum pj_pcap_link_type
    {

        /// PJ_PCAP_LINK_TYPE_ETH -> 1
        PJ_PCAP_LINK_TYPE_ETH = 1,
    }

    public enum pj_pcap_proto_type
    {

        /// PJ_PCAP_PROTO_TYPE_UDP -> 17
        PJ_PCAP_PROTO_TYPE_UDP = 17,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_pcap_udp_hdr
    {

        /// pj_uint16_t->unsigned short
        public ushort src_port;

        /// pj_uint16_t->unsigned short
        public ushort dst_port;

        /// pj_uint16_t->unsigned short
        public ushort len;

        /// pj_uint16_t->unsigned short
        public ushort csum;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_pcap_filter
    {

        /// pj_pcap_link_type
        public pj_pcap_link_type link;

        /// pj_pcap_proto_type
        public pj_pcap_proto_type proto;

        /// pj_uint32_t->unsigned int
        public uint ip_src;

        /// pj_uint32_t->unsigned int
        public uint ip_dst;

        /// pj_uint16_t->unsigned short
        public ushort src_port;

        /// pj_uint16_t->unsigned short
        public ushort dst_port;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_activesock_cfg
    {

        /// unsigned int
        public uint async_cnt;

        /// int
        public int concurrency;

        /// pj_bool_t->int
        public int whole_data;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_hostent
    {

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string h_name;

        /// char**
        public System.IntPtr h_aliases;

        /// int
        public int h_addrtype;

        /// int
        public int h_length;

        /// char**
        public System.IntPtr h_addr_list;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pj_addrinfo
    {

        /// char[128]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
        public string ai_canonname;

        /// pj_sockaddr
        public pj_sockaddr ai_addr;
    }

    public enum pj_log_decoration
    {

        /// PJ_LOG_HAS_DAY_NAME -> 1
        PJ_LOG_HAS_DAY_NAME = 1,

        /// PJ_LOG_HAS_YEAR -> 2
        PJ_LOG_HAS_YEAR = 2,

        /// PJ_LOG_HAS_MONTH -> 4
        PJ_LOG_HAS_MONTH = 4,

        /// PJ_LOG_HAS_DAY_OF_MON -> 8
        PJ_LOG_HAS_DAY_OF_MON = 8,

        /// PJ_LOG_HAS_TIME -> 16
        PJ_LOG_HAS_TIME = 16,

        /// PJ_LOG_HAS_MICRO_SEC -> 32
        PJ_LOG_HAS_MICRO_SEC = 32,

        /// PJ_LOG_HAS_SENDER -> 64
        PJ_LOG_HAS_SENDER = 64,

        /// PJ_LOG_HAS_NEWLINE -> 128
        PJ_LOG_HAS_NEWLINE = 128,

        /// PJ_LOG_HAS_CR -> 256
        PJ_LOG_HAS_CR = 256,

        /// PJ_LOG_HAS_SPACE -> 512
        PJ_LOG_HAS_SPACE = 512,

        /// PJ_LOG_HAS_COLOR -> 1024
        PJ_LOG_HAS_COLOR = 1024,

        /// PJ_LOG_HAS_LEVEL_TEXT -> 2048
        PJ_LOG_HAS_LEVEL_TEXT = 2048,

        /// PJ_LOG_HAS_THREAD_ID -> 4096
        PJ_LOG_HAS_THREAD_ID = 4096,
    }

    /// Return Type: void
    ///level: int
    ///data: char*
    ///len: int
    public delegate void pj_log_func(int level, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string data, int len);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_file_stat
    {

        /// pj_off_t->pj_int64_t->__int64
        public long size;

        /// pj_time_val
        public pj_time_val atime;

        /// pj_time_val
        public pj_time_val mtime;

        /// pj_time_val
        public pj_time_val ctime;
    }

    public enum pj_file_access
    {

        /// PJ_O_RDONLY -> 0x1101
        PJ_O_RDONLY = 4353,

        /// PJ_O_WRONLY -> 0x1102
        PJ_O_WRONLY = 4354,

        /// PJ_O_RDWR -> 0x1103
        PJ_O_RDWR = 4355,

        /// PJ_O_APPEND -> 0x1108
        PJ_O_APPEND = 4360,
    }

    public enum pj_file_seek_type
    {

        /// PJ_SEEK_SET -> 0x1201
        PJ_SEEK_SET = 4609,

        /// PJ_SEEK_CUR -> 0x1202
        PJ_SEEK_CUR = 4610,

        /// PJ_SEEK_END -> 0x1203
        PJ_SEEK_END = 4611,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public struct pj_ip_route_entry
    {

        /// Anonymous_ba5c8abb_977a_4b30_9369_4a8ab7380a3f
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_ba5c8abb_977a_4b30_9369_4a8ab7380a3f ipv4;
    }

    public enum pj_rbcolor_t
    {

        PJ_RBCOLOR_BLACK,

        PJ_RBCOLOR_RED,
    }

    /// Return Type: int
    ///key1: void*
    ///key2: void*
    public delegate int pj_rbtree_comp(System.IntPtr key1, System.IntPtr key2);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_fd_set_t
    {

        /// pj_sock_t[5004]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5004, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] data;
    }

    /// Return Type: void
    ///level: int
    ///data: char*
    ///len: int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_logging_config_cb(int level, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string data, int len);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 2)]
    public class pjsua_logging_config
    {

        /// pj_bool_t->int
        public int msg_logging;

        /// unsigned int
        public uint level;

        /// unsigned int
        public uint console_level;

        /// unsigned int
        public uint decor;

        /// pj_str_t
        public pj_str_t log_filename;

        /// unsigned int
        public uint log_file_flags;

        /// pjsua_logging_config_cb
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_logging_config_cb AnonymousMember1;
    }

    /// Return Type: void
    ///call_id: pjsua_call_id->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_call_media_state(int call_id);

    /// Return Type: void
    ///call_id: pjsua_call_id->int
    ///digit: int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_dtmf_digit(int call_id, int digit);

    /// Return Type: void
    ///call_id: pjsua_call_id->int
    ///dst: pj_str_t*
    ///code: pjsip_status_code*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_call_transfer_request(int call_id, ref pj_str_t dst, ref pjsip_status_code code);

    /// Return Type: void
    ///call_id: pjsua_call_id->int
    ///st_code: int
    ///st_text: pj_str_t*
    ///final: pj_bool_t->int
    ///p_cont: pj_bool_t*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_call_transfer_status(int call_id, int st_code, ref pj_str_t st_text, int final, ref int p_cont);

    /// Return Type: void
    ///old_call_id: pjsua_call_id->int
    ///new_call_id: pjsua_call_id->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_call_replaced(int old_call_id, int new_call_id);

    /// Return Type: void
    ///acc_id: pjsua_acc_id->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_reg_state(int acc_id);

    /// Return Type: void
    ///buddy_id: pjsua_buddy_id->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_buddy_state(int buddy_id);

    /// Return Type: void
    ///call_id: pjsua_call_id->int
    ///from: pj_str_t*
    ///to: pj_str_t*
    ///contact: pj_str_t*
    ///mime_type: pj_str_t*
    ///body: pj_str_t*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_pager(int call_id, ref pj_str_t from, ref pj_str_t to, ref pj_str_t contact, ref pj_str_t mime_type, ref pj_str_t body);

    /// Return Type: void
    ///call_id: pjsua_call_id->int
    ///to: pj_str_t*
    ///body: pj_str_t*
    ///user_data: void*
    ///status: pjsip_status_code
    ///reason: pj_str_t*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_pager_status(int call_id, ref pj_str_t to, ref pj_str_t body, System.IntPtr user_data, pjsip_status_code status, ref pj_str_t reason);

    /// Return Type: void
    ///call_id: pjsua_call_id->int
    ///from: pj_str_t*
    ///to: pj_str_t*
    ///contact: pj_str_t*
    ///is_typing: pj_bool_t->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_typing(int call_id, ref pj_str_t from, ref pj_str_t to, ref pj_str_t contact, int is_typing);

    /// Return Type: void
    ///res: pj_stun_nat_detect_result*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_nat_detect(ref pj_stun_nat_detect_result res);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public class pjsua_msg_data
    {

        /// pjsip_hdr
        public pjsip_hdr hdr_list;

        /// pj_str_t
        public pj_str_t content_type;

        /// pj_str_t
        public pj_str_t msg_body;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pj_stun_resolve_result
    {

        /// void*
        public System.IntPtr token;

        /// pj_status_t->int
        public int status;

        /// pj_str_t
        public pj_str_t name;

        /// pj_sockaddr
        public pj_sockaddr addr;
    }

    /// Return Type: void
    ///result: pj_stun_resolve_result*
    public delegate void pj_stun_resolve_cb(ref pj_stun_resolve_result result);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public class pjsua_transport_config
    {

        /// unsigned int
        public uint port;

        /// pj_str_t
        public pj_str_t public_addr;

        /// pj_str_t
        public pj_str_t bound_addr;

        /// pjsip_tls_setting
        public pjsip_tls_setting tls_setting = new pjsip_tls_setting();
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public class pjsua_transport_info
    {

        /// pjsua_transport_id->int
        public int id;

        /// pjsip_transport_type_e
        public pjsip_transport_type_e type;

        /// pj_str_t
        public pj_str_t type_name;

        /// pj_str_t
        public pj_str_t info;

        /// unsigned int
        public uint flag;

        /// unsigned int
        public uint addr_len;

        /// pj_sockaddr
        public pj_sockaddr local_addr;

        /// pjsip_host_port
        public pjsip_host_port local_name;

        /// unsigned int
        public uint usage_count;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public class pjsua_acc_config
    {

        /// void*
        public System.IntPtr user_data;

        /// int
        public int priority;

        /// pj_str_t
        public pj_str_t id;

        /// pj_str_t
        public pj_str_t reg_uri;

        /// pj_bool_t->int
        public int publish_enabled;

        /// pjsip_auth_clt_pref
        public pjsip_auth_clt_pref auth_pref;

        /// pj_str_t
        public pj_str_t pidf_tuple_id;

        /// pj_str_t
        public pj_str_t force_contact;

        /// pj_str_t
        public pj_str_t contact_params;

        /// pj_str_t
        public pj_str_t contact_uri_params;

        /// pj_bool_t->int
        public int require_100rel;

        /// pj_bool_t->int
        public int require_timer;

        /// pjsip_timer_setting
        public pjsip_timer_setting timer_setting;

        /// unsigned int
        public uint proxy_cnt;

        /// pj_str_t[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public pj_str_t[] proxy = new pj_str_t[8];

        /// unsigned int
        public uint reg_timeout;

        /// unsigned int
        public uint cred_count;

        /// pjsip_cred_info[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public pjsip_cred_info[] cred_info = new pjsip_cred_info[8];

        /// pjsua_transport_id->int
        public int transport_id;

        /// pj_bool_t->int
        public int allow_contact_rewrite;

        /// unsigned int
        public uint ka_interval;

        /// pj_str_t
        public pj_str_t ka_data;

        /// pjmedia_srtp_use
        public pjmedia_srtp_use use_srtp;

        /// int
        public int srtp_secure_signaling;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pjsua_acc_info
    {

        /// pjsua_acc_id->int
        public int id;

        /// pj_bool_t->int
        public int is_default;

        /// pj_str_t
        public pj_str_t acc_uri;

        /// pj_bool_t->int
        public int has_registration;

        /// int
        public int expires;

        /// pjsip_status_code
        public pjsip_status_code status;

        /// pj_str_t
        public pj_str_t status_text;

        /// pj_bool_t->int
        public int online_status;

        /// pj_str_t
        public pj_str_t online_status_text;

        /// pjrpid_element
        public pjrpid_element rpid;

        /// char[]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
        public string buf_;
    }

    public enum pjsua_call_media_status
    {

        PJSUA_CALL_MEDIA_NONE,

        PJSUA_CALL_MEDIA_ACTIVE,

        PJSUA_CALL_MEDIA_LOCAL_HOLD,

        PJSUA_CALL_MEDIA_REMOTE_HOLD,

        PJSUA_CALL_MEDIA_ERROR,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsua_call_info
    {

        /// pjsua_call_id->int
        public int id;

        /// pjsip_role_e
        public pjsip_role_e role;

        /// pjsua_acc_id->int
        public int acc_id;

        /// pj_str_t
        public pj_str_t local_info;

        /// pj_str_t
        public pj_str_t local_contact;

        /// pj_str_t
        public pj_str_t remote_info;

        /// pj_str_t
        public pj_str_t remote_contact;

        /// pj_str_t
        public pj_str_t call_id;

        /// pjsip_inv_state
        public pjsip_inv_state state;

        /// pj_str_t
        public pj_str_t state_text;

        /// pjsip_status_code
        public pjsip_status_code last_status;

        /// pj_str_t
        public pj_str_t last_status_text;

        /// pjsua_call_media_status
        public pjsua_call_media_status media_status;

        /// pjmedia_dir
        public pjmedia_dir media_dir;

        /// pjsua_conf_port_id->int
        public int conf_slot;

        /// pj_time_val
        public pj_time_val connect_duration;

        /// pj_time_val
        public pj_time_val total_duration;

        /// Anonymous_e56200bd_465b_43a5_bb0a_cf4096207b0c
        public Anonymous_e56200bd_465b_43a5_bb0a_cf4096207b0c buf_;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public class pjsua_buddy_config
    {

        /// pj_str_t
        public pj_str_t uri;

        /// pj_bool_t->int
        public int subscribe;

        /// void*
        public System.IntPtr user_data;
    }

    public enum pjsua_buddy_status
    {

        PJSUA_BUDDY_STATUS_UNKNOWN,

        PJSUA_BUDDY_STATUS_ONLINE,

        PJSUA_BUDDY_STATUS_OFFLINE,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pjsua_buddy_info
    {

        /// pjsua_buddy_id->int
        public int id;

        /// pj_str_t
        public pj_str_t uri;

        /// pj_str_t
        public pj_str_t contact;

        /// pjsua_buddy_status
        public pjsua_buddy_status status;

        /// pj_str_t
        public pj_str_t status_text;

        /// pj_bool_t->int
        public int monitor_pres;

        /// pjsip_evsub_state
        public pjsip_evsub_state sub_state;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string sub_state_name;

        /// pj_str_t
        public pj_str_t sub_term_reason;

        /// pjrpid_element
        public pjrpid_element rpid;

        /// pjsip_pres_status
        public pjsip_pres_status pres_status;

        /// char[512]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 512)]
        public string buf_;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public class pjsua_media_config
    {

        /// unsigned int
        public uint clock_rate;

        /// unsigned int
        public uint snd_clock_rate;

        /// unsigned int
        public uint channel_count;

        /// unsigned int
        public uint audio_frame_ptime;

        /// unsigned int
        public uint max_media_ports;

        /// pj_bool_t->int
        public int has_ioqueue;

        /// unsigned int
        public uint thread_cnt;

        /// unsigned int
        public uint quality;

        /// unsigned int
        public uint ptime;

        /// pj_bool_t->int
        public int no_vad;

        /// unsigned int
        public uint ilbc_mode;

        /// unsigned int
        public uint tx_drop_pct;

        /// unsigned int
        public uint rx_drop_pct;

        /// unsigned int
        public uint ec_options;

        /// unsigned int
        public uint ec_tail_len;

        /// unsigned int
        public uint snd_rec_latency;

        /// unsigned int
        public uint snd_play_latency;

        /// int
        public int jb_init;

        /// int
        public int jb_min_pre;

        /// int
        public int jb_max_pre;

        /// int
        public int jb_max;

        /// pj_bool_t->int
        public int enable_ice;

        /// int
        public int ice_max_host_cands;

        /// pj_ice_sess_options
        public pj_ice_sess_options ice_opt;

        /// pj_bool_t->int
        public int ice_no_rtcp;

        /// pj_bool_t->int
        public int enable_turn;

        /// pj_str_t
        public pj_str_t turn_server;

        /// pj_turn_tp_type
        public pj_turn_tp_type turn_conn_type;

        /// pj_stun_auth_cred
        public pj_stun_auth_cred turn_auth_cred;

        /// int
        public int snd_auto_close_time;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pjsua_codec_info
    {

        /// pj_str_t
        public pj_str_t codec_id;

        /// pj_uint8_t->unsigned char
        public byte priority;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string buf_;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsua_conf_port_info
    {

        /// pjsua_conf_port_id->int
        public int slot_id;

        /// pj_str_t
        public pj_str_t name;

        /// unsigned int
        public uint clock_rate;

        /// unsigned int
        public uint channel_count;

        /// unsigned int
        public uint samples_per_frame;

        /// unsigned int
        public uint bits_per_sample;

        /// unsigned int
        public uint listener_cnt;

        /// pjsua_conf_port_id[254]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 254, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] listeners;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct pjsua_media_transport
    {

        /// pjmedia_sock_info
        public pjmedia_sock_info skinfo;

        /// pjmedia_transport*
        public System.IntPtr transport;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_8f76ed83_b773_414d_aab1_99764d2712ae
    {

        /// pj_uint32_t->unsigned int
        public uint lo;

        /// pj_uint32_t->unsigned int
        public uint hi;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_086cca6e_5828_482b_8f5b_27304685ff89
    {

        /// unsigned int
        public uint max_count;

        /// unsigned int
        public uint t1;

        /// unsigned int
        public uint t2;

        /// unsigned int
        public uint t4;

        /// unsigned int
        public uint td;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_c441d546_e170_46ac_93c6_11da47055c8f
    {

        /// pj_bool_t->int
        public int check_contact;

        /// pj_bool_t->int
        public int add_xuid_param;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public struct Anonymous_92f5cbce_6875_485c_99be_45295d0617d1
    {

        /// pjsip_request_line
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pjsip_request_line req;

        /// pjsip_status_line
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pjsip_status_line status;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public struct Anonymous_e77ed7d9_8eae_4efc_bdaf_ea578a55b094
    {

        /// pjsip_common_credential
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pjsip_common_credential common;

        /// pjsip_digest_credential
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pjsip_digest_credential digest;

        /// pjsip_pgp_credential
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pjsip_pgp_credential pgp;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public struct Anonymous_e3727455_c116_4081_998c_73e2457c5923
    {

        /// pjsip_common_challenge
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pjsip_common_challenge common;

        /// pjsip_digest_challenge
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pjsip_digest_challenge digest;

        /// pjsip_pgp_challenge
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public pjsip_pgp_challenge pgp;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public struct Anonymous_3eeaa12c_ae9a_4f9d_9e09_5cfc2bf23da5
    {

        /// Anonymous_3f7cb69a_6697_4649_802e_729198b77563
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_3f7cb69a_6697_4649_802e_729198b77563 aka;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_5f5fdd64_f5a8_4714_9bc5_3704040cd03c
    {

        /// unsigned int
        public uint clock_rate;

        /// unsigned int
        public uint channel_cnt;

        /// pj_uint32_t->unsigned int
        public uint avg_bps;

        /// pj_uint32_t->unsigned int
        public uint max_bps;

        /// pj_uint16_t->unsigned short
        public ushort frm_ptime;

        /// pj_uint16_t->unsigned short
        public ushort enc_ptime;

        /// pj_uint8_t->unsigned char
        public byte pcm_bits_per_sample;

        /// pj_uint8_t->unsigned char
        public byte pt;

        /// pjmedia_format_id
        public pjmedia_format_id fmt_id;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_a1ebca6a_52b2_431a_9440_f4bd2e622211
    {

        /// pj_uint8_t->unsigned char
        public byte frm_per_pkt;

        /// vad : 1
        ///cng : 1
        ///penh : 1
        ///plc : 1
        ///reserved : 1
        public uint bitvector1;

        /// pjmedia_codec_fmtp
        public pjmedia_codec_fmtp enc_fmtp;

        /// pjmedia_codec_fmtp
        public pjmedia_codec_fmtp dec_fmtp;

        public uint vad
        {
            get
            {
                return ((uint)((this.bitvector1 & 1u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint cng
        {
            get
            {
                return ((uint)(((this.bitvector1 & 2u)
                            / 2)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 2)
                            | this.bitvector1)));
            }
        }

        public uint penh
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4u)
                            / 4)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 4)
                            | this.bitvector1)));
            }
        }

        public uint plc
        {
            get
            {
                return ((uint)(((this.bitvector1 & 8u)
                            / 8)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 8)
                            | this.bitvector1)));
            }
        }

        public uint reserved
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16u)
                            / 16)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16)
                            | this.bitvector1)));
            }
        }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_5785ac56_567e_49cd_a064_a19fece4f976
    {

        /// pj_str_t
        public pj_str_t media;

        /// pj_uint16_t->unsigned short
        public ushort port;

        /// unsigned int
        public uint port_count;

        /// pj_str_t
        public pj_str_t transport;

        /// unsigned int
        public uint fmt_count;

        /// pj_str_t[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public pj_str_t[] fmt;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_317d2398_97dd_4de7_b964_c7e28dbf3420
    {

        /// pj_str_t
        public pj_str_t user;

        /// pj_uint32_t->unsigned int
        public uint id;

        /// pj_uint32_t->unsigned int
        public uint version;

        /// pj_str_t
        public pj_str_t net_type;

        /// pj_str_t
        public pj_str_t addr_type;

        /// pj_str_t
        public pj_str_t addr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_4de5b558_55e9_4df5_a932_74cef35a8e4b
    {

        /// pj_uint32_t->unsigned int
        public uint start;

        /// pj_uint32_t->unsigned int
        public uint stop;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_a14448ec_b859_47e9_8724_6af5eedbde17
    {

        /// count : 5
        ///p : 1
        ///version : 2
        ///pt : 8
        ///length : 16
        public uint bitvector1;

        /// pj_uint32_t->unsigned int
        public uint ssrc;

        public uint count
        {
            get
            {
                return ((uint)((this.bitvector1 & 31u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint p
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32u)
                            / 32)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32)
                            | this.bitvector1)));
            }
        }

        public uint version
        {
            get
            {
                return ((uint)(((this.bitvector1 & 192u)
                            / 64)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 64)
                            | this.bitvector1)));
            }
        }

        public uint pt
        {
            get
            {
                return ((uint)(((this.bitvector1 & 65280u)
                            / 256)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 256)
                            | this.bitvector1)));
            }
        }

        public uint length
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4294901760u)
                            / 65536)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 65536)
                            | this.bitvector1)));
            }
        }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_aa0c1455_526f_4abe_bc41_ef74ed856d68
    {

        /// pj_time_val
        public pj_time_val update;

        /// pj_uint32_t->unsigned int
        public uint begin_seq;

        /// pj_uint32_t->unsigned int
        public uint end_seq;

        /// unsigned int
        public uint count;

        /// l : 1
        ///d : 1
        ///j : 1
        ///t : 2
        public uint bitvector1;

        /// unsigned int
        public uint lost;

        /// unsigned int
        public uint dup;

        /// pj_math_stat
        public pj_math_stat jitter;

        /// pj_math_stat
        public pj_math_stat toh;

        public uint l
        {
            get
            {
                return ((uint)((this.bitvector1 & 1u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint d
        {
            get
            {
                return ((uint)(((this.bitvector1 & 2u)
                            / 2)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 2)
                            | this.bitvector1)));
            }
        }

        public uint j
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4u)
                            / 4)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 4)
                            | this.bitvector1)));
            }
        }

        public uint t
        {
            get
            {
                return ((uint)(((this.bitvector1 & 24u)
                            / 8)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 8)
                            | this.bitvector1)));
            }
        }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_c4f986d4_7d01_41ea_8724_a1d054cb26c0
    {

        /// pj_time_val
        public pj_time_val update;

        /// pj_uint8_t->unsigned char
        public byte loss_rate;

        /// pj_uint8_t->unsigned char
        public byte discard_rate;

        /// pj_uint8_t->unsigned char
        public byte burst_den;

        /// pj_uint8_t->unsigned char
        public byte gap_den;

        /// pj_uint16_t->unsigned short
        public ushort burst_dur;

        /// pj_uint16_t->unsigned short
        public ushort gap_dur;

        /// pj_uint16_t->unsigned short
        public ushort rnd_trip_delay;

        /// pj_uint16_t->unsigned short
        public ushort end_sys_delay;

        /// pj_int8_t->char
        public byte signal_lvl;

        /// pj_int8_t->char
        public byte noise_lvl;

        /// pj_uint8_t->unsigned char
        public byte rerl;

        /// pj_uint8_t->unsigned char
        public byte gmin;

        /// pj_uint8_t->unsigned char
        public byte r_factor;

        /// pj_uint8_t->unsigned char
        public byte ext_r_factor;

        /// pj_uint8_t->unsigned char
        public byte mos_lq;

        /// pj_uint8_t->unsigned char
        public byte mos_cq;

        /// pj_uint8_t->unsigned char
        public byte rx_config;

        /// pj_uint16_t->unsigned short
        public ushort jb_nom;

        /// pj_uint16_t->unsigned short
        public ushort jb_max;

        /// pj_uint16_t->unsigned short
        public ushort jb_abs_max;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_50c755a7_59e7_44a9_8789_96eeb30d4164
    {

        /// pj_uint32_t->unsigned int
        public uint pkt;

        /// pj_uint32_t->unsigned int
        public uint lost;

        /// pj_uint32_t->unsigned int
        public uint loss_count;

        /// pj_uint32_t->unsigned int
        public uint discard_count;

        /// pj_uint32_t->unsigned int
        public uint c11;

        /// pj_uint32_t->unsigned int
        public uint c13;

        /// pj_uint32_t->unsigned int
        public uint c14;

        /// pj_uint32_t->unsigned int
        public uint c22;

        /// pj_uint32_t->unsigned int
        public uint c23;

        /// pj_uint32_t->unsigned int
        public uint c33;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public struct Anonymous_f82179d2_ca4d_4982_bfb2_c571f88a474c
    {

        /// _flag
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public flag Struct1;

        /// pj_uint16_t->unsigned short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ushort value;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_4d61a905_b963_46ef_8547_2aaa9774cf85
    {

        /// burst : 1
        ///random : 1
        public uint bitvector1;

        public uint burst
        {
            get
            {
                return ((uint)((this.bitvector1 & 1u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint random
        {
            get
            {
                return ((uint)(((this.bitvector1 & 2u)
                            / 2)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 2)
                            | this.bitvector1)));
            }
        }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_5d329b9d_5b05_4095_9710_1f4fa75f6b7a
    {

        /// Anonymous_d82988bb_a2f4_4f34_99ca_ff1053e56d6b
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_d82988bb_a2f4_4f34_99ca_ff1053e56d6b static_cred;

        ///// Anonymous_23b81a5c_89b5_42d8_81df_3255cc787da4
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        //public Anonymous_23b81a5c_89b5_42d8_81df_3255cc787da4 dyn_cred;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_493f2a2f_2df7_4488_b2c6_b0e054f612ae
    {

        /// pj_uint32_t->unsigned int
        public uint riff;

        /// pj_uint32_t->unsigned int
        public uint file_len;

        /// pj_uint32_t->unsigned int
        public uint wave;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_4e0909fa_74e9_480d_9958_95f6e147a9dc
    {

        /// pj_uint32_t->unsigned int
        public uint fmt;

        /// pj_uint32_t->unsigned int
        public uint len;

        /// pj_uint16_t->unsigned short
        public ushort fmt_tag;

        /// pj_uint16_t->unsigned short
        public ushort nchan;

        /// pj_uint32_t->unsigned int
        public uint sample_rate;

        /// pj_uint32_t->unsigned int
        public uint bytes_per_sec;

        /// pj_uint16_t->unsigned short
        public ushort block_align;

        /// pj_uint16_t->unsigned short
        public ushort bits_per_sample;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_d58ae436_ef8c_4ebd_ae68_4e047c684d40
    {

        /// pj_uint32_t->unsigned int
        public uint data;

        /// pj_uint32_t->unsigned int
        public uint len;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_ba5c8abb_977a_4b30_9369_4a8ab7380a3f
    {

        /// pj_in_addr
        public pj_in_addr if_addr;

        /// pj_in_addr
        public pj_in_addr dst_addr;

        /// pj_in_addr
        public pj_in_addr mask;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct Anonymous_e56200bd_465b_43a5_bb0a_cf4096207b0c
    {

        /// char[128]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
        public string local_info;

        /// char[128]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
        public string local_contact;

        /// char[128]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
        public string remote_info;

        /// char[128]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
        public string remote_contact;

        /// char[128]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
        public string call_id;

        /// char[128]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
        public string last_status_text;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_117b0241_67c2_4345_8937_776cc4b07c57
    {

        /// pjsip_transport_type_e
        public pjsip_transport_type_e type;

        /// unsigned int
        public uint priority;

        /// unsigned int
        public uint weight;

        /// pj_sockaddr
        public pj_sockaddr addr;

        /// int
        public int addr_len;
    }

    /// Return Type: void
    ///user_data: void*
    ///pkt: void*
    ///size: pj_ssize_t->int
    public delegate void Anonymous_85d742b6_eba5_4080_a5b4_07d19b35439c(System.IntPtr user_data, System.IntPtr pkt, int size);

    /// Return Type: void
    ///user_data: void*
    ///pkt: void*
    ///size: pj_ssize_t->int
    public delegate void Anonymous_5be1ad26_db76_4044_9249_95d1d7418205(System.IntPtr user_data, System.IntPtr pkt, int size);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_027e9f14_4c2d_429d_87f8_af0dc61b7581
    {

        /// char
        public byte digit;

        /// short
        public short freq1;

        /// short
        public short freq2;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_3f860102_f882_4a29_98fd_fe70f9d7a321
    {

        /// pj_bool_t->int
        public int basic_open;

        /// pjrpid_element
        public pjrpid_element rpid;

        /// pj_str_t
        public pj_str_t id;

        /// pj_str_t
        public pj_str_t contact;

        /// pj_xml_node*
        public System.IntPtr tuple_node;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_30c1cc4f_b70b_42fe_91de_97b5a067b9cc
    {

        /// unsigned int
        public uint priority;

        /// unsigned int
        public uint weight;

        /// pj_uint16_t->unsigned short
        public ushort port;

        /// pj_dns_a_record
        public pj_dns_a_record server;
    }

    /// Return Type: int
    ///value: void*
    ///node: pj_list_type*
    public delegate int Anonymous_b50cc8f0_25e3_49bb_b501_6a81aadfb7df(System.IntPtr value, System.IntPtr node);

    /// Return Type: pj_status_t->int
    ///port: pjmedia_port*
    ///usr_data: void*
    public delegate int Anonymous_a805b307_7f51_4758_9a1e_e61d30fa7d22(ref pjmedia_port port, System.IntPtr usr_data);

    /// Return Type: pj_status_t->int
    ///port: pjmedia_port*
    ///usr_data: void*
    public delegate int Anonymous_2b450b20_62bb_4846_83e4_3a6d810d5311(ref pjmedia_port port, System.IntPtr usr_data);

    /// Return Type: pj_status_t->int
    ///port: pjmedia_port*
    ///usr_data: void*
    public delegate int Anonymous_28f14dff_42f4_44ee_b905_e63938284c22(ref pjmedia_port port, System.IntPtr usr_data);

    /// Return Type: pj_status_t->int
    ///port: pjmedia_port*
    ///usr_data: void*
    public delegate int Anonymous_03fcbe86_28cb_4a25_9be8_a1146a401a61(ref pjmedia_port port, System.IntPtr usr_data);

    /// Return Type: pj_status_t->int
    ///port: pjmedia_port*
    ///usr_data: void*
    public delegate int Anonymous_6204802f_a3d0_4432_bd7e_cf396a99421e(ref pjmedia_port port, System.IntPtr usr_data);

    /// Return Type: pj_bool_t->int
    ///param0: pj_xml_node*
    ///param1: void*
    public delegate int Anonymous_76463a82_d404_4d5e_98b5_18f64e8f1ab8(ref pj_xml_node param0, System.IntPtr param1);

    /// Return Type: pj_bool_t->int
    ///param0: pj_xml_node*
    ///param1: void*
    public delegate int Anonymous_f9f11ca9_c386_4eb6_a618_3e998a3ced4c(ref pj_xml_node param0, System.IntPtr param1);

    /// Return Type: pj_status_t->int
    ///value: void*
    public delegate int Anonymous_9cce8374_1e78_4863_8558_2b4d98dfdb49(System.IntPtr value);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_3f7cb69a_6697_4649_802e_729198b77563
    {

        /// pj_str_t
        public pj_str_t k;

        /// pj_str_t
        public pj_str_t op;

        /// pj_str_t
        public pj_str_t amf;

        /// pjsip_cred_cb
        public pjsip_cred_cb cb;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_d82988bb_a2f4_4f34_99ca_ff1053e56d6b
    {

        /// pj_str_t
        public pj_str_t realm;

        /// pj_str_t
        public pj_str_t username;

        /// pj_stun_passwd_type
        public pj_stun_passwd_type data_type;

        /// pj_str_t
        public pj_str_t data;

        /// pj_str_t
        public pj_str_t nonce;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_23b81a5c_89b5_42d8_81df_3255cc787da4
    {

        /// void*
        public System.IntPtr user_data;

        /// _get_auth
        public _get_auth AnonymousMember1;

        /// _get_cred
        public _get_cred AnonymousMember2;

        /// _get_password
        public _get_password AnonymousMember3;

        /// _verify_nonce
        public _verify_nonce AnonymousMember4;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct localeinfo_struct
    {

        /// pthreadlocinfo->threadlocaleinfostruct*
        public System.IntPtr locinfo;

        /// pthreadmbcinfo->threadmbcinfostruct*
        public System.IntPtr mbcinfo;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct threadlocaleinfostruct
    {

        /// int
        public int refcount;

        /// unsigned int
        public uint lc_codepage;

        /// unsigned int
        public uint lc_collate_cp;

        /// unsigned int[6]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U4)]
        public uint[] lc_handle;

        /// LC_ID[6]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public tagLC_ID[] lc_id;

        /// Anonymous_39b23187_c36e_4db1_9e66_9a5ea7403a6a[6]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public Anonymous_39b23187_c36e_4db1_9e66_9a5ea7403a6a[] lc_category;

        /// int
        public int lc_clike;

        /// int
        public int mb_cur_max;

        /// int*
        public System.IntPtr lconv_intl_refcount;

        /// int*
        public System.IntPtr lconv_num_refcount;

        /// int*
        public System.IntPtr lconv_mon_refcount;

        /// lconv*
        public System.IntPtr lconv;

        /// int*
        public System.IntPtr ctype1_refcount;

        /// unsigned short*
        public System.IntPtr ctype1;

        /// short*
        public System.IntPtr pctype;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string pclmap;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string pcumap;

        /// __lc_time_data*
        public System.IntPtr lc_time_curr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Anonymous_39b23187_c36e_4db1_9e66_9a5ea7403a6a
    {

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string locale;

        /// wchar_t*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
        public string wlocale;

        /// int*
        public System.IntPtr refcount;

        /// int*
        public System.IntPtr wrefcount;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct tagLC_ID
    {

        /// unsigned short
        public ushort wLanguage;

        /// unsigned short
        public ushort wCountry;

        /// unsigned short
        public ushort wCodePage;
    }

    public static class PJSUA_DLL
    {

        public static class Basic
        {
            /// Return Type: void
            ///cfg: pjsua_logging_config*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_logging_config_default")]
            public static extern void pjsua_logging_config_default([In][Out] pjsua_logging_config cfg);

            [DllImport("pjsua.dll", EntryPoint = "pjsua_config_default")]
            public static extern void pjsua_config_default([In][Out] pjsua_config cfg);

            [DllImport("pjsua.dll", EntryPoint = "pjsua_init")]
            public static extern int pjsua_init([In][Out] pjsua_config ua_cfg,
                                                [In][Out] pjsua_logging_config log_cfg,
                                                [In][Out] pjsua_media_config media_cfg);

            /// Return Type: pj_status_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_create")]
            public static extern int pjsua_create();


            /// Return Type: pj_status_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_start")]
            public static extern int pjsua_start();


            /// Return Type: pj_status_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_destroy")]
            public static extern int pjsua_destroy();


            /// Return Type: int
            ///msec_timeout: unsigned int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_handle_events")]
            public static extern int pjsua_handle_events(uint msec_timeout);

            /// Return Type: pj_status_t->int
            ///c: pjsua_logging_config*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_reconfigure_logging")]
            public static extern int pjsua_reconfigure_logging([In][Out] pjsua_logging_config c);


            /// Return Type: pj_status_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_detect_nat_type")]
            public static extern int pjsua_detect_nat_type();


            /// Return Type: pj_status_t->int
            ///type: pj_stun_nat_type*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_get_nat_type")]
            public static extern int pjsua_get_nat_type([In][Out] ref pj_stun_nat_type type);


            /// Return Type: pj_status_t->int
            ///count: unsigned int
            ///srv: pj_str_t*
            ///wait: pj_bool_t->int
            ///token: void*
            ///cb: pj_stun_resolve_cb
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_resolve_stun_servers")]
            public static extern int pjsua_resolve_stun_servers(uint count, ref pj_str_t srv, int wait, System.IntPtr token, pj_stun_resolve_cb cb);


            /// Return Type: pj_status_t->int
            ///token: void*
            ///notify_cb: pj_bool_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_cancel_stun_resolution")]
            public static extern int pjsua_cancel_stun_resolution(System.IntPtr token, int notify_cb);


            /// Return Type: pj_status_t->int
            ///url: char*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_verify_sip_url")]
            public static extern int pjsua_verify_sip_url([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string url);


            /// Return Type: void
            ///sender: char*
            ///title: char*
            ///status: pj_status_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_perror")]
            public static extern void pjsua_perror([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string sender, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string title, int status);


            /// Return Type: void
            ///detail: pj_bool_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_dump")]
            public static extern void pjsua_dump([MarshalAs(UnmanagedType.I4)]bool detail);
        }

        public static class Transport
        {

            /// Return Type: void
            ///cfg: pjsua_transport_config*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_transport_config_default")]
            public static extern void pjsua_transport_config_default([In][Out] pjsua_transport_config cfg);


            /// Return Type: pj_status_t->int
            ///type: pjsip_transport_type_e
            ///cfg: pjsua_transport_config*
            ///p_id: pjsua_transport_id*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_transport_create")]
            public static extern int pjsua_transport_create(pjsip_transport_type_e type, [In][Out] pjsua_transport_config cfg, ref int p_id);


            /// Return Type: pj_status_t->int
            ///id: pjsua_transport_id*
            ///count: unsigned int*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_enum_transports")]
            public static extern int pjsua_enum_transports([Out] int[] id, ref uint count);


            /// Return Type: pj_status_t->int
            ///id: pjsua_transport_id->int
            ///info: pjsua_transport_info*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_transport_get_info")]
            public static extern int pjsua_transport_get_info(int id, [In][Out] pjsua_transport_info info);


            /// Return Type: pj_status_t->int
            ///id: pjsua_transport_id->int
            ///enabled: pj_bool_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_transport_set_enable")]
            public static extern int pjsua_transport_set_enable(int id, int enabled);


            /// Return Type: pj_status_t->int
            ///id: pjsua_transport_id->int
            ///force: pj_bool_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_transport_close")]
            public static extern int pjsua_transport_close(int id, int force);
        }

        public static class Accounts
        {

            /// Return Type: void
            ///cfg: pjsua_acc_config*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_config_default")]
            public static extern void pjsua_acc_config_default([In][Out] pjsua_acc_config cfg);


            /// Return Type: unsigned int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_get_count")]
            public static extern uint pjsua_acc_get_count();


            /// Return Type: pj_bool_t->int
            ///acc_id: pjsua_acc_id->int
            [DllImport("pjsua.dll", EntryPoint = "pjsua_acc_is_valid")]
            private static extern int pjsua_acc_is_valid1(int acc_id);

            public static bool pjsua_acc_is_valid(int acc_id)
            {
                return Convert.ToBoolean(pjsua_acc_is_valid1(acc_id));
            }

            /// Return Type: pj_status_t->int
            ///acc_id: pjsua_acc_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_set_default")]
            public static extern int pjsua_acc_set_default(int acc_id);


            /// Return Type: pjsua_acc_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_get_default")]
            public static extern int pjsua_acc_get_default();


            /// Return Type: pj_status_t->int
            ///acc_cfg: pjsua_acc_config*
            ///is_default: pj_bool_t->int
            ///p_acc_id: pjsua_acc_id*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_add")]
            public static extern int pjsua_acc_add([In][Out] pjsua_acc_config acc_cfg, int is_default, ref int p_acc_id);


            /// Return Type: pj_status_t->int
            ///tid: pjsua_transport_id->int
            ///is_default: pj_bool_t->int
            ///p_acc_id: pjsua_acc_id*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_add_local")]
            public static extern int pjsua_acc_add_local(int tid, int is_default, ref int p_acc_id);


            /// Return Type: pj_status_t->int
            ///acc_id: pjsua_acc_id->int
            ///user_data: void*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_set_user_data")]
            public static extern int pjsua_acc_set_user_data(int acc_id, System.IntPtr user_data);


            /// Return Type: void*
            ///acc_id: pjsua_acc_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_get_user_data")]
            public static extern System.IntPtr pjsua_acc_get_user_data(int acc_id);


            /// Return Type: pj_status_t->int
            ///acc_id: pjsua_acc_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_del")]
            public static extern int pjsua_acc_del(int acc_id);


            /// Return Type: pj_status_t->int
            ///acc_id: pjsua_acc_id->int
            ///acc_cfg: pjsua_acc_config*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_modify")]
            public static extern int pjsua_acc_modify(int acc_id, [In][Out] pjsua_acc_config acc_cfg);


            /// Return Type: pj_status_t->int
            ///acc_id: pjsua_acc_id->int
            ///is_online: pj_bool_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_set_online_status")]
            public static extern int pjsua_acc_set_online_status(int acc_id, int is_online);


            /// Return Type: pj_status_t->int
            ///acc_id: pjsua_acc_id->int
            ///is_online: pj_bool_t->int
            ///pr: pjrpid_element*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_set_online_status2")]
            public static extern int pjsua_acc_set_online_status2(int acc_id, int is_online, ref pjrpid_element pr);


            /// Return Type: pj_status_t->int
            ///acc_id: pjsua_acc_id->int
            ///renew: pj_bool_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_set_registration")]
            public static extern int pjsua_acc_set_registration(int acc_id, int renew);


            /// Return Type: pj_status_t->int
            ///acc_id: pjsua_acc_id->int
            ///info: pjsua_acc_info*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_get_info")]
            public static extern int pjsua_acc_get_info(int acc_id, ref pjsua_acc_info info);


            /// Return Type: pj_status_t->int
            ///ids: pjsua_acc_id*
            ///count: unsigned int*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_enum_accs")]
            public static extern int pjsua_enum_accs([Out] int[] ids, ref uint count);


            /// Return Type: pj_status_t->int
            ///info: pjsua_acc_info*
            ///count: unsigned int*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_enum_info")]
            public static extern int pjsua_acc_enum_info([Out] pjsua_acc_info[] info, ref uint count);


            /// Return Type: pjsua_acc_id->int
            ///url: pj_str_t*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_find_for_outgoing")]
            public static extern int pjsua_acc_find_for_outgoing(ref pj_str_t url);


            /// Return Type: pj_status_t->int
            ///pool: pj_pool_t*
            ///contact: pj_str_t*
            ///acc_id: pjsua_acc_id->int
            ///uri: pj_str_t*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_create_uac_contact")]
            public static extern int pjsua_acc_create_uac_contact(ref pj_pool_t pool, ref pj_str_t contact, int acc_id, ref pj_str_t uri);


            /// Return Type: pj_status_t->int
            ///acc_id: pjsua_acc_id->int
            ///tp_id: pjsua_transport_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_acc_set_transport")]
            public static extern int pjsua_acc_set_transport(int acc_id, int tp_id);
        }

        public static class Calls
        {

            /// Return Type: unsigned int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_get_max_count")]
            public static extern uint pjsua_call_get_max_count();


            /// Return Type: unsigned int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_get_count")]
            public static extern uint pjsua_call_get_count();


            /// Return Type: pj_status_t->int
            ///ids: pjsua_call_id*
            ///count: unsigned int*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_enum_calls")]
            public static extern int pjsua_enum_calls([Out] int[] ids, ref uint count);


            /// Return Type: pj_status_t->int
            ///acc_id: pjsua_acc_id->int
            ///dst_uri: pj_str_t*
            ///options: unsigned int
            ///user_data: void*
            ///msg_data: pjsua_msg_data*
            ///p_call_id: pjsua_call_id*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_make_call")]
            public static extern int pjsua_call_make_call(int acc_id, ref pj_str_t dst_uri, uint options, System.IntPtr user_data, pjsua_msg_data msg_data, ref int p_call_id);


            /// Return Type: pj_bool_t->int
            ///call_id: pjsua_call_id->int
            [DllImport("pjsua.dll", EntryPoint = "pjsua_call_is_active")]
            private static extern int pjsua_call_is_active1(int call_id);

            public static bool pjsua_call_is_active(int call_id)
            {
                return Convert.ToBoolean(pjsua_call_is_active1(call_id));
            }

            /// Return Type: pj_bool_t->int
            ///call_id: pjsua_call_id->int
            [DllImport("pjsua.dll", EntryPoint = "pjsua_call_has_media")]
            private static extern int pjsua_call_has_media1(int call_id);

            public static bool pjsua_call_has_media(int call_id)
            {
                return Convert.ToBoolean(pjsua_call_has_media1(call_id));
            }

            /// Return Type: pjmedia_transport*
            ///cid: pjsua_call_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_get_media_transport")]
            public static extern System.IntPtr pjsua_call_get_media_transport(int cid);


            /// Return Type: pjsua_conf_port_id->int
            ///call_id: pjsua_call_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_get_conf_port")]
            public static extern int pjsua_call_get_conf_port(int call_id);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///info: pjsua_call_info*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_get_info")]
            public static extern int pjsua_call_get_info(int call_id, ref pjsua_call_info info);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///user_data: void*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_set_user_data")]
            public static extern int pjsua_call_set_user_data(int call_id, System.IntPtr user_data);


            /// Return Type: void*
            ///call_id: pjsua_call_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_get_user_data")]
            public static extern System.IntPtr pjsua_call_get_user_data(int call_id);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///p_type: pj_stun_nat_type*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_get_rem_nat_type")]
            public static extern int pjsua_call_get_rem_nat_type(int call_id, ref pj_stun_nat_type p_type);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///code: unsigned int
            ///reason: pj_str_t*
            ///msg_data: pjsua_msg_data*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_answer")]
            public static extern int pjsua_call_answer(int call_id, uint code, ref pj_str_t reason, pjsua_msg_data msg_data);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///code: unsigned int
            ///reason: pj_str_t*
            ///msg_data: pjsua_msg_data*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_hangup")]
            public static extern int pjsua_call_hangup(int call_id, uint code, ref pj_str_t reason, pjsua_msg_data msg_data);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///cmd: pjsip_redirect_op
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_process_redirect")]
            public static extern int pjsua_call_process_redirect(int call_id, pjsip_redirect_op cmd);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///msg_data: pjsua_msg_data*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_set_hold")]
            public static extern int pjsua_call_set_hold(int call_id, pjsua_msg_data msg_data);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///unhold: pj_bool_t->int
            ///msg_data: pjsua_msg_data*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_reinvite")]
            public static extern int pjsua_call_reinvite(int call_id, int unhold, pjsua_msg_data msg_data);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///options: unsigned int
            ///msg_data: pjsua_msg_data*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_update")]
            public static extern int pjsua_call_update(int call_id, uint options, pjsua_msg_data msg_data);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///dest: pj_str_t*
            ///msg_data: pjsua_msg_data*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_xfer")]
            public static extern int pjsua_call_xfer(int call_id, ref pj_str_t dest, pjsua_msg_data msg_data);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///dest_call_id: pjsua_call_id->int
            ///options: unsigned int
            ///msg_data: pjsua_msg_data*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_xfer_replaces")]
            public static extern int pjsua_call_xfer_replaces(int call_id, int dest_call_id, uint options, pjsua_msg_data msg_data);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///digits: pj_str_t*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_dial_dtmf")]
            public static extern int pjsua_call_dial_dtmf(int call_id, ref pj_str_t digits);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///mime_type: pj_str_t*
            ///content: pj_str_t*
            ///msg_data: pjsua_msg_data*
            ///user_data: void*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_send_im")]
            public static extern int pjsua_call_send_im(int call_id, ref pj_str_t mime_type, ref pj_str_t content, pjsua_msg_data msg_data, System.IntPtr user_data);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///is_typing: pj_bool_t->int
            ///msg_data: pjsua_msg_data*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_send_typing_ind")]
            public static extern int pjsua_call_send_typing_ind(int call_id, int is_typing, pjsua_msg_data msg_data);


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///method: pj_str_t*
            ///msg_data: pjsua_msg_data*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_send_request")]
            public static extern int pjsua_call_send_request(int call_id, ref pj_str_t method, pjsua_msg_data msg_data);


            /// Return Type: void
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_hangup_all")]
            public static extern void pjsua_call_hangup_all();


            /// Return Type: pj_status_t->int
            ///call_id: pjsua_call_id->int
            ///with_media: pj_bool_t->int
            ///buffer: char*
            ///maxlen: unsigned int
            ///indent: char*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_call_dump")]
            public static extern int pjsua_call_dump(int call_id, int with_media, System.IntPtr buffer, uint maxlen, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string indent);
        }

        public static class IM
        {

            /// Return Type: void
            ///cfg: pjsua_buddy_config*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_buddy_config_default")]
            public static extern void pjsua_buddy_config_default([In][Out] pjsua_buddy_config cfg);


            /// Return Type: unsigned int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_get_buddy_count")]
            public static extern uint pjsua_get_buddy_count();


            /// Return Type: pj_bool_t->int
            ///buddy_id: pjsua_buddy_id->int
            [DllImport("pjsua.dll", EntryPoint = "pjsua_buddy_is_valid")]
            private static extern int pjsua_buddy_is_valid1(int buddy_id);

            public static bool pjsua_buddy_is_valid(int buddy_id)
            {
                return Convert.ToBoolean(pjsua_buddy_is_valid1(buddy_id));
            }

            /// Return Type: pj_status_t->int
            ///ids: pjsua_buddy_id*
            ///count: unsigned int*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_enum_buddies")]
            public static extern int pjsua_enum_buddies([Out] int[] ids, ref uint count);


            /// Return Type: pjsua_buddy_id->int
            ///uri: pj_str_t*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_buddy_find")]
            public static extern int pjsua_buddy_find(ref pj_str_t uri);


            /// Return Type: pj_status_t->int
            ///buddy_id: pjsua_buddy_id->int
            ///info: pjsua_buddy_info*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_buddy_get_info")]
            public static extern int pjsua_buddy_get_info(int buddy_id, ref pjsua_buddy_info info);


            /// Return Type: pj_status_t->int
            ///buddy_id: pjsua_buddy_id->int
            ///user_data: void*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_buddy_set_user_data")]
            public static extern int pjsua_buddy_set_user_data(int buddy_id, System.IntPtr user_data);


            /// Return Type: void*
            ///buddy_id: pjsua_buddy_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_buddy_get_user_data")]
            public static extern System.IntPtr pjsua_buddy_get_user_data(int buddy_id);


            /// Return Type: pj_status_t->int
            ///buddy_cfg: pjsua_buddy_config*
            ///p_buddy_id: pjsua_buddy_id*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_buddy_add")]
            public static extern int pjsua_buddy_add([In][Out] pjsua_buddy_config buddy_cfg, ref int p_buddy_id);


            /// Return Type: pj_status_t->int
            ///buddy_id: pjsua_buddy_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_buddy_del")]
            public static extern int pjsua_buddy_del(int buddy_id);


            /// Return Type: pj_status_t->int
            ///buddy_id: pjsua_buddy_id->int
            ///subscribe: pj_bool_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_buddy_subscribe_pres")]
            public static extern int pjsua_buddy_subscribe_pres(int buddy_id, int subscribe);


            /// Return Type: pj_status_t->int
            ///buddy_id: pjsua_buddy_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_buddy_update_pres")]
            public static extern int pjsua_buddy_update_pres(int buddy_id);


            /// Return Type: void
            ///verbose: pj_bool_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_pres_dump")]
            public static extern void pjsua_pres_dump(int verbose);

            [DllImport("pjsua.dll", EntryPoint = "pjsua_pres_notify")]
            public static extern int pjsua_pres_notify(int acc_id, IntPtr srv_pres, pjsip_evsub_state state,
                ref pj_str_t state_str, ref pj_str_t reason, int with_body, [In] pjsua_msg_data msg_data);


            /// Return Type: pj_status_t->int
            ///acc_id: pjsua_acc_id->int
            ///to: pj_str_t*
            ///mime_type: pj_str_t*
            ///content: pj_str_t*
            ///msg_data: pjsua_msg_data*
            ///user_data: void*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_im_send")]
            public static extern int pjsua_im_send(int acc_id, ref pj_str_t to, ref pj_str_t mime_type, ref pj_str_t content, pjsua_msg_data msg_data, System.IntPtr user_data);


            /// Return Type: pj_status_t->int
            ///acc_id: pjsua_acc_id->int
            ///to: pj_str_t*
            ///is_typing: pj_bool_t->int
            ///msg_data: pjsua_msg_data*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_im_typing")]
            public static extern int pjsua_im_typing(int acc_id, ref pj_str_t to, int is_typing, pjsua_msg_data msg_data);

        }

        public static class Media
        {

            /// Return Type: void
            ///cfg: pjsua_media_config*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_media_config_default")]
            public static extern void pjsua_media_config_default([In][Out] pjsua_media_config cfg);


            /// Return Type: unsigned int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_conf_get_max_ports")]
            public static extern uint pjsua_conf_get_max_ports();


            /// Return Type: unsigned int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_conf_get_active_ports")]
            public static extern uint pjsua_conf_get_active_ports();


            /// Return Type: pj_status_t->int
            ///id: pjsua_conf_port_id*
            ///count: unsigned int*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_enum_conf_ports")]
            public static extern int pjsua_enum_conf_ports([Out] int[] id, ref uint count);


            /// Return Type: pj_status_t->int
            ///port_id: pjsua_conf_port_id->int
            ///info: pjsua_conf_port_info*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_conf_get_port_info")]
            public static extern int pjsua_conf_get_port_info([In]int port_id, ref pjsua_conf_port_info info);


            /// Return Type: pj_status_t->int
            ///pool: pj_pool_t*
            ///port: pjmedia_port*
            ///p_id: pjsua_conf_port_id*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_conf_add_port")]
            public static extern int pjsua_conf_add_port(ref pj_pool_t pool, ref pjmedia_port port, ref int p_id);


            /// Return Type: pj_status_t->int
            ///port_id: pjsua_conf_port_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_conf_remove_port")]
            public static extern int pjsua_conf_remove_port([In]int port_id);


            /// Return Type: pj_status_t->int
            ///source: pjsua_conf_port_id->int
            ///sink: pjsua_conf_port_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_conf_connect")]
            public static extern int pjsua_conf_connect([In]int source, [In]int sink);


            /// Return Type: pj_status_t->int
            ///source: pjsua_conf_port_id->int
            ///sink: pjsua_conf_port_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_conf_disconnect")]
            public static extern int pjsua_conf_disconnect([In]int source, [In]int sink);


            /// Return Type: pj_status_t->int
            ///slot: pjsua_conf_port_id->int
            ///level: float
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_conf_adjust_tx_level")]
            public static extern int pjsua_conf_adjust_tx_level([In]int slot, [In]float level);


            /// Return Type: pj_status_t->int
            ///slot: pjsua_conf_port_id->int
            ///level: float
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_conf_adjust_rx_level")]
            public static extern int pjsua_conf_adjust_rx_level([In]int slot, [In]float level);


            /// Return Type: pj_status_t->int
            ///slot: pjsua_conf_port_id->int
            ///tx_level: unsigned int*
            ///rx_level: unsigned int*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_conf_get_signal_level")]
            public static extern int pjsua_conf_get_signal_level([In]int slot, ref uint tx_level, ref uint rx_level);


            /// Return Type: pj_status_t->int
            ///filename: pj_str_t*
            ///options: unsigned int
            ///p_id: pjsua_player_id*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_player_create")]
            public static extern int pjsua_player_create(ref pj_str_t filename, [In]uint options, ref int p_id);


            /// Return Type: pj_status_t->int
            ///file_names: pj_str_t*
            ///file_count: unsigned int
            ///label: pj_str_t*
            ///options: unsigned int
            ///p_id: pjsua_player_id*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_playlist_create")]
            public static extern int pjsua_playlist_create(ref pj_str_t file_names, [In]uint file_count, ref pj_str_t label, [In]uint options, ref int p_id);


            /// Return Type: pjsua_conf_port_id->int
            ///id: pjsua_player_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_player_get_conf_port")]
            public static extern int pjsua_player_get_conf_port([In]int id);


            /// Return Type: pj_status_t->int
            ///id: pjsua_player_id->int
            ///p_port: pjmedia_port**
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_player_get_port")]
            public static extern int pjsua_player_get_port([In]int id, ref System.IntPtr p_port);


            /// Return Type: pj_status_t->int
            ///id: pjsua_player_id->int
            ///samples: pj_uint32_t->unsigned int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_player_set_pos")]
            public static extern int pjsua_player_set_pos([In]int id, [In]uint samples);


            /// Return Type: pj_status_t->int
            ///id: pjsua_player_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_player_destroy")]
            public static extern int pjsua_player_destroy([In]int id);


            /// Return Type: pj_status_t->int
            ///filename: pj_str_t*
            ///enc_type: unsigned int
            ///enc_param: void*
            ///max_size: pj_ssize_t->int
            ///options: unsigned int
            ///p_id: pjsua_recorder_id*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_recorder_create")]
            public static extern int pjsua_recorder_create(ref pj_str_t filename, [In]uint enc_type, System.IntPtr enc_param, [In]int max_size, [In]uint options, ref int p_id);


            /// Return Type: pjsua_conf_port_id->int
            ///id: pjsua_recorder_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_recorder_get_conf_port")]
            public static extern int pjsua_recorder_get_conf_port([In]int id);


            /// Return Type: pj_status_t->int
            ///id: pjsua_recorder_id->int
            ///p_port: pjmedia_port**
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_recorder_get_port")]
            public static extern int pjsua_recorder_get_port([In]int id, ref System.IntPtr p_port);


            /// Return Type: pj_status_t->int
            ///id: pjsua_recorder_id->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_recorder_destroy")]
            public static extern int pjsua_recorder_destroy([In]int id);


            /// Return Type: pj_status_t->int
            ///info: pjmedia_aud_dev_info*
            ///count: unsigned int*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_enum_aud_devs")]
            public static extern int pjsua_enum_aud_devs([Out] pjmedia_aud_dev_info[] info, ref uint count);


            /// Return Type: pj_status_t->int
            ///info: pjmedia_snd_dev_info*
            ///count: unsigned int*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_enum_snd_devs")]
            public static extern int pjsua_enum_snd_devs([Out] pjmedia_snd_dev_info[] info, ref uint count);


            /// Return Type: pj_status_t->int
            ///capture_dev: int*
            ///playback_dev: int*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_get_snd_dev")]
            public static extern int pjsua_get_snd_dev(ref int capture_dev, ref int playback_dev);


            /// Return Type: pj_status_t->int
            ///capture_dev: int
            ///playback_dev: int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_set_snd_dev")]
            public static extern int pjsua_set_snd_dev([In]int capture_dev, [In]int playback_dev);


            /// Return Type: pj_status_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_set_null_snd_dev")]
            public static extern int pjsua_set_null_snd_dev();


            /// Return Type: pjmedia_port*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_set_no_snd_dev")]
            public static extern System.IntPtr pjsua_set_no_snd_dev();


            /// Return Type: pj_status_t->int
            ///tail_ms: unsigned int
            ///options: unsigned int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_set_ec")]
            public static extern int pjsua_set_ec([In]uint tail_ms, [In]uint options);


            /// Return Type: pj_status_t->int
            ///p_tail_ms: unsigned int*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_get_ec_tail")]
            public static extern int pjsua_get_ec_tail(ref uint p_tail_ms);


            /// Return Type: pj_bool_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_snd_is_active")]
            public static extern int pjsua_snd_is_active();


            /// Return Type: pj_status_t->int
            ///cap: pjmedia_aud_dev_cap
            ///pval: void*
            ///keep: pj_bool_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_snd_set_setting")]
            public static extern int pjsua_snd_set_setting(pjmedia_aud_dev_cap cap, System.IntPtr pval, [In]int keep);


            /// Return Type: pj_status_t->int
            ///cap: pjmedia_aud_dev_cap
            ///pval: void*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_snd_get_setting")]
            public static extern int pjsua_snd_get_setting(pjmedia_aud_dev_cap cap, System.IntPtr pval);


            /// Return Type: pj_status_t->int
            ///id: pjsua_codec_info*
            ///count: unsigned int*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_enum_codecs")]
            public static extern int pjsua_enum_codecs([Out] pjsua_codec_info[] id, ref uint count);


            /// Return Type: pj_status_t->int
            ///codec_id: pj_str_t*
            ///priority: pj_uint8_t->unsigned char
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_codec_set_priority")]
            public static extern int pjsua_codec_set_priority([In]ref pj_str_t codec_id, [In]byte priority);


            /// Return Type: pj_status_t->int
            ///codec_id: pj_str_t*
            ///param: pjmedia_codec_param*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_codec_get_param")]
            public static extern int pjsua_codec_get_param([In]ref pj_str_t codec_id, [In][Out] ref pjmedia_codec_param param);


            /// Return Type: pj_status_t->int
            ///codec_id: pj_str_t*
            ///param: pjmedia_codec_param*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_codec_set_param")]
            public static extern int pjsua_codec_set_param([In]ref pj_str_t codec_id, [In][Out] ref pjmedia_codec_param param);


            /// Return Type: pj_status_t->int
            ///cfg: pjsua_transport_config*
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_media_transports_create")]
            public static extern int pjsua_media_transports_create([In][Out] pjsua_transport_config cfg);


            /// Return Type: pj_status_t->int
            ///tp: pjsua_media_transport*
            ///count: unsigned int
            ///auto_delete: pj_bool_t->int
            [System.Runtime.InteropServices.DllImportAttribute("pjsua.dll", EntryPoint = "pjsua_media_transports_attach")]
            public static extern int pjsua_media_transports_attach(ref pjsua_media_transport tp, [In]uint count, [In]int auto_delete);
        }

    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct pjsua_callback
    {
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_call_state on_call_state;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_incoming_call on_incoming_call;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_call_tsx_state on_call_tsx_state;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_call_media_state on_call_media_state;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_stream_created on_stream_created;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_stream_destroyed on_stream_destroyed;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_dtmf_digit on_dtmf_digit;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_call_transfer_request on_call_transfer_request;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_call_transfer_status on_call_transfer_status;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_call_replace_request on_call_replace_request;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_call_replaced on_call_replaced;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_reg_state on_reg_state;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_incoming_subscribe on_incoming_subscribe;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_srv_subscribe_state on_srv_subscribe_state;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_buddy_state on_buddy_state;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_pager on_pager;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_pager2 on_pager2;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_pager_status on_pager_status;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_pager_status2 on_pager_status2;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_typing on_typing;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_typing2 on_typing2;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_nat_detect on_nat_detect;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public pjsua_callback_on_call_redirected on_call_redirected;
        //public pjsua_callback_on_mwi_info on_mwi_info;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_call_state(int call_id, ref IntPtr e);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_typing2(
            int call_id, ref pj_str_t from,
        ref pj_str_t to,
        ref pj_str_t contact,
        [MarshalAs(UnmanagedType.I1)] bool is_typing,
            IntPtr rdata, int acc_id);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_pager_status2(
        int call_id, ref pj_str_t to,
    ref pj_str_t body,
    IntPtr user_data, pjsip_status_code status,
    ref pj_str_t reason,
        IntPtr tdata, IntPtr rdata, int acc_id);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_pager2(
        int call_id, ref pj_str_t from,
    ref pj_str_t to,
    ref pj_str_t contact,
    ref pj_str_t mime_type,
    ref pj_str_t body,
        IntPtr rdata, int acc_id);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_srv_subscribe_state(
        int acc_id, IntPtr srv_pres, ref pj_str_t remote_uri,
    pjsip_evsub_state state, IntPtr @event);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_incoming_subscribe(
        int acc_id, IntPtr srv_pres, int buddy_id,
    ref pj_str_t from,
    IntPtr rdata, ref pjsip_status_code code,
    ref pj_str_t reason, pjsua_msg_data msg_data);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_call_replace_request(
        int call_id, IntPtr rdata, ref int st_code,
    ref pj_str_t st_text);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_stream_destroyed(int call_id, IntPtr sess, uint stream_idx);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_stream_created(
        int call_id, IntPtr sess, uint stream_idx, [In][Out] ref pjmedia_port p_port);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_call_tsx_state(int call_id, IntPtr tsx, ref IntPtr e);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_incoming_call(int acc_id, int call_id, IntPtr rdata);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate pjsip_redirect_op pjsua_callback_on_call_redirected(int call_id, ref pjsip_uri target, IntPtr e);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void pjsua_callback_on_mwi_info(int acc_id, IntPtr mwi_info);

    [StructLayout(LayoutKind.Sequential)]
    public class pjsua_config
    {
        public uint max_calls;
        public uint thread_cnt;
        public uint nameserver_count;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        ///// pj_str_t
        public pj_str_t[] nameserver;
        //[MarshalAs(UnmanagedType.I1)]
        public int force_lr;
        public uint outbound_proxy_cnt;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public pj_str_t[] outbound_proxy;
        /// pj_str_t
        public pj_str_t stun_domain;
        /// pj_str_t
        public pj_str_t stun_host;

        public uint stun_srv_cnt;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public pj_str_t[] stun_srv;
        public int stun_ignore_failure;

        public int nat_type_in_sdp;
        //[MarshalAs(UnmanagedType.I1)]
        public int require_100rel;
        public int require_timer;
        public pjsip_timer_setting timer_setting;
        public uint cred_count;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.Struct)]
        public pjsip_cred_info[] cred_info;
        /// pj_str_t
        public pj_str_t user_agent;
        public pjmedia_srtp_use use_srtp;
        public int srtp_secure_signaling;
        //[MarshalAs(UnmanagedType.I1)]
        public int hangup_forked_call;
        public pjsua_callback cb;

        public pjsua_config()
        {
            nameserver = new pj_str_t[4];
            outbound_proxy = new pj_str_t[4];
            stun_srv = new pj_str_t[8];
            cred_info = new pjsip_cred_info[8];
        }
    }
}
