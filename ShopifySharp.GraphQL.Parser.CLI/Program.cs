using CommandLine;

namespace ShopifySharp.GraphQL.Parser.CLI;

internal static class Program
{
    private static readonly CommandContext Context = new(Console.Out, Console.Error);
    private static readonly GenerateCommand GenerateCommand = new(Context);

    private static async Task<int> Main(string[] args)
    {
        var parser = new CommandLine.Parser(settings =>
        {
            settings.HelpWriter = null;
            settings.EnableDashDash = true;
        });

        return await parser.ParseArguments<GenerateOptions, object>(args)
            .MapResult(
                (GenerateOptions options) => GenerateCommand.ExecuteAsync(options),
                errors => Task.FromResult(HandleParseErrors(errors.ToArray()))
            );
    }

    private static int HandleParseErrors(Error[] errors)
    {
        foreach (var error in errors)
        {
            switch (error.Tag)
            {
                case ErrorType.HelpRequestedError:
                case ErrorType.HelpVerbRequestedError:
                    Context.PrintHelp();
                    return 0;
                case ErrorType.VersionRequestedError:
                    Context.PrintHeaderAndVersion();
                    return 0;
                default:
                    continue;
            }
        }

        Context.PrintErrors(errors);
        return 1;
    }
}
