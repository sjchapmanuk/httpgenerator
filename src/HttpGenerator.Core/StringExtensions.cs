namespace HttpGenerator.Core;

public static class StringExtensions
{
    public static string ConvertKebabCaseToPascalCase(this string str)
    {
        var parts = str.Split('-');

        for (var i = 0; i < parts.Length; i++)
        {
            parts[i] = parts[i].CapitalizeFirstCharacter().Replace(".", "_");
        }

        return string.Join(string.Empty, parts);
    }

    public static string ConvertRouteToCamelCase(this string str)
    {
        var parts = str.Split('/');
        for (var i = 1; i < parts.Length; i++)
        {
            parts[i] = parts[i].CapitalizeFirstCharacter();
        }

        return string.Join(string.Empty, parts);
    }

    public static string CapitalizeFirstCharacter(this string str)
    {
        return str.Substring(0, 1).ToUpperInvariant() +
               str.Substring(1, str.Length - 1);
    }

    public static string ConvertSpacesToPascalCase(this string str)
    {
        var parts = str.Split(' ');
        for (var i = 0; i < parts.Length; i++)
        {
            parts[i] = parts[i].CapitalizeFirstCharacter();
        }

        return string.Join(string.Empty, parts);
    }

    public static string Prefix(this string str, string prefix)
    {
        if (str.StartsWith(prefix))
        {
            return str;
        }

        return prefix + str;
    }

    public static string? PrefixLineBreaks(this string value, string prefix = "###") =>
        value
            ?.Replace(
                Environment.OSVersion.Platform == PlatformID.MacOSX ||
                Environment.OSVersion.Platform == PlatformID.Unix
                    ? "\r\n" // Environment.NewLine value for non-Unix platforms
                    : "\n", // Environment.NewLine value for Unix platforms
                $"{Environment.NewLine}{prefix} ");
}