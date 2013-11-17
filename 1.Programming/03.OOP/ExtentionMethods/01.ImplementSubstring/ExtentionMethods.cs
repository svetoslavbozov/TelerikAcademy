using System;
using System.Text;

namespace _01.ImplementSubstring
{
    public static class ExtentionMethods
    {
        public static StringBuilder Substring(this StringBuilder text, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (startIndex > text.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (startIndex > text.Length - length)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (length == 0)
            {
                return result.Append(string.Empty);
            }

            if (startIndex == 0 && length == text.Length)
            {
                return text;
            }

            for (int i = startIndex; i < length; i++)
            {
                result.Append(text[i]);
            }

            return result;
        }
    }
}
