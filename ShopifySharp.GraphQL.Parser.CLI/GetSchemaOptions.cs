using CommandLine;
using JetBrains.Annotations;

namespace ShopifySharp.GraphQL.Parser.CLI;

[UsedImplicitly]
[Verb("get-schema", aliases: ["download"], HelpText = "Downloads a new version of Shopify's graphql schema and saves it to the filesystem.")]
public record GetSchemaOptions
{
    [Option('a', "api-version", Required = true, HelpText = "A Shopify API version, e.g. \"2025-07\"")]
    public required string ApiVersion { get; init; }

    [Option('o', "output", Required = true, HelpText = "Write the schema to a file at the given path")]
    public required string OutputFileName { get; init; }

    [Option('d', "domain", Required = true, HelpText = "Your shop's *.myshopify.com domain")]
    public required string ShopDomain { get; init; }

    [Option('t', "token", Required = true, HelpText = "A Shopify access token matching the domain from --domain")]
    public required string AccessToken { get; init; }
}
