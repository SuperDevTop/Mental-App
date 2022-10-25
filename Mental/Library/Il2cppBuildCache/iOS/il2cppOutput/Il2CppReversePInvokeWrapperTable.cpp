#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <stdint.h>
#include <limits>



// System.String
struct String_t;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;

struct unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902;
struct unitytls_key_ref_t6BD91D013DF11047C53738FEEB12CE290FDC71A2;
struct unitytls_tlsctx_tF8BBCBFE1E957B846442DED65ECB89BC5307DEAE;
struct unitytls_x509list_ref_t6C5C1CF0B720516A681CB741104A164FD8B3CF17;
struct unitytls_x509name_t8A1108C917795D8FE946B50769ACE51489C7BF5D;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// Unity.Notifications.iOS.CalendarTriggerData
struct CalendarTriggerData_t95CDF224E7B6165CE42899A54B3BADAE1B4BBB23 
{
	// System.Int32 Unity.Notifications.iOS.CalendarTriggerData::year
	int32_t ___year_0;
	// System.Int32 Unity.Notifications.iOS.CalendarTriggerData::month
	int32_t ___month_1;
	// System.Int32 Unity.Notifications.iOS.CalendarTriggerData::day
	int32_t ___day_2;
	// System.Int32 Unity.Notifications.iOS.CalendarTriggerData::hour
	int32_t ___hour_3;
	// System.Int32 Unity.Notifications.iOS.CalendarTriggerData::minute
	int32_t ___minute_4;
	// System.Int32 Unity.Notifications.iOS.CalendarTriggerData::second
	int32_t ___second_5;
	// System.Byte Unity.Notifications.iOS.CalendarTriggerData::repeats
	uint8_t ___repeats_6;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// Unity.Notifications.iOS.LocationTriggerData
struct LocationTriggerData_t6C709C3123CDD15B8FA218B532776BAB4B0172FC 
{
	// System.Single Unity.Notifications.iOS.LocationTriggerData::centerX
	float ___centerX_0;
	// System.Single Unity.Notifications.iOS.LocationTriggerData::centerY
	float ___centerY_1;
	// System.Single Unity.Notifications.iOS.LocationTriggerData::radius
	float ___radius_2;
	// System.Byte Unity.Notifications.iOS.LocationTriggerData::notifyOnEntry
	uint8_t ___notifyOnEntry_3;
	// System.Byte Unity.Notifications.iOS.LocationTriggerData::notifyOnExit
	uint8_t ___notifyOnExit_4;
};

// Unity.Notifications.iOS.TimeTriggerData
struct TimeTriggerData_t110F07D01BDEC0F8D7C1E625A581638C9AEE6823 
{
	// System.Int32 Unity.Notifications.iOS.TimeTriggerData::interval
	int32_t ___interval_0;
	// System.Byte Unity.Notifications.iOS.TimeTriggerData::repeats
	uint8_t ___repeats_1;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// Unity.Notifications.iOS.iOSAuthorizationRequestData
struct iOSAuthorizationRequestData_t216987B5D9A6729184F783B5F68AE9124B9321AC 
{
	// System.Int32 Unity.Notifications.iOS.iOSAuthorizationRequestData::granted
	int32_t ___granted_0;
	// System.String Unity.Notifications.iOS.iOSAuthorizationRequestData::error
	String_t* ___error_1;
	// System.String Unity.Notifications.iOS.iOSAuthorizationRequestData::deviceToken
	String_t* ___deviceToken_2;
};
// Native definition for P/Invoke marshalling of Unity.Notifications.iOS.iOSAuthorizationRequestData
struct iOSAuthorizationRequestData_t216987B5D9A6729184F783B5F68AE9124B9321AC_marshaled_pinvoke
{
	int32_t ___granted_0;
	char* ___error_1;
	char* ___deviceToken_2;
};
// Native definition for COM marshalling of Unity.Notifications.iOS.iOSAuthorizationRequestData
struct iOSAuthorizationRequestData_t216987B5D9A6729184F783B5F68AE9124B9321AC_marshaled_com
{
	int32_t ___granted_0;
	Il2CppChar* ___error_1;
	Il2CppChar* ___deviceToken_2;
};

// Mono.Unity.UnityTls/unitytls_x509_ref
struct unitytls_x509_ref_t9CEB17766B4144117333AB50379B21A357FA4333 
{
	// System.UInt64 Mono.Unity.UnityTls/unitytls_x509_ref::handle
	uint64_t ___handle_0;
};

// Mono.Unity.UnityTls/unitytls_x509list_ref
struct unitytls_x509list_ref_t6C5C1CF0B720516A681CB741104A164FD8B3CF17 
{
	// System.UInt64 Mono.Unity.UnityTls/unitytls_x509list_ref::handle
	uint64_t ___handle_0;
};

// Unity.Notifications.iOS.TriggerData
struct TriggerData_t5B00176E3EB034DB9078E419981580696EB8D39E 
{
	union
	{
		#pragma pack(push, tp, 1)
		struct
		{
			// Unity.Notifications.iOS.TimeTriggerData Unity.Notifications.iOS.TriggerData::timeInterval
			TimeTriggerData_t110F07D01BDEC0F8D7C1E625A581638C9AEE6823 ___timeInterval_0;
		};
		#pragma pack(pop, tp)
		struct
		{
			TimeTriggerData_t110F07D01BDEC0F8D7C1E625A581638C9AEE6823 ___timeInterval_0_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// Unity.Notifications.iOS.CalendarTriggerData Unity.Notifications.iOS.TriggerData::calendar
			CalendarTriggerData_t95CDF224E7B6165CE42899A54B3BADAE1B4BBB23 ___calendar_1;
		};
		#pragma pack(pop, tp)
		struct
		{
			CalendarTriggerData_t95CDF224E7B6165CE42899A54B3BADAE1B4BBB23 ___calendar_1_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// Unity.Notifications.iOS.LocationTriggerData Unity.Notifications.iOS.TriggerData::location
			LocationTriggerData_t6C709C3123CDD15B8FA218B532776BAB4B0172FC ___location_2;
		};
		#pragma pack(pop, tp)
		struct
		{
			LocationTriggerData_t6C709C3123CDD15B8FA218B532776BAB4B0172FC ___location_2_forAlignmentOnly;
		};
	};
};

// Unity.Notifications.iOS.iOSNotificationData
struct iOSNotificationData_t57D24EBD788D6C71F203ACE14688358AFA08BDED 
{
	// System.String Unity.Notifications.iOS.iOSNotificationData::identifier
	String_t* ___identifier_0;
	// System.String Unity.Notifications.iOS.iOSNotificationData::title
	String_t* ___title_1;
	// System.String Unity.Notifications.iOS.iOSNotificationData::body
	String_t* ___body_2;
	// System.Int32 Unity.Notifications.iOS.iOSNotificationData::badge
	int32_t ___badge_3;
	// System.String Unity.Notifications.iOS.iOSNotificationData::subtitle
	String_t* ___subtitle_4;
	// System.String Unity.Notifications.iOS.iOSNotificationData::categoryIdentifier
	String_t* ___categoryIdentifier_5;
	// System.String Unity.Notifications.iOS.iOSNotificationData::threadIdentifier
	String_t* ___threadIdentifier_6;
	// System.IntPtr Unity.Notifications.iOS.iOSNotificationData::userInfo
	intptr_t ___userInfo_7;
	// System.IntPtr Unity.Notifications.iOS.iOSNotificationData::attachments
	intptr_t ___attachments_8;
	// System.Int32 Unity.Notifications.iOS.iOSNotificationData::triggerType
	int32_t ___triggerType_9;
	// Unity.Notifications.iOS.TriggerData Unity.Notifications.iOS.iOSNotificationData::trigger
	TriggerData_t5B00176E3EB034DB9078E419981580696EB8D39E ___trigger_10;
};
// Native definition for P/Invoke marshalling of Unity.Notifications.iOS.iOSNotificationData
struct iOSNotificationData_t57D24EBD788D6C71F203ACE14688358AFA08BDED_marshaled_pinvoke
{
	char* ___identifier_0;
	char* ___title_1;
	char* ___body_2;
	int32_t ___badge_3;
	char* ___subtitle_4;
	char* ___categoryIdentifier_5;
	char* ___threadIdentifier_6;
	intptr_t ___userInfo_7;
	intptr_t ___attachments_8;
	int32_t ___triggerType_9;
	TriggerData_t5B00176E3EB034DB9078E419981580696EB8D39E ___trigger_10;
};
// Native definition for COM marshalling of Unity.Notifications.iOS.iOSNotificationData
struct iOSNotificationData_t57D24EBD788D6C71F203ACE14688358AFA08BDED_marshaled_com
{
	Il2CppChar* ___identifier_0;
	Il2CppChar* ___title_1;
	Il2CppChar* ___body_2;
	int32_t ___badge_3;
	Il2CppChar* ___subtitle_4;
	Il2CppChar* ___categoryIdentifier_5;
	Il2CppChar* ___threadIdentifier_6;
	intptr_t ___userInfo_7;
	intptr_t ___attachments_8;
	int32_t ___triggerType_9;
	TriggerData_t5B00176E3EB034DB9078E419981580696EB8D39E ___trigger_10;
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif

extern "C" void DEFAULT_CALL ReversePInvokeWrapper_CultureInfo_OnCultureInfoChangedInAppX_m407BCFC1029A4485B7B063BC2F3601968C3BE577(Il2CppChar* ___language0);
extern "C" int32_t CDECL ReversePInvokeWrapper_DeflateStreamNative_UnmanagedRead_m321A2621068F1C9509594A4D8F405F4F12C1CEB3(intptr_t ___buffer0, int32_t ___length1, intptr_t ___data2);
extern "C" int32_t CDECL ReversePInvokeWrapper_DeflateStreamNative_UnmanagedWrite_mB0AD438266A9DD2813715E8BC90BF07DC7A02F52(intptr_t ___buffer0, int32_t ___length1, intptr_t ___data2);
extern "C" int64_t CDECL ReversePInvokeWrapper_MonoBtlsBioMono_Control_mA7B1C493171314C6F02CAC5F73EB7CB94B86ED78(intptr_t ___instance0, int32_t ___command1, int64_t ___arg2);
extern "C" int32_t CDECL ReversePInvokeWrapper_MonoBtlsBioMono_OnRead_m8888AD0EA2D55D9FFE183BC63D4023BC621941F9(intptr_t ___instance0, intptr_t ___data1, int32_t ___dataLength2, int32_t* ___wantMore3);
extern "C" int32_t CDECL ReversePInvokeWrapper_MonoBtlsBioMono_OnWrite_mD90183BD125599306AAF4E74E941A3983027C575(intptr_t ___instance0, intptr_t ___data1, int32_t ___dataLength2);
extern "C" int32_t CDECL ReversePInvokeWrapper_MonoBtlsSsl_PrintErrorsCallback_m93ED1F9335C5974459F0915323C5527382A83959(intptr_t ___str0, intptr_t ___len1, intptr_t ___ctx2);
extern "C" int32_t CDECL ReversePInvokeWrapper_MonoBtlsSslCtx_NativeSelectCallback_m5A906B70CBEC53FE7F4208810264D78D4AA26EE4(intptr_t ___instance0, int32_t ___count1, intptr_t ___sizes2, intptr_t ___data3);
extern "C" int32_t CDECL ReversePInvokeWrapper_MonoBtlsSslCtx_NativeServerNameCallback_mC76D35B6D2668F93E280D35B5560A06571810857(intptr_t ___instance0);
extern "C" int32_t CDECL ReversePInvokeWrapper_MonoBtlsSslCtx_NativeVerifyCallback_m13C23EDCF9CDADF430C5A1664D33DC7621974916(intptr_t ___instance0, int32_t ___preverify_ok1, intptr_t ___store_ctx2);
extern "C" int32_t CDECL ReversePInvokeWrapper_MonoBtlsX509LookupMono_OnGetBySubject_m85B0F4B20C12F67DE4CD9521EC58308C9A27BA24(intptr_t ___instance0, intptr_t ___name_ptr1, intptr_t* ___x509_ptr2);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_OSSpecificSynchronizationContext_InvocationEntry_mF93C3CF6DBEC86E377576D840CAF517CB6E4D7E3(intptr_t ___arg0);
extern "C" void CDECL ReversePInvokeWrapper_UnityTlsContext_CertificateCallback_m8CC672A44A8CCFD2A3EB2D9B38A9A134F6EF706B(void* ___userData0, unitytls_tlsctx_tF8BBCBFE1E957B846442DED65ECB89BC5307DEAE* ___ctx1, uint8_t* ___cn2, intptr_t ___cnLen3, unitytls_x509name_t8A1108C917795D8FE946B50769ACE51489C7BF5D* ___caList4, intptr_t ___caListLen5, unitytls_x509list_ref_t6C5C1CF0B720516A681CB741104A164FD8B3CF17* ___chain6, unitytls_key_ref_t6BD91D013DF11047C53738FEEB12CE290FDC71A2* ___key7, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState8);
extern "C" intptr_t CDECL ReversePInvokeWrapper_UnityTlsContext_ReadCallback_m068A7DC153B3D2C4F6922B46BC5957CF33AE3450(void* ___userData0, uint8_t* ___buffer1, intptr_t ___bufferLen2, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState3);
extern "C" uint32_t CDECL ReversePInvokeWrapper_UnityTlsContext_VerifyCallback_mC7AE01FAD8A336A6BF11CF8A3EFAC60CF6167E6F(void* ___userData0, unitytls_x509list_ref_t6C5C1CF0B720516A681CB741104A164FD8B3CF17 ___chain1, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState2);
extern "C" intptr_t CDECL ReversePInvokeWrapper_UnityTlsContext_WriteCallback_m74F83CFEE7D8FB7EBD1A1021DCB8945E89382998(void* ___userData0, uint8_t* ___data1, intptr_t ___bufferLen2, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState3);
extern "C" uint32_t CDECL ReversePInvokeWrapper_UnityTlsProvider_x509verify_callback_mB2465D108005179B9873A37C418CD26A37194E3B(void* ___userData0, unitytls_x509_ref_t9CEB17766B4144117333AB50379B21A357FA4333 ___cert1, uint32_t ___result2, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState3);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_iOSNotificationsWrapper_AuthorizationRequestReceived_m4A6C75E5BFEA2C3E529F2F8CEEA8A813F428B3CD(intptr_t ___request0, iOSAuthorizationRequestData_t216987B5D9A6729184F783B5F68AE9124B9321AC_marshaled_pinvoke ___data1);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_iOSNotificationsWrapper_NotificationReceived_mB7F4859AF321D5AF115D70F4BD8AB131543D7524(iOSNotificationData_t57D24EBD788D6C71F203ACE14688358AFA08BDED_marshaled_pinvoke ___data0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_iOSNotificationsWrapper_ReceiveNSDictionaryKeyValue_m57E371B7275602846E05E0770BFA78C6641BC856(intptr_t ___dict0, char* ___key1, char* ___value2);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_iOSNotificationsWrapper_ReceiveUNNotificationAttachment_mF8194BDA3434E46D10AF292C61D4F3E00B654652(intptr_t ___array0, char* ___id1, char* ___url2);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_iOSNotificationsWrapper_RemoteNotificationReceived_mBF44180FD060AC5811C9979FE6E771650AA35212(iOSNotificationData_t57D24EBD788D6C71F203ACE14688358AFA08BDED_marshaled_pinvoke ___data0);


IL2CPP_EXTERN_C const Il2CppMethodPointer g_ReversePInvokeWrapperPointers[];
const Il2CppMethodPointer g_ReversePInvokeWrapperPointers[22] = 
{
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_CultureInfo_OnCultureInfoChangedInAppX_m407BCFC1029A4485B7B063BC2F3601968C3BE577),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_DeflateStreamNative_UnmanagedRead_m321A2621068F1C9509594A4D8F405F4F12C1CEB3),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_DeflateStreamNative_UnmanagedWrite_mB0AD438266A9DD2813715E8BC90BF07DC7A02F52),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_MonoBtlsBioMono_Control_mA7B1C493171314C6F02CAC5F73EB7CB94B86ED78),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_MonoBtlsBioMono_OnRead_m8888AD0EA2D55D9FFE183BC63D4023BC621941F9),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_MonoBtlsBioMono_OnWrite_mD90183BD125599306AAF4E74E941A3983027C575),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_MonoBtlsSsl_PrintErrorsCallback_m93ED1F9335C5974459F0915323C5527382A83959),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_MonoBtlsSslCtx_NativeSelectCallback_m5A906B70CBEC53FE7F4208810264D78D4AA26EE4),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_MonoBtlsSslCtx_NativeServerNameCallback_mC76D35B6D2668F93E280D35B5560A06571810857),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_MonoBtlsSslCtx_NativeVerifyCallback_m13C23EDCF9CDADF430C5A1664D33DC7621974916),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_MonoBtlsX509LookupMono_OnGetBySubject_m85B0F4B20C12F67DE4CD9521EC58308C9A27BA24),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_OSSpecificSynchronizationContext_InvocationEntry_mF93C3CF6DBEC86E377576D840CAF517CB6E4D7E3),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsContext_CertificateCallback_m8CC672A44A8CCFD2A3EB2D9B38A9A134F6EF706B),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsContext_ReadCallback_m068A7DC153B3D2C4F6922B46BC5957CF33AE3450),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsContext_VerifyCallback_mC7AE01FAD8A336A6BF11CF8A3EFAC60CF6167E6F),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsContext_WriteCallback_m74F83CFEE7D8FB7EBD1A1021DCB8945E89382998),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsProvider_x509verify_callback_mB2465D108005179B9873A37C418CD26A37194E3B),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_iOSNotificationsWrapper_AuthorizationRequestReceived_m4A6C75E5BFEA2C3E529F2F8CEEA8A813F428B3CD),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_iOSNotificationsWrapper_NotificationReceived_mB7F4859AF321D5AF115D70F4BD8AB131543D7524),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_iOSNotificationsWrapper_ReceiveNSDictionaryKeyValue_m57E371B7275602846E05E0770BFA78C6641BC856),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_iOSNotificationsWrapper_ReceiveUNNotificationAttachment_mF8194BDA3434E46D10AF292C61D4F3E00B654652),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_iOSNotificationsWrapper_RemoteNotificationReceived_mBF44180FD060AC5811C9979FE6E771650AA35212),
};
