using System.IO.Pipelines;
using System.Text;

namespace ShopifySharp.GraphQL.Parser;

public class Parser(CasingType propertyNameCasingType)
{
    public async Task<string> ParseAsync(ReadOnlyMemory<char> graphqlData, CancellationToken cancellationToken = default)
    {
        using var stream = new MemoryStream();
        await using var streamWriter = new StreamWriter(stream, Encoding.UTF8);
        var pipe = new Pipe();

        var visitor = new ShopifyGraphAstVisitor();
        var context = new WriterContext(pipe.Writer, cancellationToken)
        {
            CasingType = propertyNameCasingType
        };

        // Start reading the pipe before writing to it, or else the writer can hang if the pipe fills before it's read
        var readTask = ReadPipeAsync(pipe.Reader, cancellationToken);

        var ast = GraphQLParser.Parser.Parse(graphqlData);
        var writeTask = visitor.VisitDocumentAsync(ast, context);
        await writeTask.ConfigureAwait(false);
        await pipe.Writer.CompleteAsync().ConfigureAwait(false);

        var csharpCode = await readTask.ConfigureAwait(false);

        return csharpCode.Trim();
    }

    static async Task<string> ReadPipeAsync(PipeReader reader, CancellationToken ct = default)
    {
        var sb = new StringBuilder();

        while (true)
        {
            var result = await reader.ReadAsync(ct).ConfigureAwait(false);
            var buffer = result.Buffer;

            foreach (var segment in buffer)
                sb.Append(Encoding.UTF8.GetString(segment.Span));

            reader.AdvanceTo(buffer.End);

            if (result.IsCompleted || result.IsCanceled) break;
        }

        await reader.CompleteAsync().ConfigureAwait(false);
        return sb.ToString();
    }
}
