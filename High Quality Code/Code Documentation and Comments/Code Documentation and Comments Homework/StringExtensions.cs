﻿namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class StringExtensions
    {
        /// <summary>
        /// Get MD5 hash of a string
        /// </summary>
        /// <param name="input">string to get MD5 hash</param>
        /// <returns>Returns a hexadecimal string</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            
            
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            
            return builder.ToString();
        }
        /// <summary>
        /// Check if a string contains true value(ex: true, ok, yes, 1, да)
        /// </summary>
        /// <param name="input">string that should be checked if it has true value or not</param>
        /// <returns>Returns boolean result if the input has true value (ex: true, ok, yes, 1, да)</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }
        /// <summary>
        /// Tries to parse input string and to out 16-bit signed integer
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Parsed string to 16-bit signed integer</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }
        /// <summary>
        /// Tries to parse input string and to out integer value
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Parses string to 32-bit integer</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }
        /// <summary>
        /// Tries to parse input string and to out long value
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns >Parses string to 64-bit integer</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }
        /// <summary>
        /// Tries to parse input string and to out variable type DateTime
        /// </summary>
        /// <param name="input">Input String</param>
        /// <returns>Parses string to DateTime</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }
        /// <summary>
        /// Capitalize first letter of a string
        /// </summary>
        /// <param name="input">string to capitalize first letter</param>
        /// <returns>return same string with capital first letter</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }
        /// <summary>
        /// From the inputted string we return the substring situated between
        /// the startString and endString
        /// </summary>
        /// <param name="input">Input string that is going to be used</param>
        /// <param name="startString">The left delimiter</param>
        /// <param name="endString">The right delimiter</param>
        /// <param name="startFrom">The search starts from here</param>
        /// <returns>Substring from the input string. It is being situated
        /// between startString and endString</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }
        /// <summary>
        /// Converts cyrillic to latin letters
        /// </summary>
        /// <param name="input" string with cyrillic letters</param>
        /// <returns>Returns new string with latin letters</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }
        /// <summary>
        /// Converts latin letters to cyrillic ones
        /// </summary>
        /// <param name="input">string with latin letters</param>
        /// <returns>Returns string with cyrillic letters</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }
        /// <summary>
        /// Convert a string from input to a username 
        /// </summary>
        /// <param name="input">string that represents invalid user name</param>
        /// <returns>Returns valid user name</returns>

        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }
        /// <summary>
        /// Convert a string from input to string with latins letter
        /// </summary>
        /// <param name="input">string that represents file name</param>
        /// <returns>Returns valid latin file name(replaces cyrillic letters with latin ones, and removes invalid chars)</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }
        /// <summary>
        /// Get the first defined sequence of characters from string
        /// </summary>
        /// <param name="input">input string</param>
        /// <param name="charsCount">input integer for comparing and determination length of substring</param>
        /// <returns>return substring from input string</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }
        /// <summary>
        /// Get file extension of a file name represented as a string
        /// </summary>
        /// <param name="fileName">string that represents file name</param>
        /// <returns>Returns file extension from file name, represented as sting. If file name is invalid returns empty string</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }
        /// <summary>
        /// Uses dictionary.If the inputted file extension is contained as a key
        /// in the dictionary we will have the dictionary value returned.
        /// </summary>
        /// <param name="fileExtension">used to check if is contained
        /// as key in the dictionary</param>
        /// <returns>value from the dictionary corresponding to the input key</returns>

        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }
        /// <summary>
        /// Converts a set of characters from the specified character array 
        /// into a sequence of bytes.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>A byte array containing the specified set of characters.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
