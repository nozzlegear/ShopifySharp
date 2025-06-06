using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace ShopifySharp.GraphQL.Parser;

public class Parser(CasingType propertyNameCasingType)
{
    public async IAsyncEnumerable<GeneratedFile> ParseAsync(ReadOnlyMemory<char> graphqlData, [EnumeratorCancellation] CancellationToken cancellationToken = default)
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

        // Parse the generated code into individual files
        await foreach (var item in ParseCsharpToGeneratedFilesAsync(csharpCode, cancellationToken))
            yield return item;
    }

    private static async IAsyncEnumerable<GeneratedFile> ParseCsharpToGeneratedFilesAsync(string csharpCode, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        var csharpTree = await CSharpSyntaxTree.ParseText(csharpCode, cancellationToken: cancellationToken)
            .GetRootAsync(cancellationToken);
        var syntaxRoot = (CompilationUnitSyntax)csharpTree;
        var usings = syntaxRoot.Usings;
        var externals = syntaxRoot.Externs;

        foreach (var ns in syntaxRoot.Members.OfType<BaseNamespaceDeclarationSyntax>())
        {
            foreach (var type in ns.Members.OfType<BaseTypeDeclarationSyntax>())
            {
                var unit = CompilationUnit()
                    .WithExterns(externals)
                    .WithUsings(usings)
                    .AddMembers(
                        ns.WithMembers(
                            SingletonList<MemberDeclarationSyntax>(type))
                    )
                    .NormalizeWhitespace(eol: Environment.NewLine);

                yield return new GeneratedFile(type.Identifier.Text + ".cs", unit.ToFullString());
            }
        }
    }

    private static async Task<string> ReadPipeAsync(PipeReader reader, CancellationToken ct = default)
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
