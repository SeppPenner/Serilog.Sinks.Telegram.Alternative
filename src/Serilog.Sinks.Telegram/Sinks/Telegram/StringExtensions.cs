﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="Hämmer Electronics">
// The project is licensed under the MIT license.
// </copyright>
// <summary>
//   A class containing extension methods for the <see cref="string" /> type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Serilog.Sinks.Telegram
{
    /// <summary>
    /// A class containing extension methods for the <see cref="string"/> type.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Escapes the invalid chars for Telegram to valid HTML encoded ones.
        /// </summary>
        /// <param name="value">The <see cref="string"/> value to escape.</param>
        /// <returns>A new escaped <see cref="string"/>.</returns>
        public static string HtmlEscape(this string value)
        {
            return value.Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("&", "&amp;");
        }
    }
}