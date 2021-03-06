// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Globalization;

namespace System.ComponentModel
{
    /// <summary>
    ///    <para>Provides a type converter to convert 64-bit unsigned integer objects to and
    ///       from various other representations.</para>
    /// </summary>
    public class UInt64Converter : BaseNumberConverter
    {
        /// <summary>
        /// The Type this converter is targeting (e.g. Int16, UInt64, etc.)
        /// </summary>
        internal override Type TargetType
        {
            get
            {
                return typeof(UInt64);
            }
        }

        /// <summary>
        /// Convert the given value to a string using the given radix
        /// </summary>
        internal override object FromString(string value, int radix)
        {
            return Convert.ToUInt64(value, radix);
        }

        /// <summary>
        /// Convert the given value to a string using the given formatInfo
        /// </summary>
        internal override object FromString(string value, NumberFormatInfo formatInfo)
        {
            return UInt64.Parse(value, NumberStyles.Integer, formatInfo);
        }


        /// <summary>
        /// Convert the given value to a string using the given CultureInfo
        /// </summary>
        internal override object FromString(string value, CultureInfo culture)
        {
            return UInt64.Parse(value, culture);
        }

        /// <summary>
        /// Convert the given value from a string using the given formatInfo
        /// </summary>
        internal override string ToString(object value, NumberFormatInfo formatInfo)
        {
            return ((UInt64)value).ToString("G", formatInfo);
        }
    }
}

