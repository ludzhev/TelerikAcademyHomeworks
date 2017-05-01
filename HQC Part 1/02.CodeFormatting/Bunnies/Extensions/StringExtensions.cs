using System.Text;

namespace Bunnies.Extensions
{
    public static class StringExtensions
    {
        public static string SplitToSeparateWordsByUppercaseLetter(this string sequence)
        {
            const char SingleWhitespace = ' ';
            const int ProbableStringMargin = 10;
            var probableStringSize = sequence.Length + ProbableStringMargin;

            var builder = new StringBuilder(probableStringSize);

            foreach (var letter in sequence)
            {
                if (char.IsUpper(letter))
                {
                    builder.Append(SingleWhitespace);
                }

                builder.Append(letter);
            }

            return builder.ToString().Trim();
        }
    }
}
