using Microsoft.CodeAnalysis;

namespace DotMake.CommandLine.SourceGeneration.Util;

public static class IncrementalValuesProviderExtensions
{
    public static IncrementalValuesProvider<(TLeft Left, TRight Right)> SelectWhereNotNull<TLeft, TRight>(
        this IncrementalValuesProvider<(TLeft Left, TRight Right)?> provider) =>
        provider.Where(x => x.HasValue).Select((x, _) => x!.Value);
}
