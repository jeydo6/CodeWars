using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Blank.Library
{
	/*
        Customized format patterns:
        P.S. Format in the table below is the internal number format used to display the pattern.

        Patterns   Format      Description                           Example
        =========  ==========  ===================================== ========
        "h"     "0"         hour (12-hour clock)w/o leading zero  3
        "hh"    "00"        hour (12-hour clock)with leading zero 03
        "hh*"   "00"        hour (12-hour clock)with leading zero 03

        "H"     "0"         hour (24-hour clock)w/o leading zero  8
        "HH"    "00"        hour (24-hour clock)with leading zero 08
        "HH*"   "00"        hour (24-hour clock)                  08

        "m"     "0"         minute w/o leading zero
        "mm"    "00"        minute with leading zero
        "mm*"   "00"        minute with leading zero

        "s"     "0"         second w/o leading zero
        "ss"    "00"        second with leading zero
        "ss*"   "00"        second with leading zero

        "f"     "0"         second fraction (1 digit)
        "ff"    "00"        second fraction (2 digit)
        "fff"   "000"       second fraction (3 digit)
        "ffff"  "0000"      second fraction (4 digit)
        "fffff" "00000"         second fraction (5 digit)
        "ffffff"    "000000"    second fraction (6 digit)
        "fffffff"   "0000000"   second fraction (7 digit)

        "F"     "0"         second fraction (up to 1 digit)
        "FF"    "00"        second fraction (up to 2 digit)
        "FFF"   "000"       second fraction (up to 3 digit)
        "FFFF"  "0000"      second fraction (up to 4 digit)
        "FFFFF" "00000"         second fraction (up to 5 digit)
        "FFFFFF"    "000000"    second fraction (up to 6 digit)
        "FFFFFFF"   "0000000"   second fraction (up to 7 digit)

        "t"                 first character of AM/PM designator   A
        "tt"                AM/PM designator                      AM
        "tt*"               AM/PM designator                      PM

        "d"     "0"         day w/o leading zero                  1
        "dd"    "00"        day with leading zero                 01
        "ddd"               short weekday name (abbreviation)     Mon
        "dddd"              full weekday name                     Monday
        "dddd*"             full weekday name                     Monday


        "M"     "0"         month w/o leading zero                2
        "MM"    "00"        month with leading zero               02
        "MMM"               short month name (abbreviation)       Feb
        "MMMM"              full month name                       Febuary
        "MMMM*"             full month name                       Febuary

        "y"     "0"         two digit year (year % 100) w/o leading zero           0
        "yy"    "00"        two digit year (year % 100) with leading zero          00
        "yyy"   "D3"        year                                  2000
        "yyyy"  "D4"        year                                  2000
        "yyyyy" "D5"        year                                  2000
        ...

        "z"     "+0;-0"     timezone offset w/o leading zero      -8
        "zz"    "+00;-00"   timezone offset with leading zero     -08
        "zzz"      "+00;-00" for hour offset, "00" for minute offset  full timezone offset   -07:30
        "zzz*"  "+00;-00" for hour offset, "00" for minute offset   full timezone offset   -08:00

        "K"    -Local       "zzz", e.g. -08:00
                -Utc         "'Z'", representing UTC
                -Unspecified ""
                -DateTimeOffset      "zzzzz" e.g -07:30:15

        "g*"                the current era name                  A.D.

        ":"                 time separator                        : -- DEPRECATED - Insert separator directly into pattern (eg: "H.mm.ss")
        "/"                 date separator                        /-- DEPRECATED - Insert separator directly into pattern (eg: "M-dd-yyyy")
        "'"                 quoted string                         'ABC' will insert ABC into the formatted string.
        '"'                 quoted string                         "ABC" will insert ABC into the formatted string.
        "%"                 used to quote a single pattern characters      E.g.The format character "%y" is to print two digit year.
        "\"                 escaped character                     E.g. '\d' insert the character 'd' into the format string.
        other characters    insert the character into the format string.

    Pre-defined format characters:
        (U) to indicate Universal time is used.
        (G) to indicate Gregorian calendar is used.

        Format              Description                             Real format                             Example
        =========           =================================       ======================                  =======================
        "d"                 short date                              culture-specific                        10/31/1999
        "D"                 long data                               culture-specific                        Sunday, October 31, 1999
        "f"                 full date (long date + short time)      culture-specific                        Sunday, October 31, 1999 2:00 AM
        "F"                 full date (long date + long time)       culture-specific                        Sunday, October 31, 1999 2:00:00 AM
        "g"                 general date (short date + short time)  culture-specific                        10/31/1999 2:00 AM
        "G"                 general date (short date + long time)   culture-specific                        10/31/1999 2:00:00 AM
        "m"/"M"             Month/Day date                          culture-specific                        October 31
    (G)     "o"/"O"             Round Trip XML                          "yyyy-MM-ddTHH:mm:ss.fffffffK"          1999-10-31 02:00:00.0000000Z
    (G)     "r"/"R"             RFC 1123 date,                          "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"   Sun, 31 Oct 1999 10:00:00 GMT
    (G)     "s"                 Sortable format, based on ISO 8601.     "yyyy-MM-dd'T'HH:mm:ss"                 1999-10-31T02:00:00
                                                                    ('T' for local time)
        "t"                 short time                              culture-specific                        2:00 AM
        "T"                 long time                               culture-specific                        2:00:00 AM
    (G)     "u"                 Universal time with sortable format,    "yyyy'-'MM'-'dd HH':'mm':'ss'Z'"        1999-10-31 10:00:00Z
                            based on ISO 8601.
    (U)     "U"                 Universal time with full                culture-specific                        Sunday, October 31, 1999 10:00:00 AM
                            (long date + long time) format
                            "y"/"Y"             Year/Month day                          culture-specific                        October, 1999

    */
	internal static class DateOnlyFormat
	{
		private static readonly DateTimeFormatInfo InvariantFormatInfo = CultureInfo.InvariantCulture.DateTimeFormat;
		private static readonly string[] InvariantAbbreviatedMonthNames = InvariantFormatInfo.AbbreviatedMonthNames;
		private static readonly string[] InvariantAbbreviatedDayNames = InvariantFormatInfo.AbbreviatedDayNames;

		internal static string Format(DateOnly date, string? format, IFormatProvider? provider)
		{
			return date.ToDateTime().ToString(format, provider);
		}

		internal static bool TryFormat(DateOnly date, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
		{
			return date.ToDateTime().TryFormat(destination, out charsWritten, format, provider);
		}

		// Roundtrippable format. One of
		//   012345678901234567890123456789012
		//   ---------------------------------
		//   2017-06-12
		internal static bool TryFormatDateOnlyO(int year, int month, int day, Span<char> destination)
		{
			if (destination.Length < 10)
			{
				return false;
			}

			WriteFourDecimalDigits((uint)year, destination, 0);
			destination[4] = '-';
			WriteTwoDecimalDigits((uint)month, destination, 5);
			destination[7] = '-';
			WriteTwoDecimalDigits((uint)day, destination, 8);
			return true;
		}

		// Rfc1123
		//   01234567890123456789012345678
		//   -----------------------------
		//   Tue, 03 Jan 2017
		internal static bool TryFormatDateOnlyR(DayOfWeek dayOfWeek, int year, int month, int day, Span<char> destination)
		{
			if (destination.Length < 16)
			{
				return false;
			}

			string dayAbbrev = InvariantAbbreviatedDayNames[(int)dayOfWeek];
			Debug.Assert(dayAbbrev.Length == 3);

			string monthAbbrev = InvariantAbbreviatedMonthNames[month - 1];
			Debug.Assert(monthAbbrev.Length == 3);

			destination[0] = dayAbbrev[0];
			destination[1] = dayAbbrev[1];
			destination[2] = dayAbbrev[2];
			destination[3] = ',';
			destination[4] = ' ';
			WriteTwoDecimalDigits((uint)day, destination, 5);
			destination[7] = ' ';
			destination[8] = monthAbbrev[0];
			destination[9] = monthAbbrev[1];
			destination[10] = monthAbbrev[2];
			destination[11] = ' ';
			WriteFourDecimalDigits((uint)year, destination, 12);
			return true;
		}

		internal static bool IsValidCustomDateFormat(ReadOnlySpan<char> format, bool throwOnError)
		{
			int i = 0;

			while (i < format.Length)
			{
				switch (format[i])
				{
					case '\\':
						if (i == format.Length - 1)
						{
							if (throwOnError)
							{
								throw new FormatException("Invalid string!");
							}

							return false;
						}

						i += 2;
						break;

					case '\'':
					case '"':
						char quoteChar = format[i++];
						while (i < format.Length && format[i] != quoteChar)
						{
							i++;
						}

						if (i >= format.Length)
						{
							if (throwOnError)
							{
								throw new FormatException($"Bad quote char: {quoteChar}!");
							}

							return false;
						}

						i++;
						break;

					case ':':
					case 't':
					case 'f':
					case 'F':
					case 'h':
					case 'H':
					case 'm':
					case 's':
					case 'z':
					case 'K':
						// reject non-date formats
						if (throwOnError)
						{
							throw new FormatException("Invalid string!");
						}

						return false;

					default:
						i++;
						break;
				}
			}

			return true;
		}

		/// <summary>
		/// Writes a value [ 00 .. 99 ] to the buffer starting at the specified offset.
		/// This method performs best when the starting index is a constant literal.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void WriteTwoDecimalDigits(uint value, Span<char> destination, int offset)
		{
			Debug.Assert(value <= 99);

			uint temp = '0' + value;
			value /= 10;
			destination[offset + 1] = (char)(temp - (value * 10));
			destination[offset] = (char)('0' + value);
		}

		/// <summary>
		/// Writes a value [ 0000 .. 9999 ] to the buffer starting at the specified offset.
		/// This method performs best when the starting index is a constant literal.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void WriteFourDecimalDigits(uint value, Span<char> buffer, int startingIndex = 0)
		{
			Debug.Assert(value <= 9999);

			uint temp = '0' + value;
			value /= 10;
			buffer[startingIndex + 3] = (char)(temp - (value * 10));

			temp = '0' + value;
			value /= 10;
			buffer[startingIndex + 2] = (char)(temp - (value * 10));

			temp = '0' + value;
			value /= 10;
			buffer[startingIndex + 1] = (char)(temp - (value * 10));

			buffer[startingIndex] = (char)('0' + value);
		}
	}
}
