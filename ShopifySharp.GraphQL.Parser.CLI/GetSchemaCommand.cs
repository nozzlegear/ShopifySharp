using System.Text.RegularExpressions;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.GraphQL.Parser.CLI;

public class GetSchemaCommand(CommandContext context, IServiceProvider serviceProvider)
{
    private readonly Regex _apiVersionRegex = new(@"^\d{4}-\d{2}$", RegexOptions.None, TimeSpan.FromMilliseconds(500));

    public async Task<int> ExecuteAsync(GetSchemaOptions options, CancellationToken cancellationToken = default)
    {
        if (!_apiVersionRegex.IsMatch(options.ApiVersion))
        {
            context.PrintErrors($"--api-version \"{options.ApiVersion}\" is invalid, it must follow the format \"2025-07\".");
            return 1;
        }

        if (string.IsNullOrEmpty(options.AccessToken))
        {
            context.PrintErrors("--token cannot be empty.");
            return 1;
        }

        if (string.IsNullOrEmpty(options.ShopDomain))
        {
            context.PrintErrors("--domain cannot be empty.");
            return 1;
        }

        if (string.IsNullOrEmpty(options.OutputFileName))
        {
            context.PrintErrors("--output cannot be empty.");
            return 1;
        }

        await DownloadSchemaFileFromShopifyApiAsync(options, cancellationToken);
        return 0;
    }

    private async Task DownloadSchemaFileFromShopifyApiAsync(GetSchemaOptions options, CancellationToken cancellationToken = default)
    {
        var graphqlUtility = new ShopifyGraphqlUtility(serviceProvider);
        var credentials = new ShopifyApiCredentials(options.ShopDomain, options.AccessToken);
        var jsonSchema = await graphqlUtility.GetSchemaAsJsonStringAsync(credentials, options.ApiVersion, cancellationToken);

        try
        {
            await SaveSchemaContentsToPath(options.OutputFileName, jsonSchema, cancellationToken);
        }
        catch (ShopifyHttpException ex)
        {
            context.PrintErrors($"{ex.RequestInfo} {ex.RawBody}");
            throw;
        }
    }

    private static async Task SaveSchemaContentsToPath(string path, string schemaContents, CancellationToken cancellationToken = default)
    {
        var parentDir = Directory.GetParent(path);

        if (parentDir is { Exists: false })
            parentDir.Create();

        await File.WriteAllTextAsync(path, schemaContents, cancellationToken);
    }
}
