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

        if (!Directory.Exists(options.Output))
            Directory.CreateDirectory(options.Output);

        var casingType = options.CasingType switch
        {
            "camel" => Casing.Camel,
            _ => Casing.Pascal
        };
        var destination = FileSystemDestination.NewDirectory(options.Output);

        var mem = (await File.ReadAllTextAsync(options.GraphqlFilePath, cancellationToken)).AsMemory();

        await Parser.ParseAndWriteAsync(destination, casingType, options.Nullability == true, mem, CancellationToken.None);

        return 0;
    }
}
