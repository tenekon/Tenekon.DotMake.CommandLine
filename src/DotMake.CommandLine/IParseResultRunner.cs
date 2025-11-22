using System.CommandLine;
using System.Threading;
using System.Threading.Tasks;

namespace DotMake.CommandLine;

internal interface IParseResultRunner
{
    Task<int> RunAsync(ParseResult parseResult, CancellationToken cancellationToken = default);
    int Run(ParseResult parseResult);
}
