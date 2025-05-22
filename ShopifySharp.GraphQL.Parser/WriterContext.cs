using System.IO.Pipelines;
using System.Text;
using GraphQLParser.Visitors;

namespace ShopifySharp.GraphQL.Parser;

public class WriterContext: IASTVisitorContext
{
    private readonly PipeWriter _writer;
    private readonly AsyncLocal<int> _indentations;

    /// <inheritdoc/>
    public CancellationToken CancellationToken { get; }

    public WriterContext(PipeWriter pipeWriter, CancellationToken cancellationToken = default)
    {
        _writer = pipeWriter;
        _indentations = new AsyncLocal<int>
        {
            Value = 0
        };
        CancellationToken = cancellationToken;
    }

    public async Task WriteEmptyLineAsync() =>
        await _writer.WriteAsync(Encoding.UTF8.GetBytes(Environment.NewLine), CancellationToken);

    public async Task WriteAsync(string text) =>
        await _writer.WriteAsync(Encoding.UTF8.GetBytes(new string(' ', _indentations.Value * 4) + text), CancellationToken);

    public async Task WriteLineAsync(string text)
    {
        await WriteAsync(text);
        await WriteEmptyLineAsync();
    }

    public async Task WriteLineAsync(StringBuilder sb)
    {
        await WriteLineAsync(sb.ToString());
    }

    public void Indent() => _indentations.Value += 1;

    public void Outdent() => _indentations.Value -= 1;
}
