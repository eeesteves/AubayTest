/*
 * Created by SharpDevelop.
 * User: simes
 * Date: 19/06/2018
 * Time: 18:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
#include "DLL_EXPORTABLE.h"
using namespace System;

namespace AubayTest
{
class DLL_EXPORTABLE CMetaValue : public CObject
{
public:
       CMetaValue (const CMetaValue& src)
       { *this = src; }
       CMetaValue (LPCTSTR szStr = NULL, BOOL bIsDate = FALSE, BOOL bIsBool = FALSE, BOOL bIsTraceable = TRUE)
       { m_bIsDate = bIsDate; m_Value = szStr; m_bIsBool = bIsBool; m_bIsTraceable = bIsTraceable; }
public:
       CMetaValue& operator=(const CMetaValue& src)
       { m_Value = src.m_Value; m_bIsDate = src.m_bIsDate; m_bIsBool = src.m_bIsBool; m_bIsTraceable = src.m_bIsTraceable; return *this; }
       CMetaValue& operator=(LPCTSTR szStr)
       { *this = CMetaValue (szStr); return *this; }
       operator const CString& () const
       { return m_Value; } 
       BOOL operator==(const CMetaValue& src) const
       { return m_bIsDate == src.m_bIsDate && m_Value == src.m_Value; }
       BOOL operator!=(const CMetaValue& src) const
       { return !operator== (src); }
public:
       BOOL   IsEmpty () const
       { return m_Value.IsEmpty (); }
       int          GetLength () const
       { return m_Value.GetLength (); }
       void   MakeUpper ()
       { m_Value.MakeUpper (); }
       BOOL   IsTraceable () const
       { return m_bIsTraceable; }
protected:
       CString      m_Value;
       BOOL         m_bIsDate;
       BOOL         m_bIsBool;
       BOOL         m_bIsTraceable;
};
}
