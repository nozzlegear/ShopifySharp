namespace ShopifySharp.GraphQL.Parser.CLI;

public class GenerateCommand(CommandContext context)
{
    public async Task<int> ExecuteAsync(GenerateOptions options)
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

        var parser = new Parser(options.CasingType switch
        {
            "camel" => CasingType.CamelCase,
            _ => CasingType.PascalCase
        });
        var mem = (await File.ReadAllTextAsync(options.GraphqlFilePath)).AsMemory();

        await foreach (var file in parser.ParseAsync(mem, CancellationToken.None))
        {
            var outputFile = Path.Join(options.Output, "/", file.FileName);

            if (File.Exists(outputFile))
                File.Delete(outputFile);

            await File.WriteAllTextAsync(outputFile, file.FileText);
        }

        return 0;
    }
}
