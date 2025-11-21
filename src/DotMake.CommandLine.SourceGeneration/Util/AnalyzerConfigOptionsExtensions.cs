using System;
using Microsoft.CodeAnalysis.Diagnostics;

namespace DotMake.CommandLine.SourceGeneration.Util;

public static class AnalyzerConfigOptionsExtensions
{
    public static bool GetBoolOrDefault(this AnalyzerConfigOptions options, string key, bool defaultValue = false) =>
        options.TryGetValue(key, out var value)
            ? string.Equals(value, "true", StringComparison.OrdinalIgnoreCase)
            : defaultValue;

    public static string? GetStringOrDefault(
        this AnalyzerConfigOptions options,
        string key,
        string? defaultValue = null) =>
        options.TryGetValue(key, out var value) ? value : defaultValue;
}
