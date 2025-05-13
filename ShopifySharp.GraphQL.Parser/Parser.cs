using System.IO.Pipelines;
using System.Text;
using GraphQLParser.AST;

namespace ShopifySharp.GraphQL.Parser;

public class Parser
{
    public async Task<string> ParseAsync(ReadOnlyMemory<char> graphqlData, CancellationToken cancellationToken = default)
    {
        using var stream = new MemoryStream();
        await using var streamWriter = new StreamWriter(stream, Encoding.UTF8);
        var pipe = new Pipe();

        var visitor = new ShopifyGraphAstVisitor();
        var context = new WriterContext(pipe.Writer, cancellationToken);

        var ast = GraphQLParser.Parser.Parse(graphqlData);
        await visitor.VisitAsync(ast, context);
        await pipe.Writer.CompleteAsync();

        var csharpCode = "";

        while (true)
        {
            var readResult = await pipe.Reader.ReadAsync(cancellationToken);
            if (readResult.IsCanceled)
                break;

            var buffer = readResult.Buffer;
            foreach (var segment in buffer)
            {
                csharpCode += Encoding.UTF8.GetString(segment.Span);
            }

            pipe.Reader.AdvanceTo(buffer.End);

            if (readResult.IsCompleted)
                break;
        }

        return csharpCode.Trim();
    }
}
