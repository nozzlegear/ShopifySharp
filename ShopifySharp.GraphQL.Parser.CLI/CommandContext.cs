using CommandLine;
using CommandLine.Text;

namespace ShopifySharp.GraphQL.Parser.CLI;

public class CommandContext(TextWriter standardWriter, TextWriter errorWriter)
{
    private readonly SentenceBuilder _programSentenceBuilder = SentenceBuilder.Create();
    private readonly HeadingInfo _programHeadingInfo = HeadingInfo.Default;
    private readonly CopyrightInfo _programCopyrightInfo = CopyrightInfo.Default;

    public enum WriterMode
    {
        Standard,
        Error,
    }

    public void PrintHeaderAndVersion(WriterMode writerMode = WriterMode.Standard)
    {
        var textWriter = writerMode == WriterMode.Error ? errorWriter : standardWriter;
        textWriter.WriteLine(_programHeadingInfo.ToString());
    }

    public void PrintHelp()
    {
        var helpText = new HelpText(_programSentenceBuilder)
        {
            AutoHelp = true,
            AutoVersion = true,
            AdditionalNewLineAfterOption = false,
            Heading = _programHeadingInfo,
            Copyright = _programCopyrightInfo,
        };
        helpText.AddVerbs(typeof(GenerateOptions));

        standardWriter.WriteLine(helpText);
    }

    public void PrintErrors(IEnumerable<Error> errors) =>
        PrintErrorsWithHeader(RenderErrorsTextAsLines(errors));

    public void PrintErrors(IEnumerable<string> errors) =>
        PrintErrorsWithHeader(RenderLines(errors, m => m));

    public void PrintErrors(string error) =>
        PrintErrorsWithHeader(RenderLines([error], m => m));

    private void PrintErrorsWithHeader(IEnumerable<string> errors)
    {
        // Bold + RedC9
        const string ansiEscapeSequence = @"\x1b[1;38;5;9m";

        PrintHeaderAndVersion(WriterMode.Error);
        errorWriter.WriteLine(_programCopyrightInfo.ToString());
        errorWriter.WriteLine(ansiEscapeSequence + string.Concat(Environment.NewLine, _programSentenceBuilder.ErrorsHeadingText()));

        foreach (var line in errors)
            errorWriter.WriteLine(line);
    }

    private IEnumerable<string> RenderErrorsTextAsLines(IEnumerable<Error> errors)
    {
        var filtered = errors
            .Where(e => !e.StopsProcessing)
            .Where(e => !(e.Tag == ErrorType.UnknownOptionError &&
                          ((UnknownOptionError)e).Token.Equals("help", StringComparison.OrdinalIgnoreCase)))
            .ToArray();

        foreach (var line in RenderLines(filtered.Where(e => e.Tag != ErrorType.MutuallyExclusiveSetError), _programSentenceBuilder.FormatError))
            yield return line;

        var mutually = _programSentenceBuilder.FormatMutuallyExclusiveSetErrors(filtered.OfType<MutuallyExclusiveSetError>());
        if (mutually.Length > 0)
            foreach (var l in mutually.Split([Environment.NewLine], StringSplitOptions.None))
                yield return l;
    }

    private IEnumerable<string> RenderLines<T>(
        IEnumerable<T> items,
        Func<T, string> formatter)
    {
        const int indent = 2;
        var pad = new string(' ', indent);
        foreach (var i in items)
            yield return pad + formatter(i);
    }
}
