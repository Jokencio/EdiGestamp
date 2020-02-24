﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace indice.Edi
{
    public enum PictureKind
    {
        Alphanumeric,
        Numeric
    }

    /// <summary>
    /// Indicates the number of numeric (9) digits or alphanumeric (X) characters allowed in the data field.  
    /// If the field is numeric, this excludes any minus sign or the decimal point.  
    /// The decimal point is implied and its position within the data field is indicate by V.
    /// </summary>
    public struct Picture
    {
        private const string PARSE_PATTERN = @"([9X]{1})\s?\((\d+?)\)\s?(V9\((\d+?)\))?";
        private readonly byte _Precision;
        private readonly ushort _Scale;
        private readonly PictureKind _Kind;

        /// <summary>
        /// This is the total size of the string in digits
        /// </summary>
        public int Scale {
            get { return _Scale; }
        }

        /// <summary>
        /// In case of floating point number this holds the number of decimal places. Its length.
        /// </summary>
        public int Precision {
            get { return _Precision; }
        }

        /// <summary>
        /// indicates the <see cref="Kind" /> of the value represented. (ie <see cref="PictureKind.Alphanumeric"/>)
        /// </summary>
        public PictureKind Kind {
            get { return _Kind; }
        }

        /// <summary>
        /// This indicated if the value is a floating point number with by checking whether <see cref="Precision"/> is positive.
        /// </summary>
        public bool HasPrecision {
            get {
                return _Precision > 0;
            }
        }

        public bool IsValid {
            get {
                return _Scale > 0;
            }
        }

        public Picture(ushort length) {
            _Scale = length;
            _Precision = 0;
            _Kind = PictureKind.Alphanumeric;
        }

        public Picture(ushort length, PictureKind kind) {
            _Scale = length;
            _Precision = 0;
            _Kind = kind;
        }

        public Picture(ushort integerLength, byte decimalLength) {
            _Scale = (ushort)(integerLength + decimalLength);
            _Precision = decimalLength;
            _Kind = PictureKind.Numeric;
        }

        public Picture(ushort integerLength, byte decimalLength, PictureKind kind) {
            _Scale = (ushort)(integerLength + decimalLength);
            _Precision = decimalLength;
            _Kind = kind;
        }

        public override int GetHashCode() {
            return _Kind.GetHashCode() ^ _Scale.GetHashCode() ^ _Precision.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (obj != null && obj is Picture) {
                var other = ((Picture)obj);
                return other.Precision == Precision && other.Scale == Scale;
            }
            return base.Equals(obj);
        }

        public override string ToString() {
            switch (Kind) {
                case PictureKind.Alphanumeric:
                    return string.Format("X({0})", Scale);
                case PictureKind.Numeric:
                    return HasPrecision ? string.Format("9({0}) V9({1})", Scale - Precision, Precision) : string.Format("9({0})", Scale);
                default:
                    return string.Format("{0}({1},{2})", Kind, Scale, Precision);
            }
        }

        public static Picture Parse(string text) {
            var match = Regex.Match(text, PARSE_PATTERN);

            if (match != null) {
                var kind = match.Groups[1].Value == "X" ? PictureKind.Alphanumeric : PictureKind.Numeric;
                var length = ushort.Parse(match.Groups[2].Value);
                byte decimalLength = 0;
                if (kind == PictureKind.Numeric && !string.IsNullOrWhiteSpace(match.Groups[3].Value)) {
                    decimalLength = byte.Parse(match.Groups[4].Value);
                }
                return new Picture(length, decimalLength, kind);
            } else {
                return new Picture();
            }
        }

        public static implicit operator String(Picture value) {
            return value.ToString();
        }

        public static explicit operator Picture(string value) {
            return Picture.Parse(value);
        }
    }
}