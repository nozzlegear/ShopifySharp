using CommandLine;
using JetBrains.Annotations;

namespace ShopifySharp.GraphQL.Parser.CLI;

[UsedImplicitly]
[Verb("parse", aliases: ["generate"], HelpText = "Reads a .graphql file and generates C# classes, enums and input types compatible with ShopifySharp.")]
public record GenerateOptions
{
    [Option('o', "output", Required = true, HelpText = "Output directory for generated C# files")]
    public required string Output { get; init; }

    [Value(0, MetaName = "<schema.graphql>", HelpText = "Path to the GraphQL schema file to convert. Both JSON and GraphQL are accepted.")]
    public required string GraphqlFilePath { get; init; }

    [Option('c', "casing", HelpText = "Set the casing of generated C# property/field names. Valid values: camel, pascal. Default: pascal.", MetaValue = "pascal, camel", Default = "pascal")]
    public string? CasingType { get; init; }
}
