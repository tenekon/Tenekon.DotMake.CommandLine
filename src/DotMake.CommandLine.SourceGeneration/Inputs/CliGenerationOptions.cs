using DotMake.CommandLine.SourceGeneration.Util;
using Microsoft.CodeAnalysis.Diagnostics;

namespace DotMake.CommandLine.SourceGeneration.Inputs;

public record CliGenerationOptions
{
    /* Keys must be lower case! Key template is "build_property.*". */
    public const string DisableSourceGenerationAnalyzerOptionsKey = "build_property.DotMakeCommandLineDisableSourceGeneration";
    public const string ProjectDirAnalyzerOptionsKey = "build_property.projectdir";
    public const string TargetFrameworkAnalyzerOptionsKey = "build_property.targetframework";

    /// <summary>
    /// Amends options for
    /// <list type="bullet">
    /// <item><description><see cref="DisableSourceGeneration"/></description></item>
    /// <item><description><see cref="ProjectDir"/></description></item>
    /// <item><description><see cref="TargetFramework"/></description></item>
    /// </list>
    /// </summary>
    /// <param name="cliGenerationOptions"></param>
    /// <param name="analyzerOptions"></param>
    public static void Amend(CliGenerationOptions cliGenerationOptions, AnalyzerConfigOptions analyzerOptions)
    {
        cliGenerationOptions.DisableSourceGeneration = analyzerOptions.GetBoolOrDefault(
            DisableSourceGenerationAnalyzerOptionsKey);
        cliGenerationOptions.ProjectDir = analyzerOptions.GetStringOrDefault(ProjectDirAnalyzerOptionsKey);
        cliGenerationOptions.TargetFramework = analyzerOptions.GetStringOrDefault(TargetFrameworkAnalyzerOptionsKey);
    }

    public bool DisableSourceGeneration { get; set; }

    // public bool DisableDependencyInjectionSourceGeneration { get; set; }
    public string? ProjectDir { get; set; }
    public string? TargetFramework { get; set; }
}
