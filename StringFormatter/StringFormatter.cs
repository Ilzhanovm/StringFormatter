using System.Text;
using System.Text.RegularExpressions;

namespace StringFormatter;

/// <summary>
/// Collection of string formatting methods.
/// </summary>
static public class StringFormatter
{
    /// <summary>
    /// Replace repeating blanks with a single blank.
    /// </summary>
    /// <param name="input">String to modify</param>
    /// <returns>String without repeated blanks</returns>
    public static string ReplaceSpaces(string input)
    {
        StringBuilder builder = new();
        char? prevChar = null;

        foreach (char c in input)
        {
            if (c != ' ' || prevChar == null || c != prevChar)
                builder.Append(c);

            prevChar = c;
        }

        return builder.ToString();
    }

    /// <summary>
    /// Replace repeating blanks with a single blank using regex.
    /// </summary>
    /// <param name="input">String to modify</param>
    /// <returns>String without repeated blanks</returns>
    public static string ReplaceSpacesRegex(string input)
    {
        return Regex.Replace(input, " +", " ");
    }
}