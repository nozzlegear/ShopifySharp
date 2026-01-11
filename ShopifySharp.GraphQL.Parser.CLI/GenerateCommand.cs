namespace ShopifySharp.GraphQL.Parser.CLI;

public class GenerateCommand(CommandContext context)
{
    public async Task<int> ExecuteAsync(GenerateOptions options, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(options.GraphqlFilePath))
        {
            context.PrintErrors("You must specify a graphql schema file.");
            return 1;
        }

        if (!File.Exists(options.GraphqlFilePath))
        {
            context.PrintErrors($"File at `{options.GraphqlFilePath}` does not exist or is not a valid file path.");
            return 1;
        }

        if (!Directory.Exists(options.TypesPath))
            Directory.CreateDirectory(options.TypesPath);

        if (!Directory.Exists(options.QueryBuildersPath))
            Directory.CreateDirectory(options.QueryBuildersPath);

        var casingType = options.CasingType switch
        {
            "camel" => Casing.Camel,
            _ => Casing.Pascal
        };
        var typesDestination = FileSystemDestination.NewDirectory(options.TypesPath);
        var queryBuildersDestination = FileSystemDestination.NewDirectory(options.QueryBuildersPath);

        var mem = (await File.ReadAllTextAsync(options.GraphqlFilePath, cancellationToken)).AsMemory();

        await Parser.ParseAndWriteAsync(
            typesDestination,
            queryBuildersDestination,
            casingType,
            options.Nullability == true,
            mem,
            CancellationToken.None);

        return 0;
    }
}
