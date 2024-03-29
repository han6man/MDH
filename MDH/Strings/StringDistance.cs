﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDH.Strings
{
    public static class StringDistance
    {
        /// <summary>
        /// Calculate the difference between 2 strings using the Levenshtein distance algorithm.
        /// </summary>
        /// <param name="string1">First string</param>
        /// <param name="string2">Second string</param>
        /// <returns>The Levenshtein distance between the strings</returns>
        public static int LevenshteinDistance(string string1, string string2) //O(n*m)
        {
            var string1Length = string1.Length;
            var string2Length = string2.Length;

            var matrix = new int[string1Length + 1, string2Length + 1];

            // First calculation, if one entry is empty return full length. If two is empty return 0
            if (string1Length == 0 && string2Length > 0)
                return string2Length;

            if (string2Length == 0 && string1Length > 0)
                return string1Length;

            if (string1Length == 0 && string2Length == 0)
                return 0;

            // Initialization of matrix with row size source1Length and columns size source2Length
            for (var i = 0; i <= string1Length; matrix[i, 0] = i++) { }
            for (var j = 0; j <= string2Length; matrix[0, j] = j++) { }

            // Calculate rows and collumns distances
            for (var i = 1; i <= string1Length; i++)
            {
                for (var j = 1; j <= string2Length; j++)
                {
                    var cost = (string2[j - 1] == string1[i - 1]) ? 0 : 1;

                    matrix[i, j] = Math.Min(
                        Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1),
                        matrix[i - 1, j - 1] + cost);
                }
            }
            // return result
            return matrix[string1Length, string2Length];
        }

        /// <summary>
        /// Calculate the difference between 2 strings using the Damerau-Levenshtein Distance algorithm.
        /// </summary>
        /// <param name="string1">First string</param>
        /// <param name="string2">Second string</param>
        /// <returns>The Damerau-Leveshteim distance between the strings</returns>
        public static int DamerauLevenshteinDistance(string string1, string string2)
        {
            var bounds = new { Height = string1.Length + 1, Width = string2.Length + 1 };

            int[,] matrix = new int[bounds.Height, bounds.Width];

            for (int height = 0; height < bounds.Height; height++) { matrix[height, 0] = height; };
            for (int width = 0; width < bounds.Width; width++) { matrix[0, width] = width; };

            for (int height = 1; height < bounds.Height; height++)
            {
                for (int width = 1; width < bounds.Width; width++)
                {
                    int cost = (string1[height - 1] == string2[width - 1]) ? 0 : 1;
                    int insertion = matrix[height, width - 1] + 1;
                    int deletion = matrix[height - 1, width] + 1;
                    int substitution = matrix[height - 1, width - 1] + cost;

                    int distance = Math.Min(insertion, Math.Min(deletion, substitution));

                    if (height > 1 && width > 1 && string1[height - 1] == string2[width - 2] && string1[height - 2] == string2[width - 1])
                    {
                        distance = Math.Min(distance, matrix[height - 2, width - 2] + cost);
                    }

                    matrix[height, width] = distance;
                }
            }

            return matrix[bounds.Height - 1, bounds.Width - 1];
        }

        /// <summary>
        /// Computes the Damerau-Levenshtein Distance between two strings, represented as arrays of
        /// integers, where each integer represents the code point of a character in the source string.
        /// Includes an optional threshhold which can be used to indicate the maximum allowable distance.
        /// </summary>
        /// <param name="source">An array of the code points of the first string</param>
        /// <param name="target">An array of the code points of the second string</param>
        /// <param name="threshold">Maximum allowable distance</param>
        /// <returns>Int.MaxValue if threshhold exceeded; otherwise the Damerau-Leveshteim distance between the strings</returns>
        public static int DamerauLevenshteinDistance(int[] source, int[] target, int threshold)
        {

            int length1 = source.Length;
            int length2 = target.Length;

            // Return trivial case - difference in string lengths exceeds threshhold
            if (Math.Abs(length1 - length2) > threshold) { return int.MaxValue; }

            // Ensure arrays [i] / length1 use shorter length 
            if (length1 > length2)
            {
                Swap(ref target, ref source);
                Swap(ref length1, ref length2);
            }

            int maxi = length1;
            int maxj = length2;

            int[] dCurrent = new int[maxi + 1];
            int[] dMinus1 = new int[maxi + 1];
            int[] dMinus2 = new int[maxi + 1];
            int[] dSwap;

            for (int i = 0; i <= maxi; i++) { dCurrent[i] = i; }

            int jm1 = 0, im1 = 0, im2 = -1;

            for (int j = 1; j <= maxj; j++)
            {

                // Rotate
                dSwap = dMinus2;
                dMinus2 = dMinus1;
                dMinus1 = dCurrent;
                dCurrent = dSwap;

                // Initialize
                int minDistance = int.MaxValue;
                dCurrent[0] = j;
                im1 = 0;
                im2 = -1;

                for (int i = 1; i <= maxi; i++)
                {

                    int cost = source[im1] == target[jm1] ? 0 : 1;

                    int del = dCurrent[im1] + 1;
                    int ins = dMinus1[i] + 1;
                    int sub = dMinus1[im1] + cost;

                    //Fastest execution for min value of 3 integers
                    int min = (del > ins) ? (ins > sub ? sub : ins) : (del > sub ? sub : del);

                    if (i > 1 && j > 1 && source[im2] == target[jm1] && source[im1] == target[j - 2])
                        min = Math.Min(min, dMinus2[im2] + cost);

                    dCurrent[i] = min;
                    if (min < minDistance) { minDistance = min; }
                    im1++;
                    im2++;
                }
                jm1++;
                if (minDistance > threshold) { return int.MaxValue; }
            }

            int result = dCurrent[maxi];
            return (result > threshold) ? int.MaxValue : result;
        }
        static void Swap<T>(ref T arg1, ref T arg2)
        {
            T temp = arg1;
            arg1 = arg2;
            arg2 = temp;
        }

        /// <summary>
        /// Calculate the difference between 2 strings using the Hamming Distance algorithm.
        /// Strings must be equal length.
        /// </summary>
        /// <param name="string1">First string</param>
        /// <param name="string2">Second string</param>
        /// <returns>The Hamming distance between the strings</returns>
        public static int HammingDistance(string string1, string string2)
        {
            if (string1.Length != string2.Length)
            {
                throw new Exception("Strings must be equal length");
            }

            int distance =
                string1.ToCharArray()
                .Zip(string2.ToCharArray(), (c1, c2) => new { c1, c2 })
                .Count(m => m.c1 != m.c2);

            return distance;
        }
    }
}
