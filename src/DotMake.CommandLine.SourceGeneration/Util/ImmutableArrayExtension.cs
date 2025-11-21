using System;
using System.Collections.Immutable;
using System.Linq.Expressions;

namespace DotMake.CommandLine.SourceGeneration.Util;

public static class ImmutableArrayExtension
{
    // ReSharper disable once UnusedParameter.Global
    public static ImmutableArray<T> CreateEmpty<T>(T typeHint) => ImmutableArray<T>.Empty;

    // ReSharper disable once UnusedParameter.Global
    public static ImmutableArray<T> CreateEmpty<T>(Expression<Func<T>> typeHint) => ImmutableArray<T>.Empty;
}
