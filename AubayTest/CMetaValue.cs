/*
 * Created by SharpDevelop.
 * User: Edgar Esteves
 * Date: 19/06/2018
 * Time: 12:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AubayTest
{
class DLL_EXPORTABLE
    {
        public class CMetaValue
        {
            public static CMetaValue cMetaValue { get; set; }

            public CMetaValue(CMetaValue src)
            {
                cMetaValue = src;
            }

            public CMetaValue(string szStr = null, bool bIsDate = false, bool bIsBool = false, bool bIsTraceable = true)
            {
                m_bIsDate = bIsDate; m_Value = szStr; m_bIsBool = bIsBool; m_bIsTraceable = bIsTraceable;
            }

            public static CMetaValue operator +(CMetaValue cmv)
            {
                cMetaValue.m_Value = cmv.m_Value;
                cMetaValue.m_bIsDate = cmv.m_bIsDate;
                cMetaValue.m_bIsBool = cmv.m_bIsBool;
                cMetaValue.m_bIsTraceable = cmv.m_bIsTraceable;

                return cmv;
            }


            public static bool operator ==(CMetaValue cmv, string szStr)
            {
                return cmv.Equals(szStr);
            }
 
            public static bool operator !=(CMetaValue cmv, String szStr)
            {
                return !cmv.Equals(szStr);
            }

            public static string operator +(CMetaValue cmv, CMetaValue src)
            {
                return cmv.m_Value;
            }

            public static bool operator ==(CMetaValue cmv, CMetaValue src)
            {
                return cmv.m_bIsDate = src.m_bIsDate && cmv.m_Value == src.m_Value;
            }

            public static bool operator !=(CMetaValue cmv, CMetaValue src)
            {
                return cmv.Equals(src);
            }

            public Boolean IsEmpty()
            {
                return string.IsNullOrEmpty(m_Value);
            }

            public int GetLength()
            {
                return m_Value.Length;
            }

            public void MakeUpper()
            {
                m_Value = m_Value.ToUpper();
            }

            public bool IsTraceable()
            {
                return m_bIsTraceable;
            }

            protected string m_Value { get; set; }
            protected bool m_bIsDate { get; set; }
            protected bool m_bIsBool { get; set; }
            protected bool m_bIsTraceable { get; set; }
        }

    }
}
