// <copyright file="FileNameParser.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of static class Mathematics.</summary>

using System;

namespace CohesionAndCoupling
{
    /// <summary>
    /// Represent a static class that holds file name parsing methods.
    /// </summary>
    public static class FileNameParser
    {
        /// <summary>
        /// Get the file name extension.
        /// </summary>
        /// <param name="fileName">File name to be parsed.</param>
        /// <returns>The extension of the file name.</returns>
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".", StringComparison.Ordinal);
            string extension = 0 <= indexOfLastDot ? fileName.Substring(indexOfLastDot + 1) : string.Empty;

            return extension;
        }

        /// <summary>
        /// Get the file name without extension.
        /// </summary>
        /// <param name="fileName">File name to be parsed.</param>
        /// <returns>The file name without extension.</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".", StringComparison.Ordinal);
            string fileNameWithoutExtension = 0 <= indexOfLastDot ? fileName.Substring(0, indexOfLastDot) : fileName;

            return fileNameWithoutExtension;
        }
    }
}
