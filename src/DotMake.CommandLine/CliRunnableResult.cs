using System.CommandLine;
using System.Threading;
using System.Threading.Tasks;

namespace DotMake.CommandLine;

/// <summary>
/// Describes the results of parsing a command line input based on a specific parser configuration
/// and provides methods for either binding the result to definition classes or running the parsed command.
/// </summary>
public class CliRunnableResult : CliResult
{
    private readonly IParseResultRunner parseResultRunner;

    internal CliRunnableResult(
        CliBindingContext bindingContext,
        ParseResult parseResult,
        IParseResultRunner parseResultRunner) : base(bindingContext, parseResult) =>
        this.parseResultRunner = parseResultRunner;

    /// <summary>
    /// Runs the handler asynchronously for the indicated command.
    /// </summary>
    /// <returns><inheritdoc cref="CliParser.Run(string[])" path="/returns/node()" /></returns>
    /*
    /// <example>
    ///     <code source="../TestApp/CliExamples.cs" region="CliRunAsync" language="cs" />
    ///     <code source="../TestApp/CliExamples.cs" region="CliRunAsyncWithReturn" language="cs" />
    /// </example>
    */
    public int Run() => parseResultRunner.Run(ParseResult);

    /// <summary>
    /// Runs the handler asynchronously for the indicated command.
    /// </summary>
    /// <param name="cancellationToken"><inheritdoc cref="CliParser.RunAsync(string[], CancellationToken)" path="/param[@name='cancellationToken']/node()" /></param>
    /// <returns><inheritdoc cref="CliParser.Run(string[])" path="/returns/node()" /></returns>
    /*
    /// <example>
    ///     <code source="../TestApp/CliExamples.cs" region="CliRunAsyncString" language="cs" />
    ///     <code source="../TestApp/CliExamples.cs" region="CliRunAsyncStringWithReturn" language="cs" />
    /// </example>
    */
    public Task<int> RunAsync(CancellationToken cancellationToken = default) =>
        parseResultRunner.RunAsync(ParseResult, cancellationToken);
}
